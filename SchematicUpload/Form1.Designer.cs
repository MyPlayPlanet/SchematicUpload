namespace SchematicUpload
{
    partial class Schematics
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitleSearcherFromDir = new System.Windows.Forms.Label();
            this.lableTargetLocation = new System.Windows.Forms.Label();
            this.textBoxSchemDir = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.textBoxTargetDir = new System.Windows.Forms.TextBox();
            this.currentState = new System.Windows.Forms.Label();
            this.buttonSelectDir = new System.Windows.Forms.Button();
            this.buttonSelectTarget = new System.Windows.Forms.Button();
            this.folderBrowserDialogSchemDir = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogTargetDir = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitleSearcherFromDir
            // 
            this.labelTitleSearcherFromDir.AutoSize = true;
            this.labelTitleSearcherFromDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleSearcherFromDir.Location = new System.Drawing.Point(12, 22);
            this.labelTitleSearcherFromDir.Name = "labelTitleSearcherFromDir";
            this.labelTitleSearcherFromDir.Size = new System.Drawing.Size(184, 25);
            this.labelTitleSearcherFromDir.TabIndex = 1;
            this.labelTitleSearcherFromDir.Text = "Schematic Ordner";
            // 
            // lableTargetLocation
            // 
            this.lableTargetLocation.AutoSize = true;
            this.lableTargetLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableTargetLocation.Location = new System.Drawing.Point(12, 92);
            this.lableTargetLocation.Name = "lableTargetLocation";
            this.lableTargetLocation.Size = new System.Drawing.Size(119, 25);
            this.lableTargetLocation.TabIndex = 2;
            this.lableTargetLocation.Text = "Ziel Ordner";
            // 
            // textBoxSchemDir
            // 
            this.textBoxSchemDir.Location = new System.Drawing.Point(17, 60);
            this.textBoxSchemDir.Name = "textBoxSchemDir";
            this.textBoxSchemDir.Size = new System.Drawing.Size(179, 20);
            this.textBoxSchemDir.TabIndex = 3;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(17, 239);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(219, 37);
            this.buttonConvert.TabIndex = 4;
            this.buttonConvert.Text = "Konvertieren";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // textBoxTargetDir
            // 
            this.textBoxTargetDir.Location = new System.Drawing.Point(17, 120);
            this.textBoxTargetDir.Name = "textBoxTargetDir";
            this.textBoxTargetDir.Size = new System.Drawing.Size(179, 20);
            this.textBoxTargetDir.TabIndex = 5;
            // 
            // currentState
            // 
            this.currentState.AutoSize = true;
            this.currentState.Location = new System.Drawing.Point(17, 223);
            this.currentState.Name = "currentState";
            this.currentState.Size = new System.Drawing.Size(0, 13);
            this.currentState.TabIndex = 6;
            // 
            // buttonSelectDir
            // 
            this.buttonSelectDir.Location = new System.Drawing.Point(203, 60);
            this.buttonSelectDir.Name = "buttonSelectDir";
            this.buttonSelectDir.Size = new System.Drawing.Size(33, 20);
            this.buttonSelectDir.TabIndex = 7;
            this.buttonSelectDir.Text = "...";
            this.buttonSelectDir.UseVisualStyleBackColor = true;
            this.buttonSelectDir.Click += new System.EventHandler(this.buttonSelectDir_Click);
            // 
            // buttonSelectTarget
            // 
            this.buttonSelectTarget.Location = new System.Drawing.Point(203, 120);
            this.buttonSelectTarget.Name = "buttonSelectTarget";
            this.buttonSelectTarget.Size = new System.Drawing.Size(33, 20);
            this.buttonSelectTarget.TabIndex = 8;
            this.buttonSelectTarget.Text = "...";
            this.buttonSelectTarget.UseVisualStyleBackColor = true;
            this.buttonSelectTarget.Click += new System.EventHandler(this.buttonSelectTarget_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(20, 185);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(216, 20);
            this.textBoxUsername.TabIndex = 9;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(12, 157);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(110, 25);
            this.labelUserName.TabIndex = 10;
            this.labelUserName.Text = "Username";
            // 
            // Schematics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 296);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.buttonSelectTarget);
            this.Controls.Add(this.buttonSelectDir);
            this.Controls.Add(this.currentState);
            this.Controls.Add(this.textBoxTargetDir);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBoxSchemDir);
            this.Controls.Add(this.lableTargetLocation);
            this.Controls.Add(this.labelTitleSearcherFromDir);
            this.Name = "Schematics";
            this.Text = "Schematics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitleSearcherFromDir;
        private System.Windows.Forms.Label lableTargetLocation;
        private System.Windows.Forms.TextBox textBoxSchemDir;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.TextBox textBoxTargetDir;
        private System.Windows.Forms.Label currentState;
        private System.Windows.Forms.Button buttonSelectDir;
        private System.Windows.Forms.Button buttonSelectTarget;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSchemDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogTargetDir;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUserName;
    }
}

