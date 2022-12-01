using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMR_Command
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) {

        }

        private int formShowNum = 1;
        private void timer1_Tick(object sender, EventArgs e) {
            if (formShowNum <= 5) {
                formShowNum++;
                this.Activate();
                if (Form.ActiveForm != this) {
                    this.WindowState = FormWindowState.Minimized;
                    this.WindowState = FormWindowState.Normal;
                }

            } else {
                timer1.Enabled = false;
            }
        }
    }
}
