using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AutoUpdatePage
{
    //TODO: Learn Selenium and use it!!!
    public partial class AutoUpdate : Form
    {
        readonly Dictionary<string, DateTime> lastFileUpdate = new Dictionary<string, DateTime>();

        public AutoUpdate()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            bool sucess = true;

            if (rdFile.Checked)
            {
                if (String.IsNullOrEmpty(tbEditingFile.Text) || !File.Exists(tbEditingFile.Text)
                    || String.IsNullOrEmpty(tbModifiedFile.Text) || !File.Exists(tbModifiedFile.Text))
                    sucess = false;
            }
            else if (rdFolder.Checked)
            {
                if (String.IsNullOrEmpty(tbEditingFolder.Text) || !Directory.Exists(tbEditingFolder.Text))
                    sucess = false;
            }

            if (sucess)
            {
                timerCheckForUpdate.Enabled = true;
                timerCheckForUpdate.Start();
            }
            else
                MessageBox.Show(@"Pasta ou arquivo não encontrado!");
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            timerCheckForUpdate.Stop();

            lastFileUpdate.Clear();
            tbEditingFile.Text = "";
            tbEditingFolder.Text = "";
        }
        
        private void btnSearchFolder_Click(object sender, EventArgs e)
        {
            folderDialogEditingSite.ShowDialog();
            tbEditingFolder.Text = folderDialogEditingSite.SelectedPath;
        }

        private void btnSearchFile_Click(object sender, EventArgs e)
        {
            fileDialogEditingFile.ShowDialog();
            tbEditingFile.Text = fileDialogEditingFile.FileName;
        }

        private void btnSearchOpenFile_Click(object sender, EventArgs e)
        {
            fileDialogModifiedHtmlFile.ShowDialog();
            tbModifiedFile.Text = fileDialogModifiedHtmlFile.FileName;
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbEditingFile.Text))
            {
                if (lastFileUpdate.ContainsKey(tbModifiedFile.Text))
                {
                    var fileToOpen = File.GetLastWriteTime(tbModifiedFile.Text);
                    if (lastFileUpdate[tbModifiedFile.Text] != fileToOpen)
                    {
                        Process.Start(tbModifiedFile.Text);
                    }
                    else
                    {
                        if (lastFileUpdate.ContainsKey(tbEditingFile.Text))
                        {
                            var fileWorking = File.GetLastWriteTime(tbEditingFile.Text);
                            if (lastFileUpdate[tbEditingFile.Text] != fileWorking)
                            {
                                lastFileUpdate[tbEditingFile.Text] = fileWorking;
                                Process.Start(tbModifiedFile.Text);
                            }
                        }
                    }
                }
                else
                {
                    lastFileUpdate.Add(tbModifiedFile.Text, File.GetLastWriteTime(tbModifiedFile.Text));
                    Process.Start(tbModifiedFile.Text);
                }
            }
            else if (!String.IsNullOrEmpty(tbEditingFolder.Text))
            {
                bool somethingChenge = false;
                foreach (string file in Directory.GetFiles(tbEditingFolder.Text))
                {
                    if (somethingChenge)
                        lastFileUpdate[file] = File.GetLastWriteTime(file);
                    if (lastFileUpdate.ContainsKey(file))
                    {
                        if (lastFileUpdate[file] != File.GetLastWriteTime(file))
                        {
                            somethingChenge = true;
                            lastFileUpdate[file] = File.GetLastWriteTime(file);
                        }
                    }
                    else
                    {
                        lastFileUpdate.Add(file, File.GetLastWriteTime(file));
                        somethingChenge = true;
                    }
                }

                if (somethingChenge)
                {
                    OpenEveryHtmlInFolder(tbEditingFolder.Text);
                }
            }
        }

        private void OpenEveryHtmlInFolder(string folder)
        {
            foreach (string file in Directory.GetFiles(folder))
            {
                if (file.Contains(".html"))
                {
                    Process.Start(file);
                }
            }
            foreach (string childFolder in Directory.GetDirectories(folder))
            {
                OpenEveryHtmlInFolder(childFolder);
            }
        }
    }
}
