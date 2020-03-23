using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nrfjprogGUI
{
    class Cli
    {

        private CliInterface cliInterface;
        private Process proc = null;
        private string strOutput = "";

        
        public Cli(CliInterface cliInterface)
        {
            this.cliInterface = cliInterface;
            proc = new Process();

        }



        public void ProcessOutDataReceived(object sender, DataReceivedEventArgs e)
        {

            strOutput += e.Data + "\r\n";
            cliInterface.CliInterfaceAnswerReceived(strOutput);
        }

        public string Execute(string cmd)
        {
            proc.OutputDataReceived -= new DataReceivedEventHandler(ProcessOutDataReceived);
            strOutput = "";
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.FileName = "cmd.exe";
            //proc.StartInfo.Arguments = "/C";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start();
            proc.BeginOutputReadLine();
            proc.OutputDataReceived += new DataReceivedEventHandler(ProcessOutDataReceived);
            proc.StandardInput.WriteLine(cmd);
            proc.StandardInput.WriteLine("exit");
            proc.StandardInput.AutoFlush = true;


            proc.WaitForExit();
            proc.CancelOutputRead();
            proc.Close();
            return strOutput;
        }
    }
}
