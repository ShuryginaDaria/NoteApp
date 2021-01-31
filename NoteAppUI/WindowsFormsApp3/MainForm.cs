using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace WindowsFormsApp3
{
     public partial class MainForm : Form
    {
        private Project _noteList;

        public MainForm()
        {
            InitializeComponent();

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddEditForm();
            addForm.ShowDialog();
        }

        private void AboutToolStripMenu_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}
