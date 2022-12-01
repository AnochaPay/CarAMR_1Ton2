namespace AMR_Command {
    partial class FormMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.bgwk_sensor = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tm_send_data = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.bgwk_serial = new System.ComponentModel.BackgroundWorker();
            this.bgwk_main = new System.ComponentModel.BackgroundWorker();
            this.tm_delay_csv = new System.Windows.Forms.Timer(this.components);
            this.tm_close = new System.Windows.Forms.Timer(this.components);
            this.tab_manual = new System.Windows.Forms.TabPage();
            this.label36 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_unlockCF2 = new System.Windows.Forms.Button();
            this.bt_unlockCF1 = new System.Windows.Forms.Button();
            this.bt_unlockEnd = new System.Windows.Forms.Button();
            this.bt_unlockResume = new System.Windows.Forms.Button();
            this.bt_unlockPickedup = new System.Windows.Forms.Button();
            this.bt_unlockPause = new System.Windows.Forms.Button();
            this.bt_unlockStart = new System.Windows.Forms.Button();
            this.bt_unlockDrop = new System.Windows.Forms.Button();
            this.tab_StatusExt = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label35 = new System.Windows.Forms.Label();
            this.lb_StatusNc = new System.Windows.Forms.Label();
            this.lb_BumperWingR = new System.Windows.Forms.Label();
            this.lb_BumperWingL = new System.Windows.Forms.Label();
            this.lb_BumperSideR = new System.Windows.Forms.Label();
            this.lb_BumperSideL = new System.Windows.Forms.Label();
            this.lb_BumperFront = new System.Windows.Forms.Label();
            this.lb_ScanSideStopL = new System.Windows.Forms.Label();
            this.lb_ScanSideWarningL = new System.Windows.Forms.Label();
            this.lb_ScanSideMalfunctionL = new System.Windows.Forms.Label();
            this.lb_ScanSideStopR = new System.Windows.Forms.Label();
            this.lb_ScanSideWarningR = new System.Windows.Forms.Label();
            this.lb_ScanSideMalfunctionR = new System.Windows.Forms.Label();
            this.lb_ScanFrontStop = new System.Windows.Forms.Label();
            this.lb_ScanFrontWarning = new System.Windows.Forms.Label();
            this.lb_ScanFrontMalfunction = new System.Windows.Forms.Label();
            this.lb_Emergency = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tab_statusInt = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.lb_rollDetect = new System.Windows.Forms.Label();
            this.lb_maxLimit = new System.Windows.Forms.Label();
            this.lb_forkLevel2 = new System.Windows.Forms.Label();
            this.lb_forkLevel1 = new System.Windows.Forms.Label();
            this.lb_forkLevel0 = new System.Windows.Forms.Label();
            this.lb_resetSwitch = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.lb_startSwitch = new System.Windows.Forms.Label();
            this.lb_maxLimitSup = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.lb_rollDetectSup = new System.Windows.Forms.Label();
            this.lb_forkLevel2Sup = new System.Windows.Forms.Label();
            this.lb_forkLevel1Sup = new System.Windows.Forms.Label();
            this.lb_forkLevel0Sup = new System.Windows.Forms.Label();
            this.lb_resetSwitchSup = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.tab_Serial = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_forkLevel1 = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.bt_forkLevel0 = new System.Windows.Forms.Button();
            this.bt_forkLevel2 = new System.Windows.Forms.Button();
            this.tab_Server = new System.Windows.Forms.TabPage();
            this.gb_sever = new System.Windows.Forms.GroupBox();
            this.lb_serverGet = new System.Windows.Forms.Label();
            this.lb_serialRx = new System.Windows.Forms.Label();
            this.lb_serialTx = new System.Windows.Forms.Label();
            this.lb_serverSend = new System.Windows.Forms.Label();
            this.lb_speed = new System.Windows.Forms.Label();
            this.lb_angleStepping = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lb_normalSpeed = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lb_NormalSpeedCurrent = new System.Windows.Forms.Label();
            this.lb_angleSteppingCurrent = new System.Windows.Forms.Label();
            this.lb_comport = new System.Windows.Forms.Label();
            this.lb_step = new System.Windows.Forms.Label();
            this.rtb_serial = new System.Windows.Forms.RichTextBox();
            this.rtb_server = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_Melody = new System.Windows.Forms.TabPage();
            this.cb_melody = new System.Windows.Forms.CheckBox();
            this.bt_melody_send = new System.Windows.Forms.Button();
            this.bt_plus = new System.Windows.Forms.Button();
            this.lb_melody = new System.Windows.Forms.Label();
            this.bt_minus = new System.Windows.Forms.Button();
            this.tab_Control = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_preparation = new System.Windows.Forms.Button();
            this.lb_errorSup = new System.Windows.Forms.Label();
            this.lb_angleStep = new System.Windows.Forms.Label();
            this.bt_unFocusPos = new System.Windows.Forms.Button();
            this.bt_focusPos = new System.Windows.Forms.Button();
            this.tb_anglePos = new System.Windows.Forms.TextBox();
            this.tb_yPos = new System.Windows.Forms.TextBox();
            this.tb_xPos = new System.Windows.Forms.TextBox();
            this.lb_ySup = new System.Windows.Forms.Label();
            this.lb_xSup = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.bt_manual = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lb_plant = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lb_location = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_AGV = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_jobOrder = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_speedSum = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_battery = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lb_angle = new System.Windows.Forms.Label();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.lb_y = new System.Windows.Forms.Label();
            this.lb_x = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_camera = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lb_statusRail = new System.Windows.Forms.Label();
            this.lb_messageRail = new System.Windows.Forms.Label();
            this.bt_railTrue = new System.Windows.Forms.Button();
            this.bt_railFalse = new System.Windows.Forms.Button();
            this.bt_cameraDetectF = new System.Windows.Forms.Button();
            this.lb_depth = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.ptb_camera = new System.Windows.Forms.PictureBox();
            this.tab_manual.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tab_StatusExt.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tab_statusInt.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tab_Serial.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tab_Server.SuspendLayout();
            this.gb_sever.SuspendLayout();
            this.tab_Melody.SuspendLayout();
            this.tab_Control.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_camera.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_camera)).BeginInit();
            this.SuspendLayout();
            // 
            // bgwk_sensor
            // 
            this.bgwk_sensor.WorkerReportsProgress = true;
            this.bgwk_sensor.WorkerSupportsCancellation = true;
            this.bgwk_sensor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwk_sensor_DoWork);
            this.bgwk_sensor.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwk_sensor_ProgressChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            // 
            // bgwk_serial
            // 
            this.bgwk_serial.WorkerReportsProgress = true;
            this.bgwk_serial.WorkerSupportsCancellation = true;
            this.bgwk_serial.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwk_serial_DoWork);
            this.bgwk_serial.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwk_serial_ProgressChanged);
            // 
            // bgwk_main
            // 
            this.bgwk_main.WorkerReportsProgress = true;
            this.bgwk_main.WorkerSupportsCancellation = true;
            this.bgwk_main.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwk_main_DoWork);
            this.bgwk_main.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwk_main_ProgressChanged);
            // 
            // tm_delay_csv
            // 
            this.tm_delay_csv.Interval = 5;
            this.tm_delay_csv.Tick += new System.EventHandler(this.tm_delay_csv_Tick);
            // 
            // tm_close
            // 
            this.tm_close.Tick += new System.EventHandler(this.tm_close_Tick);
            // 
            // tab_manual
            // 
            this.tab_manual.BackgroundImage = global::AMR_Command.Properties.Resources.image1;
            this.tab_manual.Controls.Add(this.label36);
            this.tab_manual.Controls.Add(this.groupBox1);
            this.tab_manual.Location = new System.Drawing.Point(4, 22);
            this.tab_manual.Margin = new System.Windows.Forms.Padding(2);
            this.tab_manual.Name = "tab_manual";
            this.tab_manual.Size = new System.Drawing.Size(775, 411);
            this.tab_manual.TabIndex = 5;
            this.tab_manual.Text = "Manual Command";
            this.tab_manual.UseVisualStyleBackColor = true;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.Black;
            this.label36.Location = new System.Drawing.Point(251, 24);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(272, 39);
            this.label36.TabIndex = 111;
            this.label36.Text = "Force Command";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.bt_unlockCF2);
            this.groupBox1.Controls.Add(this.bt_unlockCF1);
            this.groupBox1.Controls.Add(this.bt_unlockEnd);
            this.groupBox1.Controls.Add(this.bt_unlockResume);
            this.groupBox1.Controls.Add(this.bt_unlockPickedup);
            this.groupBox1.Controls.Add(this.bt_unlockPause);
            this.groupBox1.Controls.Add(this.bt_unlockStart);
            this.groupBox1.Controls.Add(this.bt_unlockDrop);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 398);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            // 
            // bt_unlockCF2
            // 
            this.bt_unlockCF2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_unlockCF2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_unlockCF2.Location = new System.Drawing.Point(450, 284);
            this.bt_unlockCF2.Margin = new System.Windows.Forms.Padding(2);
            this.bt_unlockCF2.Name = "bt_unlockCF2";
            this.bt_unlockCF2.Size = new System.Drawing.Size(240, 49);
            this.bt_unlockCF2.TabIndex = 7;
            this.bt_unlockCF2.Text = "Remote CF2";
            this.bt_unlockCF2.UseVisualStyleBackColor = true;
            this.bt_unlockCF2.Click += new System.EventHandler(this.bt_unlockCF2_Click);
            // 
            // bt_unlockCF1
            // 
            this.bt_unlockCF1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_unlockCF1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_unlockCF1.Location = new System.Drawing.Point(75, 284);
            this.bt_unlockCF1.Margin = new System.Windows.Forms.Padding(2);
            this.bt_unlockCF1.Name = "bt_unlockCF1";
            this.bt_unlockCF1.Size = new System.Drawing.Size(240, 49);
            this.bt_unlockCF1.TabIndex = 6;
            this.bt_unlockCF1.Text = "Remote CF1";
            this.bt_unlockCF1.UseVisualStyleBackColor = true;
            this.bt_unlockCF1.Click += new System.EventHandler(this.bt_unlockCF1_Click);
            // 
            // bt_unlockEnd
            // 
            this.bt_unlockEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_unlockEnd.Location = new System.Drawing.Point(450, 219);
            this.bt_unlockEnd.Margin = new System.Windows.Forms.Padding(2);
            this.bt_unlockEnd.Name = "bt_unlockEnd";
            this.bt_unlockEnd.Size = new System.Drawing.Size(240, 49);
            this.bt_unlockEnd.TabIndex = 5;
            this.bt_unlockEnd.Text = "End";
            this.bt_unlockEnd.UseVisualStyleBackColor = true;
            this.bt_unlockEnd.Click += new System.EventHandler(this.bt_unlockEnd_Click);
            // 
            // bt_unlockResume
            // 
            this.bt_unlockResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_unlockResume.Location = new System.Drawing.Point(75, 219);
            this.bt_unlockResume.Margin = new System.Windows.Forms.Padding(2);
            this.bt_unlockResume.Name = "bt_unlockResume";
            this.bt_unlockResume.Size = new System.Drawing.Size(240, 49);
            this.bt_unlockResume.TabIndex = 1;
            this.bt_unlockResume.Text = "Resume";
            this.bt_unlockResume.UseVisualStyleBackColor = true;
            this.bt_unlockResume.Click += new System.EventHandler(this.bt_unlockResume_Click);
            // 
            // bt_unlockPickedup
            // 
            this.bt_unlockPickedup.BackColor = System.Drawing.Color.Transparent;
            this.bt_unlockPickedup.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_unlockPickedup.ForeColor = System.Drawing.Color.Black;
            this.bt_unlockPickedup.Location = new System.Drawing.Point(450, 89);
            this.bt_unlockPickedup.Margin = new System.Windows.Forms.Padding(2);
            this.bt_unlockPickedup.Name = "bt_unlockPickedup";
            this.bt_unlockPickedup.Size = new System.Drawing.Size(240, 49);
            this.bt_unlockPickedup.TabIndex = 3;
            this.bt_unlockPickedup.Text = "Pickedup";
            this.bt_unlockPickedup.UseVisualStyleBackColor = false;
            this.bt_unlockPickedup.Click += new System.EventHandler(this.bt_unlockPickedup_Click);
            // 
            // bt_unlockPause
            // 
            this.bt_unlockPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_unlockPause.Location = new System.Drawing.Point(75, 154);
            this.bt_unlockPause.Margin = new System.Windows.Forms.Padding(2);
            this.bt_unlockPause.Name = "bt_unlockPause";
            this.bt_unlockPause.Size = new System.Drawing.Size(240, 49);
            this.bt_unlockPause.TabIndex = 0;
            this.bt_unlockPause.Text = "Pause";
            this.bt_unlockPause.UseVisualStyleBackColor = true;
            this.bt_unlockPause.Click += new System.EventHandler(this.bt_unlockPause_Click);
            // 
            // bt_unlockStart
            // 
            this.bt_unlockStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_unlockStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_unlockStart.Location = new System.Drawing.Point(75, 89);
            this.bt_unlockStart.Margin = new System.Windows.Forms.Padding(2);
            this.bt_unlockStart.Name = "bt_unlockStart";
            this.bt_unlockStart.Size = new System.Drawing.Size(240, 49);
            this.bt_unlockStart.TabIndex = 4;
            this.bt_unlockStart.Text = "Start";
            this.bt_unlockStart.UseVisualStyleBackColor = true;
            this.bt_unlockStart.Click += new System.EventHandler(this.bt_unlockStart_Click);
            // 
            // bt_unlockDrop
            // 
            this.bt_unlockDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_unlockDrop.Location = new System.Drawing.Point(450, 154);
            this.bt_unlockDrop.Margin = new System.Windows.Forms.Padding(2);
            this.bt_unlockDrop.Name = "bt_unlockDrop";
            this.bt_unlockDrop.Size = new System.Drawing.Size(240, 49);
            this.bt_unlockDrop.TabIndex = 2;
            this.bt_unlockDrop.Text = "Drop";
            this.bt_unlockDrop.UseVisualStyleBackColor = true;
            this.bt_unlockDrop.Click += new System.EventHandler(this.bt_unlockDrop_Click);
            // 
            // tab_StatusExt
            // 
            this.tab_StatusExt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tab_StatusExt.BackgroundImage")));
            this.tab_StatusExt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_StatusExt.Controls.Add(this.groupBox4);
            this.tab_StatusExt.Location = new System.Drawing.Point(4, 22);
            this.tab_StatusExt.Name = "tab_StatusExt";
            this.tab_StatusExt.Size = new System.Drawing.Size(775, 411);
            this.tab_StatusExt.TabIndex = 4;
            this.tab_StatusExt.Text = "Status Ext";
            this.tab_StatusExt.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label35);
            this.groupBox4.Controls.Add(this.lb_StatusNc);
            this.groupBox4.Controls.Add(this.lb_BumperWingR);
            this.groupBox4.Controls.Add(this.lb_BumperWingL);
            this.groupBox4.Controls.Add(this.lb_BumperSideR);
            this.groupBox4.Controls.Add(this.lb_BumperSideL);
            this.groupBox4.Controls.Add(this.lb_BumperFront);
            this.groupBox4.Controls.Add(this.lb_ScanSideStopL);
            this.groupBox4.Controls.Add(this.lb_ScanSideWarningL);
            this.groupBox4.Controls.Add(this.lb_ScanSideMalfunctionL);
            this.groupBox4.Controls.Add(this.lb_ScanSideStopR);
            this.groupBox4.Controls.Add(this.lb_ScanSideWarningR);
            this.groupBox4.Controls.Add(this.lb_ScanSideMalfunctionR);
            this.groupBox4.Controls.Add(this.lb_ScanFrontStop);
            this.groupBox4.Controls.Add(this.lb_ScanFrontWarning);
            this.groupBox4.Controls.Add(this.lb_ScanFrontMalfunction);
            this.groupBox4.Controls.Add(this.lb_Emergency);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(765, 398);
            this.groupBox4.TabIndex = 78;
            this.groupBox4.TabStop = false;
            // 
            // label35
            // 
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label35.Location = new System.Drawing.Point(5, 20);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(755, 37);
            this.label35.TabIndex = 110;
            this.label35.Text = "I/O Status External";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_StatusNc
            // 
            this.lb_StatusNc.AutoSize = true;
            this.lb_StatusNc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_StatusNc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_StatusNc.Location = new System.Drawing.Point(600, 251);
            this.lb_StatusNc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_StatusNc.Name = "lb_StatusNc";
            this.lb_StatusNc.Size = new System.Drawing.Size(70, 25);
            this.lb_StatusNc.TabIndex = 109;
            this.lb_StatusNc.Text = "False";
            // 
            // lb_BumperWingR
            // 
            this.lb_BumperWingR.AutoSize = true;
            this.lb_BumperWingR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BumperWingR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_BumperWingR.Location = new System.Drawing.Point(600, 225);
            this.lb_BumperWingR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_BumperWingR.Name = "lb_BumperWingR";
            this.lb_BumperWingR.Size = new System.Drawing.Size(70, 25);
            this.lb_BumperWingR.TabIndex = 108;
            this.lb_BumperWingR.Text = "False";
            // 
            // lb_BumperWingL
            // 
            this.lb_BumperWingL.AutoSize = true;
            this.lb_BumperWingL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BumperWingL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_BumperWingL.Location = new System.Drawing.Point(600, 199);
            this.lb_BumperWingL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_BumperWingL.Name = "lb_BumperWingL";
            this.lb_BumperWingL.Size = new System.Drawing.Size(70, 25);
            this.lb_BumperWingL.TabIndex = 107;
            this.lb_BumperWingL.Text = "False";
            // 
            // lb_BumperSideR
            // 
            this.lb_BumperSideR.AutoSize = true;
            this.lb_BumperSideR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BumperSideR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_BumperSideR.Location = new System.Drawing.Point(600, 173);
            this.lb_BumperSideR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_BumperSideR.Name = "lb_BumperSideR";
            this.lb_BumperSideR.Size = new System.Drawing.Size(70, 25);
            this.lb_BumperSideR.TabIndex = 106;
            this.lb_BumperSideR.Text = "False";
            // 
            // lb_BumperSideL
            // 
            this.lb_BumperSideL.AutoSize = true;
            this.lb_BumperSideL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BumperSideL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_BumperSideL.Location = new System.Drawing.Point(600, 147);
            this.lb_BumperSideL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_BumperSideL.Name = "lb_BumperSideL";
            this.lb_BumperSideL.Size = new System.Drawing.Size(70, 25);
            this.lb_BumperSideL.TabIndex = 105;
            this.lb_BumperSideL.Text = "False";
            // 
            // lb_BumperFront
            // 
            this.lb_BumperFront.AutoSize = true;
            this.lb_BumperFront.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BumperFront.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_BumperFront.Location = new System.Drawing.Point(600, 121);
            this.lb_BumperFront.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_BumperFront.Name = "lb_BumperFront";
            this.lb_BumperFront.Size = new System.Drawing.Size(70, 25);
            this.lb_BumperFront.TabIndex = 104;
            this.lb_BumperFront.Text = "False";
            // 
            // lb_ScanSideStopL
            // 
            this.lb_ScanSideStopL.AutoSize = true;
            this.lb_ScanSideStopL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ScanSideStopL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_ScanSideStopL.Location = new System.Drawing.Point(600, 95);
            this.lb_ScanSideStopL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ScanSideStopL.Name = "lb_ScanSideStopL";
            this.lb_ScanSideStopL.Size = new System.Drawing.Size(70, 25);
            this.lb_ScanSideStopL.TabIndex = 103;
            this.lb_ScanSideStopL.Text = "False";
            // 
            // lb_ScanSideWarningL
            // 
            this.lb_ScanSideWarningL.AutoSize = true;
            this.lb_ScanSideWarningL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ScanSideWarningL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_ScanSideWarningL.Location = new System.Drawing.Point(600, 69);
            this.lb_ScanSideWarningL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ScanSideWarningL.Name = "lb_ScanSideWarningL";
            this.lb_ScanSideWarningL.Size = new System.Drawing.Size(70, 25);
            this.lb_ScanSideWarningL.TabIndex = 102;
            this.lb_ScanSideWarningL.Text = "False";
            // 
            // lb_ScanSideMalfunctionL
            // 
            this.lb_ScanSideMalfunctionL.AutoSize = true;
            this.lb_ScanSideMalfunctionL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ScanSideMalfunctionL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_ScanSideMalfunctionL.Location = new System.Drawing.Point(278, 251);
            this.lb_ScanSideMalfunctionL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ScanSideMalfunctionL.Name = "lb_ScanSideMalfunctionL";
            this.lb_ScanSideMalfunctionL.Size = new System.Drawing.Size(70, 25);
            this.lb_ScanSideMalfunctionL.TabIndex = 101;
            this.lb_ScanSideMalfunctionL.Text = "False";
            // 
            // lb_ScanSideStopR
            // 
            this.lb_ScanSideStopR.AutoSize = true;
            this.lb_ScanSideStopR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ScanSideStopR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_ScanSideStopR.Location = new System.Drawing.Point(278, 225);
            this.lb_ScanSideStopR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ScanSideStopR.Name = "lb_ScanSideStopR";
            this.lb_ScanSideStopR.Size = new System.Drawing.Size(70, 25);
            this.lb_ScanSideStopR.TabIndex = 100;
            this.lb_ScanSideStopR.Text = "False";
            // 
            // lb_ScanSideWarningR
            // 
            this.lb_ScanSideWarningR.AutoSize = true;
            this.lb_ScanSideWarningR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ScanSideWarningR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_ScanSideWarningR.Location = new System.Drawing.Point(278, 199);
            this.lb_ScanSideWarningR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ScanSideWarningR.Name = "lb_ScanSideWarningR";
            this.lb_ScanSideWarningR.Size = new System.Drawing.Size(70, 25);
            this.lb_ScanSideWarningR.TabIndex = 99;
            this.lb_ScanSideWarningR.Text = "False";
            // 
            // lb_ScanSideMalfunctionR
            // 
            this.lb_ScanSideMalfunctionR.AutoSize = true;
            this.lb_ScanSideMalfunctionR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ScanSideMalfunctionR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_ScanSideMalfunctionR.Location = new System.Drawing.Point(278, 173);
            this.lb_ScanSideMalfunctionR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ScanSideMalfunctionR.Name = "lb_ScanSideMalfunctionR";
            this.lb_ScanSideMalfunctionR.Size = new System.Drawing.Size(70, 25);
            this.lb_ScanSideMalfunctionR.TabIndex = 98;
            this.lb_ScanSideMalfunctionR.Text = "False";
            // 
            // lb_ScanFrontStop
            // 
            this.lb_ScanFrontStop.AutoSize = true;
            this.lb_ScanFrontStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ScanFrontStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_ScanFrontStop.Location = new System.Drawing.Point(278, 147);
            this.lb_ScanFrontStop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ScanFrontStop.Name = "lb_ScanFrontStop";
            this.lb_ScanFrontStop.Size = new System.Drawing.Size(70, 25);
            this.lb_ScanFrontStop.TabIndex = 97;
            this.lb_ScanFrontStop.Text = "False";
            // 
            // lb_ScanFrontWarning
            // 
            this.lb_ScanFrontWarning.AutoSize = true;
            this.lb_ScanFrontWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ScanFrontWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_ScanFrontWarning.Location = new System.Drawing.Point(278, 121);
            this.lb_ScanFrontWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ScanFrontWarning.Name = "lb_ScanFrontWarning";
            this.lb_ScanFrontWarning.Size = new System.Drawing.Size(70, 25);
            this.lb_ScanFrontWarning.TabIndex = 96;
            this.lb_ScanFrontWarning.Text = "False";
            // 
            // lb_ScanFrontMalfunction
            // 
            this.lb_ScanFrontMalfunction.AutoSize = true;
            this.lb_ScanFrontMalfunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ScanFrontMalfunction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_ScanFrontMalfunction.Location = new System.Drawing.Point(278, 95);
            this.lb_ScanFrontMalfunction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ScanFrontMalfunction.Name = "lb_ScanFrontMalfunction";
            this.lb_ScanFrontMalfunction.Size = new System.Drawing.Size(70, 25);
            this.lb_ScanFrontMalfunction.TabIndex = 95;
            this.lb_ScanFrontMalfunction.Text = "False";
            // 
            // lb_Emergency
            // 
            this.lb_Emergency.AutoSize = true;
            this.lb_Emergency.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Emergency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_Emergency.Location = new System.Drawing.Point(278, 69);
            this.lb_Emergency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Emergency.Name = "lb_Emergency";
            this.lb_Emergency.Size = new System.Drawing.Size(70, 25);
            this.lb_Emergency.TabIndex = 94;
            this.lb_Emergency.Text = "False";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label18.Location = new System.Drawing.Point(390, 95);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(195, 26);
            this.label18.TabIndex = 93;
            this.label18.Text = "Side SC L Stop";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label17.Location = new System.Drawing.Point(390, 251);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(195, 26);
            this.label17.TabIndex = 92;
            this.label17.Text = "----------";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label16.Location = new System.Drawing.Point(390, 225);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(195, 26);
            this.label16.TabIndex = 91;
            this.label16.Text = "Wing Bumper R";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label15.Location = new System.Drawing.Point(390, 199);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(195, 26);
            this.label15.TabIndex = 90;
            this.label15.Text = "Wing Bumper L";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label14.Location = new System.Drawing.Point(390, 173);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(195, 26);
            this.label14.TabIndex = 89;
            this.label14.Text = "Side Bumper R";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(390, 147);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(195, 26);
            this.label13.TabIndex = 88;
            this.label13.Text = "Side Bumper L";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(390, 121);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 26);
            this.label12.TabIndex = 87;
            this.label12.Text = "Front Bumper";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(390, 69);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 26);
            this.label11.TabIndex = 86;
            this.label11.Text = "Side SC L Warn";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(82, 251);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(176, 26);
            this.label10.TabIndex = 85;
            this.label10.Text = "Side SC L Malf";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(82, 225);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(176, 26);
            this.label9.TabIndex = 84;
            this.label9.Text = "Side SC R Stop";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(82, 199);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(192, 26);
            this.label8.TabIndex = 83;
            this.label8.Text = "Side SC R Warn";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(82, 173);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(176, 26);
            this.label7.TabIndex = 82;
            this.label7.Text = "Side SC R Malf";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(82, 147);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(176, 26);
            this.label6.TabIndex = 81;
            this.label6.Text = "Front SC Stop";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(82, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(176, 26);
            this.label5.TabIndex = 80;
            this.label5.Text = "Front SC Warn";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(83, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(176, 26);
            this.label4.TabIndex = 79;
            this.label4.Text = "Front SC Malf";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(82, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(176, 26);
            this.label3.TabIndex = 78;
            this.label3.Text = "Emergency SW";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tab_statusInt
            // 
            this.tab_statusInt.BackgroundImage = global::AMR_Command.Properties.Resources.image4;
            this.tab_statusInt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_statusInt.Controls.Add(this.groupBox5);
            this.tab_statusInt.Location = new System.Drawing.Point(4, 22);
            this.tab_statusInt.Name = "tab_statusInt";
            this.tab_statusInt.Size = new System.Drawing.Size(775, 411);
            this.tab_statusInt.TabIndex = 7;
            this.tab_statusInt.Text = "Status Int";
            this.tab_statusInt.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.label37);
            this.groupBox5.Controls.Add(this.lb_rollDetect);
            this.groupBox5.Controls.Add(this.lb_maxLimit);
            this.groupBox5.Controls.Add(this.lb_forkLevel2);
            this.groupBox5.Controls.Add(this.lb_forkLevel1);
            this.groupBox5.Controls.Add(this.lb_forkLevel0);
            this.groupBox5.Controls.Add(this.lb_resetSwitch);
            this.groupBox5.Controls.Add(this.label44);
            this.groupBox5.Controls.Add(this.label45);
            this.groupBox5.Controls.Add(this.label46);
            this.groupBox5.Controls.Add(this.label47);
            this.groupBox5.Controls.Add(this.lb_startSwitch);
            this.groupBox5.Controls.Add(this.lb_maxLimitSup);
            this.groupBox5.Controls.Add(this.label50);
            this.groupBox5.Controls.Add(this.label51);
            this.groupBox5.Controls.Add(this.label52);
            this.groupBox5.Controls.Add(this.label53);
            this.groupBox5.Controls.Add(this.label54);
            this.groupBox5.Controls.Add(this.lb_rollDetectSup);
            this.groupBox5.Controls.Add(this.lb_forkLevel2Sup);
            this.groupBox5.Controls.Add(this.lb_forkLevel1Sup);
            this.groupBox5.Controls.Add(this.lb_forkLevel0Sup);
            this.groupBox5.Controls.Add(this.lb_resetSwitchSup);
            this.groupBox5.Controls.Add(this.label60);
            this.groupBox5.Controls.Add(this.label61);
            this.groupBox5.Controls.Add(this.label62);
            this.groupBox5.Controls.Add(this.label63);
            this.groupBox5.Controls.Add(this.label64);
            this.groupBox5.Location = new System.Drawing.Point(4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(765, 398);
            this.groupBox5.TabIndex = 79;
            this.groupBox5.TabStop = false;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label23.Location = new System.Drawing.Point(5, 20);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(755, 37);
            this.label23.TabIndex = 110;
            this.label23.Text = "I/O Status Internal";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label26.Location = new System.Drawing.Point(600, 251);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(70, 25);
            this.label26.TabIndex = 109;
            this.label26.Text = "False";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label27.Location = new System.Drawing.Point(600, 225);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(70, 25);
            this.label27.TabIndex = 108;
            this.label27.Text = "False";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label29.Location = new System.Drawing.Point(600, 199);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(70, 25);
            this.label29.TabIndex = 107;
            this.label29.Text = "False";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label31.Location = new System.Drawing.Point(600, 173);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(70, 25);
            this.label31.TabIndex = 106;
            this.label31.Text = "False";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label37.Location = new System.Drawing.Point(600, 147);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(70, 25);
            this.label37.TabIndex = 105;
            this.label37.Text = "False";
            // 
            // lb_rollDetect
            // 
            this.lb_rollDetect.AutoSize = true;
            this.lb_rollDetect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rollDetect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_rollDetect.Location = new System.Drawing.Point(600, 121);
            this.lb_rollDetect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_rollDetect.Name = "lb_rollDetect";
            this.lb_rollDetect.Size = new System.Drawing.Size(70, 25);
            this.lb_rollDetect.TabIndex = 104;
            this.lb_rollDetect.Text = "False";
            // 
            // lb_maxLimit
            // 
            this.lb_maxLimit.AutoSize = true;
            this.lb_maxLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maxLimit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_maxLimit.Location = new System.Drawing.Point(600, 95);
            this.lb_maxLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_maxLimit.Name = "lb_maxLimit";
            this.lb_maxLimit.Size = new System.Drawing.Size(70, 25);
            this.lb_maxLimit.TabIndex = 103;
            this.lb_maxLimit.Text = "False";
            // 
            // lb_forkLevel2
            // 
            this.lb_forkLevel2.AutoSize = true;
            this.lb_forkLevel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_forkLevel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_forkLevel2.Location = new System.Drawing.Point(600, 69);
            this.lb_forkLevel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_forkLevel2.Name = "lb_forkLevel2";
            this.lb_forkLevel2.Size = new System.Drawing.Size(70, 25);
            this.lb_forkLevel2.TabIndex = 102;
            this.lb_forkLevel2.Text = "False";
            // 
            // lb_forkLevel1
            // 
            this.lb_forkLevel1.AutoSize = true;
            this.lb_forkLevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_forkLevel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_forkLevel1.Location = new System.Drawing.Point(278, 251);
            this.lb_forkLevel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_forkLevel1.Name = "lb_forkLevel1";
            this.lb_forkLevel1.Size = new System.Drawing.Size(70, 25);
            this.lb_forkLevel1.TabIndex = 101;
            this.lb_forkLevel1.Text = "False";
            // 
            // lb_forkLevel0
            // 
            this.lb_forkLevel0.AutoSize = true;
            this.lb_forkLevel0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_forkLevel0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_forkLevel0.Location = new System.Drawing.Point(278, 225);
            this.lb_forkLevel0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_forkLevel0.Name = "lb_forkLevel0";
            this.lb_forkLevel0.Size = new System.Drawing.Size(70, 25);
            this.lb_forkLevel0.TabIndex = 100;
            this.lb_forkLevel0.Text = "False";
            // 
            // lb_resetSwitch
            // 
            this.lb_resetSwitch.AutoSize = true;
            this.lb_resetSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_resetSwitch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_resetSwitch.Location = new System.Drawing.Point(278, 199);
            this.lb_resetSwitch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_resetSwitch.Name = "lb_resetSwitch";
            this.lb_resetSwitch.Size = new System.Drawing.Size(70, 25);
            this.lb_resetSwitch.TabIndex = 99;
            this.lb_resetSwitch.Text = "False";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label44.Location = new System.Drawing.Point(278, 173);
            this.label44.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(70, 25);
            this.label44.TabIndex = 98;
            this.label44.Text = "False";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label45.Location = new System.Drawing.Point(278, 147);
            this.label45.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(70, 25);
            this.label45.TabIndex = 97;
            this.label45.Text = "False";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label46.Location = new System.Drawing.Point(278, 121);
            this.label46.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(70, 25);
            this.label46.TabIndex = 96;
            this.label46.Text = "False";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label47.Location = new System.Drawing.Point(278, 95);
            this.label47.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(70, 25);
            this.label47.TabIndex = 95;
            this.label47.Text = "False";
            // 
            // lb_startSwitch
            // 
            this.lb_startSwitch.AutoSize = true;
            this.lb_startSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_startSwitch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_startSwitch.Location = new System.Drawing.Point(278, 69);
            this.lb_startSwitch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_startSwitch.Name = "lb_startSwitch";
            this.lb_startSwitch.Size = new System.Drawing.Size(70, 25);
            this.lb_startSwitch.TabIndex = 94;
            this.lb_startSwitch.Text = "False";
            // 
            // lb_maxLimitSup
            // 
            this.lb_maxLimitSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maxLimitSup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_maxLimitSup.Location = new System.Drawing.Point(421, 94);
            this.lb_maxLimitSup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_maxLimitSup.Name = "lb_maxLimitSup";
            this.lb_maxLimitSup.Size = new System.Drawing.Size(175, 26);
            this.lb_maxLimitSup.TabIndex = 93;
            this.lb_maxLimitSup.Text = "Max Limit";
            this.lb_maxLimitSup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label50
            // 
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label50.Location = new System.Drawing.Point(421, 250);
            this.label50.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(175, 26);
            this.label50.TabIndex = 92;
            this.label50.Text = "----------";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label51
            // 
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label51.Location = new System.Drawing.Point(421, 224);
            this.label51.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(175, 26);
            this.label51.TabIndex = 91;
            this.label51.Text = "----------";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label52
            // 
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label52.Location = new System.Drawing.Point(421, 198);
            this.label52.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(175, 26);
            this.label52.TabIndex = 90;
            this.label52.Text = "----------";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label53
            // 
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label53.Location = new System.Drawing.Point(421, 172);
            this.label53.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(175, 26);
            this.label53.TabIndex = 89;
            this.label53.Text = "----------";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label54
            // 
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label54.Location = new System.Drawing.Point(421, 146);
            this.label54.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(175, 26);
            this.label54.TabIndex = 88;
            this.label54.Text = "----------";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_rollDetectSup
            // 
            this.lb_rollDetectSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rollDetectSup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_rollDetectSup.Location = new System.Drawing.Point(421, 120);
            this.lb_rollDetectSup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_rollDetectSup.Name = "lb_rollDetectSup";
            this.lb_rollDetectSup.Size = new System.Drawing.Size(175, 26);
            this.lb_rollDetectSup.TabIndex = 87;
            this.lb_rollDetectSup.Text = "Roll Detect";
            this.lb_rollDetectSup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_forkLevel2Sup
            // 
            this.lb_forkLevel2Sup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_forkLevel2Sup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_forkLevel2Sup.Location = new System.Drawing.Point(421, 68);
            this.lb_forkLevel2Sup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_forkLevel2Sup.Name = "lb_forkLevel2Sup";
            this.lb_forkLevel2Sup.Size = new System.Drawing.Size(175, 26);
            this.lb_forkLevel2Sup.TabIndex = 86;
            this.lb_forkLevel2Sup.Text = "Fork Level 2";
            this.lb_forkLevel2Sup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_forkLevel1Sup
            // 
            this.lb_forkLevel1Sup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_forkLevel1Sup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_forkLevel1Sup.Location = new System.Drawing.Point(82, 251);
            this.lb_forkLevel1Sup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_forkLevel1Sup.Name = "lb_forkLevel1Sup";
            this.lb_forkLevel1Sup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_forkLevel1Sup.Size = new System.Drawing.Size(176, 26);
            this.lb_forkLevel1Sup.TabIndex = 85;
            this.lb_forkLevel1Sup.Text = "Fork Level 1";
            this.lb_forkLevel1Sup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_forkLevel0Sup
            // 
            this.lb_forkLevel0Sup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_forkLevel0Sup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_forkLevel0Sup.Location = new System.Drawing.Point(82, 225);
            this.lb_forkLevel0Sup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_forkLevel0Sup.Name = "lb_forkLevel0Sup";
            this.lb_forkLevel0Sup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_forkLevel0Sup.Size = new System.Drawing.Size(176, 26);
            this.lb_forkLevel0Sup.TabIndex = 84;
            this.lb_forkLevel0Sup.Text = "Fork Level 0";
            this.lb_forkLevel0Sup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_resetSwitchSup
            // 
            this.lb_resetSwitchSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_resetSwitchSup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_resetSwitchSup.Location = new System.Drawing.Point(82, 199);
            this.lb_resetSwitchSup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_resetSwitchSup.Name = "lb_resetSwitchSup";
            this.lb_resetSwitchSup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_resetSwitchSup.Size = new System.Drawing.Size(176, 26);
            this.lb_resetSwitchSup.TabIndex = 83;
            this.lb_resetSwitchSup.Text = "Reset Switch";
            this.lb_resetSwitchSup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label60
            // 
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label60.Location = new System.Drawing.Point(82, 173);
            this.label60.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label60.Name = "label60";
            this.label60.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label60.Size = new System.Drawing.Size(176, 26);
            this.label60.TabIndex = 82;
            this.label60.Text = "----------";
            this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label61
            // 
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label61.Location = new System.Drawing.Point(82, 147);
            this.label61.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label61.Name = "label61";
            this.label61.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label61.Size = new System.Drawing.Size(176, 26);
            this.label61.TabIndex = 81;
            this.label61.Text = "----------";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label62
            // 
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label62.Location = new System.Drawing.Point(82, 121);
            this.label62.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label62.Name = "label62";
            this.label62.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label62.Size = new System.Drawing.Size(176, 26);
            this.label62.TabIndex = 80;
            this.label62.Text = "----------";
            this.label62.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label63
            // 
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label63.Location = new System.Drawing.Point(83, 95);
            this.label63.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label63.Name = "label63";
            this.label63.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label63.Size = new System.Drawing.Size(176, 26);
            this.label63.TabIndex = 79;
            this.label63.Text = "----------";
            this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label64
            // 
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label64.Location = new System.Drawing.Point(82, 69);
            this.label64.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label64.Name = "label64";
            this.label64.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label64.Size = new System.Drawing.Size(176, 26);
            this.label64.TabIndex = 78;
            this.label64.Text = "Start Switch";
            this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tab_Serial
            // 
            this.tab_Serial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tab_Serial.BackgroundImage")));
            this.tab_Serial.Controls.Add(this.groupBox3);
            this.tab_Serial.Location = new System.Drawing.Point(4, 22);
            this.tab_Serial.Name = "tab_Serial";
            this.tab_Serial.Size = new System.Drawing.Size(775, 411);
            this.tab_Serial.TabIndex = 3;
            this.tab_Serial.Text = "Manual";
            this.tab_Serial.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.bt_forkLevel1);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Controls.Add(this.bt_forkLevel0);
            this.groupBox3.Controls.Add(this.bt_forkLevel2);
            this.groupBox3.Location = new System.Drawing.Point(4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(765, 398);
            this.groupBox3.TabIndex = 79;
            this.groupBox3.TabStop = false;
            // 
            // bt_forkLevel1
            // 
            this.bt_forkLevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_forkLevel1.Location = new System.Drawing.Point(244, 169);
            this.bt_forkLevel1.Name = "bt_forkLevel1";
            this.bt_forkLevel1.Size = new System.Drawing.Size(264, 65);
            this.bt_forkLevel1.TabIndex = 90;
            this.bt_forkLevel1.Text = "Level 1";
            this.bt_forkLevel1.UseVisualStyleBackColor = true;
            this.bt_forkLevel1.Click += new System.EventHandler(this.bt_forkLevel1_Click);
            // 
            // label34
            // 
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(5, 15);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(755, 37);
            this.label34.TabIndex = 87;
            this.label34.Text = "Lift Control";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_forkLevel0
            // 
            this.bt_forkLevel0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_forkLevel0.Location = new System.Drawing.Point(244, 259);
            this.bt_forkLevel0.Name = "bt_forkLevel0";
            this.bt_forkLevel0.Size = new System.Drawing.Size(264, 65);
            this.bt_forkLevel0.TabIndex = 85;
            this.bt_forkLevel0.Text = "Level 0";
            this.bt_forkLevel0.UseVisualStyleBackColor = true;
            this.bt_forkLevel0.Click += new System.EventHandler(this.bt_forkLevel0_Click);
            // 
            // bt_forkLevel2
            // 
            this.bt_forkLevel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_forkLevel2.Location = new System.Drawing.Point(244, 80);
            this.bt_forkLevel2.Name = "bt_forkLevel2";
            this.bt_forkLevel2.Size = new System.Drawing.Size(264, 65);
            this.bt_forkLevel2.TabIndex = 86;
            this.bt_forkLevel2.Text = "Level 2";
            this.bt_forkLevel2.UseVisualStyleBackColor = true;
            this.bt_forkLevel2.Click += new System.EventHandler(this.bt_forkLevel2_Click);
            // 
            // tab_Server
            // 
            this.tab_Server.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tab_Server.BackgroundImage")));
            this.tab_Server.Controls.Add(this.gb_sever);
            this.tab_Server.Location = new System.Drawing.Point(4, 22);
            this.tab_Server.Name = "tab_Server";
            this.tab_Server.Size = new System.Drawing.Size(775, 411);
            this.tab_Server.TabIndex = 2;
            this.tab_Server.Text = "Technical View";
            this.tab_Server.UseVisualStyleBackColor = true;
            // 
            // gb_sever
            // 
            this.gb_sever.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_sever.BackColor = System.Drawing.Color.Transparent;
            this.gb_sever.Controls.Add(this.lb_serverGet);
            this.gb_sever.Controls.Add(this.lb_serialRx);
            this.gb_sever.Controls.Add(this.lb_serialTx);
            this.gb_sever.Controls.Add(this.lb_serverSend);
            this.gb_sever.Controls.Add(this.lb_speed);
            this.gb_sever.Controls.Add(this.lb_angleStepping);
            this.gb_sever.Controls.Add(this.label19);
            this.gb_sever.Controls.Add(this.label20);
            this.gb_sever.Controls.Add(this.lb_normalSpeed);
            this.gb_sever.Controls.Add(this.label21);
            this.gb_sever.Controls.Add(this.lb_NormalSpeedCurrent);
            this.gb_sever.Controls.Add(this.lb_angleSteppingCurrent);
            this.gb_sever.Controls.Add(this.lb_comport);
            this.gb_sever.Controls.Add(this.lb_step);
            this.gb_sever.Controls.Add(this.rtb_serial);
            this.gb_sever.Controls.Add(this.rtb_server);
            this.gb_sever.Controls.Add(this.label2);
            this.gb_sever.Controls.Add(this.tb_port);
            this.gb_sever.Controls.Add(this.tb_ip);
            this.gb_sever.Controls.Add(this.label1);
            this.gb_sever.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gb_sever.Location = new System.Drawing.Point(4, 3);
            this.gb_sever.Name = "gb_sever";
            this.gb_sever.Size = new System.Drawing.Size(760, 401);
            this.gb_sever.TabIndex = 77;
            this.gb_sever.TabStop = false;
            // 
            // lb_serverGet
            // 
            this.lb_serverGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_serverGet.Location = new System.Drawing.Point(4, 111);
            this.lb_serverGet.Name = "lb_serverGet";
            this.lb_serverGet.Size = new System.Drawing.Size(748, 80);
            this.lb_serverGet.TabIndex = 98;
            this.lb_serverGet.Text = "Server Get:";
            // 
            // lb_serialRx
            // 
            this.lb_serialRx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_serialRx.Location = new System.Drawing.Point(7, 331);
            this.lb_serialRx.Name = "lb_serialRx";
            this.lb_serialRx.Size = new System.Drawing.Size(748, 67);
            this.lb_serialRx.TabIndex = 97;
            this.lb_serialRx.Text = "Serial Rx:";
            // 
            // lb_serialTx
            // 
            this.lb_serialTx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_serialTx.Location = new System.Drawing.Point(7, 265);
            this.lb_serialTx.Name = "lb_serialTx";
            this.lb_serialTx.Size = new System.Drawing.Size(748, 66);
            this.lb_serialTx.TabIndex = 96;
            this.lb_serialTx.Text = "Serial Tx:";
            // 
            // lb_serverSend
            // 
            this.lb_serverSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_serverSend.Location = new System.Drawing.Point(6, 39);
            this.lb_serverSend.Name = "lb_serverSend";
            this.lb_serverSend.Size = new System.Drawing.Size(748, 72);
            this.lb_serverSend.TabIndex = 93;
            this.lb_serverSend.Text = "Server Send:";
            // 
            // lb_speed
            // 
            this.lb_speed.AutoSize = true;
            this.lb_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_speed.Location = new System.Drawing.Point(406, 197);
            this.lb_speed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_speed.Name = "lb_speed";
            this.lb_speed.Size = new System.Drawing.Size(96, 20);
            this.lb_speed.TabIndex = 85;
            this.lb_speed.Text = "Speed     =";
            // 
            // lb_angleStepping
            // 
            this.lb_angleStepping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_angleStepping.ForeColor = System.Drawing.Color.Black;
            this.lb_angleStepping.Location = new System.Drawing.Point(506, 226);
            this.lb_angleStepping.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_angleStepping.Name = "lb_angleStepping";
            this.lb_angleStepping.Size = new System.Drawing.Size(74, 24);
            this.lb_angleStepping.TabIndex = 92;
            this.lb_angleStepping.Text = "0000";
            this.lb_angleStepping.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(406, 226);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 20);
            this.label19.TabIndex = 86;
            this.label19.Text = "Stepping =";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label20.Location = new System.Drawing.Point(584, 197);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(96, 20);
            this.label20.TabIndex = 87;
            this.label20.Text = "Speed     =";
            // 
            // lb_normalSpeed
            // 
            this.lb_normalSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_normalSpeed.ForeColor = System.Drawing.Color.Black;
            this.lb_normalSpeed.Location = new System.Drawing.Point(506, 197);
            this.lb_normalSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_normalSpeed.Name = "lb_normalSpeed";
            this.lb_normalSpeed.Size = new System.Drawing.Size(74, 24);
            this.lb_normalSpeed.TabIndex = 91;
            this.lb_normalSpeed.Text = "0000";
            this.lb_normalSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label21.Location = new System.Drawing.Point(584, 226);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 20);
            this.label21.TabIndex = 88;
            this.label21.Text = "Stepping =";
            // 
            // lb_NormalSpeedCurrent
            // 
            this.lb_NormalSpeedCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NormalSpeedCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lb_NormalSpeedCurrent.Location = new System.Drawing.Point(684, 197);
            this.lb_NormalSpeedCurrent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_NormalSpeedCurrent.Name = "lb_NormalSpeedCurrent";
            this.lb_NormalSpeedCurrent.Size = new System.Drawing.Size(71, 24);
            this.lb_NormalSpeedCurrent.TabIndex = 89;
            this.lb_NormalSpeedCurrent.Text = "0000";
            this.lb_NormalSpeedCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_angleSteppingCurrent
            // 
            this.lb_angleSteppingCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_angleSteppingCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lb_angleSteppingCurrent.Location = new System.Drawing.Point(684, 226);
            this.lb_angleSteppingCurrent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_angleSteppingCurrent.Name = "lb_angleSteppingCurrent";
            this.lb_angleSteppingCurrent.Size = new System.Drawing.Size(71, 24);
            this.lb_angleSteppingCurrent.TabIndex = 90;
            this.lb_angleSteppingCurrent.Text = "0000";
            this.lb_angleSteppingCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_comport
            // 
            this.lb_comport.AutoSize = true;
            this.lb_comport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_comport.Location = new System.Drawing.Point(246, 226);
            this.lb_comport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_comport.Name = "lb_comport";
            this.lb_comport.Size = new System.Drawing.Size(70, 20);
            this.lb_comport.TabIndex = 79;
            this.lb_comport.Text = "Serial =";
            // 
            // lb_step
            // 
            this.lb_step.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_step.Location = new System.Drawing.Point(4, 226);
            this.lb_step.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_step.Name = "lb_step";
            this.lb_step.Size = new System.Drawing.Size(199, 24);
            this.lb_step.TabIndex = 78;
            this.lb_step.Text = "Step =";
            // 
            // rtb_serial
            // 
            this.rtb_serial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_serial.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rtb_serial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rtb_serial.Location = new System.Drawing.Point(4, 252);
            this.rtb_serial.MaxLength = 1000;
            this.rtb_serial.Name = "rtb_serial";
            this.rtb_serial.ReadOnly = true;
            this.rtb_serial.Size = new System.Drawing.Size(751, 10);
            this.rtb_serial.TabIndex = 77;
            this.rtb_serial.Text = "";
            this.rtb_serial.Visible = false;
            // 
            // rtb_server
            // 
            this.rtb_server.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_server.BackColor = System.Drawing.Color.White;
            this.rtb_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rtb_server.Location = new System.Drawing.Point(4, 26);
            this.rtb_server.MaxLength = 1000;
            this.rtb_server.Name = "rtb_server";
            this.rtb_server.ReadOnly = true;
            this.rtb_server.Size = new System.Drawing.Size(751, 10);
            this.rtb_server.TabIndex = 76;
            this.rtb_server.Text = "";
            this.rtb_server.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(246, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "Port :";
            // 
            // tb_port
            // 
            this.tb_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_port.Location = new System.Drawing.Point(298, 194);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(103, 26);
            this.tb_port.TabIndex = 69;
            this.tb_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_ip
            // 
            this.tb_ip.BackColor = System.Drawing.SystemColors.Window;
            this.tb_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_ip.Location = new System.Drawing.Point(43, 194);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(161, 26);
            this.tb_ip.TabIndex = 67;
            this.tb_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(6, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "IP :";
            // 
            // tab_Melody
            // 
            this.tab_Melody.BackgroundImage = global::AMR_Command.Properties.Resources.melody2;
            this.tab_Melody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_Melody.Controls.Add(this.cb_melody);
            this.tab_Melody.Controls.Add(this.bt_melody_send);
            this.tab_Melody.Controls.Add(this.bt_plus);
            this.tab_Melody.Controls.Add(this.lb_melody);
            this.tab_Melody.Controls.Add(this.bt_minus);
            this.tab_Melody.Location = new System.Drawing.Point(4, 22);
            this.tab_Melody.Name = "tab_Melody";
            this.tab_Melody.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Melody.Size = new System.Drawing.Size(775, 411);
            this.tab_Melody.TabIndex = 1;
            this.tab_Melody.Text = "Melody";
            this.tab_Melody.UseVisualStyleBackColor = true;
            // 
            // cb_melody
            // 
            this.cb_melody.AutoSize = true;
            this.cb_melody.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cb_melody.Location = new System.Drawing.Point(636, 6);
            this.cb_melody.Name = "cb_melody";
            this.cb_melody.Size = new System.Drawing.Size(130, 28);
            this.cb_melody.TabIndex = 5;
            this.cb_melody.Text = "flag bit 6, 7";
            this.cb_melody.UseVisualStyleBackColor = true;
            // 
            // bt_melody_send
            // 
            this.bt_melody_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bt_melody_send.Location = new System.Drawing.Point(505, 298);
            this.bt_melody_send.Name = "bt_melody_send";
            this.bt_melody_send.Size = new System.Drawing.Size(238, 87);
            this.bt_melody_send.TabIndex = 4;
            this.bt_melody_send.Text = "Save";
            this.bt_melody_send.UseVisualStyleBackColor = true;
            this.bt_melody_send.Click += new System.EventHandler(this.bt_melody_send_Click);
            // 
            // bt_plus
            // 
            this.bt_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bt_plus.Location = new System.Drawing.Point(383, 319);
            this.bt_plus.Name = "bt_plus";
            this.bt_plus.Size = new System.Drawing.Size(47, 51);
            this.bt_plus.TabIndex = 3;
            this.bt_plus.Text = "+";
            this.bt_plus.UseVisualStyleBackColor = true;
            this.bt_plus.Click += new System.EventHandler(this.bt_plus_Click);
            // 
            // lb_melody
            // 
            this.lb_melody.AutoSize = true;
            this.lb_melody.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lb_melody.Location = new System.Drawing.Point(273, 325);
            this.lb_melody.Name = "lb_melody";
            this.lb_melody.Size = new System.Drawing.Size(57, 39);
            this.lb_melody.TabIndex = 2;
            this.lb_melody.Text = "11";
            // 
            // bt_minus
            // 
            this.bt_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bt_minus.Location = new System.Drawing.Point(162, 319);
            this.bt_minus.Name = "bt_minus";
            this.bt_minus.Size = new System.Drawing.Size(47, 51);
            this.bt_minus.TabIndex = 0;
            this.bt_minus.Text = "-";
            this.bt_minus.UseVisualStyleBackColor = true;
            this.bt_minus.Click += new System.EventHandler(this.bt_minus_Click);
            // 
            // tab_Control
            // 
            this.tab_Control.BackColor = System.Drawing.Color.Transparent;
            this.tab_Control.BackgroundImage = global::AMR_Command.Properties.Resources.image1;
            this.tab_Control.Controls.Add(this.groupBox2);
            this.tab_Control.Location = new System.Drawing.Point(4, 22);
            this.tab_Control.Name = "tab_Control";
            this.tab_Control.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Control.Size = new System.Drawing.Size(775, 411);
            this.tab_Control.TabIndex = 0;
            this.tab_Control.Text = "Control";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.bt_preparation);
            this.groupBox2.Controls.Add(this.lb_errorSup);
            this.groupBox2.Controls.Add(this.lb_angleStep);
            this.groupBox2.Controls.Add(this.bt_unFocusPos);
            this.groupBox2.Controls.Add(this.bt_focusPos);
            this.groupBox2.Controls.Add(this.tb_anglePos);
            this.groupBox2.Controls.Add(this.tb_yPos);
            this.groupBox2.Controls.Add(this.tb_xPos);
            this.groupBox2.Controls.Add(this.lb_ySup);
            this.groupBox2.Controls.Add(this.lb_xSup);
            this.groupBox2.Controls.Add(this.lb_status);
            this.groupBox2.Controls.Add(this.label32);
            this.groupBox2.Controls.Add(this.bt_manual);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.lb_angle);
            this.groupBox2.Controls.Add(this.bt_start);
            this.groupBox2.Controls.Add(this.bt_stop);
            this.groupBox2.Controls.Add(this.lb_y);
            this.groupBox2.Controls.Add(this.lb_x);
            this.groupBox2.Location = new System.Drawing.Point(4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 398);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            // 
            // bt_preparation
            // 
            this.bt_preparation.BackColor = System.Drawing.Color.LightGray;
            this.bt_preparation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_preparation.Location = new System.Drawing.Point(566, 16);
            this.bt_preparation.Name = "bt_preparation";
            this.bt_preparation.Size = new System.Drawing.Size(189, 65);
            this.bt_preparation.TabIndex = 102;
            this.bt_preparation.Text = "Preparation";
            this.bt_preparation.UseVisualStyleBackColor = false;
            this.bt_preparation.Click += new System.EventHandler(this.bt_preparation_Click);
            // 
            // lb_errorSup
            // 
            this.lb_errorSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_errorSup.ForeColor = System.Drawing.Color.Black;
            this.lb_errorSup.Location = new System.Drawing.Point(362, 111);
            this.lb_errorSup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_errorSup.Name = "lb_errorSup";
            this.lb_errorSup.Size = new System.Drawing.Size(207, 21);
            this.lb_errorSup.TabIndex = 101;
            this.lb_errorSup.Text = "ErrorSup =";
            // 
            // lb_angleStep
            // 
            this.lb_angleStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_angleStep.ForeColor = System.Drawing.Color.Black;
            this.lb_angleStep.Location = new System.Drawing.Point(362, 87);
            this.lb_angleStep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_angleStep.Name = "lb_angleStep";
            this.lb_angleStep.Size = new System.Drawing.Size(207, 21);
            this.lb_angleStep.TabIndex = 100;
            this.lb_angleStep.Text = "AngleStep =";
            // 
            // bt_unFocusPos
            // 
            this.bt_unFocusPos.Location = new System.Drawing.Point(574, 111);
            this.bt_unFocusPos.Name = "bt_unFocusPos";
            this.bt_unFocusPos.Size = new System.Drawing.Size(75, 23);
            this.bt_unFocusPos.TabIndex = 99;
            this.bt_unFocusPos.Text = "UnFocus";
            this.bt_unFocusPos.UseVisualStyleBackColor = true;
            this.bt_unFocusPos.Click += new System.EventHandler(this.bt_unFocusPos_Click);
            // 
            // bt_focusPos
            // 
            this.bt_focusPos.Location = new System.Drawing.Point(574, 85);
            this.bt_focusPos.Name = "bt_focusPos";
            this.bt_focusPos.Size = new System.Drawing.Size(75, 23);
            this.bt_focusPos.TabIndex = 98;
            this.bt_focusPos.Text = "Focus";
            this.bt_focusPos.UseVisualStyleBackColor = false;
            this.bt_focusPos.Click += new System.EventHandler(this.bt_focusPos_Click);
            // 
            // tb_anglePos
            // 
            this.tb_anglePos.Location = new System.Drawing.Point(655, 139);
            this.tb_anglePos.Name = "tb_anglePos";
            this.tb_anglePos.Size = new System.Drawing.Size(100, 20);
            this.tb_anglePos.TabIndex = 97;
            this.tb_anglePos.Text = "0";
            // 
            // tb_yPos
            // 
            this.tb_yPos.Location = new System.Drawing.Point(655, 113);
            this.tb_yPos.Name = "tb_yPos";
            this.tb_yPos.Size = new System.Drawing.Size(100, 20);
            this.tb_yPos.TabIndex = 96;
            this.tb_yPos.Text = "0";
            // 
            // tb_xPos
            // 
            this.tb_xPos.Location = new System.Drawing.Point(655, 87);
            this.tb_xPos.Name = "tb_xPos";
            this.tb_xPos.Size = new System.Drawing.Size(100, 20);
            this.tb_xPos.TabIndex = 95;
            this.tb_xPos.Text = "0";
            // 
            // lb_ySup
            // 
            this.lb_ySup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ySup.ForeColor = System.Drawing.Color.Black;
            this.lb_ySup.Location = new System.Drawing.Point(259, 131);
            this.lb_ySup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ySup.Name = "lb_ySup";
            this.lb_ySup.Size = new System.Drawing.Size(249, 31);
            this.lb_ySup.TabIndex = 94;
            this.lb_ySup.Text = "Y_ =";
            // 
            // lb_xSup
            // 
            this.lb_xSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_xSup.ForeColor = System.Drawing.Color.Black;
            this.lb_xSup.Location = new System.Drawing.Point(14, 131);
            this.lb_xSup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_xSup.Name = "lb_xSup";
            this.lb_xSup.Size = new System.Drawing.Size(241, 31);
            this.lb_xSup.TabIndex = 93;
            this.lb_xSup.Text = "X_ =";
            // 
            // lb_status
            // 
            this.lb_status.BackColor = System.Drawing.Color.Transparent;
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.ForeColor = System.Drawing.Color.Black;
            this.lb_status.Location = new System.Drawing.Point(132, 86);
            this.lb_status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(190, 32);
            this.lb_status.TabIndex = 92;
            this.lb_status.Text = "AAAAAAAAA";
            this.lb_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.Black;
            this.label32.Location = new System.Drawing.Point(8, 86);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(114, 37);
            this.label32.TabIndex = 91;
            this.label32.Text = "Status";
            // 
            // bt_manual
            // 
            this.bt_manual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_manual.Location = new System.Drawing.Point(384, 16);
            this.bt_manual.Name = "bt_manual";
            this.bt_manual.Size = new System.Drawing.Size(176, 65);
            this.bt_manual.TabIndex = 1;
            this.bt_manual.Text = "Manual";
            this.bt_manual.UseVisualStyleBackColor = true;
            this.bt_manual.Click += new System.EventHandler(this.bt_manual_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.lb_plant);
            this.panel6.Controls.Add(this.label25);
            this.panel6.Location = new System.Drawing.Point(510, 202);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(252, 98);
            this.panel6.TabIndex = 88;
            // 
            // lb_plant
            // 
            this.lb_plant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_plant.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_plant.ForeColor = System.Drawing.Color.White;
            this.lb_plant.Location = new System.Drawing.Point(18, 53);
            this.lb_plant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_plant.Name = "lb_plant";
            this.lb_plant.Size = new System.Drawing.Size(215, 31);
            this.lb_plant.TabIndex = 4;
            this.lb_plant.Text = "xx";
            this.lb_plant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(46, 12);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(164, 36);
            this.label25.TabIndex = 2;
            this.label25.Text = "Plant";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lb_location);
            this.panel5.Controls.Add(this.label24);
            this.panel5.Location = new System.Drawing.Point(256, 202);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(252, 98);
            this.panel5.TabIndex = 88;
            // 
            // lb_location
            // 
            this.lb_location.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_location.ForeColor = System.Drawing.Color.White;
            this.lb_location.Location = new System.Drawing.Point(14, 53);
            this.lb_location.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_location.Name = "lb_location";
            this.lb_location.Size = new System.Drawing.Size(225, 31);
            this.lb_location.TabIndex = 2;
            this.lb_location.Text = "xx";
            this.lb_location.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(64, 12);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(129, 36);
            this.label24.TabIndex = 1;
            this.label24.Text = "Location";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lb_AGV);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Location = new System.Drawing.Point(3, 202);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(252, 98);
            this.panel4.TabIndex = 90;
            // 
            // lb_AGV
            // 
            this.lb_AGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_AGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AGV.ForeColor = System.Drawing.Color.White;
            this.lb_AGV.Location = new System.Drawing.Point(21, 53);
            this.lb_AGV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_AGV.Name = "lb_AGV";
            this.lb_AGV.Size = new System.Drawing.Size(212, 31);
            this.lb_AGV.TabIndex = 1;
            this.lb_AGV.Text = "xx";
            this.lb_AGV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(66, 12);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(135, 36);
            this.label22.TabIndex = 0;
            this.label22.Text = "AGV No.";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lb_jobOrder);
            this.panel3.Controls.Add(this.label33);
            this.panel3.Location = new System.Drawing.Point(510, 301);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(252, 98);
            this.panel3.TabIndex = 89;
            // 
            // lb_jobOrder
            // 
            this.lb_jobOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_jobOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_jobOrder.ForeColor = System.Drawing.Color.White;
            this.lb_jobOrder.Location = new System.Drawing.Point(18, 53);
            this.lb_jobOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_jobOrder.Name = "lb_jobOrder";
            this.lb_jobOrder.Size = new System.Drawing.Size(209, 31);
            this.lb_jobOrder.TabIndex = 3;
            this.lb_jobOrder.Text = "xx";
            this.lb_jobOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(55, 12);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(147, 36);
            this.label33.TabIndex = 4;
            this.label33.Text = "Job Order";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lb_speedSum);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Location = new System.Drawing.Point(3, 301);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 98);
            this.panel1.TabIndex = 87;
            // 
            // lb_speedSum
            // 
            this.lb_speedSum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_speedSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_speedSum.ForeColor = System.Drawing.Color.White;
            this.lb_speedSum.Location = new System.Drawing.Point(15, 53);
            this.lb_speedSum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_speedSum.Name = "lb_speedSum";
            this.lb_speedSum.Size = new System.Drawing.Size(225, 31);
            this.lb_speedSum.TabIndex = 2;
            this.lb_speedSum.Text = "xx";
            this.lb_speedSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(77, 12);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(101, 36);
            this.label28.TabIndex = 2;
            this.label28.Text = "Speed";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lb_battery);
            this.panel2.Controls.Add(this.label30);
            this.panel2.Location = new System.Drawing.Point(256, 301);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 98);
            this.panel2.TabIndex = 88;
            // 
            // lb_battery
            // 
            this.lb_battery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_battery.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_battery.ForeColor = System.Drawing.Color.White;
            this.lb_battery.Location = new System.Drawing.Point(40, 53);
            this.lb_battery.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_battery.Name = "lb_battery";
            this.lb_battery.Size = new System.Drawing.Size(181, 31);
            this.lb_battery.TabIndex = 3;
            this.lb_battery.Text = "xx";
            this.lb_battery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(34, 12);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(187, 36);
            this.label30.TabIndex = 3;
            this.label30.Text = "Battery Level";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_angle
            // 
            this.lb_angle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_angle.ForeColor = System.Drawing.Color.Black;
            this.lb_angle.Location = new System.Drawing.Point(504, 162);
            this.lb_angle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_angle.Name = "lb_angle";
            this.lb_angle.Size = new System.Drawing.Size(256, 31);
            this.lb_angle.TabIndex = 73;
            this.lb_angle.Text = "angle =";
            // 
            // bt_start
            // 
            this.bt_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_start.Location = new System.Drawing.Point(20, 16);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(176, 65);
            this.bt_start.TabIndex = 0;
            this.bt_start.Text = "AUTO";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_stop.Location = new System.Drawing.Point(202, 16);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(176, 65);
            this.bt_stop.TabIndex = 74;
            this.bt_stop.Text = "STOP";
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // lb_y
            // 
            this.lb_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_y.ForeColor = System.Drawing.Color.Black;
            this.lb_y.Location = new System.Drawing.Point(259, 162);
            this.lb_y.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_y.Name = "lb_y";
            this.lb_y.Size = new System.Drawing.Size(249, 31);
            this.lb_y.TabIndex = 72;
            this.lb_y.Text = "Y =";
            // 
            // lb_x
            // 
            this.lb_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_x.ForeColor = System.Drawing.Color.Black;
            this.lb_x.Location = new System.Drawing.Point(14, 162);
            this.lb_x.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_x.Name = "lb_x";
            this.lb_x.Size = new System.Drawing.Size(241, 31);
            this.lb_x.TabIndex = 71;
            this.lb_x.Text = "X =";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Control);
            this.tabControl1.Controls.Add(this.tab_Melody);
            this.tabControl1.Controls.Add(this.tab_Server);
            this.tabControl1.Controls.Add(this.tab_Serial);
            this.tabControl1.Controls.Add(this.tab_statusInt);
            this.tabControl1.Controls.Add(this.tab_StatusExt);
            this.tabControl1.Controls.Add(this.tab_manual);
            this.tabControl1.Controls.Add(this.tab_camera);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(783, 437);
            this.tabControl1.TabIndex = 76;
            // 
            // tab_camera
            // 
            this.tab_camera.BackgroundImage = global::AMR_Command.Properties.Resources.image1;
            this.tab_camera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tab_camera.Controls.Add(this.groupBox6);
            this.tab_camera.Location = new System.Drawing.Point(4, 22);
            this.tab_camera.Name = "tab_camera";
            this.tab_camera.Size = new System.Drawing.Size(775, 411);
            this.tab_camera.TabIndex = 8;
            this.tab_camera.Text = "Camera";
            this.tab_camera.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lb_statusRail);
            this.groupBox6.Controls.Add(this.lb_messageRail);
            this.groupBox6.Controls.Add(this.bt_railTrue);
            this.groupBox6.Controls.Add(this.bt_railFalse);
            this.groupBox6.Controls.Add(this.bt_cameraDetectF);
            this.groupBox6.Controls.Add(this.lb_depth);
            this.groupBox6.Controls.Add(this.label38);
            this.groupBox6.Controls.Add(this.ptb_camera);
            this.groupBox6.Location = new System.Drawing.Point(6, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(760, 401);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            // 
            // lb_statusRail
            // 
            this.lb_statusRail.AutoSize = true;
            this.lb_statusRail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_statusRail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_statusRail.Location = new System.Drawing.Point(449, 300);
            this.lb_statusRail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_statusRail.Name = "lb_statusRail";
            this.lb_statusRail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_statusRail.Size = new System.Drawing.Size(33, 25);
            this.lb_statusRail.TabIndex = 85;
            this.lb_statusRail.Text = "...";
            this.lb_statusRail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_messageRail
            // 
            this.lb_messageRail.AutoSize = true;
            this.lb_messageRail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_messageRail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_messageRail.Location = new System.Drawing.Point(449, 256);
            this.lb_messageRail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_messageRail.Name = "lb_messageRail";
            this.lb_messageRail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_messageRail.Size = new System.Drawing.Size(33, 25);
            this.lb_messageRail.TabIndex = 84;
            this.lb_messageRail.Text = "...";
            this.lb_messageRail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bt_railTrue
            // 
            this.bt_railTrue.BackColor = System.Drawing.Color.LightGray;
            this.bt_railTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_railTrue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_railTrue.Location = new System.Drawing.Point(454, 196);
            this.bt_railTrue.Margin = new System.Windows.Forms.Padding(2);
            this.bt_railTrue.Name = "bt_railTrue";
            this.bt_railTrue.Size = new System.Drawing.Size(240, 49);
            this.bt_railTrue.TabIndex = 83;
            this.bt_railTrue.Text = "Rail True";
            this.bt_railTrue.UseVisualStyleBackColor = false;
            this.bt_railTrue.Click += new System.EventHandler(this.bt_railTrue_Click);
            // 
            // bt_railFalse
            // 
            this.bt_railFalse.BackColor = System.Drawing.Color.LightGray;
            this.bt_railFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_railFalse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_railFalse.Location = new System.Drawing.Point(454, 143);
            this.bt_railFalse.Margin = new System.Windows.Forms.Padding(2);
            this.bt_railFalse.Name = "bt_railFalse";
            this.bt_railFalse.Size = new System.Drawing.Size(240, 49);
            this.bt_railFalse.TabIndex = 82;
            this.bt_railFalse.Text = "Rail False";
            this.bt_railFalse.UseVisualStyleBackColor = false;
            this.bt_railFalse.Click += new System.EventHandler(this.bt_railFalse_Click);
            // 
            // bt_cameraDetectF
            // 
            this.bt_cameraDetectF.BackColor = System.Drawing.Color.LightGray;
            this.bt_cameraDetectF.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cameraDetectF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_cameraDetectF.Location = new System.Drawing.Point(454, 90);
            this.bt_cameraDetectF.Margin = new System.Windows.Forms.Padding(2);
            this.bt_cameraDetectF.Name = "bt_cameraDetectF";
            this.bt_cameraDetectF.Size = new System.Drawing.Size(240, 49);
            this.bt_cameraDetectF.TabIndex = 81;
            this.bt_cameraDetectF.Text = "CameraDetectF";
            this.bt_cameraDetectF.UseVisualStyleBackColor = false;
            this.bt_cameraDetectF.Click += new System.EventHandler(this.bt_cameraDetectF_Click);
            // 
            // lb_depth
            // 
            this.lb_depth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_depth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_depth.Location = new System.Drawing.Point(551, 19);
            this.lb_depth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_depth.Name = "lb_depth";
            this.lb_depth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_depth.Size = new System.Drawing.Size(204, 26);
            this.lb_depth.TabIndex = 80;
            this.lb_depth.Text = "0000";
            this.lb_depth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label38
            // 
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label38.Location = new System.Drawing.Point(449, 19);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label38.Size = new System.Drawing.Size(98, 26);
            this.label38.TabIndex = 79;
            this.label38.Text = "Depth =";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ptb_camera
            // 
            this.ptb_camera.Location = new System.Drawing.Point(6, 19);
            this.ptb_camera.Name = "ptb_camera";
            this.ptb_camera.Size = new System.Drawing.Size(426, 376);
            this.ptb_camera.TabIndex = 0;
            this.ptb_camera.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AMR_Command V2022.20";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab_manual.ResumeLayout(false);
            this.tab_manual.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tab_StatusExt.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tab_statusInt.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tab_Serial.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tab_Server.ResumeLayout(false);
            this.gb_sever.ResumeLayout(false);
            this.gb_sever.PerformLayout();
            this.tab_Melody.ResumeLayout(false);
            this.tab_Melody.PerformLayout();
            this.tab_Control.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_camera.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_camera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker bgwk_sensor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer tm_send_data;
        private System.ComponentModel.BackgroundWorker bgwk_serial;
        private System.ComponentModel.BackgroundWorker bgwk_main;
        public System.Windows.Forms.Timer tm_delay_csv;
        private System.Windows.Forms.Timer tm_close;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabPage tab_manual;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_unlockCF2;
        private System.Windows.Forms.Button bt_unlockCF1;
        private System.Windows.Forms.Button bt_unlockEnd;
        private System.Windows.Forms.Button bt_unlockResume;
        private System.Windows.Forms.Button bt_unlockPickedup;
        private System.Windows.Forms.Button bt_unlockPause;
        private System.Windows.Forms.Button bt_unlockStart;
        private System.Windows.Forms.Button bt_unlockDrop;
        private System.Windows.Forms.TabPage tab_StatusExt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label lb_StatusNc;
        private System.Windows.Forms.Label lb_BumperWingR;
        private System.Windows.Forms.Label lb_BumperWingL;
        private System.Windows.Forms.Label lb_BumperSideR;
        private System.Windows.Forms.Label lb_BumperSideL;
        private System.Windows.Forms.Label lb_BumperFront;
        private System.Windows.Forms.Label lb_ScanSideStopL;
        private System.Windows.Forms.Label lb_ScanSideWarningL;
        private System.Windows.Forms.Label lb_ScanSideMalfunctionL;
        private System.Windows.Forms.Label lb_ScanSideStopR;
        private System.Windows.Forms.Label lb_ScanSideWarningR;
        private System.Windows.Forms.Label lb_ScanSideMalfunctionR;
        private System.Windows.Forms.Label lb_ScanFrontStop;
        private System.Windows.Forms.Label lb_ScanFrontWarning;
        private System.Windows.Forms.Label lb_ScanFrontMalfunction;
        private System.Windows.Forms.Label lb_Emergency;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tab_statusInt;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label lb_rollDetect;
        private System.Windows.Forms.Label lb_maxLimit;
        private System.Windows.Forms.Label lb_forkLevel2;
        private System.Windows.Forms.Label lb_forkLevel1;
        private System.Windows.Forms.Label lb_forkLevel0;
        private System.Windows.Forms.Label lb_resetSwitch;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label lb_startSwitch;
        private System.Windows.Forms.Label lb_maxLimitSup;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label lb_rollDetectSup;
        private System.Windows.Forms.Label lb_forkLevel2Sup;
        private System.Windows.Forms.Label lb_forkLevel1Sup;
        private System.Windows.Forms.Label lb_forkLevel0Sup;
        private System.Windows.Forms.Label lb_resetSwitchSup;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TabPage tab_Serial;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_forkLevel1;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button bt_forkLevel0;
        private System.Windows.Forms.Button bt_forkLevel2;
        private System.Windows.Forms.TabPage tab_Server;
        private System.Windows.Forms.GroupBox gb_sever;
        private System.Windows.Forms.Label lb_serverGet;
        private System.Windows.Forms.Label lb_serialRx;
        private System.Windows.Forms.Label lb_serialTx;
        private System.Windows.Forms.Label lb_serverSend;
        private System.Windows.Forms.Label lb_speed;
        private System.Windows.Forms.Label lb_angleStepping;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lb_normalSpeed;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lb_NormalSpeedCurrent;
        private System.Windows.Forms.Label lb_angleSteppingCurrent;
        private System.Windows.Forms.Label lb_comport;
        private System.Windows.Forms.Label lb_step;
        public System.Windows.Forms.RichTextBox rtb_serial;
        public System.Windows.Forms.RichTextBox rtb_server;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tab_Melody;
        private System.Windows.Forms.CheckBox cb_melody;
        private System.Windows.Forms.Button bt_melody_send;
        private System.Windows.Forms.Button bt_plus;
        private System.Windows.Forms.Label lb_melody;
        private System.Windows.Forms.Button bt_minus;
        private System.Windows.Forms.TabPage tab_Control;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_errorSup;
        private System.Windows.Forms.Label lb_angleStep;
        private System.Windows.Forms.Button bt_unFocusPos;
        private System.Windows.Forms.Button bt_focusPos;
        private System.Windows.Forms.TextBox tb_anglePos;
        private System.Windows.Forms.TextBox tb_yPos;
        private System.Windows.Forms.TextBox tb_xPos;
        private System.Windows.Forms.Label lb_ySup;
        private System.Windows.Forms.Label lb_xSup;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button bt_manual;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lb_jobOrder;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lb_location;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb_AGV;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_plant;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_speedSum;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_battery;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lb_angle;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.Label lb_y;
        private System.Windows.Forms.Label lb_x;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_camera;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox ptb_camera;
        private System.Windows.Forms.Label lb_depth;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Button bt_preparation;
        private System.Windows.Forms.Button bt_cameraDetectF;
        private System.Windows.Forms.Button bt_railTrue;
        private System.Windows.Forms.Button bt_railFalse;
        private System.Windows.Forms.Label lb_messageRail;
        private System.Windows.Forms.Label lb_statusRail;
    }
}

