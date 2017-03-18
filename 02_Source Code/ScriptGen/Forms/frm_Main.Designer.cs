namespace ScriptGen
{
    partial class frm_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lb_Type = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lb_Location = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lb_Year = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fctb = new FastColoredTextBoxNS.FastColoredTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmd_Generate = new System.Windows.Forms.Button();
            this.cmd_About = new System.Windows.Forms.Button();
            this.cmd_Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctb)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(12, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(940, 239);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generator Parameters";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lb_Type);
            this.groupBox6.Location = new System.Drawing.Point(12, 39);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(292, 176);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Type";
            // 
            // lb_Type
            // 
            this.lb_Type.FormattingEnabled = true;
            this.lb_Type.ItemHeight = 25;
            this.lb_Type.Items.AddRange(new object[] {
            "Arrests",
            "Discipline",
            "Criminal Offense",
            "Hate Crime",
            "Vawa"});
            this.lb_Type.Location = new System.Drawing.Point(21, 30);
            this.lb_Type.Name = "lb_Type";
            this.lb_Type.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb_Type.Size = new System.Drawing.Size(253, 129);
            this.lb_Type.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lb_Location);
            this.groupBox5.Location = new System.Drawing.Point(326, 39);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(292, 176);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Location";
            // 
            // lb_Location
            // 
            this.lb_Location.FormattingEnabled = true;
            this.lb_Location.ItemHeight = 25;
            this.lb_Location.Items.AddRange(new object[] {
            "On Campus",
            "Non Campus",
            "Public Property Arrests",
            "Reported by Police",
            "Residence Hall"});
            this.lb_Location.Location = new System.Drawing.Point(15, 30);
            this.lb_Location.Name = "lb_Location";
            this.lb_Location.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb_Location.Size = new System.Drawing.Size(258, 129);
            this.lb_Location.TabIndex = 15;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lb_Year);
            this.groupBox4.Location = new System.Drawing.Point(632, 39);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(292, 176);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Year";
            // 
            // lb_Year
            // 
            this.lb_Year.FormattingEnabled = true;
            this.lb_Year.ItemHeight = 25;
            this.lb_Year.Items.AddRange(new object[] {
            "2011",
            "2012",
            "2013",
            "2014",
            "2015"});
            this.lb_Year.Location = new System.Drawing.Point(16, 30);
            this.lb_Year.Name = "lb_Year";
            this.lb_Year.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb_Year.Size = new System.Drawing.Size(258, 129);
            this.lb_Year.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fctb);
            this.groupBox2.Location = new System.Drawing.Point(12, 456);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1285, 323);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generated SQL";
            // 
            // fctb
            // 
            this.fctb.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctb.AutoIndentCharsPatterns = "";
            this.fctb.AutoIndentExistingLines = false;
            this.fctb.AutoScrollMinSize = new System.Drawing.Size(1131, 120);
            this.fctb.BackBrush = null;
            this.fctb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fctb.CharHeight = 30;
            this.fctb.CharWidth = 14;
            this.fctb.CommentPrefix = "--";
            this.fctb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctb.DelayedEventsInterval = 200;
            this.fctb.DelayedTextChangedInterval = 500;
            this.fctb.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctb.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.fctb.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.fctb.IsReplaceMode = false;
            this.fctb.Language = FastColoredTextBoxNS.Language.SQL;
            this.fctb.LeftBracket = '(';
            this.fctb.Location = new System.Drawing.Point(22, 27);
            this.fctb.Margin = new System.Windows.Forms.Padding(6);
            this.fctb.Name = "fctb";
            this.fctb.Paddings = new System.Windows.Forms.Padding(0);
            this.fctb.PreferredLineWidth = 80;
            this.fctb.ReadOnly = true;
            this.fctb.ReservedCountOfLineNumberChars = 2;
            this.fctb.RightBracket = ')';
            this.fctb.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctb.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctb.ServiceColors")));
            this.fctb.Size = new System.Drawing.Size(1246, 278);
            this.fctb.TabIndex = 7;
            this.fctb.Text = "-- Hello there =)\r\n\r\n-- Specify the required parameters for a script to be genera" +
    "ted\r\n-- You can multi-select fields by holding down control or by click + draggi" +
    "ng";
            this.fctb.Zoom = 100;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmd_Generate);
            this.groupBox3.Controls.Add(this.cmd_About);
            this.groupBox3.Controls.Add(this.cmd_Exit);
            this.groupBox3.Location = new System.Drawing.Point(969, 211);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 239);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control";
            // 
            // cmd_Generate
            // 
            this.cmd_Generate.Location = new System.Drawing.Point(18, 39);
            this.cmd_Generate.Name = "cmd_Generate";
            this.cmd_Generate.Size = new System.Drawing.Size(293, 51);
            this.cmd_Generate.TabIndex = 2;
            this.cmd_Generate.Text = "Generate";
            this.cmd_Generate.UseVisualStyleBackColor = true;
            this.cmd_Generate.Click += new System.EventHandler(this.cmd_Generate_Click);
            // 
            // cmd_About
            // 
            this.cmd_About.Location = new System.Drawing.Point(18, 103);
            this.cmd_About.Name = "cmd_About";
            this.cmd_About.Size = new System.Drawing.Size(293, 51);
            this.cmd_About.TabIndex = 1;
            this.cmd_About.Text = "About";
            this.cmd_About.UseVisualStyleBackColor = true;
            this.cmd_About.Click += new System.EventHandler(this.cmd_About_Click);
            // 
            // cmd_Exit
            // 
            this.cmd_Exit.Location = new System.Drawing.Point(18, 166);
            this.cmd_Exit.Name = "cmd_Exit";
            this.cmd_Exit.Size = new System.Drawing.Size(293, 51);
            this.cmd_Exit.TabIndex = 0;
            this.cmd_Exit.Text = "Exit";
            this.cmd_Exit.UseVisualStyleBackColor = true;
            this.cmd_Exit.Click += new System.EventHandler(this.cmd_Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1311, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 790);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScriptGen";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctb)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lb_Year;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmd_Generate;
        private System.Windows.Forms.Button cmd_About;
        private System.Windows.Forms.Button cmd_Exit;
        private FastColoredTextBoxNS.FastColoredTextBox fctb;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox lb_Type;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox lb_Location;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

