using System;
using System.Windows.Forms;

namespace GLScoreMaker
{
	public partial class FormConfig : Form
	{
		public float LevelMultiplier { get; set; }
		public float DeathMultiplier { get; set; }
		public float SkipMultiplier { get; set; }

		public FormConfig ()
		{
			InitializeComponent();
		}

		public void Init (float levelMultiplier, float skipMultiplier, float deathMultiplier)
		{
			LevelMultiplier = levelMultiplier;
			SkipMultiplier = skipMultiplier;
			DeathMultiplier = deathMultiplier;

			NumericLevelMultiplier.Value = (decimal)LevelMultiplier;
			NumericSkipMultiplier.Value = (decimal)SkipMultiplier;
			NumericDeathMultiplier.Value = (decimal)DeathMultiplier;
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
	}
}
