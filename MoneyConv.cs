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
using System.Xml.Linq;

namespace WinFormsFinalProject
{
    public partial class MoneyConv : Form
    {
        public MoneyConv()
        {
            InitializeComponent();
        }

        // Data to txt file
        string dir = @".\files\";
        string file = "MoneyConv.txt";
        string name = "Money Exchange";

        //format to save in the txt file
        //100 CAD = 76 USD, 2022/7/29 9:57:33 AM

        public void createFile(string dir, string file, string name, string txt)
        {
            DateTime currentDate = DateTime.Now;

            try
            {
                string path = Path.Combine(dir, file);

                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                else
                {
                    StreamWriter sw = new StreamWriter(path, true);    //Pass the filepath and filename to the StreamWriter Constructor
                    sw.WriteLine($"{txt}, {currentDate}");  //Write a line of text
                    sw.Close();
                }
                //Close the file
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        private void MoneyConv_Load(object sender, EventArgs e)
        {
            // default select
            rbCAD1.Checked = true;
            rbCAD2.Checked = true;
        }

        private void rbCheckedChanged(object sender, EventArgs e)
        {
            // clear the Convert value alwways radiobutton checked changed
            textBox2.Text = "";
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            /* Rates in 2023-03-28
                CAD: 1.00 --> 0.79 USD
                CAD: 1.00 --> 0.68 EUR
                CAD: 1.00 --> 0.60 GBP
                CAD: 1.00 --> 3.79 BRL
            */
            decimal CAD = 1.00m;
            decimal USD = 0.79m;
            decimal EUR = 0.68m;
            decimal GBP = 0.60m;
            decimal BRL = 3.79m;
            decimal amount = 0;
            decimal fMoney = 0;
            decimal sMoney = 0;

            string txt = "";    // text file
            string fText = "";  // text from money
            string tText = "";  // text to money

            try
            {
                if (textBox1.Text != "")
                {
                    if (decimal.Parse(textBox1.Text) > 0)
                    {
                        // Running every groupbox control
                        foreach (RadioButton radioButton1 in groupBox1.Controls.OfType<RadioButton>())
                        {
                            // check if radio button is checked
                            if (radioButton1.Checked)
                            {
                                // select the value to convertion
                                switch (radioButton1.Text)
                                {
                                    case "CAD":
                                        {
                                            fMoney = CAD;
                                            fText = radioButton1.Text;
                                            break;

                                        }
                                    case "USD":
                                        {
                                            fMoney = USD;
                                            fText = radioButton1.Text;
                                            break;

                                        }
                                    case "EUR":
                                        {
                                            fMoney = EUR;
                                            fText = radioButton1.Text;
                                            break;

                                        }
                                    case "GBP":
                                        {
                                            fMoney = GBP;
                                            fText = radioButton1.Text;
                                            break;

                                        }
                                    case "BRL":
                                        {
                                            fMoney = BRL;
                                            fText = radioButton1.Text;
                                            break;
                                        }
                                    default:
                                        break;
                                }
                            }
                        }

                        foreach (RadioButton radioButton2 in groupBox2.Controls.OfType<RadioButton>())
                        {
                            if (radioButton2.Checked)
                            {
                                // select the value to convertion
                                switch (radioButton2.Text)
                                {
                                    case "CAD":
                                        {
                                            sMoney = CAD;
                                            tText = radioButton2.Text;
                                            break;

                                        }
                                    case "USD":
                                        {
                                            sMoney = USD;
                                            tText = radioButton2.Text;
                                            break;

                                        }
                                    case "EUR":
                                        {
                                            sMoney = EUR;
                                            tText = radioButton2.Text;
                                            break;

                                        }
                                    case "GBP":
                                        {
                                            sMoney = GBP;
                                            tText = radioButton2.Text;
                                            break;

                                        }
                                    case "BRL":
                                        {
                                            sMoney = BRL;
                                            tText = radioButton2.Text;
                                            break;

                                        }
                                    default:
                                        break;
                                }
                            }
                        }

                        // convert = ( FROM * textbox1 ) / TO
                        amount = (Convert.ToDecimal(textBox1.Text) * sMoney) / fMoney;

                        // round value 0.00 format 
                        amount = decimal.Round(amount, 2);

                        // put the convert value into textbox2
                        textBox2.Text = amount.ToString();

                        // txt = initial value + initial money = converted value + final money
                        txt = textBox1.Text + " " + fText + " = " + textBox2.Text + " " + tText;
                        createFile(dir, file, name, txt);    //Create text file. 
                    }
                    else
                    {
                        MessageBox.Show("Input a positive value to convert", "Convert Value", MessageBoxButtons.OK);
                        textBox1.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Input a positive value to convert", "Convert Value", MessageBoxButtons.OK);
                    textBox1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void showMsgModal(string title, string msg)
        {
            ShowMsg msgModal = new ShowMsg();
            msgModal.Text = title;
            msgModal.textBox1.Text = (msg.Trim());
            msgModal.ShowDialog();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(dir, file);
            string title = "Money Exchange";
            string textToPrint = "";
            FileStream stream = null;
            byte counter = 0;
            int numexhibit = 10;

            try
            {
                using (stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (reader.Peek() != -1)
                    {
                        string line = reader.ReadLine();
                        textToPrint += line + "\r\n";
                    }

                    // call the modal form, putting the text and title.
                    showMsgModal(title, textToPrint);

                    reader.Close();
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("IO Exception\n" + ex.Message);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string title = "Money Exchange";

            if (MessageBox.Show("Do you want to quit the application \n" + title + "?", "Exit " + title, MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }


    }
}
