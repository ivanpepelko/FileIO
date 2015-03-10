namespace FileIO {
    partial class FileIOWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.openButton = new System.Windows.Forms.Button();
            this.saveInButton = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.openTextBox = new System.Windows.Forms.TextBox();
            this.saveFileInTextBox = new System.Windows.Forms.TextBox();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.filePrintTextBox = new System.Windows.Forms.RichTextBox();
            this.fileInputTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveInButton
            // 
            this.saveInButton.Location = new System.Drawing.Point(15, 279);
            this.saveInButton.Name = "saveInButton";
            this.saveInButton.Size = new System.Drawing.Size(75, 23);
            this.saveInButton.TabIndex = 1;
            this.saveInButton.Text = "Save in";
            this.saveInButton.UseVisualStyleBackColor = true;
            this.saveInButton.Click += new System.EventHandler(this.saveInButton_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(497, 306);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // openTextBox
            // 
            this.openTextBox.Location = new System.Drawing.Point(93, 15);
            this.openTextBox.Name = "openTextBox";
            this.openTextBox.ReadOnly = true;
            this.openTextBox.Size = new System.Drawing.Size(479, 20);
            this.openTextBox.TabIndex = 3;
            // 
            // saveFileInTextBox
            // 
            this.saveFileInTextBox.Location = new System.Drawing.Point(96, 282);
            this.saveFileInTextBox.Name = "saveFileInTextBox";
            this.saveFileInTextBox.ReadOnly = true;
            this.saveFileInTextBox.Size = new System.Drawing.Size(476, 20);
            this.saveFileInTextBox.TabIndex = 4;
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(96, 308);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(395, 20);
            this.fileNameTextBox.TabIndex = 5;
            // 
            // filePrintTextBox
            // 
            this.filePrintTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filePrintTextBox.Location = new System.Drawing.Point(15, 64);
            this.filePrintTextBox.Name = "filePrintTextBox";
            this.filePrintTextBox.ReadOnly = true;
            this.filePrintTextBox.Size = new System.Drawing.Size(557, 96);
            this.filePrintTextBox.TabIndex = 6;
            this.filePrintTextBox.Text = "";
            // 
            // fileInputTextBox
            // 
            this.fileInputTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileInputTextBox.Location = new System.Drawing.Point(15, 179);
            this.fileInputTextBox.Name = "fileInputTextBox";
            this.fileInputTextBox.Size = new System.Drawing.Size(557, 96);
            this.fileInputTextBox.TabIndex = 7;
            this.fileInputTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "File content";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Input content";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "File name";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // FileIOWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 342);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileInputTextBox);
            this.Controls.Add(this.filePrintTextBox);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.saveFileInTextBox);
            this.Controls.Add(this.openTextBox);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.saveInButton);
            this.Controls.Add(this.openButton);
            this.MaximumSize = new System.Drawing.Size(600, 380);
            this.MinimumSize = new System.Drawing.Size(600, 380);
            this.Name = "FileIOWindow";
            this.Text = "FileIO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveInButton;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox openTextBox;
        private System.Windows.Forms.TextBox saveFileInTextBox;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.RichTextBox filePrintTextBox;
        private System.Windows.Forms.RichTextBox fileInputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;

    }
}

