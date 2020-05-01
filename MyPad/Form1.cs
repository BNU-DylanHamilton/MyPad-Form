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

        /// <summary>
        /// This cuts any text that the user has highlighted
        /// within the application.
        /// </summary>
        private void cutItems(object sender, EventArgs e)
        {
            mainRichTextBox.Cut();
        }

        /// <summary>
        /// This copies any text that is highlighted within 
        /// the application.
        /// </summary>
        private void copyItems(object sender, EventArgs e)
        {
            mainRichTextBox.Copy();
        }

        /// <summary>
        /// This pastes any text that the user has copied.
        /// </summary>
        private void pasteItems(object sender, EventArgs e)
        {
            mainRichTextBox.Paste();
        }

        /// <summary>
        /// This undoes anything the user does and chooses
        /// to undo.
        /// </summary>
        private void undoItems(object sender, EventArgs e)
        {
            mainRichTextBox.Undo();
        }

        /// <summary>
        /// This saves the file the user is currently
        /// working on and allows them to give it a 
        /// unique name.
        /// </summary>
        private void saveFile(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            mainRichTextBox.SaveFile(saveFileDialog.FileName);
        }

        /// <summary>
        /// This opens the file the user chooses.
        /// </summary>
        private void openFile(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            mainRichTextBox.LoadFile(openFileDialog.FileName);
        }

        /// <summary>
        /// This allows the user to change the 
        /// font, font size and font style to 
        /// what the user decides.
        /// </summary>
        private void changeFont(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            mainRichTextBox.Font = fontDialog.Font;
        }

        /// <summary>
        /// This changes the background colour
        /// to what the user decides.
        /// </summary>
        private void changeBackground(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            mainRichTextBox.BackColor = colorDialog.Color;
        }

        /// <summary>
        /// This changes the foreground
        /// colour to what the user decides.
        /// </summary>
        private void changeForeground(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            mainRichTextBox.ForeColor = colorDialog.Color;
        }

        /// <summary>
        /// This changes the font size dependant 
        /// on where the scroll bar is located along
        /// the scroll.
        /// </summary>
        private void changeFontSize(object sender, ScrollEventArgs e)
        {
            Font f = new Font(mainRichTextBox.Font.Name, fontScrollBar.Value, FontStyle.Regular);
            mainRichTextBox.SelectionFont = f;
        }
    }
}
