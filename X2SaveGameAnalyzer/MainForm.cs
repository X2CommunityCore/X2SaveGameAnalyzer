using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using X2SaveDataLib;

namespace X2SaveGameAnalyzer {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
			UpdateGui(null);
		}

		private void MainForm_Load(object sender, EventArgs e) {
			Text += " " + Program.GetVersion();
		}

		private void Log(string message, TraceLevel level = TraceLevel.Info, bool newLine = true) {
			if (level != TraceLevel.Off)
				tInfo.AppendText($"{level,-8}: {message}");
			else
				tInfo.AppendText(message);

			if (newLine)
				tInfo.AppendText(Environment.NewLine);
		}

		private void LogClear() {
			tInfo.Clear();
		}

		private void bAnalyze_Click(object sender, EventArgs e) {
			string fileName = openSaveGameDialog.FileName;

			X2SaveGame saveGame = null;

			if (!File.Exists(fileName)) {
				Log("No savegame selected.", TraceLevel.Info);
				return;
			}

			try {
				saveGame = X2SaveGame.Parse(fileName);
			} catch (Exception ex) {
				Log(ex.Message, TraceLevel.Error);
				Log(ex.StackTrace, TraceLevel.Error);
			}

			UpdateGui(saveGame);
		}

		private void UpdateGui(X2SaveGame saveGame) {
			if (saveGame != null) {
				propertyGrid1.SelectedObject = saveGame;

				lVersion.Text = saveGame.Version.ToString(); ;
				lCampaign.Text = saveGame.CampaignNumber.ToString();
				lSavegame.Text = saveGame.SaveGameNumber.ToString();
				lDescription.Text = saveGame.Description;
				lMapCommand.Text = saveGame.MapCommand;
				lLanguage.Text = saveGame.Language;
				lCreated.Text = saveGame.Created.ToString();
				lLastModified.Text = saveGame.LastModified.ToString();
				lName.Text = saveGame.Name;

				tMods.Clear();
				tMods.AppendText($"{"Idx",-3} | { "DLC",-3 } | {"Designation 1",-30} | {"Designation 2",-30}");
				tMods.AppendText(Environment.NewLine);

				foreach (var item in saveGame.Mods) {
					tMods.AppendText($"{item.Index,-3} | { (item.IsDlc ? "yes" : "no"),-3} | {item.Designation1,-30} | {item.Designation2,-30}");
					tMods.AppendText(Environment.NewLine);
				}
			} else {
				lVersion.Text = "";
				lCampaign.Text = "";
				lSavegame.Text = "";
				lDescription.Text = "";
				lMapCommand.Text = "";
				lLanguage.Text = "";
				lCreated.Text = "";
				lLastModified.Text = "";
				lName.Text = "";

				tMods.Clear();
			}
		}

		private void bSelectFile_Click(object sender, EventArgs e) {
			// Try to auto-detect savegame path
			string wotcSavegamePath = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\Documents\My Games\XCOM2 War of the Chosen\XComGame\SaveData");
			string vanillaSavegamePath = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\Documents\My Games\XCOM2\XComGame\SaveData");

			if (Directory.Exists(wotcSavegamePath))
				openSaveGameDialog.InitialDirectory = wotcSavegamePath;
			else if (Directory.Exists(vanillaSavegamePath))
				openSaveGameDialog.InitialDirectory = vanillaSavegamePath;

			var result = openSaveGameDialog.ShowDialog();

			if (result == DialogResult.OK) {
				tPath.Text = Path.GetDirectoryName(openSaveGameDialog.FileName);
				tFileName.Text = Path.GetFileName(openSaveGameDialog.FileName);
			}
		}
	}
}
