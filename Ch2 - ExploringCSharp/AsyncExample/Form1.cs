using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblLinesRead.Text = "0";
            lblCompletedLineCount.Text = "0";
        }
        private async void btnReadBigFile_Click(object sender, EventArgs e)
        {
            int linesInFile = await ReadFileAsync();
            lblCompletedLineCount.Text = linesInFile.ToString();
        }

        private async Task<int> ReadFileAsync()
        {
            var FileLines = new List<string>();
            int lineCount = 0;

            using (var reader = File.OpenText(@"C:\temp\big_file.txt"))
            {
                string line = string.Empty;
                while ((line = await reader.ReadLineAsync().ConfigureAwait(false)) != null)
                {

                    FileLines.Add(line);
                    lineCount += 1;

                    if (lblLinesRead.InvokeRequired)
                    {
                        lblLinesRead.Invoke(new Action(() => lblLinesRead.Text = lineCount.ToString()));
                    }
                    else
                    {
                        lblLinesRead.Text = lineCount.ToString();
                    }
                }
            }

            return lineCount;
        }











        //async Task PerformSomeLongRunningOperation()
        //{
        //    //DoSomeWork(false).Wait();
        //    //await DoSomeWork(false);
        //    DoSomeWork(false).GetAwaiter().GetResult();
        //}


        //async Task DoSomeWork(bool blnToggleIsOn)
        //{
        //    // Some work is done here
        //}
                           


    }
}
