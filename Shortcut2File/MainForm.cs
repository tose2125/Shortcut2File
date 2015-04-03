using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Tose2125.Shortcut2File
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public String[] ChangeProgress(object sender, ChangeProgressEventArgs e)
        {
            if (InvokeRequired)
            {
                return (String[])Invoke(new ChangeProgressEventHandler(_ChangeProgress), sender, e);
            }
            else
            {
                return _ChangeProgress(sender, e);
            }
        }
        private String[] _ChangeProgress(object sender, ChangeProgressEventArgs e)
        {
            List<String> progressTextboxLines = ProgressTextbox.Lines.ToList();
            progressTextboxLines.Add(e.Message);
            ProgressTextbox.Lines = progressTextboxLines.ToArray();
            ProgressTextbox.Update();
            ProgressProgressbar.Maximum = e.All;
            ProgressProgressbar.Value = e.Count;
            return ProgressTextbox.Lines;
        }

        private void FolderSelectButton_Click(object sender, EventArgs e)
        {
            DialogResult folderSelectDialogResult = FolderSelectDialog.ShowDialog();
            if (folderSelectDialogResult == DialogResult.OK)
            {
                FolderPathLabel.Text = FolderSelectDialog.SelectedPath;
            }
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            ProgressTextbox.Lines = new String[1];
            ShortcutFileCopy myShortcutFileCopy = new ShortcutFileCopy();
            myShortcutFileCopy.ProgressChanging += this.ChangeProgress;
            myShortcutFileCopy.Main(FolderPathLabel.Text, OverWriteCheckbox.Checked, MoveModeCheckbox.Checked, ShortcutDeleteCheckbox.Checked);
        }
        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                ((String[])e.Data.GetData(DataFormats.FileDrop)).ToList().ForEach(filePath =>
                {
                    try
                    {
                        FolderPathLabel.Text = System.IO.Path.GetDirectoryName(filePath);
                    }
                    catch (ArgumentException ee)
                    {
                        FolderPathLabel.Text = "";
                        ChangeProgress(this, new ChangeProgressEventArgs(0, 0, ee.Message));
                        return;
                    }
                    catch (System.IO.IOException ee)
                    {
                        FolderPathLabel.Text = "";
                        ChangeProgress(this, new ChangeProgressEventArgs(0, 0, ee.Message));
                        return;
                    }
                });
                ProgressTextbox.Text = "フォルダ名が変更されました。";
            }
        }
        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
        }
    }
}
