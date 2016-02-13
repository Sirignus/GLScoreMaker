using System;
using System.Windows.Forms;

namespace GLScoreMaker
{
	public partial class Form1 : Form
	{

		public int LevelCount, SkipCount, DeathCount;

		public float LevelMultiplier = 10f, SkipMultiplier = 2f, DeathMultiplier = 0.5f;

		public float FinalScore = 0f;

		protected System.Timers.Timer statusLabelTimer;

		public Form1 ()
		{
			InitializeComponent();

			statusLabelTimer = new System.Timers.Timer(4000f);
			statusLabelTimer.Elapsed += delegate (object s, System.Timers.ElapsedEventArgs e2) { toolStripStatusLabel1.Text = ""; statusLabelTimer.Stop(); };
			statusLabelTimer.AutoReset = false;
			toolStripStatusLabel1.TextChanged += ToolStripStatusLabel1_TextChanged;
		}

		private void Form1_Load (object sender, EventArgs e)
		{

		}

		private void ConfigurationToolStripMenuItem_Click (object sender, EventArgs e)
		{
			FormConfig form = new FormConfig();
			form.Init(LevelMultiplier, SkipMultiplier, DeathMultiplier);
			if (form.ShowDialog() == DialogResult.OK)
			{
				LevelMultiplier = form.LevelMultiplier;
				SkipMultiplier = form.SkipMultiplier;
				DeathMultiplier = form.DeathMultiplier;

				UpdateAllValues();
			}
		}

		protected void UpdateAllValues ()
		{
			LabelLevelsValue.Text = "+ " + (LevelCount * LevelMultiplier);
			LabelSkipsValue.Text = "- " + (SkipCount * SkipMultiplier);
			LabelDeathsValue.Text = "- " + (DeathCount * DeathMultiplier);

			UpdateFinalScore();
		}

		private void ButtonReset_Click (object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Es-tu sûr de vouloir remettre les valeurs à zero ?\nJ'affiche simplement ce message pour que tu n'ai pas d'excuse du style : \"Oh mince, j'ai reset sans faire exprès, on doit recommencer la race ! Quel dommage...\"",
				"Es-tu sûr ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

			if (result == DialogResult.Yes)
			{
				NumericLevels.Value = 0;
				NumericSkips.Value = 0;
				NumericDeaths.Value = 0;
			}
		}

		private void Form1_KeyDown (object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Space:
					NumericDeaths.Value++;
					e.Handled = true;
					e.SuppressKeyPress = true;
					break;
				case Keys.S:
					NumericSkips.Value++;
					e.Handled = true;
					e.SuppressKeyPress = true;
					break;
				case Keys.L:
					NumericLevels.Value++;
					e.Handled = true;
					e.SuppressKeyPress = true;
					break;
			}
		}

		private void NumericLevels_ValueChanged (object sender, EventArgs e)
		{
			LevelCount = (int)NumericLevels.Value;
			LabelLevelsValue.Text = "+ " + (LevelCount * LevelMultiplier);
			UpdateFinalScore();
		}

		private void NumericSkips_ValueChanged (object sender, EventArgs e)
		{
			if (FinalScore > 0 || NumericSkips.Value < SkipCount)
			{
				SkipCount = (int)NumericSkips.Value;
				LabelSkipsValue.Text = "- " + (SkipCount * SkipMultiplier);
				UpdateFinalScore();
			}
			else
			{
				NumericSkips.Value = SkipCount;
				toolStripStatusLabel1.Text = "Vous ne pouvez ajouter de skips si score final = 0 !";
			}
		}

		private void NumericDeaths_ValueChanged (object sender, EventArgs e)
		{
			if (FinalScore > 0 || NumericDeaths.Value < DeathCount)
			{
				DeathCount = (int)NumericDeaths.Value;
				LabelDeathsValue.Text = "- " + (DeathCount * DeathMultiplier);
				UpdateFinalScore();
			}
			else
			{
				NumericDeaths.Value = DeathCount;
				toolStripStatusLabel1.Text = "Vous ne pouvez ajouter de morts si score final = 0 !";
			}
		}


		protected void UpdateFinalScore ()
		{
			FinalScore = LevelCount * LevelMultiplier - SkipCount * SkipMultiplier - DeathCount * DeathMultiplier;
			if (FinalScore < 0)
			{
				FinalScore = 0;
			}

			TextBoxFinalScore.Text = FinalScore.ToString("N2");
		}

		private void ToolStripStatusLabel1_TextChanged (object sender, EventArgs e)
		{
			if (toolStripStatusLabel1.Text != "")
			{
				if (!statusLabelTimer.Enabled)
				{
					statusLabelTimer.Start();
				}
				else
				{
					statusLabelTimer.Stop();
					statusLabelTimer = new System.Timers.Timer(4000f);
					statusLabelTimer.Elapsed += delegate (object s, System.Timers.ElapsedEventArgs e2) { toolStripStatusLabel1.Text = ""; statusLabelTimer.Stop(); };
					statusLabelTimer.AutoReset = false;
				}
				
			}
		}
	}
}
