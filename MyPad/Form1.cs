using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPad
{
    public partial class myPadForm : Form
    {
        public myPadForm()
        {
            InitializeComponent();
        }

        private void cutItems(object sender, EventArgs e)
        {
            mainRichTextBox.Cut();
        }

        private void copyItems(object sender, EventArgs e)
        {
            mainRichTextBox.Copy();
        }

        private void pasteItems(object sender, EventArgs e)
        {
            mainRichTextBox.Paste();
        }

        private void undoItems(object sender, EventArgs e)
        {
            mainRichTextBox.Undo();
        }

        private void saveFile(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            mainRichTextBox.SaveFile(saveFileDialog.FileName);
        }

        private void openFile(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            mainRichTextBox.LoadFile(openFileDialog.FileName);
        }

        private void changeFont(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            mainRichTextBox.Font = fontDialog.Font;
        }

        private void changeBackground(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            mainRichTextBox.BackColor = colorDialog.Color;
        }

        private void foregroundColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            mainRichTextBox.ForeColor = colorDialog.Color;
        }
    }
}
