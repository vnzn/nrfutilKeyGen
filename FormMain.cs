using nrfjprogGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nrfutilKeyGen
{
    public partial class FormMain : Form, CliInterface
    {

        private const String backupPrivateKeyPrefix = "move private.key private.key.";
        private const String nrfutilCommandGeneratePrivateKey = "nrfutil.exe keys generate private.key";
        private const String nrfutilCommandGeneratePublicKey = "nrfutil.exe keys display --key pk --format code private.key --out_file public_key.c";

        public FormMain()
        {
            InitializeComponent();
        }

        private delegate void updateLogDelegate(String log);
        private void updateLog(String log)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new updateLogDelegate(updateLog), new object[] { log });
                }
                else
                {
                    textBoxLog.Text = log;
                }
            }
            catch
            {

            }
        }

        private void threadGenerate(object obj)
        {

            String selectedFileName = obj.ToString();


            Cli c = new Cli(this);

            if (string.IsNullOrEmpty(selectedFileName))
            {

                c.Execute(backupPrivateKeyPrefix + (System.DateTime.UtcNow.ToUniversalTime().Ticks / 10000000).ToString());
                c.Execute(nrfutilCommandGeneratePrivateKey);
            }


            c.Execute(nrfutilCommandGeneratePublicKey);

            Process proc = new Process();
            proc.StartInfo.FileName = "explorer";
            proc.StartInfo.Arguments = @"/select,"+ System.Windows.Forms.Application.ExecutablePath;
            proc.Start();
        }

        public void CliInterfaceAnswerReceived(string answer)
        {

            updateLog(answer);
        }

        private void buttonGenerateNew_Click(object sender, EventArgs e)
        {


            Thread thread = new Thread(new ParameterizedThreadStart(threadGenerate));
            thread.Start("");

        }

        private void buttonGeneratePublic_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialogPrivateKey.ShowDialog();
            String selectedFileName = openFileDialogPrivateKey.FileName;
            if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(selectedFileName))
            {

                Thread thread = new Thread(new ParameterizedThreadStart(threadGenerate));
                thread.Start(selectedFileName);
            }
            else
            {
                MessageBox.Show("Need to select a private key!");
            }

            openFileDialogPrivateKey.FileName = "";
        }
    }
}
