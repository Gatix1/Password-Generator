using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGen
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddToChars(ref List<String> chars, int i)
        {
            chars.Add(((char)i).ToString());
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            List<String> chars = new List<String>();
            if (UppercaseCheckbox.Checked)
                for (int i = 65; i < 91; i++)
                {
                    AddToChars(ref chars, i);
                }
            if (LowercaseCheckbox.Checked)
                for (int i = 97; i < 123; i++)
                {
                    AddToChars(ref chars, i);
                }
            if (NumbersCheckbox.Checked)
                for (int i = 48; i < 58; i++)
                {
                    AddToChars(ref chars, i);
                }
            if (CharactersCheckbox.Checked)
                for (int i = 33; i < 48; i++)
                {
                    AddToChars(ref chars, i);
                }

            string generatedPassword = "";
            Random randChar = new Random();
            int passwordLength = 12;
            try
            {
                if (Int32.Parse(LengthTextbox.Text) <= 0)
                    throw new Exception("Error");
                else
                    passwordLength = Int32.Parse(LengthTextbox.Text);
                for (int i = 0; i < passwordLength; i++)
                {
                    generatedPassword += chars[randChar.Next(0, chars.ToArray().Length)];
                }
                PasswordsList.Items.Add(generatedPassword);
            }
            catch
            {
                MessageBox.Show("You are supposed to enter an integer value greater then 0, and to choose at least one option!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "TXT file|*.txt";
            saveFileDialog1.Title = "Save the passwords list";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                FileStream fs = (FileStream)saveFileDialog1.OpenFile();
                    foreach(var pass in PasswordsList.Items)
                    {
                        byte[] bytes = Encoding.UTF8.GetBytes(pass.ToString()+"\n");
                        fs.Write(bytes, 0, bytes.Length);
                    }
                fs.Close();
                MessageBox.Show("File saved successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
