namespace AMR_Command {
    partial class err_code {
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
            this.lb_err_code = new System.Windows.Forms.Label();
            this.lb_detail = new System.Windows.Forms.Label();
            this.bt_dismiss = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_err_code
            // 
            this.lb_err_code.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_err_code.Location = new System.Drawing.Point(21, 41);
            this.lb_err_code.Name = "lb_err_code";
            this.lb_err_code.Size = new System.Drawing.Size(552, 44);
            this.lb_err_code.TabIndex = 0;
            this.lb_err_code.Text = "label1";
            this.lb_err_code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_detail
            // 
            this.lb_detail.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_detail.Location = new System.Drawing.Point(21, 119);
            this.lb_detail.Name = "lb_detail";
            this.lb_detail.Size = new System.Drawing.Size(552, 44);
            this.lb_detail.TabIndex = 1;
            this.lb_detail.Text = "label2";
            this.lb_detail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_dismiss
            // 
            this.bt_dismiss.BackColor = System.Drawing.Color.Yellow;
            this.bt_dismiss.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dismiss.Location = new System.Drawing.Point(28, 210);
            this.bt_dismiss.Name = "bt_dismiss";
            this.bt_dismiss.Size = new System.Drawing.Size(132, 48);
            this.bt_dismiss.TabIndex = 2;
            this.bt_dismiss.Text = "Dismiss";
            this.bt_dismiss.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.bt_cancel);
            this.groupBox1.Controls.Add(this.bt_reset);
            this.groupBox1.Controls.Add(this.lb_err_code);
            this.groupBox1.Controls.Add(this.bt_dismiss);
            this.groupBox1.Controls.Add(this.lb_detail);
            this.groupBox1.Location = new System.Drawing.Point(7, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 289);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.Yellow;
            this.bt_cancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancel.Location = new System.Drawing.Point(441, 210);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(132, 48);
            this.bt_cancel.TabIndex = 4;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = false;
            // 
            // bt_reset
            // 
            this.bt_reset.BackColor = System.Drawing.Color.Yellow;
            this.bt_reset.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reset.Location = new System.Drawing.Point(234, 210);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(132, 48);
            this.bt_reset.TabIndex = 3;
            this.bt_reset.Text = "Reset";
            this.bt_reset.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // err_code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(610, 307);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "err_code";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "err_code";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lb_err_code;
        public System.Windows.Forms.Label lb_detail;
        public System.Windows.Forms.Button bt_dismiss;
        public System.Windows.Forms.Button bt_cancel;
        public System.Windows.Forms.Button bt_reset;
    }
}