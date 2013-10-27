namespace FileToBase64
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ButtonOpenFile = new System.Windows.Forms.Button();
            this.ButtonConvertToBase64 = new System.Windows.Forms.Button();
            this.ButtonCopy = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonTextWrap = new System.Windows.Forms.CheckBox();
            this.fullFileName = new System.Windows.Forms.Label();
            this.lengthBase64String = new System.Windows.Forms.Label();
            this.fileSize = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this._fileSize = new FileToBase64.DStyle.DTextBox();
            this._lengthBase64String = new FileToBase64.DStyle.DTextBox();
            this._fullFileName = new FileToBase64.DStyle.DTextBox();
            this._stringBase64 = new FileToBase64.DStyle.DRichTextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.lSeparator = new System.Windows.Forms.Label();
            this.panelBase64 = new System.Windows.Forms.Panel();
            this.panelBase64.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonOpenFile
            // 
            this.ButtonOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonOpenFile.Location = new System.Drawing.Point(11, 212);
            this.ButtonOpenFile.Name = "ButtonOpenFile";
            this.ButtonOpenFile.Size = new System.Drawing.Size(130, 22);
            this.ButtonOpenFile.TabIndex = 8;
            this.ButtonOpenFile.Text = "Выбрать";
            this.ButtonOpenFile.UseVisualStyleBackColor = true;
            this.ButtonOpenFile.Click += new System.EventHandler(this.ButtonOpenFile_Click);
            // 
            // ButtonConvertToBase64
            // 
            this.ButtonConvertToBase64.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonConvertToBase64.Location = new System.Drawing.Point(146, 212);
            this.ButtonConvertToBase64.Name = "ButtonConvertToBase64";
            this.ButtonConvertToBase64.Size = new System.Drawing.Size(130, 22);
            this.ButtonConvertToBase64.TabIndex = 9;
            this.ButtonConvertToBase64.Text = "Преобразовать";
            this.ButtonConvertToBase64.UseVisualStyleBackColor = true;
            this.ButtonConvertToBase64.Click += new System.EventHandler(this.ButtonConvertToBase64_Click);
            // 
            // ButtonCopy
            // 
            this.ButtonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonCopy.Location = new System.Drawing.Point(11, 240);
            this.ButtonCopy.Name = "ButtonCopy";
            this.ButtonCopy.Size = new System.Drawing.Size(130, 22);
            this.ButtonCopy.TabIndex = 10;
            this.ButtonCopy.Text = "Скопировать";
            this.ButtonCopy.UseVisualStyleBackColor = true;
            this.ButtonCopy.Click += new System.EventHandler(this.ButtonCopy_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonClose.Location = new System.Drawing.Point(146, 268);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(130, 22);
            this.ButtonClose.TabIndex = 13;
            this.ButtonClose.Text = "Закрыть";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonClear.Location = new System.Drawing.Point(11, 268);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(130, 22);
            this.ButtonClear.TabIndex = 12;
            this.ButtonClear.Text = "Очистить";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonTextWrap
            // 
            this.ButtonTextWrap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonTextWrap.AutoSize = true;
            this.ButtonTextWrap.BackColor = System.Drawing.Color.Transparent;
            this.ButtonTextWrap.Checked = true;
            this.ButtonTextWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ButtonTextWrap.Location = new System.Drawing.Point(12, 193);
            this.ButtonTextWrap.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonTextWrap.Name = "ButtonTextWrap";
            this.ButtonTextWrap.Size = new System.Drawing.Size(107, 17);
            this.ButtonTextWrap.TabIndex = 7;
            this.ButtonTextWrap.Text = "Перенос текста";
            this.ButtonTextWrap.UseVisualStyleBackColor = false;
            this.ButtonTextWrap.Visible = false;
            this.ButtonTextWrap.CheckedChanged += new System.EventHandler(this.ButtonTextWrap_CheckedChanged);
            // 
            // fullFileName
            // 
            this.fullFileName.AutoSize = true;
            this.fullFileName.BackColor = System.Drawing.Color.Transparent;
            this.fullFileName.Location = new System.Drawing.Point(8, 39);
            this.fullFileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fullFileName.Name = "fullFileName";
            this.fullFileName.Size = new System.Drawing.Size(106, 13);
            this.fullFileName.TabIndex = 0;
            this.fullFileName.Text = "Полное имя файла:";
            // 
            // lengthBase64String
            // 
            this.lengthBase64String.AutoSize = true;
            this.lengthBase64String.BackColor = System.Drawing.Color.Transparent;
            this.lengthBase64String.Location = new System.Drawing.Point(8, 117);
            this.lengthBase64String.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lengthBase64String.Name = "lengthBase64String";
            this.lengthBase64String.Size = new System.Drawing.Size(125, 13);
            this.lengthBase64String.TabIndex = 4;
            this.lengthBase64String.Text = "Размер строки base64:";
            // 
            // fileSize
            // 
            this.fileSize.AutoSize = true;
            this.fileSize.BackColor = System.Drawing.Color.Transparent;
            this.fileSize.Location = new System.Drawing.Point(8, 78);
            this.fileSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fileSize.Name = "fileSize";
            this.fileSize.Size = new System.Drawing.Size(139, 13);
            this.fileSize.TabIndex = 2;
            this.fileSize.Text = "Размер исходного файла:";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // _fileSize
            // 
            this._fileSize.BackColor = System.Drawing.Color.White;
            this._fileSize.Location = new System.Drawing.Point(11, 93);
            this._fileSize.Margin = new System.Windows.Forms.Padding(2);
            this._fileSize.Name = "_fileSize";
            this._fileSize.ReadOnly = true;
            this._fileSize.Size = new System.Drawing.Size(265, 20);
            this._fileSize.TabIndex = 3;
            // 
            // _lengthBase64String
            // 
            this._lengthBase64String.BackColor = System.Drawing.Color.White;
            this._lengthBase64String.Location = new System.Drawing.Point(11, 132);
            this._lengthBase64String.Margin = new System.Windows.Forms.Padding(2);
            this._lengthBase64String.Name = "_lengthBase64String";
            this._lengthBase64String.ReadOnly = true;
            this._lengthBase64String.Size = new System.Drawing.Size(265, 20);
            this._lengthBase64String.TabIndex = 5;
            // 
            // _fullFileName
            // 
            this._fullFileName.BackColor = System.Drawing.Color.White;
            this._fullFileName.Location = new System.Drawing.Point(11, 54);
            this._fullFileName.Margin = new System.Windows.Forms.Padding(2);
            this._fullFileName.Name = "_fullFileName";
            this._fullFileName.ReadOnly = true;
            this._fullFileName.Size = new System.Drawing.Size(265, 20);
            this._fullFileName.TabIndex = 1;
            // 
            // _stringBase64
            // 
            this._stringBase64.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._stringBase64.BackColor = System.Drawing.Color.White;
            this._stringBase64.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._stringBase64.Location = new System.Drawing.Point(1, 1);
            this._stringBase64.Margin = new System.Windows.Forms.Padding(1);
            this._stringBase64.Name = "_stringBase64";
            this._stringBase64.ReadOnly = true;
            this._stringBase64.ShowSelectionMargin = true;
            this._stringBase64.Size = new System.Drawing.Size(395, 253);
            this._stringBase64.TabIndex = 6;
            this._stringBase64.Text = "";
            this._stringBase64.ZoomFactor = 0.8F;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonSave.Location = new System.Drawing.Point(146, 240);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(130, 22);
            this.ButtonSave.TabIndex = 11;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ButtonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStop.Location = new System.Drawing.Point(299, 229);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(75, 23);
            this.ButtonStop.TabIndex = 14;
            this.ButtonStop.Text = "Прервать";
            this.ButtonStop.UseVisualStyleBackColor = false;
            this.ButtonStop.Visible = false;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // lSeparator
            // 
            this.lSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lSeparator.BackColor = System.Drawing.Color.Transparent;
            this.lSeparator.Image = global::FileToBase64.Properties.Resources.main_line;
            this.lSeparator.Location = new System.Drawing.Point(278, 35);
            this.lSeparator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lSeparator.Name = "lSeparator";
            this.lSeparator.Size = new System.Drawing.Size(10, 252);
            this.lSeparator.TabIndex = 15;
            // 
            // panelBase64
            // 
            this.panelBase64.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBase64.BackColor = System.Drawing.Color.LightGray;
            this.panelBase64.Controls.Add(this.ButtonStop);
            this.panelBase64.Controls.Add(this._stringBase64);
            this.panelBase64.Location = new System.Drawing.Point(293, 34);
            this.panelBase64.Name = "panelBase64";
            this.panelBase64.Size = new System.Drawing.Size(397, 255);
            this.panelBase64.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 300);
            this.Controls.Add(this.panelBase64);
            this.Controls.Add(this.ButtonOpenFile);
            this.Controls.Add(this.lSeparator);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this._lengthBase64String);
            this.Controls.Add(this.lengthBase64String);
            this.Controls.Add(this._fileSize);
            this.Controls.Add(this.fileSize);
            this.Controls.Add(this._fullFileName);
            this.Controls.Add(this.fullFileName);
            this.Controls.Add(this.ButtonTextWrap);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonCopy);
            this.Controls.Add(this.ButtonConvertToBase64);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileToBase64";
            this.Controls.SetChildIndex(this.ButtonConvertToBase64, 0);
            this.Controls.SetChildIndex(this.ButtonCopy, 0);
            this.Controls.SetChildIndex(this.ButtonClose, 0);
            this.Controls.SetChildIndex(this.ButtonClear, 0);
            this.Controls.SetChildIndex(this.ButtonTextWrap, 0);
            this.Controls.SetChildIndex(this.fullFileName, 0);
            this.Controls.SetChildIndex(this._fullFileName, 0);
            this.Controls.SetChildIndex(this.fileSize, 0);
            this.Controls.SetChildIndex(this._fileSize, 0);
            this.Controls.SetChildIndex(this.lengthBase64String, 0);
            this.Controls.SetChildIndex(this._lengthBase64String, 0);
            this.Controls.SetChildIndex(this.ButtonSave, 0);
            this.Controls.SetChildIndex(this.lSeparator, 0);
            this.Controls.SetChildIndex(this.ButtonOpenFile, 0);
            this.Controls.SetChildIndex(this.panelBase64, 0);
            this.panelBase64.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region VARIABLES CLASS:

        private System.Windows.Forms.Button ButtonOpenFile;
        private System.Windows.Forms.Button ButtonConvertToBase64;
        private System.Windows.Forms.Button ButtonCopy;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.CheckBox ButtonTextWrap;
        private System.Windows.Forms.Label fullFileName;
        private System.Windows.Forms.Label lengthBase64String;
        private System.Windows.Forms.Label fileSize;
        private System.ComponentModel.BackgroundWorker backgroundWorker;

        private DStyle.DTextBox _fullFileName;
        private DStyle.DTextBox _lengthBase64String;
        private DStyle.DTextBox _fileSize;        
        private DStyle.DRichTextBox _stringBase64;

        #endregion VARIABLES CLASS:
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Label lSeparator;
        private System.Windows.Forms.Panel panelBase64;
    }
}

