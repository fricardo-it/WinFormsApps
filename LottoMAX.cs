using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Messaging;

namespace WinFormsFinalProject
{
    public partial class LottoMAX : Form
    {
        public LottoMAX()
        {
            InitializeComponent();
        }

        // Data to txt file
        string dir = @".\files\";
        string file = "LottoMax.txt";
        string name = "Lotto Max";

        public string randSeq(int range)   
        {
            Random random = new Random();
            string tempString = "";                                 // variable to return

            List<int> numbers = Enumerable.Range(1, 50).ToList();   // Adding the random numbers in the array. 

            for (int i = 0; i < range; i++)
            {
                int index = random.Next(numbers.Count);             
                int randomNumber = numbers[index];

                tempString += randomNumber.ToString() + "\t";       // add TAB after the random number
                numbers.RemoveAt(index);                                    // Remove all the repeating numbers. 
            }

            string txt = tempString.Remove(tempString.Length - 1, 1);      // remove last TAB or , and return the 'range' random numbers
            return (txt);       
        }

        public string randControl(int range) 
        {
            Random random = new Random();
            string tempString = "";                                 // variable to return

            List<int> numbers = Enumerable.Range(1, 9).ToList();   // Adding the random numbers in the array. 

            for (int i = 0; i < range; i++)
            {
                int index = random.Next(numbers.Count);
                int randomNumber = numbers[index];

                tempString += randomNumber.ToString() + " ";       // add TAB after the random number
                //numbers.RemoveAt(index);                                    // Remove all the repeating numbers. 
            }

           return tempString;
        }

        public void createFile(string dir, string file, string name, string txt)
        {
            string path = Path.Combine(dir, file);

            DateTime currentDate = DateTime.Now;
            txt = txt.Replace("\t", ",");

            try
            {
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                else
                {
                    StreamWriter sw = new StreamWriter(path, true);    //Pass the filepath and filename to the StreamWriter Constructor
                    sw.WriteLine($"{name}, {currentDate}, {txt.Remove(txt.LastIndexOf(","))}, Bonus " + txt.Substring(txt.LastIndexOf(",") + 1));  //Write a line of text

                    sw.Close();  //Close the file
                }          
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message,"Error " + name);
            }
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int range = 8;      // qty of random numbers
            label2.Text = "";
            label2.Text = randControl(range);     // label2 = "Range" random numbers
            textBox1.Text = "";
            textBox1.Text = randSeq(range);   // textBox1 = "Range" random numbers

            string txt = textBox1.Text;
            createFile(dir, file, name, txt);    //Create text file. 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string title = "Lotto Max";

            if (MessageBox.Show("Do you want to quit the application \n" + title + "?", "Exit " + title, MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }
        private void showMsgModal(string title, string msg)
        {
            ShowMsg msgModal = new ShowMsg();
            msgModal.Text = title;
            msgModal.textBox1.Text = (msg.Trim());
            msgModal.ShowDialog();
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(dir, file);
            string title = "Lotto Max";
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

        private void LottoMAX_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }
    }
}
