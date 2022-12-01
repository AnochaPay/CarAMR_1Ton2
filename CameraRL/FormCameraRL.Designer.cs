namespace CameraRL {
    partial class FormCameraRL {
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
            this.bt_connect = new System.Windows.Forms.Button();
            this.lb_connect = new System.Windows.Forms.Label();
            this.lb_read = new System.Windows.Forms.Label();
            this.bt_read = new System.Windows.Forms.Button();
            this.lb_checkDepthRoll = new System.Windows.Forms.Label();
            this.bt_checkRoll = new System.Windows.Forms.Button();
            this.lb_checkRailDifferent = new System.Windows.Forms.Label();
            this.bt_checkRailDif = new System.Windows.Forms.Button();
            this.tb_parameter4 = new System.Windows.Forms.TextBox();
            this.tb_parameter8 = new System.Windows.Forms.TextBox();
            this.tb_parameter7 = new System.Windows.Forms.TextBox();
            this.tb_parameter3 = new System.Windows.Forms.TextBox();
            this.tb_parameter6 = new System.Windows.Forms.TextBox();
            this.tb_parameter2 = new System.Windows.Forms.TextBox();
            this.tb_parameter5 = new System.Windows.Forms.TextBox();
            this.tb_parameter1 = new System.Windows.Forms.TextBox();
            this.tb_parameter10 = new System.Windows.Forms.TextBox();
            this.tb_parameter9 = new System.Windows.Forms.TextBox();
            this.lb_depthRollL = new System.Windows.Forms.Label();
            this.lb_depthRailL = new System.Windows.Forms.Label();
            this.lb_depthRollR = new System.Windows.Forms.Label();
            this.lb_depthObject = new System.Windows.Forms.Label();
            this.lb_depthRailR = new System.Windows.Forms.Label();
            this.bt_startAuto = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.timerAuto = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bt_connect
            // 
            this.bt_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_connect.Location = new System.Drawing.Point(12, 12);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(231, 34);
            this.bt_connect.TabIndex = 0;
            this.bt_connect.Text = "Connect";
            this.bt_connect.UseVisualStyleBackColor = true;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // lb_connect
            // 
            this.lb_connect.AutoSize = true;
            this.lb_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_connect.Location = new System.Drawing.Point(258, 19);
            this.lb_connect.Name = "lb_connect";
            this.lb_connect.Size = new System.Drawing.Size(24, 20);
            this.lb_connect.TabIndex = 1;
            this.lb_connect.Text = "...";
            // 
            // lb_read
            // 
            this.lb_read.AutoSize = true;
            this.lb_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_read.Location = new System.Drawing.Point(258, 59);
            this.lb_read.Name = "lb_read";
            this.lb_read.Size = new System.Drawing.Size(24, 20);
            this.lb_read.TabIndex = 8;
            this.lb_read.Text = "...";
            // 
            // bt_read
            // 
            this.bt_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_read.Location = new System.Drawing.Point(12, 52);
            this.bt_read.Name = "bt_read";
            this.bt_read.Size = new System.Drawing.Size(231, 34);
            this.bt_read.TabIndex = 7;
            this.bt_read.Text = "Read";
            this.bt_read.UseVisualStyleBackColor = true;
            this.bt_read.Click += new System.EventHandler(this.bt_getDepth_Click);
            // 
            // lb_checkDepthRoll
            // 
            this.lb_checkDepthRoll.AutoSize = true;
            this.lb_checkDepthRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_checkDepthRoll.Location = new System.Drawing.Point(258, 99);
            this.lb_checkDepthRoll.Name = "lb_checkDepthRoll";
            this.lb_checkDepthRoll.Size = new System.Drawing.Size(24, 20);
            this.lb_checkDepthRoll.TabIndex = 10;
            this.lb_checkDepthRoll.Text = "...";
            // 
            // bt_checkRoll
            // 
            this.bt_checkRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_checkRoll.Location = new System.Drawing.Point(12, 92);
            this.bt_checkRoll.Name = "bt_checkRoll";
            this.bt_checkRoll.Size = new System.Drawing.Size(231, 34);
            this.bt_checkRoll.TabIndex = 9;
            this.bt_checkRoll.Text = "Check Depth Roll";
            this.bt_checkRoll.UseVisualStyleBackColor = true;
            this.bt_checkRoll.Click += new System.EventHandler(this.bt_checkDepth_Click);
            // 
            // lb_checkRailDifferent
            // 
            this.lb_checkRailDifferent.AutoSize = true;
            this.lb_checkRailDifferent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_checkRailDifferent.Location = new System.Drawing.Point(258, 139);
            this.lb_checkRailDifferent.Name = "lb_checkRailDifferent";
            this.lb_checkRailDifferent.Size = new System.Drawing.Size(24, 20);
            this.lb_checkRailDifferent.TabIndex = 12;
            this.lb_checkRailDifferent.Text = "...";
            // 
            // bt_checkRailDif
            // 
            this.bt_checkRailDif.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_checkRailDif.Location = new System.Drawing.Point(12, 132);
            this.bt_checkRailDif.Name = "bt_checkRailDif";
            this.bt_checkRailDif.Size = new System.Drawing.Size(231, 34);
            this.bt_checkRailDif.TabIndex = 11;
            this.bt_checkRailDif.Text = "Check Rail Different";
            this.bt_checkRailDif.UseVisualStyleBackColor = true;
            this.bt_checkRailDif.Click += new System.EventHandler(this.bt_getAverage_Click);
            // 
            // tb_parameter4
            // 
            this.tb_parameter4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_parameter4.Location = new System.Drawing.Point(12, 403);
            this.tb_parameter4.Name = "tb_parameter4";
            this.tb_parameter4.ReadOnly = true;
            this.tb_parameter4.Size = new System.Drawing.Size(361, 26);
            this.tb_parameter4.TabIndex = 13;
            // 
            // tb_parameter8
            // 
            this.tb_parameter8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_parameter8.Location = new System.Drawing.Point(379, 403);
            this.tb_parameter8.Name = "tb_parameter8";
            this.tb_parameter8.ReadOnly = true;
            this.tb_parameter8.Size = new System.Drawing.Size(361, 26);
            this.tb_parameter8.TabIndex = 14;
            // 
            // tb_parameter7
            // 
            this.tb_parameter7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_parameter7.Location = new System.Drawing.Point(379, 371);
            this.tb_parameter7.Name = "tb_parameter7";
            this.tb_parameter7.ReadOnly = true;
            this.tb_parameter7.Size = new System.Drawing.Size(361, 26);
            this.tb_parameter7.TabIndex = 16;
            // 
            // tb_parameter3
            // 
            this.tb_parameter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_parameter3.Location = new System.Drawing.Point(12, 371);
            this.tb_parameter3.Name = "tb_parameter3";
            this.tb_parameter3.ReadOnly = true;
            this.tb_parameter3.Size = new System.Drawing.Size(361, 26);
            this.tb_parameter3.TabIndex = 15;
            // 
            // tb_parameter6
            // 
            this.tb_parameter6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_parameter6.Location = new System.Drawing.Point(379, 339);
            this.tb_parameter6.Name = "tb_parameter6";
            this.tb_parameter6.ReadOnly = true;
            this.tb_parameter6.Size = new System.Drawing.Size(361, 26);
            this.tb_parameter6.TabIndex = 18;
            // 
            // tb_parameter2
            // 
            this.tb_parameter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_parameter2.Location = new System.Drawing.Point(12, 339);
            this.tb_parameter2.Name = "tb_parameter2";
            this.tb_parameter2.ReadOnly = true;
            this.tb_parameter2.Size = new System.Drawing.Size(361, 26);
            this.tb_parameter2.TabIndex = 17;
            // 
            // tb_parameter5
            // 
            this.tb_parameter5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_parameter5.Location = new System.Drawing.Point(379, 307);
            this.tb_parameter5.Name = "tb_parameter5";
            this.tb_parameter5.ReadOnly = true;
            this.tb_parameter5.Size = new System.Drawing.Size(361, 26);
            this.tb_parameter5.TabIndex = 20;
            // 
            // tb_parameter1
            // 
            this.tb_parameter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_parameter1.Location = new System.Drawing.Point(12, 307);
            this.tb_parameter1.Name = "tb_parameter1";
            this.tb_parameter1.ReadOnly = true;
            this.tb_parameter1.Size = new System.Drawing.Size(361, 26);
            this.tb_parameter1.TabIndex = 19;
            // 
            // tb_parameter10
            // 
            this.tb_parameter10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_parameter10.Location = new System.Drawing.Point(12, 275);
            this.tb_parameter10.Name = "tb_parameter10";
            this.tb_parameter10.ReadOnly = true;
            this.tb_parameter10.Size = new System.Drawing.Size(728, 26);
            this.tb_parameter10.TabIndex = 21;
            // 
            // tb_parameter9
            // 
            this.tb_parameter9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_parameter9.Location = new System.Drawing.Point(12, 243);
            this.tb_parameter9.Name = "tb_parameter9";
            this.tb_parameter9.ReadOnly = true;
            this.tb_parameter9.Size = new System.Drawing.Size(728, 26);
            this.tb_parameter9.TabIndex = 22;
            // 
            // lb_depthRollL
            // 
            this.lb_depthRollL.AutoSize = true;
            this.lb_depthRollL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_depthRollL.Location = new System.Drawing.Point(504, 19);
            this.lb_depthRollL.Name = "lb_depthRollL";
            this.lb_depthRollL.Size = new System.Drawing.Size(124, 20);
            this.lb_depthRollL.TabIndex = 23;
            this.lb_depthRollL.Text = "Depth Roll L =";
            // 
            // lb_depthRailL
            // 
            this.lb_depthRailL.AutoSize = true;
            this.lb_depthRailL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_depthRailL.Location = new System.Drawing.Point(504, 43);
            this.lb_depthRailL.Name = "lb_depthRailL";
            this.lb_depthRailL.Size = new System.Drawing.Size(124, 20);
            this.lb_depthRailL.TabIndex = 24;
            this.lb_depthRailL.Text = "Depth Rail L =";
            // 
            // lb_depthRollR
            // 
            this.lb_depthRollR.AutoSize = true;
            this.lb_depthRollR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_depthRollR.Location = new System.Drawing.Point(504, 69);
            this.lb_depthRollR.Name = "lb_depthRollR";
            this.lb_depthRollR.Size = new System.Drawing.Size(127, 20);
            this.lb_depthRollR.TabIndex = 25;
            this.lb_depthRollR.Text = "Depth Roll R =";
            // 
            // lb_depthObject
            // 
            this.lb_depthObject.AutoSize = true;
            this.lb_depthObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_depthObject.Location = new System.Drawing.Point(504, 121);
            this.lb_depthObject.Name = "lb_depthObject";
            this.lb_depthObject.Size = new System.Drawing.Size(130, 20);
            this.lb_depthObject.TabIndex = 27;
            this.lb_depthObject.Text = "Depth Object =";
            // 
            // lb_depthRailR
            // 
            this.lb_depthRailR.AutoSize = true;
            this.lb_depthRailR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_depthRailR.Location = new System.Drawing.Point(504, 95);
            this.lb_depthRailR.Name = "lb_depthRailR";
            this.lb_depthRailR.Size = new System.Drawing.Size(127, 20);
            this.lb_depthRailR.TabIndex = 26;
            this.lb_depthRailR.Text = "Depth Rail R =";
            // 
            // bt_startAuto
            // 
            this.bt_startAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_startAuto.Location = new System.Drawing.Point(12, 172);
            this.bt_startAuto.Name = "bt_startAuto";
            this.bt_startAuto.Size = new System.Drawing.Size(231, 65);
            this.bt_startAuto.TabIndex = 28;
            this.bt_startAuto.Text = "Start Auto";
            this.bt_startAuto.UseVisualStyleBackColor = true;
            this.bt_startAuto.Click += new System.EventHandler(this.bt_startAuto_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_stop.Location = new System.Drawing.Point(249, 172);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(231, 65);
            this.bt_stop.TabIndex = 29;
            this.bt_stop.Text = "Stop";
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // timerAuto
            // 
            this.timerAuto.Interval = 1000;
            this.timerAuto.Tick += new System.EventHandler(this.timerAuto_Tick);
            // 
            // FormCameraRL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.bt_stop);
            this.Controls.Add(this.bt_startAuto);
            this.Controls.Add(this.lb_depthObject);
            this.Controls.Add(this.lb_depthRailR);
            this.Controls.Add(this.lb_depthRollR);
            this.Controls.Add(this.lb_depthRailL);
            this.Controls.Add(this.lb_depthRollL);
            this.Controls.Add(this.tb_parameter9);
            this.Controls.Add(this.tb_parameter10);
            this.Controls.Add(this.tb_parameter5);
            this.Controls.Add(this.tb_parameter1);
            this.Controls.Add(this.tb_parameter6);
            this.Controls.Add(this.tb_parameter2);
            this.Controls.Add(this.tb_parameter7);
            this.Controls.Add(this.tb_parameter3);
            this.Controls.Add(this.tb_parameter8);
            this.Controls.Add(this.tb_parameter4);
            this.Controls.Add(this.lb_checkRailDifferent);
            this.Controls.Add(this.bt_checkRailDif);
            this.Controls.Add(this.lb_checkDepthRoll);
            this.Controls.Add(this.bt_checkRoll);
            this.Controls.Add(this.lb_read);
            this.Controls.Add(this.bt_read);
            this.Controls.Add(this.lb_connect);
            this.Controls.Add(this.bt_connect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCameraRL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CameraRL";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCameraRL_FormClosed);
            this.Load += new System.EventHandler(this.FormCameraRL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_connect;
        private System.Windows.Forms.Label lb_connect;
        private System.Windows.Forms.Label lb_read;
        private System.Windows.Forms.Button bt_read;
        private System.Windows.Forms.Label lb_checkDepthRoll;
        private System.Windows.Forms.Button bt_checkRoll;
        private System.Windows.Forms.Label lb_checkRailDifferent;
        private System.Windows.Forms.Button bt_checkRailDif;
        private System.Windows.Forms.TextBox tb_parameter4;
        private System.Windows.Forms.TextBox tb_parameter8;
        private System.Windows.Forms.TextBox tb_parameter7;
        private System.Windows.Forms.TextBox tb_parameter3;
        private System.Windows.Forms.TextBox tb_parameter6;
        private System.Windows.Forms.TextBox tb_parameter2;
        private System.Windows.Forms.TextBox tb_parameter5;
        private System.Windows.Forms.TextBox tb_parameter1;
        private System.Windows.Forms.TextBox tb_parameter10;
        private System.Windows.Forms.TextBox tb_parameter9;
        private System.Windows.Forms.Label lb_depthRollL;
        private System.Windows.Forms.Label lb_depthRailL;
        private System.Windows.Forms.Label lb_depthRollR;
        private System.Windows.Forms.Label lb_depthObject;
        private System.Windows.Forms.Label lb_depthRailR;
        private System.Windows.Forms.Button bt_startAuto;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.Timer timerAuto;
    }
}

