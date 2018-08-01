using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace AndOTA
{
    public partial class AndOTA : Form
    {
        private BackgroundWorker convertWorker;
        private TransferList transferList;

        public AndOTA()
        {
            InitializeComponent();

            convertWorker = new BackgroundWorker();
            convertWorker.WorkerReportsProgress = true;
            convertWorker.ProgressChanged += ConvertWorker_ProgressChanged;
            convertWorker.DoWork += ConvertWorker_DoWork;
            convertWorker.RunWorkerCompleted += ConvertWorker_RunWorkerCompleted;
        }

        private void ConvertWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            updateStatus(e.UserState as String);
        }

        private void ConvertWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) => updateStatus("Idle");

        private void ConvertWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Int32 BLOCK_SIZE = 4096;

            FileStream outputFileStream = new FileStream(textBoxOutputFile.Text, FileMode.Create);
            FileStream dataFileStream = File.OpenRead(textBoxDataFile.Text);
            BinaryReader dataFileReader = new BinaryReader(dataFileStream);
            BinaryWriter outputFileWriter = new BinaryWriter(outputFileStream);
            Int32 blockCount = 1;
            foreach (object[] command in transferList.Commands)
            {
                if ((String)command[0] == "new")
                {
                    foreach (Tuple<Int64, Int64> blockset in (command[1] as List<Tuple<Int64, Int64>>))
                    {
                        Int64 start = blockset.Item1, end = blockset.Item2;
                        Int64 blocks = end - start;
                        convertWorker.ReportProgress(blockCount, $"Copying {blocks} blocks into position {start}...");

                        outputFileStream.Seek(start * BLOCK_SIZE, SeekOrigin.Begin);
                        while (blocks > 0)
                        {
                            blockCount++;
                            outputFileWriter.Write(dataFileReader.ReadBytes(BLOCK_SIZE));
                            blocks--;
                        }
                    }
                }
            }

            dataFileReader.Close();
            dataFileStream.Close();
            outputFileStream.Flush();
            outputFileStream.Close();
            convertWorker.ReportProgress(transferList.BlocksToWrite, "Done");
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if(File.Exists(textBoxDataFile.Text) && File.Exists(textBoxTransferList.Text) && !String.IsNullOrEmpty(textBoxOutputFile.Text))
            {
                progressBar.Maximum = transferList.BlocksToWrite;
                convertWorker.RunWorkerAsync();
            }
        }

        private void buttonBrowseTransferList_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseTransferListDialog = new OpenFileDialog();
            if(browseTransferListDialog.ShowDialog() == DialogResult.OK)
            {
                if (loadTransferList(browseTransferListDialog.FileName))
                    checkReadiness();
            }
        }

        private void buttonBrowseDataFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseDataFileDialog = new OpenFileDialog();
            if (browseDataFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxDataFile.Text = browseDataFileDialog.FileName;
                String transferListTestPath = Path.Combine(Path.GetDirectoryName(textBoxDataFile.Text), $"{Path.GetFileName(textBoxDataFile.Text).Replace(".new.dat", "")}.transfer.list");
                if (File.Exists(transferListTestPath))
                {
                    if (loadTransferList(transferListTestPath))
                        checkReadiness();
                }

            }
        }

        private void checkReadiness()
        {
            if (transferList.GetType() == typeof(TransferList) && File.Exists(textBoxDataFile.Text) && !String.IsNullOrEmpty(textBoxOutputFile.Text))
                if (Directory.Exists(Path.GetDirectoryName(textBoxOutputFile.Text)))
                    setReadiness(true);
                else
                    setReadiness(false);
            else
                setReadiness(false);
        }

        private void setReadiness(bool ready)
        {
            buttonConvert.Enabled = ready;
            updateStatus(ready ? "Ready" : "Idle");
        }

        private void buttonSaveOutputFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveOutputFileDialog = new SaveFileDialog();
            saveOutputFileDialog.Filter = "Image file (*.img)|*.img";
            saveOutputFileDialog.DefaultExt = "img";
            if (!String.IsNullOrEmpty(textBoxDataFile.Text))
                saveOutputFileDialog.FileName = $"{Path.GetFileName(textBoxDataFile.Text).Replace(".new.dat", "")}";

            if (saveOutputFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxOutputFile.Text = saveOutputFileDialog.FileName;
                checkReadiness();
            }
        }

        private bool loadTransferList(String path)
        {
            updateStatus("Parsing transfer list...");
            transferList = TransferList.FromFile(path);
            if(transferList != null)
            {
                labelListVersion.Text = $"List version: {transferList.Version}";
                labelBlocks.Text = $"Blocks to write: {transferList.BlocksToWrite}";
                textBoxTransferList.Text = path;
                return true;
            }
            return false;
        }

        private void updateStatus(String status)
        {
            labelStatus.Text = $"Status: {status}";
        }
    }
}
