namespace JRAssignment1PROG2370
{
    partial class DesignForm
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
            this.txtRows = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtColumns = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblColumns = new System.Windows.Forms.Label();
            this.btnNone = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblToolbox = new System.Windows.Forms.Label();
            this.btnYellowBox = new System.Windows.Forms.Button();
            this.btnBlueBox = new System.Windows.Forms.Button();
            this.btnGreenBox = new System.Windows.Forms.Button();
            this.btnRedBox = new System.Windows.Forms.Button();
            this.btnYellowDoor = new System.Windows.Forms.Button();
            this.btnBlueDoor = new System.Windows.Forms.Button();
            this.btnGreenDoor = new System.Windows.Forms.Button();
            this.btnRedDoor = new System.Windows.Forms.Button();
            this.btnWall = new System.Windows.Forms.Button();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(91, 68);
            this.txtRows.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(112, 26);
            this.txtRows.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1407, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // txtColumns
            // 
            this.txtColumns.Location = new System.Drawing.Point(317, 68);
            this.txtColumns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(112, 26);
            this.txtColumns.TabIndex = 2;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(482, 60);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(214, 44);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(37, 71);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(49, 20);
            this.lblRows.TabIndex = 4;
            this.lblRows.Text = "Rows";
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(241, 71);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(71, 20);
            this.lblColumns.TabIndex = 5;
            this.lblColumns.Text = "Columns";
            // 
            // btnNone
            // 
            this.btnNone.Location = new System.Drawing.Point(21, 59);
            this.btnNone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(180, 70);
            this.btnNone.TabIndex = 6;
            this.btnNone.Text = "None";
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblToolbox);
            this.panel1.Controls.Add(this.btnYellowBox);
            this.panel1.Controls.Add(this.btnBlueBox);
            this.panel1.Controls.Add(this.btnGreenBox);
            this.panel1.Controls.Add(this.btnRedBox);
            this.panel1.Controls.Add(this.btnYellowDoor);
            this.panel1.Controls.Add(this.btnBlueDoor);
            this.panel1.Controls.Add(this.btnGreenDoor);
            this.panel1.Controls.Add(this.btnRedDoor);
            this.panel1.Controls.Add(this.btnWall);
            this.panel1.Controls.Add(this.btnNone);
            this.panel1.Location = new System.Drawing.Point(0, 119);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 855);
            this.panel1.TabIndex = 7;
            // 
            // lblToolbox
            // 
            this.lblToolbox.AutoSize = true;
            this.lblToolbox.Location = new System.Drawing.Point(72, 15);
            this.lblToolbox.Name = "lblToolbox";
            this.lblToolbox.Size = new System.Drawing.Size(66, 20);
            this.lblToolbox.TabIndex = 8;
            this.lblToolbox.Text = "ToolBox";
            // 
            // btnYellowBox
            // 
            this.btnYellowBox.Location = new System.Drawing.Point(21, 756);
            this.btnYellowBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnYellowBox.Name = "btnYellowBox";
            this.btnYellowBox.Size = new System.Drawing.Size(180, 70);
            this.btnYellowBox.TabIndex = 6;
            this.btnYellowBox.Text = "Yellow Box";
            this.btnYellowBox.UseVisualStyleBackColor = true;
            this.btnYellowBox.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnBlueBox
            // 
            this.btnBlueBox.Location = new System.Drawing.Point(21, 679);
            this.btnBlueBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBlueBox.Name = "btnBlueBox";
            this.btnBlueBox.Size = new System.Drawing.Size(180, 70);
            this.btnBlueBox.TabIndex = 6;
            this.btnBlueBox.Text = "Blue Box";
            this.btnBlueBox.UseVisualStyleBackColor = true;
            this.btnBlueBox.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnGreenBox
            // 
            this.btnGreenBox.Location = new System.Drawing.Point(21, 601);
            this.btnGreenBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGreenBox.Name = "btnGreenBox";
            this.btnGreenBox.Size = new System.Drawing.Size(180, 70);
            this.btnGreenBox.TabIndex = 6;
            this.btnGreenBox.Text = "Green Box";
            this.btnGreenBox.UseVisualStyleBackColor = true;
            this.btnGreenBox.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnRedBox
            // 
            this.btnRedBox.Location = new System.Drawing.Point(21, 524);
            this.btnRedBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRedBox.Name = "btnRedBox";
            this.btnRedBox.Size = new System.Drawing.Size(180, 70);
            this.btnRedBox.TabIndex = 6;
            this.btnRedBox.Text = "Red Box";
            this.btnRedBox.UseVisualStyleBackColor = true;
            this.btnRedBox.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnYellowDoor
            // 
            this.btnYellowDoor.Location = new System.Drawing.Point(21, 446);
            this.btnYellowDoor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnYellowDoor.Name = "btnYellowDoor";
            this.btnYellowDoor.Size = new System.Drawing.Size(180, 70);
            this.btnYellowDoor.TabIndex = 6;
            this.btnYellowDoor.Text = "Yellow Door";
            this.btnYellowDoor.UseVisualStyleBackColor = true;
            this.btnYellowDoor.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnBlueDoor
            // 
            this.btnBlueDoor.Location = new System.Drawing.Point(21, 369);
            this.btnBlueDoor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBlueDoor.Name = "btnBlueDoor";
            this.btnBlueDoor.Size = new System.Drawing.Size(180, 70);
            this.btnBlueDoor.TabIndex = 6;
            this.btnBlueDoor.Text = "Blue Door";
            this.btnBlueDoor.UseVisualStyleBackColor = true;
            this.btnBlueDoor.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnGreenDoor
            // 
            this.btnGreenDoor.Location = new System.Drawing.Point(21, 291);
            this.btnGreenDoor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGreenDoor.Name = "btnGreenDoor";
            this.btnGreenDoor.Size = new System.Drawing.Size(180, 70);
            this.btnGreenDoor.TabIndex = 6;
            this.btnGreenDoor.Text = "Green Door";
            this.btnGreenDoor.UseVisualStyleBackColor = true;
            this.btnGreenDoor.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnRedDoor
            // 
            this.btnRedDoor.Location = new System.Drawing.Point(21, 214);
            this.btnRedDoor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRedDoor.Name = "btnRedDoor";
            this.btnRedDoor.Size = new System.Drawing.Size(180, 70);
            this.btnRedDoor.TabIndex = 6;
            this.btnRedDoor.Text = "Red Door";
            this.btnRedDoor.UseVisualStyleBackColor = true;
            this.btnRedDoor.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnWall
            // 
            this.btnWall.Location = new System.Drawing.Point(21, 136);
            this.btnWall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWall.Name = "btnWall";
            this.btnWall.Size = new System.Drawing.Size(180, 70);
            this.btnWall.TabIndex = 6;
            this.btnWall.Text = "Wall";
            this.btnWall.UseVisualStyleBackColor = true;
            this.btnWall.Click += new System.EventHandler(this.btn_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Location = new System.Drawing.Point(242, 119);
            this.pnlGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1166, 911);
            this.pnlGrid.TabIndex = 8;
            // 
            // DesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 1034);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblColumns);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtColumns);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DesignForm";
            this.Text = "DesignForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TextBox txtColumns;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblToolbox;
        private System.Windows.Forms.Button btnYellowBox;
        private System.Windows.Forms.Button btnBlueBox;
        private System.Windows.Forms.Button btnGreenBox;
        private System.Windows.Forms.Button btnRedBox;
        private System.Windows.Forms.Button btnYellowDoor;
        private System.Windows.Forms.Button btnBlueDoor;
        private System.Windows.Forms.Button btnGreenDoor;
        private System.Windows.Forms.Button btnRedDoor;
        private System.Windows.Forms.Button btnWall;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}