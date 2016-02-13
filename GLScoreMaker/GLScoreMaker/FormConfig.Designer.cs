namespace GLScoreMaker
{
	partial class FormConfig
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.NumericLevelMultiplier = new System.Windows.Forms.NumericUpDown();
			this.NumericDeathMultiplier = new System.Windows.Forms.NumericUpDown();
			this.NumericSkipMultiplier = new System.Windows.Forms.NumericUpDown();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.NumericLevelMultiplier)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericDeathMultiplier)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericSkipMultiplier)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(153, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Points gagnés par level réussi :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(41, 126);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Points perdus par mort :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(42, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Points perdus par skip :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// NumericLevelMultiplier
			// 
			this.NumericLevelMultiplier.DecimalPlaces = 2;
			this.NumericLevelMultiplier.Location = new System.Drawing.Point(165, 45);
			this.NumericLevelMultiplier.Name = "NumericLevelMultiplier";
			this.NumericLevelMultiplier.Size = new System.Drawing.Size(63, 20);
			this.NumericLevelMultiplier.TabIndex = 3;
			this.NumericLevelMultiplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.NumericLevelMultiplier.ValueChanged += new System.EventHandler(this.NumericLevelMultiplier_ValueChanged);
			// 
			// NumericDeathMultiplier
			// 
			this.NumericDeathMultiplier.DecimalPlaces = 2;
			this.NumericDeathMultiplier.Location = new System.Drawing.Point(165, 124);
			this.NumericDeathMultiplier.Name = "NumericDeathMultiplier";
			this.NumericDeathMultiplier.Size = new System.Drawing.Size(63, 20);
			this.NumericDeathMultiplier.TabIndex = 4;
			this.NumericDeathMultiplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.NumericDeathMultiplier.ValueChanged += new System.EventHandler(this.NumericDeathMultiplier_ValueChanged);
			// 
			// NumericSkipMultiplier
			// 
			this.NumericSkipMultiplier.DecimalPlaces = 2;
			this.NumericSkipMultiplier.Location = new System.Drawing.Point(165, 85);
			this.NumericSkipMultiplier.Name = "NumericSkipMultiplier";
			this.NumericSkipMultiplier.Size = new System.Drawing.Size(63, 20);
			this.NumericSkipMultiplier.TabIndex = 5;
			this.NumericSkipMultiplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.NumericSkipMultiplier.ValueChanged += new System.EventHandler(this.NumericSkipMultiplier_ValueChanged);
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(165, 157);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Valider";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FormConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(258, 192);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.NumericSkipMultiplier);
			this.Controls.Add(this.NumericDeathMultiplier);
			this.Controls.Add(this.NumericLevelMultiplier);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormConfig";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Configuration";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConfig_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.NumericLevelMultiplier)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericDeathMultiplier)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericSkipMultiplier)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown NumericLevelMultiplier;
		private System.Windows.Forms.NumericUpDown NumericDeathMultiplier;
		private System.Windows.Forms.NumericUpDown NumericSkipMultiplier;
		private System.Windows.Forms.Button button1;
	}
}