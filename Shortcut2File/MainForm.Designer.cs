namespace Tose2125.Shortcut2File
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.FolderSelectDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.FolderSelectButton = new System.Windows.Forms.Button();
            this.FolderPathLabel = new System.Windows.Forms.Label();
            this.OverWriteCheckbox = new System.Windows.Forms.CheckBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.ProgressTextbox = new System.Windows.Forms.TextBox();
            this.MoveModeCheckbox = new System.Windows.Forms.CheckBox();
            this.ProgressProgressbar = new System.Windows.Forms.ProgressBar();
            this.ShortcutDeleteCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // FolderSelectDialog
            // 
            this.FolderSelectDialog.Description = "実体ファイルに置き換えたいショートカットがあるフォルダを選択してください";
            // 
            // FolderSelectButton
            // 
            this.FolderSelectButton.Location = new System.Drawing.Point(12, 12);
            this.FolderSelectButton.Name = "FolderSelectButton";
            this.FolderSelectButton.Size = new System.Drawing.Size(93, 23);
            this.FolderSelectButton.TabIndex = 1;
            this.FolderSelectButton.Text = "フォルダを選択";
            this.FolderSelectButton.UseVisualStyleBackColor = true;
            this.FolderSelectButton.Click += new System.EventHandler(this.FolderSelectButton_Click);
            // 
            // FolderPathLabel
            // 
            this.FolderPathLabel.AutoSize = true;
            this.FolderPathLabel.Location = new System.Drawing.Point(112, 18);
            this.FolderPathLabel.Name = "FolderPathLabel";
            this.FolderPathLabel.Size = new System.Drawing.Size(0, 12);
            this.FolderPathLabel.TabIndex = 0;
            // 
            // OverWriteCheckbox
            // 
            this.OverWriteCheckbox.AutoSize = true;
            this.OverWriteCheckbox.Location = new System.Drawing.Point(12, 41);
            this.OverWriteCheckbox.Name = "OverWriteCheckbox";
            this.OverWriteCheckbox.Size = new System.Drawing.Size(139, 16);
            this.OverWriteCheckbox.TabIndex = 2;
            this.OverWriteCheckbox.Text = "コピー先ファイルを上書き";
            this.OverWriteCheckbox.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 63);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(190, 23);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "ショートカットを実体ファイルに置換";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ProgressTextbox
            // 
            this.ProgressTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressTextbox.Location = new System.Drawing.Point(12, 92);
            this.ProgressTextbox.Multiline = true;
            this.ProgressTextbox.Name = "ProgressTextbox";
            this.ProgressTextbox.ReadOnly = true;
            this.ProgressTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProgressTextbox.Size = new System.Drawing.Size(560, 337);
            this.ProgressTextbox.TabIndex = 6;
            this.ProgressTextbox.Text = "ここに結果が表示されます。";
            // 
            // MoveModeCheckbox
            // 
            this.MoveModeCheckbox.AutoSize = true;
            this.MoveModeCheckbox.Location = new System.Drawing.Point(157, 41);
            this.MoveModeCheckbox.Name = "MoveModeCheckbox";
            this.MoveModeCheckbox.Size = new System.Drawing.Size(176, 16);
            this.MoveModeCheckbox.TabIndex = 3;
            this.MoveModeCheckbox.Text = "コピー元のファイルを削除 (移動)";
            this.MoveModeCheckbox.UseVisualStyleBackColor = true;
            // 
            // ProgressProgressbar
            // 
            this.ProgressProgressbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressProgressbar.Location = new System.Drawing.Point(208, 63);
            this.ProgressProgressbar.Name = "ProgressProgressbar";
            this.ProgressProgressbar.Size = new System.Drawing.Size(364, 23);
            this.ProgressProgressbar.TabIndex = 0;
            // 
            // ShortcutDeleteCheckbox
            // 
            this.ShortcutDeleteCheckbox.AutoSize = true;
            this.ShortcutDeleteCheckbox.Location = new System.Drawing.Point(339, 41);
            this.ShortcutDeleteCheckbox.Name = "ShortcutDeleteCheckbox";
            this.ShortcutDeleteCheckbox.Size = new System.Drawing.Size(115, 16);
            this.ShortcutDeleteCheckbox.TabIndex = 4;
            this.ShortcutDeleteCheckbox.Text = "ショートカットを削除";
            this.ShortcutDeleteCheckbox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.ProgressProgressbar);
            this.Controls.Add(this.ShortcutDeleteCheckbox);
            this.Controls.Add(this.MoveModeCheckbox);
            this.Controls.Add(this.ProgressTextbox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.OverWriteCheckbox);
            this.Controls.Add(this.FolderPathLabel);
            this.Controls.Add(this.FolderSelectButton);
            this.MinimumSize = new System.Drawing.Size(600, 480);
            this.Name = "MainForm";
            this.Text = "Shortcut2File";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog FolderSelectDialog;
        private System.Windows.Forms.Button FolderSelectButton;
        private System.Windows.Forms.Label FolderPathLabel;
        private System.Windows.Forms.CheckBox OverWriteCheckbox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox ProgressTextbox;
        private System.Windows.Forms.CheckBox MoveModeCheckbox;
        private System.Windows.Forms.ProgressBar ProgressProgressbar;
        private System.Windows.Forms.CheckBox ShortcutDeleteCheckbox;
    }
}

