using System;
using System.Windows.Forms;

namespace GLScoreMaker
{
	public partial class FormConfig : Form
	{
		public float LevelMultiplier { get; set; }
		public float SkipMultiplier { get; set; }
		public float DeathMultiplier { get; set; }
		public int DeathModulo { get; set; }

		public FormConfig ()
		{
			InitializeComponent();
		}

		public void Init (float levelMultiplier, float skipMultiplier, float deathMultiplier, int deathModulo)
		{
			LevelMultiplier = levelMultiplier;
			SkipMultiplier = skipMultiplier;
			DeathMultiplier = deathMultiplier;
			DeathModulo = deathModulo;

			NumericLevelMultiplier.Value = (decimal)LevelMultiplier;
			NumericSkipMultiplier.Value = (decimal)SkipMultiplier;
			NumericDeathMultiplier.Value = (decimal)DeathMultiplier;
			NumericDeathModulo.Value = (decimal)DeathModulo;
		}

		private void NumericLevelMultiplier_ValueChanged (object sender, EventArgs e)
		{
			LevelMultiplier = (float)NumericLevelMultiplier.Value;
		}

		private void NumericSkipMultiplier_ValueChanged (object sender, EventArgs e)
		{
			SkipMultiplier = (float)NumericSkipMultiplier.Value;
		}

		private void NumericDeathMultiplier_ValueChanged (object sender, EventArgs e)
		{
			DeathMultiplier = (float)NumericDeathMultiplier.Value;
		}

		private void NumericDeathModulo_ValueChanged (object sender, EventArgs e)
		{
			DeathModulo = (int)NumericDeathModulo.Value;
		}

		private void button1_Click (object sender, EventArgs e)
		{

		}

		private void FormConfig_FormClosing (object sender, FormClosingEventArgs e)
		{
			if (DialogResult == DialogResult.OK)
			{
				DialogResult result = MessageBox.Show("Changer la configuration réinitialisera les compteurs ainsi que le score !\nEtes-vous sûr ?",
					"Etes-vous sûr ?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
				if (result == DialogResult.No)
				{
					e.Cancel = true;
				}
			}
		}

		private void label4_Click (object sender, EventArgs e)
		{

		}

		private void label5_Click (object sender, EventArgs e)
		{

		}
	}
}
