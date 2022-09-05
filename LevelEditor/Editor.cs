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

namespace LevelEditor
{
    public partial class Editor : Form
    {

        //list of screens
        private List<PictureBox[,]> screens;
        private int currentScreen;

        //list of transition trackers
        private List<TransitionTracker> trackers;

        //changes made boolean
        private bool changes;

        /// <summary>
        /// NEW map constructor
        /// generates one NEW screen with empty tiles
        /// </summary>
        public Editor()
        {
            InitializeComponent();

            //instantiate lists
            screens = new List<PictureBox[,]>(1);
            trackers = new List<TransitionTracker>();
            trackers.Add(new TransitionTracker());

            //add a screen 0 with empty tiles
            AddScreenEmptyTiles();

            //start on screen 0
            currentScreen = 0;
        }

        //LOAD map constructor
        //calls loadmap method
        public Editor(string fileName)
        {
            InitializeComponent();

            LoadMap(fileName);

            changes = false;
        }

        private void ChangeTileColor(object sender, EventArgs e)
        {
            //cast sender to a tile object
            PictureBox tile = (PictureBox)sender;
            //cast e to MouseEventArgs
            MouseEventArgs mouseE = (MouseEventArgs)e;

            if (mouseE.Button == MouseButtons.Left) //left click results in chosen tile type
            {
                //change tile type (color)
                switch ((int)numericUpDownTileSelector.Value)
                {
                    case 1: tile.BackColor = Color.Black; break;
                    case 2: tile.BackColor = Color.Gray; break;
                    case 3: tile.BackColor = Color.Red; break;
                    case 4: tile.BackColor = Color.White; break;
                    case 5: tile.BackColor = Color.Blue; break;
                    case 6: tile.BackColor = Color.DarkGray; break;
                    case 7: tile.BackColor = Color.Yellow; break;
                    case 8: tile.BackColor = Color.YellowGreen; break;
                    case 9: tile.BackColor = Color.GreenYellow; break;
                    case 10: tile.BackColor = Color.Green; break;
                    case 11: tile.BackColor = Color.Green; break;
                }
            }
            else if(mouseE.Button == MouseButtons.Right) //right click always results in empty
            {
                tile.BackColor = Color.White;
            }

            //un-capture the mouse to allow for click and drag
            tile.Capture = false;

            CheckChanges();
        }

        //adds a new, empty screen and goes to that new screen
        private void buttonAddScreen_Click(object sender, EventArgs e)
        {
            //add new transitiontracker to trackers list
            trackers.Add(new TransitionTracker());

            //add new screen
            RemoveFromControls();
            AddScreenEmptyTiles();
            numericUpDownScreenAmount.Maximum++;
            numericUpDownScreenAmount.Value = (int)numericUpDownScreenAmount.Maximum;

            //increase maximum for transition selectors
            numericUpDownRight.Maximum++;
            numericUpDownLeft.Maximum++;
            numericUpDownTop.Maximum++;
            numericUpDownBottom.Maximum++;

            CheckChanges();
        }

        //removes the current screen and sets the current screen to the one below it unless current screen is 0
        private void buttonRemoveScreen_Click(object sender, EventArgs e)
        {
            if(currentScreen == 0)
            {
                MessageBox.Show("Cannot remove screen 0.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //remove current screen
                RemoveFromControls();
                screens.RemoveAt(currentScreen);

                //update current screen values
                currentScreen--;
                numericUpDownScreenAmount.Value = currentScreen;
                numericUpDownScreenAmount.Maximum--;

                //remove the trackers from the current screen (getting deleted)
                trackers.RemoveAt(currentScreen);

                //check if ANY transition tracker ints are above new max, reset if they are
                for(int i = 0; i < trackers.Count; i++)
                {
                    trackers[i].ResetIfOver((int)numericUpDownScreenAmount.Maximum);
                }

                //lessen maximum for transition selectors
                numericUpDownRight.Maximum--;
                numericUpDownLeft.Maximum--;
                numericUpDownTop.Maximum--;
                numericUpDownBottom.Maximum--;
            }

            CheckChanges();
        }

        //create and fill a screen object's 2D array of tiles with empty tiles
        //all added to groupBoxMap controls
        //used when creating a new map or a new screen
        private void AddScreenEmptyTiles()
        {
            //create a 2D array of tiles
            PictureBox[,] emptyScreen = new PictureBox[40, 25];

            //fill 2D array with empty tiles
            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    //create a new, empty tile
                    PictureBox emptyTile = new PictureBox();
                    emptyTile.BackColor = Color.White;

                    //add to groupbox controls
                    groupBoxMap.Controls.Add(emptyTile);

                    //picturebox visuals
                    emptyTile.Location = new System.Drawing.Point(10 + i * 17, 20 + j * 17);
                    emptyTile.Size = new System.Drawing.Size(16, 16);
                    emptyTile.TabIndex = 8;
                    emptyTile.TabStop = false;

                    //add to event for clicking a tile
                    emptyTile.MouseDown += ChangeTileColor;
                    emptyTile.MouseMove += ChangeTileColor;

                    //add tile to 2D array of tiles
                    emptyScreen[i, j] = emptyTile;
                }
            }

            //add 2D array to screens list
            screens.Add(emptyScreen);
        }

        //removes the tiles in the current screen from the group box controls
        private void RemoveFromControls()
        {
            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    groupBoxMap.Controls.Remove(screens[currentScreen][i, j]);
                }
            }
        }

        //update the text box when the tile selector is changed
        private void numericUpDownTileSelector_ValueChanged(object sender, EventArgs e)
        {
            switch ((int)numericUpDownTileSelector.Value)
            {
                case 1: textBoxCurrentTile.Text = "Ground"; break;
                case 2: textBoxCurrentTile.Text = "Semisolid"; break;
                case 3: textBoxCurrentTile.Text = "Hazard"; break;
                case 4: textBoxCurrentTile.Text = "Empty"; break;
                case 5: textBoxCurrentTile.Text = "Spring"; break;
                case 6: textBoxCurrentTile.Text = "NoWallJump"; break;
                case 7: textBoxCurrentTile.Text = "PlayerLeft"; break;
                case 8: textBoxCurrentTile.Text = "PlayerRight"; break;
                case 9: textBoxCurrentTile.Text = "PlayerTop"; break;
                case 10: textBoxCurrentTile.Text = "PlayerBottom"; break;
                case 11: textBoxCurrentTile.Text = "Exit"; break;
            }
        }

        //when a new screen is chosen, clear the current tiles and fill box with correct tiles
        //also update transition trackers
        private void numericUpDownScreenAmount_ValueChanged(object sender, EventArgs e)
        {
            RemoveFromControls();

            currentScreen = (int)numericUpDownScreenAmount.Value;

            UpdateEditorValues();
        }

        //transition tracker changes
        private void numericUpDownRight_ValueChanged(object sender, EventArgs e)
        {
            trackers[currentScreen].Right = (int)numericUpDownRight.Value;
            CheckChanges();
        }
        private void numericUpDownTop_ValueChanged(object sender, EventArgs e)
        {
            trackers[currentScreen].Top = (int)numericUpDownTop.Value;
            CheckChanges();
        }
        private void numericUpDownLeft_ValueChanged(object sender, EventArgs e)
        {
            trackers[currentScreen].Left = (int)numericUpDownLeft.Value;
            CheckChanges();
        }
        private void numericUpDownBottom_ValueChanged(object sender, EventArgs e)
        {
            trackers[currentScreen].Bottom = (int)numericUpDownBottom.Value;
            CheckChanges();
        }

        //if no changes are made, set changes to true and add * to title
        private void CheckChanges()
        {
            //if no changes WERE made, indicate that changes have now been made
            if (changes == false) this.Text += " *";

            changes = true;
        }

        // if unsaved changes have been made
        // prompt the user if they are sure they want to close the editor
        private void Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changes)
            {
                //messagebox prompt, cancel if they hit no
                if(MessageBox.Show("There are unsaved changes. Are you sure you want to quit?",
                    "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        // save map method
        // opens a save file dialog to let the user choose a file location
        // saves # of screens, every tile in every screen, and the list of transitions
        // updates changes to false
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //allow the user to choose a save location and save input
            SaveFileDialog saveWindow = new SaveFileDialog();
            saveWindow.Filter = "Level Files (*.level)|*.level";
            saveWindow.Title = "Save a level file.";
            DialogResult choice = saveWindow.ShowDialog();

            //if the user hit cancel, stop the method
            if (choice != DialogResult.OK)
            {
                return;
            }

            //open a streamwriter at the location the user chose
            StreamWriter output = new StreamWriter(saveWindow.FileName);

            //write # of screens
            output.WriteLine((int)numericUpDownScreenAmount.Maximum);

            //write RGB value of every tile of every screen
            for(int i = 0; i < screens.Count; i++)
            {
                for(int row = 0; row < 25; row++)
                {
                    for(int col = 0; col < 40; col++)
                    {
                        output.WriteLine(screens[i][col, row].BackColor.ToArgb());
                    }
                }
            }

            //write level transitions
            for(int i = 0; i < trackers.Count; i++)
            {
                output.WriteLine(trackers[i].Right);
                output.WriteLine(trackers[i].Top);
                output.WriteLine(trackers[i].Left);
                output.WriteLine(trackers[i].Bottom);
            }

            //close streamwriter
            output.Close();

            //upon a successful save, show a messagebox
            MessageBox.Show("File saved successfully", "File saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //update the title bar of the editor form to show the current loaded file
            Text = "Level Editor - " + saveWindow.FileName.Substring(saveWindow.FileName.LastIndexOf('\\') + 1);

            //update changes bool
            changes = false;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            //allow the user to choose a load location and save input
            OpenFileDialog loadWindow = new OpenFileDialog();
            loadWindow.Filter = "Level Files (*.level)|*.level";
            loadWindow.Title = "Load a level file.";
            DialogResult choice = loadWindow.ShowDialog();

            //if the user hit cancel, stop the method
            if (choice != DialogResult.OK)
            {
                return;
            }

            RemoveFromControls();

            LoadMap(loadWindow.FileName);

            //update changes bool
            changes = false;
        }

        private void LoadMap(string fileName)
        {
            screens = new List<PictureBox[,]>();
            trackers = new List<TransitionTracker>();

            //just in case reader fails at any point
            try
            {
                //open a streamreader at location the user chose
                StreamReader input = new StreamReader(fileName);

                //save number of screens
                int numScreens = int.Parse(input.ReadLine()) + 1;

                for (int i = 0; i < numScreens; i++)
                {
                    //create a 2D array of tiles
                    PictureBox[,] screenTiles = new PictureBox[40, 25];

                    //read in tile color values and fill 2D array
                    for(int row = 0; row < 25; row++)
                    {
                        for(int col = 0; col < 40; col++)
                        {
                            //new tile
                            PictureBox tile = new PictureBox();

                            //picturebox visuals
                            tile.BackColor = Color.FromArgb(int.Parse(input.ReadLine()));
                            tile.Location = new System.Drawing.Point(10 + col * 17, 20 + row * 17);
                            tile.Size = new System.Drawing.Size(16, 16);
                            tile.TabIndex = 8;
                            tile.TabStop = false;

                            //add to event for clicking a tile
                            tile.MouseClick += ChangeTileColor;

                            //add to 2D array of tiles
                            screenTiles[col, row] = tile;
                        }
                    }

                    //add 2D array to list of screens
                    screens.Add(screenTiles);
                }

                //fill transition tracker list
                for(int i = 0; i < numScreens; i++)
                {
                    //empty transition tracker object
                    TransitionTracker transitions = new TransitionTracker();

                    //read info to fill tracker
                    transitions.Right = int.Parse(input.ReadLine());
                    transitions.Top = int.Parse(input.ReadLine());
                    transitions.Left = int.Parse(input.ReadLine());
                    transitions.Bottom = int.Parse(input.ReadLine());

                    //add to list of transition trackers
                    trackers.Add(transitions);
                }

                numericUpDownScreenAmount.Maximum = numScreens - 1;
                numericUpDownRight.Maximum = numScreens - 1;
                numericUpDownLeft.Maximum = numScreens - 1;
                numericUpDownTop.Maximum = numScreens - 1;
                numericUpDownBottom.Maximum = numScreens - 1;

                currentScreen = 0;
                UpdateEditorValues();

                //close reader
                input.Close();
            }
            catch
            {
                //message box with error message, quit method
                MessageBox.Show("- Error reading from file", "Error Loading Map", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //upon a successful load, show a messagebox
            MessageBox.Show("File loaded successfully", "File Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //update the title bar of the editor form to show the current loaded file
            this.Text = "Level Editor - " + fileName.Substring(fileName.LastIndexOf('\\') + 1);
        }

        //adds current screens tiles to controls, updates transition tracker values
        private void UpdateEditorValues()
        {
            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    groupBoxMap.Controls.Add(screens[currentScreen][i, j]);
                }
            }

            //update transition trackers
            numericUpDownRight.Value = trackers[currentScreen].Right;
            numericUpDownLeft.Value = trackers[currentScreen].Left;
            numericUpDownTop.Value = trackers[currentScreen].Top;
            numericUpDownBottom.Value = trackers[currentScreen].Bottom;
        }
    }
}
