using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace GoWR_Trainer
{
    public partial class frmGoWRTrainer : Form
    {
        private System.Windows.Forms.Timer refreshData;

        public frmGoWRTrainer()
        {
            InitializeComponent();
            refreshData = new System.Windows.Forms.Timer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshData.Interval = 33;
            refreshData.Tick += Refresh_Data;

            dtInventory.Columns.Add("Name", typeof(string));
            dtInventory.Columns.Add("Amount", typeof(int));

            dgvInventory.DataSource = dtInventory;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.Font = new Font("Arial", 8);

            dtPlayerMeters.Columns.Add("Name", typeof(string));
            dtPlayerMeters.Columns.Add("Value", typeof(Single));

            dgvPlayerMeters.DataSource = dtPlayerMeters;
            dgvPlayerMeters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPlayerMeters.RowHeadersVisible = false;
            dgvPlayerMeters.AllowUserToAddRows = false;
            dgvPlayerMeters.Font = new Font("Arial", 8);

            dtNmeMeters.Columns.Add("Name", typeof(string));
            dtNmeMeters.Columns.Add("Value", typeof(Single));
            dgvNmeMeters.DataSource = dtNmeMeters;
            dgvNmeMeters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNmeMeters.RowHeadersVisible = false;
            dgvNmeMeters.AllowUserToAddRows = false;
            dgvNmeMeters.Font = new Font("Arial", 8);
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (ScanForProcess("GoWR"))
            {
                FindDllAddresses();
                lblProcName.Text = _targetProcess.ProcessName;
                refreshData.Start();
            }
            else
            {
                lblProcName.Text = "No Process found";
            };

        }

        IntPtr bInvuln;
        IntPtr fGamespeed;
        IntPtr gamelog;
        IntPtr goPlayer;
        IntPtr sharedResourceData;
        IntPtr locomotion__g_list;
        IntPtr factManager;


        private void Refresh_Data(object sender, EventArgs e)
        {
            //bInvuln
            //48 89 5c 24 08 57 48 83 ec 20 48 8b da c6 02 00 48 8b f9 e8 ?? ?? ?? ?? 44 8b 80 a4 02 00 00 41 d1 e8 41 f6 c0 01 75 ?? 80 
            //fGamespeed
            //f3 41 0f 5e c4 48 8b 0f 48 8b d1 f3 41 0f 5f c3 f3 41 0f 5d c1 f3 0f 5c c8 f3 41 0f 59 c6 f3 41 0f 59 cd f3 0f 58 c8 f3 0f 2c f1 89 77 2c f3 ?? ?? ?? ?? ?? ?? ?? 41 0f 2f c3
            //gameLog
            //48 89 4c 24 08 48 89 54 24 10 4c 89 44 24 18 4c 89 4c 24 20 53 57 48 83 ec 28 48 ?? ?? ?? ?? ?? ?? 48 81 c2 00 31 00 00
            //goPlayer
            //40 56 48 83 ec 30 48 83 ?? ?? ?? ?? ?? ?? 48 8b f1 0f 85 9b 02 00 00 48 89 5c 24 40 48 8d ?? ?? ?? ?? ?? 48 89 6c 24 50 33 d2 48 89 7c 24 28
            //locomotion::g_list
            //cc 48 ?? ?? ?? ?? ?? ?? 48 ?? ?? ?? ?? ?? ?? 48 3b c2 74 0e 48 39 48 10 74 0a 48 8b 00 48 3b c2 75 f2 33 c0 c3 cc
            //sharedResourceData
            //85 c0 74 65 45 33 c9 8d 14 40 c1 e2 04 49 8b cd 45 8d 41 08 e8 ?? ?? ?? ?? 33 db 48 

            //progression::facts::s_factManager.m_acceleration_criticalPathProgress = gowr.exe+0x2560510

            bInvuln = gowr + 0x3936979;                                                         //1.0.622.6666
            fGamespeed = gowr + 0x2441568;                                                      //1.0.622.6666
            gamelog = RIntPtr(gowr + 0x4f1eb98);                                                //1.0.622.6666
            goPlayer = RIntPtr(gowr + 0x5d09990);                                               //1.0.622.6666
            sharedResourceData = RIntPtr(gowr + 0x5e32238);                                     //1.0.622.6666
            int resCount = RInt32(gowr + 0x5e32240);                                            //1.0.622.6666
            locomotion__g_list = gowr + 0x24f2f20;                                              //1.0.622.6666
            factManager = gowr + 0x253d6c0;                                                     //1.0.622.6666


            IntPtr currEnemy = RIntPtr(locomotion__g_list);
            IntPtr lastEnemy = RIntPtr(locomotion__g_list + 8);

            if (RUInt32(gowr + 0xc0) == 0)
            {
                lblProcName.Text = "No Process found";
                refreshData.Stop();
            }



            IntPtr goCreature = RIntPtr(goPlayer + 0x8);
            IntPtr wadContext = RIntPtr(goCreature + 0x79f0);

            txtXPos.Text = Math.Round(RSingle(goCreature + 0x50), 3).ToString();
            txtYPos.Text = Math.Round(RSingle(goCreature + 0x54), 3).ToString();
            txtZPos.Text = Math.Round(RSingle(goCreature + 0x58), 3).ToString();

            txtCurrHp.Text = Math.Round(RSingle(goCreature + 0x2b90), 3).ToString();
            txtHeroName.Text = RAscStr(goCreature + 0x7078);
            txtWadContextName.Text = RAscStr(wadContext + 0xcb8);
            txtStrength.Text = RSingle(goCreature + 0x7ca0).ToString();
            txtDefense.Text = RSingle(goCreature + 0x7ca4).ToString();
            txtRunic.Text = RSingle(goCreature + 0x7ca8).ToString();
            txtVitality.Text = RSingle(goCreature + 0x7cac).ToString();
            txtLuck.Text = RSingle(goCreature + 0x7cb0).ToString();
            txtCooldown.Text = RSingle(goCreature + 0x7cb4).ToString();
            txtUnk7cb8.Text = RSingle(goCreature + 0x7cb8).ToString();
            txtLevel.Text = RSingle(goCreature + 0x7cbc).ToString();

            UInt64 TargetHandle = RUInt64(goPlayer + 0x200);
            txtTargetHandle.Text = TargetHandle.ToString("X");

            IntPtr firstmeter = RIntPtr(goCreature + 0x39a8);
            IntPtr lastmeter = RIntPtr(goCreature + 0x39b0);



            sharedResourceData += 0x332e8;


            for (int i = 0; i < resCount; i++)
            {
                string resourceName = "";
                IntPtr resourceNamePtr = RIntPtr(sharedResourceData + i * 0x10);
                resourceNamePtr = RIntPtr(resourceNamePtr + 0x28);
                resourceNamePtr = RIntPtr(resourceNamePtr + 0x30);
                resourceName = RAscStr(resourceNamePtr);

                int amt = RInt32(sharedResourceData + 8 + i * 0x10);

                if (i > dtInventory.Rows.Count - 1)
                {
                    dtInventory.Rows.Add(resourceName, amt);
                }
                else
                {

                    dtInventory.Rows[i]["Name"] = resourceName;
                    dtInventory.Rows[i]["Amount"] = amt;
                }

            }

            dtPlayerMeters.Clear();
            for (int i = 0; i < 23; i++)
            {
                IntPtr currMeter = firstmeter + i * 0x98;
                IntPtr mtwk = RIntPtr(currMeter + 0x18);
                string meterName = RAscStr(RIntPtr(mtwk));
                Single meterValue = RSingle(currMeter + 0x28);
                dtPlayerMeters.Rows.Add(meterName, meterValue);
            }
            dtNmeMeters.Clear();

            if (TargetHandle == 0)
            {
                txtTargetXPos.Text = "";
                txtTargetYPos.Text = "";
                txtTargetZPos.Text = "";

                txtTargetName.Text = "";
                txtTargetCurrHp.Text = "";
                txtTargetStrength.Text = "";
                txtTargetDefense.Text = "";
                txtTargetRunic.Text = "";
                txtTargetVitality.Text = "";
                txtTargetLuck.Text = "";
                txtTargetCooldown.Text = "";
                txtTargetUnk7cb8.Text = "";
                txtTargetLevel.Text = "";
            }
            else
            {

                IntPtr nmeCreature = IntPtr.Zero;
                UInt64 nmeHandle = 0;

                int sanityCheck = 0;
                bool loop = true;
                while (loop)
                {
                    if (currEnemy == lastEnemy)
                    {
                        loop = false;
                    }
                    nmeCreature = RIntPtr(currEnemy + 0x10);
                    nmeHandle = RUInt64(nmeCreature + 0x9410);
                    if (nmeHandle == TargetHandle)
                    {
                        break;
                    }
                    currEnemy = RIntPtr(currEnemy);
                    sanityCheck++;
                    if (sanityCheck > 100)
                    {
                        break;
                    }

                }

                IntPtr firstNmeMeter = RIntPtr(nmeCreature + 0x39a8);
                for (int i = 0; i < 23; i++)
                {
                    IntPtr currMeter = firstNmeMeter + i * 0x98;
                    IntPtr mtwk = RIntPtr(currMeter + 0x18);
                    string meterName = RAscStr(RIntPtr(mtwk));
                    Single meterValue = RSingle(currMeter + 0x28);
                    dtNmeMeters.Rows.Add(meterName, meterValue);
                }

                txtTargetXPos.Text = Math.Round(RSingle(nmeCreature + 0x50), 3).ToString();
                txtTargetYPos.Text = Math.Round(RSingle(nmeCreature + 0x54), 3).ToString();
                txtTargetZPos.Text = Math.Round(RSingle(nmeCreature + 0x58), 3).ToString();

                txtTargetCurrHp.Text = Math.Round(RSingle(nmeCreature + 0x2b90), 3).ToString();
                txtTargetName.Text = RAscStr(nmeCreature + 0x7078);
                txtTargetStrength.Text = RSingle(nmeCreature + 0x7ca0).ToString();
                txtTargetDefense.Text = RSingle(nmeCreature + 0x7ca4).ToString();
                txtTargetRunic.Text = RSingle(nmeCreature + 0x7ca8).ToString();
                txtTargetVitality.Text = RSingle(nmeCreature + 0x7cac).ToString();
                txtTargetLuck.Text = RSingle(nmeCreature + 0x7cb0).ToString();
                txtTargetCooldown.Text = RSingle(nmeCreature + 0x7cb4).ToString();
                txtTargetUnk7cb8.Text = RSingle(nmeCreature + 0x7cb8).ToString();
                txtTargetLevel.Text = RSingle(nmeCreature + 0x7cbc).ToString();


            }// end if TargetHandle !=0

            chkInvulnerable.Checked = RInt8(bInvuln) != 0;
            txtGamespeed.Text = RSingle(fGamespeed).ToString();
            gamelog += 0x3100;
            int firstmsg = RInt32(gamelog + 0x8000);
            int lastmsg = RInt32(gamelog + 0x8004);
            string msg = "";
            for (int i = 0; i < 0x80; i++)
            {
                int offset = 0;
                offset = (firstmsg + i) * 0x100;
                if (offset >= 0x8000)
                {
                    offset -= 0x8000;
                }
                string newmsg = RAscStr(gamelog + offset);
                if (newmsg.Length > 0)
                {
                    msg += newmsg + Environment.NewLine;
                }
            }

            if (!txtGameLog.Text.Equals(msg))
            {
                txtGameLog.Text = msg;
                txtGameLog.SelectionStart = txtGameLog.Text.Length;
                txtGameLog.ScrollToCaret();
            }

            txtCriticalPathProgress.Text = RUInt64(factManager + 0x23ef0).ToString("X");
            txtCriticalPathProgress2.Text = RUInt64(factManager + 0x23ef0).ToString();
        }

        private void btnWadWarp_Click(object sender, EventArgs e)
        {
            WAscStr(gowr + 0x5f45e00, cmbWadWarpList.Text);     //jumpToWadName                     //1.0.622.6666
            WInt8(gowr + 0x4e62d92, 1);                         //bhvrClient::s_WADJumpRequested    //1.0.622.6666
            Thread.Sleep(5000);
            WAscStr(gowr + 0x24ecf58, "mid_chase100_intro");    //g_FirstLevel                      //1.0.622.6666
        }


        private void chkInvulnerable_MouseClick(object sender, MouseEventArgs e)
        {
            WInt8(bInvuln, Convert.ToSByte(1 - RInt8(bInvuln)));
        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtInvSelName.Text = dtInventory.Rows[e.RowIndex]["Name"].ToString();
            txtInvSelAmt.Text = dtInventory.Rows[e.RowIndex]["Amount"].ToString();
        }

        private void btnInvAmtSet_Click(object sender, EventArgs e)
        {
            IntPtr amtPos = sharedResourceData + dgvInventory.SelectedCells[0].RowIndex * 0x10 + 8;
            WInt32(amtPos, Convert.ToInt32(txtInvSelAmt.Text));
        }

        private void btnGamespeedUp_Click(object sender, EventArgs e)
        {
            WSingle(fGamespeed, Convert.ToSingle(txtGamespeed.Text) + 0.25f);
        }

        private void btnGameSpeedDown_Click(object sender, EventArgs e)
        {
            WSingle(fGamespeed, Convert.ToSingle(txtGamespeed.Text) - 0.25f);
        }
    }
}