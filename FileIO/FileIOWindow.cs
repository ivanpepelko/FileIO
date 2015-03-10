using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileIO {
    public partial class FileIOWindow : Form {

        private DialogResult dr;

        public FileIOWindow() {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e) {
            openFileDialog.ShowDialog();
        }

        private void saveInButton_Click(object sender, EventArgs e) {
            dr = folderBrowserDialog.ShowDialog();
            if (dr == DialogResult.OK) {
                saveFileInTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e) {
            openTextBox.Text = openFileDialog.FileName;
            StreamReader sr = new StreamReader(openFileDialog.FileName);
            filePrintTextBox.Text = sr.ReadToEnd();
        }

    }
}
