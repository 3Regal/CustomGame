using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LevelEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Editor editor = new Editor();
            editor.ShowDialog();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            //allow the user to choose a save location and save input
            OpenFileDialog loadWindow = new OpenFileDialog();
            loadWindow.Filter = "Level Files (*.level)|*.level";
            loadWindow.Title = "Load a level file.";
            DialogResult choice = loadWindow.ShowDialog();

            //if the user hit cancel, stop the method
            if (choice != DialogResult.OK)
            {
                return;
            }

            //create the new form using the load constructor
            Editor editor = new Editor(loadWindow.FileName);
            editor.ShowDialog();
        }
    }
}
