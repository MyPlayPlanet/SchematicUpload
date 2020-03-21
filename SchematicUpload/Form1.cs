using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using System.IO.Compression;

namespace SchematicUpload
{
    public partial class Schematics : Form
    {
        private UsernameManager _usernameManager;

        public Schematics()
        {
            InitializeComponent();
            var currentDirectory = Directory.GetCurrentDirectory() + "\\settings.json";
            var readAllText = File.ReadAllText(currentDirectory);
            var cfg = JsonSerializer.Deserialize<Config.Config>(readAllText);
            _usernameManager = new UsernameManager(cfg);
            textBoxSchemDir.Text = cfg.default_schem_dir;
            textBoxTargetDir.Text = cfg.default_target_dir;
        }

        private void buttonSelectDir_Click(object sender, EventArgs e)
        {
            var dialogResult = folderBrowserDialogSchemDir.ShowDialog();

            if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialogSchemDir.SelectedPath))
            {
                textBoxSchemDir.Text = folderBrowserDialogSchemDir.SelectedPath;
                currentState.Text = "Schematic Ordner erfogreich ausgewählt.";
            }else
            {
                currentState.Text = "Schematic Ordner konnte nicht ausgewählt werden.";
            }

        }

        private void buttonSelectTarget_Click(object sender, EventArgs e)
        {

            var dialogResult = folderBrowserDialogTargetDir.ShowDialog();

            if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialogTargetDir.SelectedPath))
            {
                textBoxTargetDir.Text = folderBrowserDialogTargetDir.SelectedPath;
                currentState.Text = "Ablage Ordner erfogreich ausgewählt.";
            }
            else
            {
                currentState.Text = "Ablage Ordner konnte nicht ausgewählt werden.";
            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            var schemDir = textBoxSchemDir.Text.EndsWith(@"\") ? textBoxSchemDir.Text : textBoxSchemDir.Text + @"\";
            var targetDir = textBoxTargetDir.Text.EndsWith("\\") ? textBoxTargetDir.Text : textBoxTargetDir.Text + "\\";

            if (string.IsNullOrWhiteSpace(schemDir))
            {
                currentState.Text = "Kein Schematic Ordner ausgewählt.";
                return;
            }

            if (string.IsNullOrWhiteSpace(targetDir))
            {
                currentState.Text = "Kein Ablage Ordner ausgewählt.";
                return;
            }

            if (!Directory.Exists(schemDir))
            {
                currentState.Text = "Schematic Ordner existiert nicht.";
                return;
            }

            if (!Directory.Exists(targetDir))
            {
                currentState.Text = "Ablage Ordner existiert nicht.";
                return;
            }

            var userName = textBoxUsername.Text;
            if (string.IsNullOrWhiteSpace(userName))
            {
                currentState.Text = "Kein Username angegeben.";
                return;
            }

            var guidForName = _usernameManager.GetGuidForName(userName);
            if (guidForName == Guid.Empty)
            {
                currentState.Text = $"Es existiert kein Benutzer mit dem namen {userName}.";
                return;
            }

            CreateZipForUser(userName, guidForName, schemDir, targetDir);

            currentState.Text = "Zip Datei erstellt.";
        }

        public void CreateZipForUser(string userName, Guid user, string schemDir, string targetDir)
        {
            var dir = schemDir + user;
            if (!Directory.Exists(dir))
            {
                currentState.Text = $"Es existiert keine Schematics für den Spieler {userName}.";
                return;
            }

            ZipFile.CreateFromDirectory(dir, targetDir + userName + ".zip");
        }
    }
}
