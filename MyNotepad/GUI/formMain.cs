using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotepad
{
    public partial class Form1 : Form
    {
        String fileName = "";
        public Form1()
        {
            InitializeComponent();
        }



        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Toolstrip(object sender, EventArgs e)
        {
            String stTask = (sender as ToolStripMenuItem).Text;
            if (stTask == "Exit")
                this.Close();

            else if (stTask == "New")
            {
                txtDoc.ReadOnly = false;
                txtDoc.Text = "";
                fileName = null;
                this.Text = "mynotepad - untitled";
            }
            else if (stTask == "Save")
            {
               
                if (fileName == null)
                {
                        saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
                    {
                        fileName = saveFileDialog1.FileName;
                    }
                    else
                        return;
                  
                }
           

                System.IO.StreamWriter sw = new System.IO.StreamWriter(fileName);
                for (int i = 0; i < txtDoc.Lines.Length; i++)
                {
                    sw.WriteLine(txtDoc.Lines[i]);
                }
                sw.Close();
                this.Text = "mynotepad - " + fileName;
            }else if (stTask == "Open")
            {
                OpenFileDialog dlgOpen = new OpenFileDialog();
                if (dlgOpen.ShowDialog(this) == DialogResult.OK)
                    fileName = dlgOpen.FileName;
                else return;

                System.IO.StreamReader sr = new System.IO.StreamReader(fileName);
                txtDoc.Text = sr.ReadToEnd();
                sr.Close();
                this.Text = "My notepad - " + fileName;

            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
