using System;
using System.IO;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Forms;

namespace GLScoreMaker
{
	public struct ScoreState
	{
		public ScoreState(int levelCount, int skipCount, int deathCount, float finalScore) 
		{
			LevelCount = levelCount;
			SkipCount = skipCount;
			DeathCount = deathCount;
			FinalScore = finalScore;
		}

		public int LevelCount, SkipCount, DeathCount;
		public float FinalScore;
	}

	public partial class Form1 : Form
	{
		#region Attributes & Properties

		protected List<ScoreState> CommandHistory;
		protected int CommandIndex;

		protected int levelCount;
		public int LevelCount
		{
			get { return levelCount; }
			set { levelCount = value; label5.Text = levelCount.ToString(); }
		}

		protected int skipCount;
		public int SkipCount
		{
			get { return skipCount; }
			set { skipCount = value; label6.Text = skipCount.ToString(); }
		}

		protected int deathCount;
		public int DeathCount
		{
			get { return deathCount; }
			set { deathCount = value; label7.Text = deathCount.ToString(); }
		}

		public float LevelMultiplier = 10f, SkipMultiplier = 2f, DeathMultiplier = 5f;
		public int DeathModulo = 10;

		public float DeathScore = 0f, SkipScore = 0f;
		protected float finalScore = 0f;
		public float FinalScore
		{
			get { return finalScore; }
			set { finalScore = value; if (finalScore < 0) { finalScore = 0; } UpdateFinalScoreText(); }
		}

		public bool ShouldUpdateFile = true;

		protected System.Timers.Timer statusLabelTimer;

		#endregion

		public Form1 ()
		{
			InitializeComponent();

			if (File.Exists(Application.StartupPath + "\\config.xml")) 
			{
				LoadConfig();
			}
			else
			{
				SaveConfig();
			}

			TryFileAuthorization();
			UpdateFile();

			CommandHistory = new List<ScoreState>();
			CommandHistory.Add(new ScoreState(0, 0, 0, 0f));

			statusLabelTimer = new System.Timers.Timer(4000f);
			statusLabelTimer.Elapsed += delegate (object s, System.Timers.ElapsedEventArgs e2) { toolStripStatusLabel1.Text = ""; statusLabelTimer.Stop(); };
			statusLabelTimer.AutoReset = false;
			toolStripStatusLabel1.TextChanged += ToolStripStatusLabel1_TextChanged;
		}

		#region CommandHistory functions

		/// <summary>
		/// Add a ScoreState to the CommandHistory list. 
		/// When adding a ScoreState, remove all remaining commands paste the CommandIndex (i.e. remove all the redos)
		/// </summary>
		/// <param name="scoreState">The ScoreState to add</param>
		protected void AddScoreStateToHistory (ScoreState scoreState) 
		{
			// When adding a new Command, remove every command paste the current
			if (CommandIndex < CommandHistory.Count - 1)  
			{
				CommandHistory.RemoveRange(CommandIndex + 1, CommandHistory.Count - 1 - CommandIndex);
			}
			CommandHistory.Add(scoreState);
			CommandIndex++;

			rétablirToolStripMenuItem.Enabled = false;
			annulerToolStripMenuItem.Enabled = true;
		}

		protected void SetNewScoreState (ScoreState scoreState) 
		{
			LevelCount = scoreState.LevelCount;
			SkipCount = scoreState.SkipCount;
			DeathCount = scoreState.DeathCount;
			FinalScore = scoreState.FinalScore;
		}

		protected void Undo () 
		{
			if (CommandIndex > 0) 
			{
				CommandIndex--;
				SetNewScoreState(CommandHistory[CommandIndex]);
			}
		}

		protected void Redo () 
		{
			if (CommandIndex < CommandHistory.Count - 1) 
			{
				CommandIndex++;
				SetNewScoreState(CommandHistory[CommandIndex]);
			}
		}

		#endregion

		protected void TryFileAuthorization ()
		{
			try
			{
				using (StreamWriter sr = new StreamWriter(Application.StartupPath + "\\" + "Data.txt"))
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
					using (StreamWriter sr = new StreamWriter(Application.StartupPath + "\\" + "Data.txt"))
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
			form.Init(LevelMultiplier, SkipMultiplier, DeathMultiplier, DeathModulo);
			if (form.ShowDialog() == DialogResult.OK)
			{
				LevelMultiplier = form.LevelMultiplier;
				SkipMultiplier = form.SkipMultiplier;
				DeathMultiplier = form.DeathMultiplier;
				DeathModulo = form.DeathModulo;

				ResetScore();

				SaveConfig();
			}
		}

		protected void ResetScore ()
		{
			LevelCount = 0; label5.Text = "0";
			SkipCount = 0; label6.Text = "0";
			DeathCount = 0; label7.Text = "0";

			FinalScore = 0;

			CommandHistory.Clear();
			CommandHistory.Add(new ScoreState(0, 0, 0, 0f));
			CommandIndex = 0;
			annulerToolStripMenuItem.Enabled = false;
			rétablirToolStripMenuItem.Enabled = false;

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

			AddScoreStateToHistory(new ScoreState(LevelCount, SkipCount, DeathCount, FinalScore));

			UpdateFinalScoreText();

			UpdateFile();
		}

		protected void IncrementSkipCount ()
		{
			SkipCount++;
			label6.Text = SkipCount.ToString();

			FinalScore -= SkipMultiplier;

			AddScoreStateToHistory(new ScoreState(LevelCount, SkipCount, DeathCount, FinalScore));

			UpdateFinalScoreText();

			UpdateFile();
		}

		private void menuStrip1_ItemClicked (object sender, ToolStripItemClickedEventArgs e) {

		}

		private void annulerToolStripMenuItem_Click (object sender, EventArgs e) {
			Undo();
			rétablirToolStripMenuItem.Enabled = true;
			if (CommandIndex <= 0) 
			{
				annulerToolStripMenuItem.Enabled = false;
			}
		}

		private void rétablirToolStripMenuItem_Click (object sender, EventArgs e) {
			Redo();
			annulerToolStripMenuItem.Enabled = true;
			if (CommandIndex >= CommandHistory.Count - 1) 
			{
				rétablirToolStripMenuItem.Enabled = false;
			}
		}

		protected void IncrementDeathCount ()
		{
			DeathCount++;
			label7.Text = DeathCount.ToString();

			if (DeathCount % DeathModulo == 0)
			{
				FinalScore -= DeathMultiplier;
				UpdateFinalScoreText();
			}

			AddScoreStateToHistory(new ScoreState(LevelCount, SkipCount, DeathCount, FinalScore));

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

		public void SaveConfig () 
		{
			try {
				XmlDocument document = new XmlDocument();
				document.AppendChild(document.CreateXmlDeclaration("1.0", "", ""));

				XmlElement GLScoreMakerElement = document.CreateElement("GLScoreMaker");
				XmlElement LevelMultiplierElement = document.CreateElement("LevelMultiplier");
				LevelMultiplierElement.AppendChild(document.CreateTextNode(LevelMultiplier.ToString()));
				XmlElement SkipMultiplierElement = document.CreateElement("SkipMultiplier");
				SkipMultiplierElement.AppendChild(document.CreateTextNode(SkipMultiplier.ToString()));
				XmlElement DeathMultiplierElement = document.CreateElement("DeathMultiplier");
				DeathMultiplierElement.AppendChild(document.CreateTextNode(DeathMultiplier.ToString()));
				XmlElement DeathModuloElement = document.CreateElement("DeathModulo");
				DeathModuloElement.AppendChild(document.CreateTextNode(DeathModulo.ToString()));

				GLScoreMakerElement.AppendChild(LevelMultiplierElement);
				GLScoreMakerElement.AppendChild(SkipMultiplierElement);
				GLScoreMakerElement.AppendChild(DeathMultiplierElement);
				GLScoreMakerElement.AppendChild(DeathModuloElement);

				document.AppendChild(GLScoreMakerElement);

				document.Save(Application.StartupPath + "\\config.xml");
			} catch {
				toolStripStatusLabel1.Text = "Impossible de sauvegarder la config";
			}
			
		}

		public void LoadConfig () 
		{
			XmlDocument document = new XmlDocument();
			try {
				document.Load(Application.StartupPath + "\\config.xml");

				XmlNodeList nodes = document["GLScoreMaker"].ChildNodes;
				foreach (XmlNode node in nodes) 
				{
					switch (node.Name) 
					{
						case "LevelMultiplier":
							LevelMultiplier = float.Parse(node.InnerText);
							break;
						case "SkipMultiplier":
							SkipMultiplier = float.Parse(node.InnerText);
							break;
						case "DeathMultiplier":
							DeathMultiplier = float.Parse(node.InnerText);
							break;
						case "DeathModulo":
							DeathModulo = int.Parse(node.InnerText);
							break;
					}
				}


			} catch {
				toolStripStatusLabel1.Text = "Impossible de récupérer la dernière config";
			}
			
		}
	}
}
