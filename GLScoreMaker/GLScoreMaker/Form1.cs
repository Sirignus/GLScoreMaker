using System;
using System.IO;
using System.Windows.Forms;

namespace GLScoreMaker
{
	public partial class Form1 : Form
	{
		protected int previousLevelCount, previousSkipCount, previousDeathCount;
		public int LevelCount, SkipCount, SkipEffectiveCount, DeathCount, DeathEffectiveCount;

		public float LevelMultiplier = 10f, SkipMultiplier = 2f, DeathMultiplier = 0.5f;

		public float DeathScore = 0f, SkipScore = 0f;
		protected float finalScore = 0f;
		public float FinalScore
		{
			get { return finalScore; }
			set { finalScore = value; if (finalScore < 0) { finalScore = 0; } UpdateFinalScoreText(); }
		}

		public bool ShouldUpdateFile = true;

		protected System.Timers.Timer statusLabelTimer;

		public Form1 ()
		{
			InitializeComponent();

			TryFileAuthorization();
			UpdateFile();

			statusLabelTimer = new System.Timers.Timer(4000f);
			statusLabelTimer.Elapsed += delegate (object s, System.Timers.ElapsedEventArgs e2) { toolStripStatusLabel1.Text = ""; statusLabelTimer.Stop(); };
			statusLabelTimer.AutoReset = false;
			toolStripStatusLabel1.TextChanged += ToolStripStatusLabel1_TextChanged;
		}

		protected void TryFileAuthorization ()
		{
			try
			{
				using (StreamWriter sr = new StreamWriter(Application.StartupPath + "Data.txt"))
				{
					sr.WriteLine("Levels finis : " + LevelCount);
					sr.WriteLine("Skips : " + SkipCount);
					sr.WriteLine("Morts : " + DeathCount);
					sr.WriteLine("Score : " + FinalScore);
				}
			}
			catch
			{
				MessageBox.Show("Il semble que l'application ne peut créer ou modifier le fichier texte " + Application.StartupPath + "Data.txt" + " !\n Vérifiez que vous avez les droits d'access nécessaires et relancez l'application pour que vous puissiez utiliser le fichier texte.\nSi des problèmes persistent, n'hésitez pas à m'insulter sur mon twitter : @Sirignus !",
					"Impossible de créer de fichier texte !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				ShouldUpdateFile = false;
			}
		}

		protected void UpdateFile ()
		{
			if (ShouldUpdateFile)
			{
				try
				{
					using (StreamWriter sr = new StreamWriter(Application.StartupPath + "Data.txt"))
					{
						sr.WriteLine("Levels finis : " + LevelCount);
						sr.WriteLine("Skips : " + SkipCount);
						sr.WriteLine("Morts : " + DeathCount);
						sr.WriteLine("Score : " + FinalScore);
					}
				}
				catch
				{
					toolStripStatusLabel1.Text = "Impossible de changer le fichier txt";
				}
			}
		}

		private void Form1_Load (object sender, EventArgs e)
		{

		}

		private void button3_Click (object sender, EventArgs e)
		{
			IncrementDeathCount();
		}

		private void button2_Click (object sender, EventArgs e)
		{
			IncrementSkipCount();
		}

		private void button1_Click (object sender, EventArgs e)
		{
			IncrementLevelCount();
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

				ResetScore();
			}
		}

		protected void ResetScore ()
		{
			LevelCount = 0; label5.Text = "0";
			SkipCount = 0; label6.Text = "0";
			DeathCount = 0; label7.Text = "0";

			FinalScore = 0;
			UpdateFinalScoreText();

			UpdateFile();
		}

		private void ButtonReset_Click (object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Es-tu sûr de vouloir remettre les valeurs à zero ?\nJ'affiche simplement ce message pour que tu n'ai pas d'excuse du style : \"Oh mince, j'ai reset sans faire exprès, on doit recommencer la race ! Quel dommage...\"",
				"Es-tu sûr ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

			if (result == DialogResult.Yes)
			{
				ResetScore();
			}
		}

		private void Form1_KeyDown (object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Space:
					IncrementDeathCount();
					e.Handled = true;
					e.SuppressKeyPress = true;
					break;
				case Keys.S:
					IncrementSkipCount();
					e.Handled = true;
					e.SuppressKeyPress = true;
					break;
				case Keys.L:
					IncrementLevelCount();
					e.Handled = true;
					e.SuppressKeyPress = true;
					break;
			}
		}

		protected void IncrementLevelCount ()
		{
			LevelCount++;
			label5.Text = LevelCount.ToString();

			FinalScore += LevelMultiplier;
			UpdateFinalScoreText();

			UpdateFile();
		}

		protected void IncrementSkipCount ()
		{
			SkipCount++;
			label6.Text = SkipCount.ToString();

			FinalScore -= SkipMultiplier;
			UpdateFinalScoreText();

			UpdateFile();
		}

		protected void IncrementDeathCount ()
		{
			DeathCount++;
			label7.Text = DeathCount.ToString();

			if (DeathCount % 10 == 0)
			{
				FinalScore -= 10 * DeathMultiplier;
				UpdateFinalScoreText();
			}

			UpdateFile();
		}

		protected void UpdateFinalScoreText ()
		{
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
