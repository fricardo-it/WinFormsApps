using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsFinalProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLottoMax_Click(object sender, EventArgs e)
        {
            LottoMAX obj = new LottoMAX();
            obj.ShowDialog();
        }

        private void btnLotto649_Click(object sender, EventArgs e)
        {
            Lotto649 obj = new Lotto649();
            obj.ShowDialog();
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            string title = "Application";

            if (MessageBox.Show("Do you want to quit the main \n" + title + "?", "Exit " + title, MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                Application.Exit();
            }

        }

        private void btnMoneyEx_Click(object sender, EventArgs e)
        {
            //MoneyEx obj = new MoneyEx();
            MoneyConv obj = new MoneyConv();

            obj.ShowDialog();
        }

        private void btnTemperature_Click(object sender, EventArgs e)
        {
            TempConv obj = new TempConv();

            obj.ShowDialog();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            SimpleCalculator obj = new SimpleCalculator();

            obj.ShowDialog();
        }

        private void btnIP_Click(object sender, EventArgs e)
        {
            IP4_Validator obj = new IP4_Validator();

            obj.ShowDialog();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            string dir = @".\files\";

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }
    }
}
