using System.Drawing;
using System.Windows.Forms;

namespace GoWR_Trainer
{
    partial class frmGoWRTrainer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConnect = new Button();
            lblProcName = new Label();
            txtHeroName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtCurrHp = new TextBox();
            tabControl1 = new TabControl();
            tabCreatures = new TabPage();
            groupBox2 = new GroupBox();
            dgvNmeMeters = new DataGridView();
            txtTargetName = new TextBox();
            label14 = new Label();
            label15 = new Label();
            txtTargetCurrHp = new TextBox();
            label25 = new Label();
            txtTargetXPos = new TextBox();
            txtTargetLevel = new TextBox();
            label24 = new Label();
            txtTargetYPos = new TextBox();
            txtTargetZPos = new TextBox();
            label16 = new Label();
            txtTargetStrength = new TextBox();
            label21 = new Label();
            txtTargetRunic = new TextBox();
            txtTargetUnk7cb8 = new TextBox();
            txtTargetDefense = new TextBox();
            label20 = new Label();
            label22 = new Label();
            label17 = new Label();
            txtTargetVitality = new TextBox();
            label19 = new Label();
            txtTargetLuck = new TextBox();
            txtTargetCooldown = new TextBox();
            label18 = new Label();
            groupBox1 = new GroupBox();
            dgvPlayerMeters = new DataGridView();
            txtWadContextName = new TextBox();
            label26 = new Label();
            txtXPos = new TextBox();
            label4 = new Label();
            txtYPos = new TextBox();
            txtZPos = new TextBox();
            txtTargetHandle = new TextBox();
            label5 = new Label();
            txtStrength = new TextBox();
            label6 = new Label();
            txtDefense = new TextBox();
            label7 = new Label();
            txtRunic = new TextBox();
            label8 = new Label();
            txtVitality = new TextBox();
            label9 = new Label();
            txtLuck = new TextBox();
            label10 = new Label();
            txtCooldown = new TextBox();
            label11 = new Label();
            txtUnk7cb8 = new TextBox();
            label12 = new Label();
            txtLevel = new TextBox();
            label13 = new Label();
            tabInventory = new TabPage();
            btnInvAmtSet = new Button();
            txtInvSelAmt = new TextBox();
            txtInvSelName = new TextBox();
            dgvInventory = new DataGridView();
            tabQuests = new TabPage();
            txtCriticalPathProgress2 = new TextBox();
            txtCriticalPathProgress = new TextBox();
            label29 = new Label();
            tabWarp = new TabPage();
            btnWadWarp = new Button();
            label3 = new Label();
            cmbWadWarpList = new ComboBox();
            tabCheats = new TabPage();
            btnGameSpeedDown = new Button();
            btnGamespeedUp = new Button();
            txtGamespeed = new TextBox();
            label23 = new Label();
            chkInvulnerable = new CheckBox();
            tabGameLog = new TabPage();
            txtGameLog = new TextBox();
            label28 = new Label();
            tabControl1.SuspendLayout();
            tabCreatures.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNmeMeters).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlayerMeters).BeginInit();
            tabInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            tabQuests.SuspendLayout();
            tabWarp.SuspendLayout();
            tabCheats.SuspendLayout();
            tabGameLog.SuspendLayout();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(883, 877);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // lblProcName
            // 
            lblProcName.AutoSize = true;
            lblProcName.Location = new Point(12, 9);
            lblProcName.Name = "lblProcName";
            lblProcName.Size = new Size(66, 15);
            lblProcName.TabIndex = 1;
            lblProcName.Text = "No process";
            // 
            // txtHeroName
            // 
            txtHeroName.Location = new Point(88, 26);
            txtHeroName.Name = "txtHeroName";
            txtHeroName.Size = new Size(239, 23);
            txtHeroName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 29);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 58);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 5;
            label2.Text = "Curr HP";
            // 
            // txtCurrHp
            // 
            txtCurrHp.Location = new Point(88, 55);
            txtCurrHp.Name = "txtCurrHp";
            txtCurrHp.Size = new Size(75, 23);
            txtCurrHp.TabIndex = 4;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabCreatures);
            tabControl1.Controls.Add(tabInventory);
            tabControl1.Controls.Add(tabQuests);
            tabControl1.Controls.Add(tabWarp);
            tabControl1.Controls.Add(tabCheats);
            tabControl1.Controls.Add(tabGameLog);
            tabControl1.Location = new Point(12, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(950, 844);
            tabControl1.TabIndex = 6;
            // 
            // tabCreatures
            // 
            tabCreatures.Controls.Add(groupBox2);
            tabCreatures.Controls.Add(groupBox1);
            tabCreatures.Location = new Point(4, 24);
            tabCreatures.Name = "tabCreatures";
            tabCreatures.Padding = new Padding(3);
            tabCreatures.Size = new Size(942, 816);
            tabCreatures.TabIndex = 0;
            tabCreatures.Text = "Creatures";
            tabCreatures.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvNmeMeters);
            groupBox2.Controls.Add(txtTargetName);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(txtTargetCurrHp);
            groupBox2.Controls.Add(label25);
            groupBox2.Controls.Add(txtTargetXPos);
            groupBox2.Controls.Add(txtTargetLevel);
            groupBox2.Controls.Add(label24);
            groupBox2.Controls.Add(txtTargetYPos);
            groupBox2.Controls.Add(txtTargetZPos);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(txtTargetStrength);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(txtTargetRunic);
            groupBox2.Controls.Add(txtTargetUnk7cb8);
            groupBox2.Controls.Add(txtTargetDefense);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(txtTargetVitality);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(txtTargetLuck);
            groupBox2.Controls.Add(txtTargetCooldown);
            groupBox2.Controls.Add(label18);
            groupBox2.Location = new Point(474, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(462, 800);
            groupBox2.TabIndex = 55;
            groupBox2.TabStop = false;
            groupBox2.Text = "Target";
            // 
            // dgvNmeMeters
            // 
            dgvNmeMeters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNmeMeters.Location = new Point(13, 173);
            dgvNmeMeters.Name = "dgvNmeMeters";
            dgvNmeMeters.RowTemplate.Height = 25;
            dgvNmeMeters.Size = new Size(319, 621);
            dgvNmeMeters.TabIndex = 54;
            // 
            // txtTargetName
            // 
            txtTargetName.Location = new Point(93, 22);
            txtTargetName.Name = "txtTargetName";
            txtTargetName.Size = new Size(237, 23);
            txtTargetName.TabIndex = 28;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(19, 25);
            label14.Name = "label14";
            label14.Size = new Size(39, 15);
            label14.TabIndex = 29;
            label14.Text = "Name";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(338, 228);
            label15.Name = "label15";
            label15.Size = new Size(34, 15);
            label15.TabIndex = 53;
            label15.Text = "Level";
            // 
            // txtTargetCurrHp
            // 
            txtTargetCurrHp.Location = new Point(93, 54);
            txtTargetCurrHp.Name = "txtTargetCurrHp";
            txtTargetCurrHp.Size = new Size(75, 23);
            txtTargetCurrHp.TabIndex = 30;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(19, 57);
            label25.Name = "label25";
            label25.Size = new Size(49, 15);
            label25.TabIndex = 31;
            label25.Text = "Curr HP";
            // 
            // txtTargetXPos
            // 
            txtTargetXPos.Location = new Point(93, 83);
            txtTargetXPos.Name = "txtTargetXPos";
            txtTargetXPos.Size = new Size(75, 23);
            txtTargetXPos.TabIndex = 32;
            // 
            // txtTargetLevel
            // 
            txtTargetLevel.Location = new Point(412, 225);
            txtTargetLevel.Name = "txtTargetLevel";
            txtTargetLevel.Size = new Size(44, 23);
            txtTargetLevel.TabIndex = 52;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(19, 86);
            label24.Name = "label24";
            label24.Size = new Size(26, 15);
            label24.TabIndex = 33;
            label24.Text = "Pos";
            // 
            // txtTargetYPos
            // 
            txtTargetYPos.Location = new Point(174, 83);
            txtTargetYPos.Name = "txtTargetYPos";
            txtTargetYPos.Size = new Size(75, 23);
            txtTargetYPos.TabIndex = 34;
            // 
            // txtTargetZPos
            // 
            txtTargetZPos.Location = new Point(255, 83);
            txtTargetZPos.Name = "txtTargetZPos";
            txtTargetZPos.Size = new Size(75, 23);
            txtTargetZPos.TabIndex = 35;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(338, 199);
            label16.Name = "label16";
            label16.Size = new Size(52, 15);
            label16.TabIndex = 51;
            label16.Text = "unk7cb8";
            // 
            // txtTargetStrength
            // 
            txtTargetStrength.Location = new Point(412, 22);
            txtTargetStrength.Name = "txtTargetStrength";
            txtTargetStrength.Size = new Size(44, 23);
            txtTargetStrength.TabIndex = 38;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(338, 54);
            label21.Name = "label21";
            label21.Size = new Size(49, 15);
            label21.TabIndex = 41;
            label21.Text = "Defense";
            // 
            // txtTargetRunic
            // 
            txtTargetRunic.Location = new Point(412, 80);
            txtTargetRunic.Name = "txtTargetRunic";
            txtTargetRunic.Size = new Size(44, 23);
            txtTargetRunic.TabIndex = 42;
            // 
            // txtTargetUnk7cb8
            // 
            txtTargetUnk7cb8.Location = new Point(412, 196);
            txtTargetUnk7cb8.Name = "txtTargetUnk7cb8";
            txtTargetUnk7cb8.Size = new Size(44, 23);
            txtTargetUnk7cb8.TabIndex = 50;
            // 
            // txtTargetDefense
            // 
            txtTargetDefense.Location = new Point(412, 51);
            txtTargetDefense.Name = "txtTargetDefense";
            txtTargetDefense.Size = new Size(44, 23);
            txtTargetDefense.TabIndex = 40;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(338, 83);
            label20.Name = "label20";
            label20.Size = new Size(37, 15);
            label20.TabIndex = 43;
            label20.Text = "Runic";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(338, 25);
            label22.Name = "label22";
            label22.Size = new Size(52, 15);
            label22.TabIndex = 39;
            label22.Text = "Strength";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(338, 170);
            label17.Name = "label17";
            label17.Size = new Size(62, 15);
            label17.TabIndex = 49;
            label17.Text = "Cooldown";
            // 
            // txtTargetVitality
            // 
            txtTargetVitality.Location = new Point(412, 109);
            txtTargetVitality.Name = "txtTargetVitality";
            txtTargetVitality.Size = new Size(44, 23);
            txtTargetVitality.TabIndex = 44;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(338, 112);
            label19.Name = "label19";
            label19.Size = new Size(43, 15);
            label19.TabIndex = 45;
            label19.Text = "Vitality";
            // 
            // txtTargetLuck
            // 
            txtTargetLuck.Location = new Point(412, 138);
            txtTargetLuck.Name = "txtTargetLuck";
            txtTargetLuck.Size = new Size(44, 23);
            txtTargetLuck.TabIndex = 46;
            // 
            // txtTargetCooldown
            // 
            txtTargetCooldown.Location = new Point(412, 167);
            txtTargetCooldown.Name = "txtTargetCooldown";
            txtTargetCooldown.Size = new Size(44, 23);
            txtTargetCooldown.TabIndex = 48;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(338, 141);
            label18.Name = "label18";
            label18.Size = new Size(32, 15);
            label18.TabIndex = 47;
            label18.Text = "Luck";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvPlayerMeters);
            groupBox1.Controls.Add(txtWadContextName);
            groupBox1.Controls.Add(label26);
            groupBox1.Controls.Add(txtHeroName);
            groupBox1.Controls.Add(txtCurrHp);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtXPos);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtYPos);
            groupBox1.Controls.Add(txtZPos);
            groupBox1.Controls.Add(txtTargetHandle);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtStrength);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDefense);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtRunic);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtVitality);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtLuck);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtCooldown);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtUnk7cb8);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtLevel);
            groupBox1.Controls.Add(label13);
            groupBox1.Location = new Point(6, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(462, 800);
            groupBox1.TabIndex = 54;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kratos";
            // 
            // dgvPlayerMeters
            // 
            dgvPlayerMeters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlayerMeters.Location = new Point(8, 173);
            dgvPlayerMeters.Name = "dgvPlayerMeters";
            dgvPlayerMeters.RowTemplate.Height = 25;
            dgvPlayerMeters.Size = new Size(319, 621);
            dgvPlayerMeters.TabIndex = 32;
            // 
            // txtWadContextName
            // 
            txtWadContextName.Location = new Point(88, 113);
            txtWadContextName.Name = "txtWadContextName";
            txtWadContextName.Size = new Size(239, 23);
            txtWadContextName.TabIndex = 28;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(14, 116);
            label26.Name = "label26";
            label26.Size = new Size(55, 15);
            label26.TabIndex = 29;
            label26.Text = "WAD Ctx";
            // 
            // txtXPos
            // 
            txtXPos.Location = new Point(88, 84);
            txtXPos.Name = "txtXPos";
            txtXPos.Size = new Size(75, 23);
            txtXPos.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 87);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 7;
            label4.Text = "Pos";
            // 
            // txtYPos
            // 
            txtYPos.Location = new Point(169, 84);
            txtYPos.Name = "txtYPos";
            txtYPos.Size = new Size(75, 23);
            txtYPos.TabIndex = 8;
            // 
            // txtZPos
            // 
            txtZPos.Location = new Point(250, 84);
            txtZPos.Name = "txtZPos";
            txtZPos.Size = new Size(75, 23);
            txtZPos.TabIndex = 9;
            // 
            // txtTargetHandle
            // 
            txtTargetHandle.Location = new Point(88, 142);
            txtTargetHandle.Name = "txtTargetHandle";
            txtTargetHandle.Size = new Size(239, 23);
            txtTargetHandle.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 145);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 11;
            label5.Text = "Target";
            // 
            // txtStrength
            // 
            txtStrength.Location = new Point(408, 26);
            txtStrength.Name = "txtStrength";
            txtStrength.Size = new Size(44, 23);
            txtStrength.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(334, 29);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 13;
            label6.Text = "Strength";
            // 
            // txtDefense
            // 
            txtDefense.Location = new Point(408, 55);
            txtDefense.Name = "txtDefense";
            txtDefense.Size = new Size(44, 23);
            txtDefense.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(334, 58);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 15;
            label7.Text = "Defense";
            // 
            // txtRunic
            // 
            txtRunic.Location = new Point(408, 84);
            txtRunic.Name = "txtRunic";
            txtRunic.Size = new Size(44, 23);
            txtRunic.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(334, 87);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 17;
            label8.Text = "Runic";
            // 
            // txtVitality
            // 
            txtVitality.Location = new Point(408, 113);
            txtVitality.Name = "txtVitality";
            txtVitality.Size = new Size(44, 23);
            txtVitality.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(334, 116);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 19;
            label9.Text = "Vitality";
            // 
            // txtLuck
            // 
            txtLuck.Location = new Point(408, 141);
            txtLuck.Name = "txtLuck";
            txtLuck.Size = new Size(44, 23);
            txtLuck.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(334, 144);
            label10.Name = "label10";
            label10.Size = new Size(32, 15);
            label10.TabIndex = 21;
            label10.Text = "Luck";
            // 
            // txtCooldown
            // 
            txtCooldown.Location = new Point(408, 170);
            txtCooldown.Name = "txtCooldown";
            txtCooldown.Size = new Size(44, 23);
            txtCooldown.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(334, 173);
            label11.Name = "label11";
            label11.Size = new Size(62, 15);
            label11.TabIndex = 23;
            label11.Text = "Cooldown";
            // 
            // txtUnk7cb8
            // 
            txtUnk7cb8.Location = new Point(408, 199);
            txtUnk7cb8.Name = "txtUnk7cb8";
            txtUnk7cb8.Size = new Size(44, 23);
            txtUnk7cb8.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(334, 202);
            label12.Name = "label12";
            label12.Size = new Size(52, 15);
            label12.TabIndex = 25;
            label12.Text = "unk7cb8";
            // 
            // txtLevel
            // 
            txtLevel.Location = new Point(408, 228);
            txtLevel.Name = "txtLevel";
            txtLevel.Size = new Size(44, 23);
            txtLevel.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(334, 231);
            label13.Name = "label13";
            label13.Size = new Size(34, 15);
            label13.TabIndex = 27;
            label13.Text = "Level";
            // 
            // tabInventory
            // 
            tabInventory.Controls.Add(btnInvAmtSet);
            tabInventory.Controls.Add(txtInvSelAmt);
            tabInventory.Controls.Add(txtInvSelName);
            tabInventory.Controls.Add(dgvInventory);
            tabInventory.Location = new Point(4, 24);
            tabInventory.Name = "tabInventory";
            tabInventory.Size = new Size(942, 816);
            tabInventory.TabIndex = 4;
            tabInventory.Text = "Inventory";
            tabInventory.UseVisualStyleBackColor = true;
            // 
            // btnInvAmtSet
            // 
            btnInvAmtSet.Location = new Point(371, 790);
            btnInvAmtSet.Name = "btnInvAmtSet";
            btnInvAmtSet.Size = new Size(75, 23);
            btnInvAmtSet.TabIndex = 36;
            btnInvAmtSet.Text = "Set";
            btnInvAmtSet.UseVisualStyleBackColor = true;
            btnInvAmtSet.Click += btnInvAmtSet_Click;
            // 
            // txtInvSelAmt
            // 
            txtInvSelAmt.Location = new Point(289, 790);
            txtInvSelAmt.Name = "txtInvSelAmt";
            txtInvSelAmt.Size = new Size(76, 23);
            txtInvSelAmt.TabIndex = 35;
            // 
            // txtInvSelName
            // 
            txtInvSelName.Enabled = false;
            txtInvSelName.Location = new Point(131, 790);
            txtInvSelName.Name = "txtInvSelName";
            txtInvSelName.Size = new Size(152, 23);
            txtInvSelName.TabIndex = 34;
            // 
            // dgvInventory
            // 
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(3, 3);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.RowTemplate.Height = 25;
            dgvInventory.Size = new Size(443, 781);
            dgvInventory.TabIndex = 33;
            dgvInventory.CellClick += dgvInventory_CellClick;
            // 
            // tabQuests
            // 
            tabQuests.Controls.Add(txtCriticalPathProgress2);
            tabQuests.Controls.Add(txtCriticalPathProgress);
            tabQuests.Controls.Add(label29);
            tabQuests.Location = new Point(4, 24);
            tabQuests.Name = "tabQuests";
            tabQuests.Size = new Size(942, 816);
            tabQuests.TabIndex = 5;
            tabQuests.Text = "Quests";
            tabQuests.UseVisualStyleBackColor = true;
            // 
            // txtCriticalPathProgress2
            // 
            txtCriticalPathProgress2.Location = new Point(125, 45);
            txtCriticalPathProgress2.Name = "txtCriticalPathProgress2";
            txtCriticalPathProgress2.Size = new Size(239, 23);
            txtCriticalPathProgress2.TabIndex = 6;
            // 
            // txtCriticalPathProgress
            // 
            txtCriticalPathProgress.Location = new Point(125, 16);
            txtCriticalPathProgress.Name = "txtCriticalPathProgress";
            txtCriticalPathProgress.Size = new Size(239, 23);
            txtCriticalPathProgress.TabIndex = 4;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(8, 19);
            label29.Name = "label29";
            label29.Size = new Size(111, 15);
            label29.TabIndex = 5;
            label29.Text = "criticalPathProgress";
            // 
            // tabWarp
            // 
            tabWarp.Controls.Add(btnWadWarp);
            tabWarp.Controls.Add(label3);
            tabWarp.Controls.Add(cmbWadWarpList);
            tabWarp.Location = new Point(4, 24);
            tabWarp.Name = "tabWarp";
            tabWarp.Padding = new Padding(3);
            tabWarp.Size = new Size(942, 816);
            tabWarp.TabIndex = 1;
            tabWarp.Text = "Warp";
            tabWarp.UseVisualStyleBackColor = true;
            // 
            // btnWadWarp
            // 
            btnWadWarp.Location = new Point(110, 35);
            btnWadWarp.Name = "btnWadWarp";
            btnWadWarp.Size = new Size(115, 23);
            btnWadWarp.TabIndex = 2;
            btnWadWarp.Text = "Warp to WAD";
            btnWadWarp.UseVisualStyleBackColor = true;
            btnWadWarp.Click += btnWadWarp_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 9);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 1;
            label3.Text = "WAD Name";
            // 
            // cmbWadWarpList
            // 
            cmbWadWarpList.FormattingEnabled = true;
            cmbWadWarpList.Items.AddRange(new object[] { "alf_bluff100_entrance", "alf_cave200_sinkhole", "alf_tmpl100_center", "mid_cal200_shore", "mid_chase100_intro", "mid_drm100_river" });
            cmbWadWarpList.Location = new Point(110, 6);
            cmbWadWarpList.Name = "cmbWadWarpList";
            cmbWadWarpList.Size = new Size(273, 23);
            cmbWadWarpList.TabIndex = 0;
            // 
            // tabCheats
            // 
            tabCheats.Controls.Add(btnGameSpeedDown);
            tabCheats.Controls.Add(btnGamespeedUp);
            tabCheats.Controls.Add(txtGamespeed);
            tabCheats.Controls.Add(label23);
            tabCheats.Controls.Add(chkInvulnerable);
            tabCheats.Location = new Point(4, 24);
            tabCheats.Name = "tabCheats";
            tabCheats.Size = new Size(942, 816);
            tabCheats.TabIndex = 2;
            tabCheats.Text = "Cheats";
            tabCheats.UseVisualStyleBackColor = true;
            // 
            // btnGameSpeedDown
            // 
            btnGameSpeedDown.Location = new Point(139, 56);
            btnGameSpeedDown.Name = "btnGameSpeedDown";
            btnGameSpeedDown.Size = new Size(40, 23);
            btnGameSpeedDown.TabIndex = 5;
            btnGameSpeedDown.Text = "-";
            btnGameSpeedDown.UseVisualStyleBackColor = true;
            btnGameSpeedDown.Click += btnGameSpeedDown_Click;
            // 
            // btnGamespeedUp
            // 
            btnGamespeedUp.Location = new Point(185, 57);
            btnGamespeedUp.Name = "btnGamespeedUp";
            btnGamespeedUp.Size = new Size(40, 23);
            btnGamespeedUp.TabIndex = 4;
            btnGamespeedUp.Text = "+";
            btnGamespeedUp.UseVisualStyleBackColor = true;
            btnGamespeedUp.Click += btnGamespeedUp_Click;
            // 
            // txtGamespeed
            // 
            txtGamespeed.Location = new Point(93, 57);
            txtGamespeed.Name = "txtGamespeed";
            txtGamespeed.Size = new Size(40, 23);
            txtGamespeed.TabIndex = 3;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(14, 60);
            label23.Name = "label23";
            label23.Size = new Size(73, 15);
            label23.TabIndex = 2;
            label23.Text = "Game Speed";
            // 
            // chkInvulnerable
            // 
            chkInvulnerable.AutoSize = true;
            chkInvulnerable.Location = new Point(12, 14);
            chkInvulnerable.Name = "chkInvulnerable";
            chkInvulnerable.Size = new Size(91, 19);
            chkInvulnerable.TabIndex = 1;
            chkInvulnerable.Text = "Invulnerable";
            chkInvulnerable.UseVisualStyleBackColor = true;
            chkInvulnerable.MouseClick += chkInvulnerable_MouseClick;
            // 
            // tabGameLog
            // 
            tabGameLog.Controls.Add(txtGameLog);
            tabGameLog.Location = new Point(4, 24);
            tabGameLog.Name = "tabGameLog";
            tabGameLog.Size = new Size(942, 816);
            tabGameLog.TabIndex = 3;
            tabGameLog.Text = "GameLog";
            tabGameLog.UseVisualStyleBackColor = true;
            // 
            // txtGameLog
            // 
            txtGameLog.Location = new Point(3, 3);
            txtGameLog.Multiline = true;
            txtGameLog.Name = "txtGameLog";
            txtGameLog.ScrollBars = ScrollBars.Vertical;
            txtGameLog.Size = new Size(932, 801);
            txtGameLog.TabIndex = 37;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(16, 881);
            label28.Name = "label28";
            label28.Size = new Size(169, 15);
            label28.TabIndex = 7;
            label28.Text = "Needs GoWR.exe v1.0.622.6666";
            // 
            // frmGoWRTrainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 912);
            Controls.Add(label28);
            Controls.Add(tabControl1);
            Controls.Add(lblProcName);
            Controls.Add(btnConnect);
            Name = "frmGoWRTrainer";
            Text = "God of War: Ragnarok - Trainer";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabCreatures.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNmeMeters).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlayerMeters).EndInit();
            tabInventory.ResumeLayout(false);
            tabInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            tabQuests.ResumeLayout(false);
            tabQuests.PerformLayout();
            tabWarp.ResumeLayout(false);
            tabWarp.PerformLayout();
            tabCheats.ResumeLayout(false);
            tabCheats.PerformLayout();
            tabGameLog.ResumeLayout(false);
            tabGameLog.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnect;
        private Label lblProcName;
        private TextBox txtHeroName;
        private Label label1;
        private Label label2;
        private TextBox txtCurrHp;
        private TabControl tabControl1;
        private TabPage tabCreatures;
        private TabPage tabWarp;
        private Button btnWadWarp;
        private Label label3;
        private ComboBox cmbWadWarpList;
        private TextBox txtZPos;
        private TextBox txtYPos;
        private Label label4;
        private TextBox txtXPos;
        private Label label5;
        private TextBox txtTargetHandle;
        private Label label13;
        private TextBox txtLevel;
        private Label label12;
        private TextBox txtUnk7cb8;
        private Label label11;
        private TextBox txtCooldown;
        private Label label10;
        private TextBox txtLuck;
        private Label label9;
        private TextBox txtVitality;
        private Label label8;
        private TextBox txtRunic;
        private Label label7;
        private TextBox txtDefense;
        private Label label6;
        private TextBox txtStrength;
        private Label label14;
        private TextBox txtTargetName;
        private GroupBox groupBox2;
        private Label label15;
        private TextBox txtTargetCurrHp;
        private TextBox txtTargetLevel;
        private Label label25;
        private Label label16;
        private TextBox txtTargetXPos;
        private TextBox txtTargetUnk7cb8;
        private Label label24;
        private Label label17;
        private TextBox txtTargetYPos;
        private TextBox txtTargetCooldown;
        private TextBox txtTargetZPos;
        private Label label18;
        private TextBox txtTargetLuck;
        private Label label19;
        private TextBox txtTargetStrength;
        private TextBox txtTargetVitality;
        private Label label22;
        private Label label20;
        private TextBox txtTargetDefense;
        private TextBox txtTargetRunic;
        private Label label21;
        private GroupBox groupBox1;
        private TabPage tabCheats;
        private CheckBox chkEasykill;
        private CheckBox chkInvulnerable;
        private TextBox txtWadContextName;
        private Label label26;
        private TextBox txtGameLog;
        private DataGridView dgvPlayerMeters;
        private TabPage tabGameLog;
        private DataGridView dgvNmeMeters;
        private TabPage tabInventory;
        private DataGridView dgvInventory;
        private TextBox txtInvSelName;
        private TextBox txtInvSelAmt;
        private Button btnInvAmtSet;
        private Label label23;
        private TextBox txtGamespeed;
        private Button btnGameSpeedDown;
        private Button btnGamespeedUp;
        private Label label28;
        private TabPage tabQuests;
        private TextBox txtCriticalPathProgress;
        private Label label29;
        private TextBox txtCriticalPathProgress2;
    }
}