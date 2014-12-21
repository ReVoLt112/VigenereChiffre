using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VigenereChiffre
{
    public partial class frmMain : Form
    {
        Dictionary<Int32, Char> ALPHA = new Dictionary<int, char>();
        public frmMain()
        {
            String allusablechars = "\r\n\t";
            allusablechars += @"^°!""§$%&/(){}[]=?´`ß\+*~'#-_,.;:öäüÖÄÜ<>| €@";
            allusablechars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            allusablechars += "0123456789";
            allusablechars += "abcdefghijklmnopqrstuvwxyz";

            int counter = 0;
            foreach (char chr in allusablechars)
            {
                ALPHA.Add(counter, chr);
                counter++;
            }
            allusablechars = null;
            InitializeComponent();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (btnGo.Text.Equals("Encrypt"))
            {
                btnGo.Text = "Decrypt";
                speichernToolStripMenuItem.Enabled = true;
            }
            else
            {
                btnGo.Text = "Encrypt";
                speichernToolStripMenuItem.Enabled = false;
            }
        }

        private void encrypt(string schluessel, string klartext)
        {
            BackgroundWorker bw = new BackgroundWorker();
            // this allows our worker to report progress during work
            bw.WorkerReportsProgress = true;
            // what to do in the background thread
            bw.DoWork += new DoWorkEventHandler(
            delegate(object o, DoWorkEventArgs args)
            {
                BackgroundWorker b = o as BackgroundWorker;
                String geheimtext = String.Empty;
                int index = 0;
                foreach (char chr in klartext)
                {
                    int newchar = (ALPHA.FirstOrDefault(x => x.Value == chr).Key + ALPHA.FirstOrDefault(x => x.Value == schluessel[index]).Key);
                    if (newchar > ALPHA.Keys.Max())
                    {
                        newchar = newchar - ALPHA.Keys.Count;
                    }
                    geheimtext += Convert.ToString(ALPHA.FirstOrDefault(x => x.Key == newchar).Value);
                    double percent = Convert.ToDouble(geheimtext.Length) / (Convert.ToDouble(klartext.Length) / Convert.ToDouble(100));
                    b.ReportProgress(Convert.ToInt32(Math.Round(percent, 0)));
                    Application.DoEvents();
                    if (index < schluessel.Length - 1)
                    {
                        index++;
                    }
                    else
                    {
                        index = 0;
                    }
                }
                args.Result = geheimtext;
            });
            // what to do when progress changed (update the progress bar for example)
            bw.ProgressChanged += new ProgressChangedEventHandler(
            delegate(object o, ProgressChangedEventArgs args)
            {
                toolStripProgressBar2.Value = args.ProgressPercentage;
                if (toolStripProgressBar2.Value > 0)
                {
                    toolStripProgressBar2.Value = toolStripProgressBar2.Value - 1;
                }
                toolStripProgressBar2.Value = args.ProgressPercentage;
            });

            // what to do when worker completes its task (notify the user)
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
            delegate(object o, RunWorkerCompletedEventArgs args)
            {
                tbChiffre.Text = Convert.ToString(args.Result);
            });
            bw.RunWorkerAsync();
        }

        private void decrypt(string schluessel, string geheimtext)
        {
            BackgroundWorker bw = new BackgroundWorker();
            // this allows our worker to report progress during work
            bw.WorkerReportsProgress = true;
            // what to do in the background thread
            bw.DoWork += new DoWorkEventHandler(
            delegate(object o, DoWorkEventArgs args)
            {
                BackgroundWorker b = o as BackgroundWorker;
                String klartext = String.Empty;
                int index = 0;
                foreach (char chr in geheimtext)
                {
                    int newchar = (ALPHA.FirstOrDefault(x => x.Value == chr).Key - ALPHA.FirstOrDefault(x => x.Value == schluessel[index]).Key);
                    if (newchar < ALPHA.Keys.Min())
                    {
                        newchar = ALPHA.Keys.Count - Math.Abs(newchar);
                    }
                    klartext += Convert.ToString(ALPHA.FirstOrDefault(x => x.Key == newchar).Value);
                    double percent = Convert.ToDouble(klartext.Length) / (Convert.ToDouble(geheimtext.Length) / Convert.ToDouble(100));
                    b.ReportProgress(Convert.ToInt32(Math.Round(percent, 0)));
                    Application.DoEvents();
                    if (index < schluessel.Length - 1)
                    {
                        index++;
                    }
                    else
                    {
                        index = 0;
                    }
                }
                args.Result = klartext;
            });
            // what to do when progress changed (update the progress bar for example)
            bw.ProgressChanged += new ProgressChangedEventHandler(
            delegate(object o, ProgressChangedEventArgs args)
            {
                toolStripProgressBar2.Value = args.ProgressPercentage;
                if (toolStripProgressBar2.Value > 0)
                {
                    toolStripProgressBar2.Value = toolStripProgressBar2.Value - 1;
                }
                toolStripProgressBar2.Value = args.ProgressPercentage;
            });
            // what to do when worker completes its task (notify the user)
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
            delegate(object o, RunWorkerCompletedEventArgs args)
            {
                tbChiffre.Text = Convert.ToString(args.Result);
            });

            bw.RunWorkerAsync();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (tbKey.TextLength > 2)
            {
                if (rbEncrypt.Checked)
                {
                    encrypt(tbKey.Text, tbChiffre.Text);
                    rbDecrypt.Checked = true;
                }
                else
                {
                    decrypt(tbKey.Text, tbChiffre.Text);
                    rbEncrypt.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Der von Ihnen gewählte Schlüssel ist zu kurz!", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void allesMarkierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbChiffre.SelectAll();
        }

        private void kopierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbChiffre.Copy();
        }

        private void einfügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbChiffre.Paste();
        }

        private void ausschneidenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbChiffre.Cut();
        }

        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    tbChiffre.Text = File.ReadAllText(file);
                    rbDecrypt.Checked = true;
                }
                catch (IOException)
                {
                }
            }
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // Get file name.
            string name = saveFileDialog1.FileName;
            // Write to the file name selected.
            // ... You can write the text from a TextBox instead of a string literal.
            File.WriteAllText(name, tbChiffre.Text);
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Fill with life
        }

    }
}
