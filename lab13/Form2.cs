using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab13
{
    public partial class Form2 : Form1
    {
        public Form2() : base()
        {
            InitializeComponent();
        }

        override protected void formRez()
        {
            base.formRez();
            string resultat = Rez.Text;

            if (resultat != "") resultat += " ";
            resultat += $" ({(int)(double)(DateTime.Now - DateB.Value).Days / 365.25}) років";
            Rez.Text = resultat;
        }

        private void DateB_ValueChanged(object sender, EventArgs e)
        {
            formRez();
        }

        private void WriteFile(string filename)
        {
            string[] arrayStr = new string[4];
            arrayStr[0] = Priz.Text;
            arrayStr[1] = NameFO.Text;
            arrayStr[2] = Fname.Text;
            arrayStr[3] = DateB.Value.ToString();
            File.WriteAllLines(filename, arrayStr);
            MessageBox.Show("Дані збережено", "Інформація");
        }

        private void WriteFile()
        {
            WriteFile("defaul.txt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteFile();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog
            {
                DefaultExt = "txt",
                AddExtension = true,
                Title = "Введіть назву"
            };

            if (saveFile.ShowDialog() != DialogResult.Cancel) WriteFile(saveFile.FileName);
        }

        private void ReadFile(string filename)
        {
            if(!File.Exists(filename))
            {
                MessageBox.Show("Файлу не існує, дані не зчитані.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] arrayStr;
            arrayStr = File.ReadAllLines(filename);

            if (arrayStr.Length != 4)
            {
                MessageBox.Show("Файлу не існує, дані не зчитані.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Priz.Text = arrayStr[0];
            NameFO.Text = arrayStr[1];
            Fname.Text = arrayStr[2];

            try
            {
                DateB.Value = Convert.ToDateTime(arrayStr[3]);
            }
            catch
            {
                MessageBox.Show("Дату не зчитано, встановіть корекну дату.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ReadFile()
        {
            ReadFile("defaul.txt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadFile();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var readFile = new OpenFileDialog
            {
                DefaultExt = "txt",
                AddExtension = true,
                Title = "Введіть назву"
            };
            if (readFile.ShowDialog() != DialogResult.Cancel) ReadFile(readFile.FileName);
        }
    }
}
