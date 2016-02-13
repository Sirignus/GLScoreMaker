namespace GLScoreMaker
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
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
		private void InitializeComponent ()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.NumericSkips = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.NumericDeaths = new System.Windows.Forms.NumericUpDown();
			this.NumericLevels = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.TextBoxFinalScore = new System.Windows.Forms.TextBox();
			this.LabelLevelsValue = new System.Windows.Forms.Label();
			this.LabelSkipsValue = new System.Windows.Forms.Label();
			this.LabelDeathsValue = new System.Windows.Forms.Label();
			this.ButtonReset = new System.Windows.Forms.Button();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumericSkips)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericDeaths)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericLevels)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 239);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(290, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConfigurationToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(290, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// ConfigurationToolStripMenuItem
			// 
			this.ConfigurationToolStripMenuItem.Name = "ConfigurationToolStripMenuItem";
			this.ConfigurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
			this.ConfigurationToolStripMenuItem.Text = "Configuration";
			this.ConfigurationToolStripMenuItem.Click += new System.EventHandler(this.ConfigurationToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(57, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Skips :";
			// 
			// NumericSkips
			// 
			this.NumericSkips.Location = new System.Drawing.Point(102, 89);
			this.NumericSkips.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.NumericSkips.Name = "NumericSkips";
			this.NumericSkips.Size = new System.Drawing.Size(62, 20);
			this.NumericSkips.TabIndex = 4;
			this.NumericSkips.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.NumericSkips.ValueChanged += new System.EventHandler(this.NumericSkips_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(57, 127);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Morts :";
			// 
			// NumericDeaths
			// 
			this.NumericDeaths.Location = new System.Drawing.Point(102, 125);
			this.NumericDeaths.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.NumericDeaths.Name = "NumericDeaths";
			this.NumericDeaths.Size = new System.Drawing.Size(62, 20);
			this.NumericDeaths.TabIndex = 6;
			this.NumericDeaths.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.NumericDeaths.ValueChanged += new System.EventHandler(this.NumericDeaths_ValueChanged);
			// 
			// NumericLevels
			// 
			this.NumericLevels.Location = new System.Drawing.Point(102, 54);
			this.NumericLevels.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.NumericLevels.Name = "NumericLevels";
			this.NumericLevels.Size = new System.Drawing.Size(62, 20);
			this.NumericLevels.TabIndex = 8;
			this.NumericLevels.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.NumericLevels.ValueChanged += new System.EventHandler(this.NumericLevels_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Levels réussis :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(121, 199);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Score Final :";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TextBoxFinalScore
			// 
			this.TextBoxFinalScore.Location = new System.Drawing.Point(193, 196);
			this.TextBoxFinalScore.Name = "TextBoxFinalScore";
			this.TextBoxFinalScore.ReadOnly = true;
			this.TextBoxFinalScore.Size = new System.Drawing.Size(60, 20);
			this.TextBoxFinalScore.TabIndex = 10;
			this.TextBoxFinalScore.Text = "0.00";
			this.TextBoxFinalScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// LabelLevelsValue
			// 
			this.LabelLevelsValue.AutoSize = true;
			this.LabelLevelsValue.Location = new System.Drawing.Point(214, 56);
			this.LabelLevelsValue.Name = "LabelLevelsValue";
			this.LabelLevelsValue.Size = new System.Drawing.Size(22, 13);
			this.LabelLevelsValue.TabIndex = 11;
			this.LabelLevelsValue.Text = "+ 0";
			this.LabelLevelsValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// LabelSkipsValue
			// 
			this.LabelSkipsValue.AutoSize = true;
			this.LabelSkipsValue.Location = new System.Drawing.Point(217, 91);
			this.LabelSkipsValue.Name = "LabelSkipsValue";
			this.LabelSkipsValue.Size = new System.Drawing.Size(19, 13);
			this.LabelSkipsValue.TabIndex = 12;
			this.LabelSkipsValue.Text = "- 0";
			this.LabelSkipsValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// LabelDeathsValue
			// 
			this.LabelDeathsValue.AutoSize = true;
			this.LabelDeathsValue.Location = new System.Drawing.Point(217, 127);
			this.LabelDeathsValue.Name = "LabelDeathsValue";
			this.LabelDeathsValue.Size = new System.Drawing.Size(19, 13);
			this.LabelDeathsValue.TabIndex = 13;
			this.LabelDeathsValue.Text = "- 0";
			this.LabelDeathsValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ButtonReset
			// 
			this.ButtonReset.Location = new System.Drawing.Point(12, 194);
			this.ButtonReset.Name = "ButtonReset";
			this.ButtonReset.Size = new System.Drawing.Size(75, 23);
			this.ButtonReset.TabIndex = 14;
			this.ButtonReset.Text = "Reset";
			this.ButtonReset.UseVisualStyleBackColor = true;
			this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(290, 261);
			this.Controls.Add(this.ButtonReset);
			this.Controls.Add(this.LabelDeathsValue);
			this.Controls.Add(this.LabelSkipsValue);
			this.Controls.Add(this.LabelLevelsValue);
			this.Controls.Add(this.TextBoxFinalScore);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.NumericLevels);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.NumericDeaths);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.NumericSkips);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "GLScoreMaker";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumericSkips)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericDeaths)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericLevels)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem ConfigurationToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown NumericSkips;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown NumericDeaths;
		private System.Windows.Forms.NumericUpDown NumericLevels;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TextBoxFinalScore;
		private System.Windows.Forms.Label LabelLevelsValue;
		private System.Windows.Forms.Label LabelSkipsValue;
		private System.Windows.Forms.Label LabelDeathsValue;
		private System.Windows.Forms.Button ButtonReset;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
	}
}

