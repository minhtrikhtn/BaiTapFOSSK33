using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;
using System.Security;

namespace ChuanHoaDuLieuNN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            // OpenFileDialog dlg = new OpenFileDialog();
            //if (dlg.ShowDialog() == DialogResult.OK)
            //{
            //   string fileName;

            //   fileName = dlg.FileName;
            //MessageBox.Show(fileName);
            //}
            OpenFileDialog oFile = new OpenFileDialog();
            oFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (oFile.ShowDialog() == DialogResult.OK)
            {
                lblFileName.Text = oFile.FileName;
            }
        }

        private void btnChonFileKQ_Click(object sender, EventArgs e)
        {

        }

        private void btnChuanhoa_Click(object sender, EventArgs e)
        {

        }


        private void lblFileName_Click(object sender, EventArgs e)
        {

        }
    }
}
