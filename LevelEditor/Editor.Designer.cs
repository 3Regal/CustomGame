
namespace LevelEditor
{
    partial class Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxTileSelect = new System.Windows.Forms.GroupBox();
            this.numericUpDownTileSelector = new System.Windows.Forms.NumericUpDown();
            this.textBoxCurrentTile = new System.Windows.Forms.TextBox();
            this.groupBoxSaveLoad = new System.Windows.Forms.GroupBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.numericUpDownScreenAmount = new System.Windows.Forms.NumericUpDown();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownBottom = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLeft = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTop = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRight = new System.Windows.Forms.NumericUpDown();
            this.labelConnections = new System.Windows.Forms.Label();
            this.buttonRemoveScreen = new System.Windows.Forms.Button();
            this.buttonAddScreen = new System.Windows.Forms.Button();
            this.labelScreenNum = new System.Windows.Forms.Label();
            this.groupBoxMap = new System.Windows.Forms.GroupBox();
            this.groupBoxTileSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTileSelector)).BeginInit();
            this.groupBoxSaveLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScreenAmount)).BeginInit();
            this.groupBoxControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRight)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTileSelect
            // 
            this.groupBoxTileSelect.Controls.Add(this.numericUpDownTileSelector);
            this.groupBoxTileSelect.Controls.Add(this.textBoxCurrentTile);
            this.groupBoxTileSelect.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTileSelect.Name = "groupBoxTileSelect";
            this.groupBoxTileSelect.Size = new System.Drawing.Size(152, 101);
            this.groupBoxTileSelect.TabIndex = 0;
            this.groupBoxTileSelect.TabStop = false;
            this.groupBoxTileSelect.Text = "Tile Select";
            // 
            // numericUpDownTileSelector
            // 
            this.numericUpDownTileSelector.Location = new System.Drawing.Point(7, 26);
            this.numericUpDownTileSelector.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.numericUpDownTileSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTileSelector.Name = "numericUpDownTileSelector";
            this.numericUpDownTileSelector.ReadOnly = true;
            this.numericUpDownTileSelector.Size = new System.Drawing.Size(139, 27);
            this.numericUpDownTileSelector.TabIndex = 1;
            this.numericUpDownTileSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTileSelector.ValueChanged += new System.EventHandler(this.numericUpDownTileSelector_ValueChanged);
            // 
            // textBoxCurrentTile
            // 
            this.textBoxCurrentTile.Location = new System.Drawing.Point(7, 59);
            this.textBoxCurrentTile.Name = "textBoxCurrentTile";
            this.textBoxCurrentTile.ReadOnly = true;
            this.textBoxCurrentTile.Size = new System.Drawing.Size(139, 27);
            this.textBoxCurrentTile.TabIndex = 0;
            this.textBoxCurrentTile.Text = "Wall";
            // 
            // groupBoxSaveLoad
            // 
            this.groupBoxSaveLoad.Controls.Add(this.buttonLoad);
            this.groupBoxSaveLoad.Controls.Add(this.buttonSave);
            this.groupBoxSaveLoad.Location = new System.Drawing.Point(12, 119);
            this.groupBoxSaveLoad.Name = "groupBoxSaveLoad";
            this.groupBoxSaveLoad.Size = new System.Drawing.Size(152, 71);
            this.groupBoxSaveLoad.TabIndex = 1;
            this.groupBoxSaveLoad.TabStop = false;
            this.groupBoxSaveLoad.Text = "Save/Load";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(78, 26);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(65, 35);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(7, 26);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(65, 35);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // numericUpDownScreenAmount
            // 
            this.numericUpDownScreenAmount.Location = new System.Drawing.Point(74, 26);
            this.numericUpDownScreenAmount.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownScreenAmount.Name = "numericUpDownScreenAmount";
            this.numericUpDownScreenAmount.Size = new System.Drawing.Size(72, 27);
            this.numericUpDownScreenAmount.TabIndex = 2;
            this.numericUpDownScreenAmount.ValueChanged += new System.EventHandler(this.numericUpDownScreenAmount_ValueChanged);
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Controls.Add(this.label4);
            this.groupBoxControls.Controls.Add(this.label3);
            this.groupBoxControls.Controls.Add(this.label2);
            this.groupBoxControls.Controls.Add(this.label1);
            this.groupBoxControls.Controls.Add(this.numericUpDownBottom);
            this.groupBoxControls.Controls.Add(this.numericUpDownLeft);
            this.groupBoxControls.Controls.Add(this.numericUpDownTop);
            this.groupBoxControls.Controls.Add(this.numericUpDownRight);
            this.groupBoxControls.Controls.Add(this.labelConnections);
            this.groupBoxControls.Controls.Add(this.buttonRemoveScreen);
            this.groupBoxControls.Controls.Add(this.buttonAddScreen);
            this.groupBoxControls.Controls.Add(this.labelScreenNum);
            this.groupBoxControls.Controls.Add(this.numericUpDownScreenAmount);
            this.groupBoxControls.Location = new System.Drawing.Point(12, 196);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Size = new System.Drawing.Size(152, 271);
            this.groupBoxControls.TabIndex = 3;
            this.groupBoxControls.TabStop = false;
            this.groupBoxControls.Text = "Level Controls";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Bottom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Left";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Top";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Right";
            // 
            // numericUpDownBottom
            // 
            this.numericUpDownBottom.Location = new System.Drawing.Point(68, 231);
            this.numericUpDownBottom.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownBottom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownBottom.Name = "numericUpDownBottom";
            this.numericUpDownBottom.Size = new System.Drawing.Size(72, 27);
            this.numericUpDownBottom.TabIndex = 10;
            this.numericUpDownBottom.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownBottom.ValueChanged += new System.EventHandler(this.numericUpDownBottom_ValueChanged);
            // 
            // numericUpDownLeft
            // 
            this.numericUpDownLeft.Location = new System.Drawing.Point(68, 198);
            this.numericUpDownLeft.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownLeft.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownLeft.Name = "numericUpDownLeft";
            this.numericUpDownLeft.Size = new System.Drawing.Size(72, 27);
            this.numericUpDownLeft.TabIndex = 9;
            this.numericUpDownLeft.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownLeft.ValueChanged += new System.EventHandler(this.numericUpDownLeft_ValueChanged);
            // 
            // numericUpDownTop
            // 
            this.numericUpDownTop.Location = new System.Drawing.Point(68, 165);
            this.numericUpDownTop.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownTop.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownTop.Name = "numericUpDownTop";
            this.numericUpDownTop.Size = new System.Drawing.Size(72, 27);
            this.numericUpDownTop.TabIndex = 8;
            this.numericUpDownTop.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownTop.ValueChanged += new System.EventHandler(this.numericUpDownTop_ValueChanged);
            // 
            // numericUpDownRight
            // 
            this.numericUpDownRight.Location = new System.Drawing.Point(68, 132);
            this.numericUpDownRight.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownRight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownRight.Name = "numericUpDownRight";
            this.numericUpDownRight.Size = new System.Drawing.Size(72, 27);
            this.numericUpDownRight.TabIndex = 7;
            this.numericUpDownRight.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownRight.ValueChanged += new System.EventHandler(this.numericUpDownRight_ValueChanged);
            // 
            // labelConnections
            // 
            this.labelConnections.AutoSize = true;
            this.labelConnections.Location = new System.Drawing.Point(28, 103);
            this.labelConnections.Name = "labelConnections";
            this.labelConnections.Size = new System.Drawing.Size(93, 20);
            this.labelConnections.TabIndex = 6;
            this.labelConnections.Text = "Connections:";
            // 
            // buttonRemoveScreen
            // 
            this.buttonRemoveScreen.Location = new System.Drawing.Point(74, 61);
            this.buttonRemoveScreen.Name = "buttonRemoveScreen";
            this.buttonRemoveScreen.Size = new System.Drawing.Size(66, 35);
            this.buttonRemoveScreen.TabIndex = 5;
            this.buttonRemoveScreen.Text = "-";
            this.buttonRemoveScreen.UseVisualStyleBackColor = true;
            this.buttonRemoveScreen.Click += new System.EventHandler(this.buttonRemoveScreen_Click);
            // 
            // buttonAddScreen
            // 
            this.buttonAddScreen.Location = new System.Drawing.Point(5, 61);
            this.buttonAddScreen.Name = "buttonAddScreen";
            this.buttonAddScreen.Size = new System.Drawing.Size(66, 35);
            this.buttonAddScreen.TabIndex = 4;
            this.buttonAddScreen.Text = "+";
            this.buttonAddScreen.UseVisualStyleBackColor = true;
            this.buttonAddScreen.Click += new System.EventHandler(this.buttonAddScreen_Click);
            // 
            // labelScreenNum
            // 
            this.labelScreenNum.AutoSize = true;
            this.labelScreenNum.Location = new System.Drawing.Point(6, 28);
            this.labelScreenNum.Name = "labelScreenNum";
            this.labelScreenNum.Size = new System.Drawing.Size(66, 20);
            this.labelScreenNum.TabIndex = 3;
            this.labelScreenNum.Text = "Screen #";
            // 
            // groupBoxMap
            // 
            this.groupBoxMap.Location = new System.Drawing.Point(179, 12);
            this.groupBoxMap.Name = "groupBoxMap";
            this.groupBoxMap.Size = new System.Drawing.Size(700, 455);
            this.groupBoxMap.TabIndex = 4;
            this.groupBoxMap.TabStop = false;
            this.groupBoxMap.Text = "Map";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 478);
            this.Controls.Add(this.groupBoxMap);
            this.Controls.Add(this.groupBoxControls);
            this.Controls.Add(this.groupBoxSaveLoad);
            this.Controls.Add(this.groupBoxTileSelect);
            this.Name = "Editor";
            this.Text = "Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Editor_FormClosing);
            this.groupBoxTileSelect.ResumeLayout(false);
            this.groupBoxTileSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTileSelector)).EndInit();
            this.groupBoxSaveLoad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScreenAmount)).EndInit();
            this.groupBoxControls.ResumeLayout(false);
            this.groupBoxControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTileSelect;
        private System.Windows.Forms.NumericUpDown numericUpDownTileSelector;
        private System.Windows.Forms.TextBox textBoxCurrentTile;
        private System.Windows.Forms.GroupBox groupBoxSaveLoad;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.NumericUpDown numericUpDownScreenAmount;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.Button buttonRemoveScreen;
        private System.Windows.Forms.Button buttonAddScreen;
        private System.Windows.Forms.Label labelScreenNum;
        private System.Windows.Forms.GroupBox groupBoxMap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownBottom;
        private System.Windows.Forms.NumericUpDown numericUpDownLeft;
        private System.Windows.Forms.NumericUpDown numericUpDownTop;
        private System.Windows.Forms.NumericUpDown numericUpDownRight;
        private System.Windows.Forms.Label labelConnections;
    }
}