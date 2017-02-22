namespace AutoUpdatePage
{
    partial class AutoUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoUpdate));
            this.tbEditingFolder = new System.Windows.Forms.TextBox();
            this.tbEditingFile = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.timerCheckForUpdate = new System.Windows.Forms.Timer(this.components);
            this.rdFolder = new System.Windows.Forms.RadioButton();
            this.rdFile = new System.Windows.Forms.RadioButton();
            this.tbModifiedFile = new System.Windows.Forms.TextBox();
            this.lbOpen = new System.Windows.Forms.Label();
            this.fileDialogEditingFile = new System.Windows.Forms.OpenFileDialog();
            this.fileDialogModifiedHtmlFile = new System.Windows.Forms.OpenFileDialog();
            this.folderDialogEditingSite = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSearchFolder = new System.Windows.Forms.Button();
            this.btnSearchEditingFile = new System.Windows.Forms.Button();
            this.btnSearchModifiedFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbEditingFolder
            // 
            this.tbEditingFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEditingFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.tbEditingFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEditingFolder.Location = new System.Drawing.Point(132, 7);
            this.tbEditingFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbEditingFolder.Name = "tbEditingFolder";
            this.tbEditingFolder.Size = new System.Drawing.Size(632, 25);
            this.tbEditingFolder.TabIndex = 1;
            // 
            // tbEditingFile
            // 
            this.tbEditingFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEditingFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.tbEditingFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEditingFile.Location = new System.Drawing.Point(132, 37);
            this.tbEditingFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbEditingFile.Name = "tbEditingFile";
            this.tbEditingFile.Size = new System.Drawing.Size(632, 25);
            this.tbEditingFile.TabIndex = 4;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Location = new System.Drawing.Point(773, 101);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(96, 26);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Parar";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Location = new System.Drawing.Point(668, 101);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(96, 26);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // timerCheckForUpdate
            // 
            this.timerCheckForUpdate.Interval = 2000;
            this.timerCheckForUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // rdFolder
            // 
            this.rdFolder.AutoSize = true;
            this.rdFolder.Location = new System.Drawing.Point(15, 8);
            this.rdFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdFolder.Name = "rdFolder";
            this.rdFolder.Size = new System.Drawing.Size(96, 21);
            this.rdFolder.TabIndex = 0;
            this.rdFolder.TabStop = true;
            this.rdFolder.Text = "Toda pasta";
            this.rdFolder.UseVisualStyleBackColor = true;
            // 
            // rdFile
            // 
            this.rdFile.AutoSize = true;
            this.rdFile.Location = new System.Drawing.Point(15, 39);
            this.rdFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdFile.Name = "rdFile";
            this.rdFile.Size = new System.Drawing.Size(79, 21);
            this.rdFile.TabIndex = 3;
            this.rdFile.TabStop = true;
            this.rdFile.Text = "Arquivo";
            this.rdFile.UseVisualStyleBackColor = true;
            // 
            // tbModifiedFile
            // 
            this.tbModifiedFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbModifiedFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.tbModifiedFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbModifiedFile.Location = new System.Drawing.Point(132, 69);
            this.tbModifiedFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbModifiedFile.Name = "tbModifiedFile";
            this.tbModifiedFile.Size = new System.Drawing.Size(632, 25);
            this.tbModifiedFile.TabIndex = 5;
            // 
            // lbOpen
            // 
            this.lbOpen.AutoSize = true;
            this.lbOpen.Location = new System.Drawing.Point(35, 73);
            this.lbOpen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOpen.Name = "lbOpen";
            this.lbOpen.Size = new System.Drawing.Size(46, 17);
            this.lbOpen.TabIndex = 5;
            this.lbOpen.Text = "Abre:";
            // 
            // fileDialogEditingFile
            // 
            this.fileDialogEditingFile.FileName = "openFileDialog1";
            this.fileDialogEditingFile.Filter = "Html-Files(*.html)|*.html";
            // 
            // fileDialogModifiedHtmlFile
            // 
            this.fileDialogModifiedHtmlFile.FileName = "openFileDialog1";
            // 
            // btnSearchFolder
            // 
            this.btnSearchFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnSearchFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchFolder.Location = new System.Drawing.Point(773, 7);
            this.btnSearchFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearchFolder.Name = "btnSearchFolder";
            this.btnSearchFolder.Size = new System.Drawing.Size(96, 25);
            this.btnSearchFolder.TabIndex = 2;
            this.btnSearchFolder.Text = "Buscar";
            this.btnSearchFolder.UseVisualStyleBackColor = false;
            this.btnSearchFolder.Click += new System.EventHandler(this.btnSearchFolder_Click);
            // 
            // btnSearchEditingFile
            // 
            this.btnSearchEditingFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchEditingFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnSearchEditingFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchEditingFile.Location = new System.Drawing.Point(773, 37);
            this.btnSearchEditingFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearchEditingFile.Name = "btnSearchEditingFile";
            this.btnSearchEditingFile.Size = new System.Drawing.Size(96, 25);
            this.btnSearchEditingFile.TabIndex = 4;
            this.btnSearchEditingFile.Text = "Buscar";
            this.btnSearchEditingFile.UseVisualStyleBackColor = false;
            this.btnSearchEditingFile.Click += new System.EventHandler(this.btnSearchFile_Click);
            // 
            // btnSearchModifiedFile
            // 
            this.btnSearchModifiedFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchModifiedFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnSearchModifiedFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchModifiedFile.Location = new System.Drawing.Point(773, 68);
            this.btnSearchModifiedFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearchModifiedFile.Name = "btnSearchModifiedFile";
            this.btnSearchModifiedFile.Size = new System.Drawing.Size(96, 26);
            this.btnSearchModifiedFile.TabIndex = 6;
            this.btnSearchModifiedFile.Text = "Buscar";
            this.btnSearchModifiedFile.UseVisualStyleBackColor = false;
            this.btnSearchModifiedFile.Click += new System.EventHandler(this.btnSearchOpenFile_Click);
            // 
            // AutoUpdate
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(878, 135);
            this.Controls.Add(this.btnSearchModifiedFile);
            this.Controls.Add(this.btnSearchEditingFile);
            this.Controls.Add(this.btnSearchFolder);
            this.Controls.Add(this.lbOpen);
            this.Controls.Add(this.tbModifiedFile);
            this.Controls.Add(this.rdFile);
            this.Controls.Add(this.rdFolder);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.tbEditingFile);
            this.Controls.Add(this.tbEditingFolder);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AutoUpdate";
            this.Text = "Atualizador de Páginas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEditingFolder;
        private System.Windows.Forms.TextBox tbEditingFile;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timerCheckForUpdate;
        private System.Windows.Forms.RadioButton rdFolder;
        private System.Windows.Forms.RadioButton rdFile;
        private System.Windows.Forms.TextBox tbModifiedFile;
        private System.Windows.Forms.Label lbOpen;
        private System.Windows.Forms.OpenFileDialog fileDialogEditingFile;
        private System.Windows.Forms.OpenFileDialog fileDialogModifiedHtmlFile;
        private System.Windows.Forms.FolderBrowserDialog folderDialogEditingSite;
        private System.Windows.Forms.Button btnSearchFolder;
        private System.Windows.Forms.Button btnSearchEditingFile;
        private System.Windows.Forms.Button btnSearchModifiedFile;
    }
}

