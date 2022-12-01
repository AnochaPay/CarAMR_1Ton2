using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMR_Command {
    public partial class err_code : Form {
        public err_code() {
            InitializeComponent();
        }

        private int formShowNum = 1;
        private void timer1_Tick(object sender, EventArgs e) {
            if (this.BackColor == Color.Red) this.BackColor = Color.Yellow;
            else this.BackColor = Color.Red;

            if (formShowNum <= 5) {
                formShowNum++;
                this.Activate();
                if (Form.ActiveForm != this) {
                    this.WindowState = FormWindowState.Minimized;
                    this.WindowState = FormWindowState.Normal;
                }

            }
        }

        




    }
}
