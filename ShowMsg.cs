using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsFinalProject
{
    public partial class ShowMsg : Form
    {
        public ShowMsg()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ShowMsg_Load(object sender, EventArgs e)
        {
            //string msg = "";
            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
        }
    }
}
