using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security;
using System.Diagnostics;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;

namespace ChuanHoaDuLieuNN
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog1, openFileDialog2;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            {
                openFileDialog1.FileName = "Select a text file",
                openFileDialog1.Filter = "Text files (*.txt)|*.txt",
                openFileDialog1.Title = "Open text file"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                lblFileName.Text = openFileDialog1.FileName;
        }

        private void btnChonFileKQ_Click(object sender, EventArgs e)
        {
            openFileDialog2 = new OpenFileDialog();
            {
                openFileDialog2.FileName = "Select a text file",
                openFileDialog2.Filter = "Text files (*.txt)|*.txt",
                openFileDialog2.Title = "Open text file"
            }
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
                lblFileResults.Text = openFileDialog2.FileName;
        }

        private void btnChuanhoa_Click(object sender, EventArgs e)
        {
            if(lblFileName.Text == "" || lblFileResults.Text == "")
                MessageBox.Show("Hãy nhập tệp nguồn/tệp đích");
        }
    }
}
