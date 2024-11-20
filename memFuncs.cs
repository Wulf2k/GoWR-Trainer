using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoWR_Trainer
{
    public partial class frmGoWRTrainer : Form
    {

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool CloseHandle(IntPtr hObject);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, out uint lpThreadId);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowA(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowExA(IntPtr hWnd1, IntPtr hWnd2, string lpsz1, string lpsz2);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int iSize, out int lpNumberOfBytesRead);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, int flAllocationType, int flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint dwNewProtect, out uint dwOldProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, int dwFreeType);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int iSize, out int lpNumberOfBytesWritten);

        // Constants
        public const uint PROCESS_VM_READ = 0x0010;
        public const uint TH32CS_SNAPPROCESS = 0x0002;
        public const int MEM_COMMIT = 0x1000;
        public const int MEM_RELEASE = 0x8000;
        public const int PAGE_READWRITE = 0x04;
        public const int PAGE_EXECUTE_READWRITE = 0x40;
        public const uint PROCESS_CREATE_THREAD = 0x0002;
        public const uint PROCESS_VM_OPERATION = 0x0008;
        public const uint PROCESS_VM_WRITE = 0x0020;
        public const uint PROCESS_ALL_ACCESS = 0x1F0FFF;

        private Process _targetProcess = null;
        private IntPtr _targetProcessHandle = IntPtr.Zero;

        private DataTable dtPlayerMeters = new DataTable();
        private DataTable dtNmeMeters = new DataTable();
        private DataTable dtInventory = new DataTable();


        public bool ScanForProcess(string procName, bool automatic = false)
        {
            Process[] _allProcesses = Process.GetProcesses();
            foreach (Process pp in _allProcesses)
            {
                if (pp.ProcessName.Equals(procName, StringComparison.OrdinalIgnoreCase))
                {
                    return TryAttachToProcess(pp, automatic);
                }
            }
            return false;
        }

        public bool TryAttachToProcess(Process proc, bool automatic = false)
        {
            if (_targetProcessHandle != IntPtr.Zero)
            {
                DetachFromProcess();
            }

            _targetProcess = proc;
            _targetProcessHandle = OpenProcess(PROCESS_ALL_ACCESS, false, _targetProcess.Id);
            if (_targetProcessHandle == IntPtr.Zero)
            {
                if (!automatic)
                {

                }
                return false;
            }
            else
            {
                return true;
            }
        }

        public void DetachFromProcess()
        {
            if (_targetProcessHandle != IntPtr.Zero)
            {
                _targetProcess = null;
                try
                {
                    CloseHandle(_targetProcessHandle);
                    _targetProcessHandle = IntPtr.Zero;
                }
                catch (Exception ex)
                {

                }
            }
        }

        public sbyte RInt8(IntPtr addr)
        {
            byte[] buffer = new byte[1];
            ReadProcessMemory(_targetProcessHandle, addr, buffer, 1, out _);
            return (sbyte)buffer[0];
        }

        public short RInt16(IntPtr addr)
        {
            byte[] buffer = new byte[2];
            ReadProcessMemory(_targetProcessHandle, addr, buffer, 2, out _);
            return BitConverter.ToInt16(buffer, 0);
        }

        public int RInt32(IntPtr addr)
        {
            byte[] buffer = new byte[4];
            ReadProcessMemory(_targetProcessHandle, addr, buffer, 4, out _);
            return BitConverter.ToInt32(buffer, 0);
        }

        public long RInt64(IntPtr addr)
        {
            byte[] buffer = new byte[8];
            ReadProcessMemory(_targetProcessHandle, addr, buffer, 8, out _);
            return BitConverter.ToInt64(buffer, 0);
        }

        public byte RUInt8(IntPtr addr)
        {
            byte[] buffer = new byte[1];
            ReadProcessMemory(_targetProcessHandle, addr, buffer, 1, out _);
            return (byte)buffer[0];
        }

        public ushort RUInt16(IntPtr addr)
        {
            byte[] buffer = new byte[2];
            ReadProcessMemory(_targetProcessHandle, addr, buffer, 2, out _);
            return BitConverter.ToUInt16(buffer, 0);
        }

        public uint RUInt32(IntPtr addr)
        {
            byte[] buffer = new byte[4];
            ReadProcessMemory(_targetProcessHandle, addr, buffer, 4, out _);
            return BitConverter.ToUInt32(buffer, 0);
        }

        public ulong RUInt64(IntPtr addr)
        {
            byte[] buffer = new byte[8];
            ReadProcessMemory(_targetProcessHandle, addr, buffer, 8, out _);
            return BitConverter.ToUInt64(buffer, 0);
        }

        public float RSingle(IntPtr addr)
        {
            byte[] buffer = new byte[4];
            ReadProcessMemory(_targetProcessHandle, addr, buffer, 4, out _);
            return BitConverter.ToSingle(buffer, 0);
        }

        public double RDouble(IntPtr addr)
        {
            byte[] buffer = new byte[8];
            ReadProcessMemory(_targetProcessHandle, addr, buffer, 8, out _);
            return BitConverter.ToDouble(buffer, 0);
        }

        public IntPtr RIntPtr(IntPtr addr)
        {
            byte[] buffer = new byte[IntPtr.Size];
            ReadProcessMemory(_targetProcessHandle, addr, buffer, IntPtr.Size, out _);
            if (IntPtr.Size == 4)
            {
                return new IntPtr(BitConverter.ToUInt32(buffer, 0));
            }
            else
            {
                return new IntPtr(BitConverter.ToInt64(buffer, 0));
            }
        }

        public byte[] RBytes(IntPtr addr, int size)
        {
            byte[] buffer = new byte[size];
            ReadProcessMemory(_targetProcessHandle, addr, buffer, size, out _);
            return buffer;
        }

        public string RAscStr(IntPtr addr, int size = 0x100)
        {
            byte[] buffer = new byte[size];
            ReadProcessMemory(_targetProcessHandle, addr, buffer, size, out _);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < buffer.Length && buffer[i] > 0; i++)
            {
                sb.Append((char)buffer[i]);
            }
            return sb.ToString();
        }

        public string RUniStr(IntPtr addr)
        {
            byte[] buffer = new byte[32];
            ReadProcessMemory(_targetProcessHandle, addr, buffer, 32, out _);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < buffer.Length && buffer[i] > 0; i += 2)
            {
                sb.Append((char)buffer[i]);
            }
            return sb.ToString();
        }
        public bool WInt8(IntPtr addr, sbyte value)
        {
            byte[] buffer = new byte[] { (byte)value };
            return WriteProcessMemory(_targetProcessHandle, addr, buffer, 1, out _);
        }

        public bool WInt16(IntPtr addr, short value)
        {
            byte[] buffer = BitConverter.GetBytes(value);
            return WriteProcessMemory(_targetProcessHandle, addr, buffer, 2, out _);
        }

        public bool WInt32(IntPtr addr, int value)
        {
            byte[] buffer = BitConverter.GetBytes(value);
            return WriteProcessMemory(_targetProcessHandle, addr, buffer, 4, out _);
        }

        public bool WInt64(IntPtr addr, long value)
        {
            byte[] buffer = BitConverter.GetBytes(value);
            return WriteProcessMemory(_targetProcessHandle, addr, buffer, 8, out _);
        }

        public bool WUInt16(IntPtr addr, ushort value)
        {
            byte[] buffer = BitConverter.GetBytes(value);
            return WriteProcessMemory(_targetProcessHandle, addr, buffer, 2, out _);
        }

        public bool WUInt32(IntPtr addr, uint value)
        {
            byte[] buffer = BitConverter.GetBytes(value);
            return WriteProcessMemory(_targetProcessHandle, addr, buffer, 4, out _);
        }

        public bool WUInt64(IntPtr addr, ulong value)
        {
            byte[] buffer = BitConverter.GetBytes(value);
            return WriteProcessMemory(_targetProcessHandle, addr, buffer, 8, out _);
        }

        public bool WSingle(IntPtr addr, float value)
        {
            byte[] buffer = BitConverter.GetBytes(value);
            return WriteProcessMemory(_targetProcessHandle, addr, buffer, 4, out _);
        }

        public bool WDouble(IntPtr addr, double value)
        {
            byte[] buffer = BitConverter.GetBytes(value);
            return WriteProcessMemory(_targetProcessHandle, addr, buffer, 8, out _);
        }

        public bool WIntPtr(IntPtr addr, IntPtr value)
        {
            byte[] buffer;
            if (IntPtr.Size == 4)
            {
                buffer = BitConverter.GetBytes((uint)value.ToInt32());
            }
            else
            {
                buffer = BitConverter.GetBytes((long)value.ToInt64());
            }
            return WriteProcessMemory(_targetProcessHandle, addr, buffer, buffer.Length, out _);
        }

        public bool WBytes(IntPtr addr, byte[] value)
        {
            return WriteProcessMemory(_targetProcessHandle, addr, value, value.Length, out _);
        }
        public bool WAscStr(IntPtr addr, string value)
        {
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(value + "\0");
            return WriteProcessMemory(_targetProcessHandle, addr, bytes, bytes.Length, out _);
        }



        IntPtr gowr = IntPtr.Zero;
        private void FindDllAddresses()
        {
            foreach (ProcessModule dll in _targetProcess.Modules)
            {
                switch (dll.ModuleName.ToLower())
                {
                    case "gowr.exe":
                        gowr = dll.BaseAddress;
                        break;
                }
            }
        }
    }
}
