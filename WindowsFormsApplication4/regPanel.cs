using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class regPanel : UserControl
    {
        public regPanel()
        {
            InitializeComponent();
        }

        private void backButt_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            this.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void trms_Click(object sender, EventArgs e)
        {

        }
    }
}
