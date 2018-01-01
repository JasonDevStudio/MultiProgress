using DevExpress.Utils.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiProgressServer
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll")]
        public static extern int WinExec(string exeName, int operType);

        public Form1()
        {
            InitializeComponent();
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            decimal.TryParse(this.textEdit1.EditValue.ToString(), out var number);

            for (int i = 0; i < number; i++)
            {
                Process.Start(@"MultiProgressJob.exe", i.ToString());
            }

        }
    }
}
