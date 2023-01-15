namespace Scraper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TargetTxt = new System.Windows.Forms.TextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.DataContainer = new System.Windows.Forms.RichTextBox();
            this.ClearDataTxt = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TargetTxt
            // 
            this.TargetTxt.BackColor = System.Drawing.Color.Black;
            this.TargetTxt.ForeColor = System.Drawing.Color.White;
            this.TargetTxt.Location = new System.Drawing.Point(12, 14);
            this.TargetTxt.Name = "TargetTxt";
            this.TargetTxt.PlaceholderText = "Enter Username";
            this.TargetTxt.Size = new System.Drawing.Size(136, 23);
            this.TargetTxt.TabIndex = 0;
            this.TargetTxt.Click += new System.EventHandler(this.TargetTxt_Click);
            // 
            // RunButton
            // 
            this.RunButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RunButton.ForeColor = System.Drawing.Color.White;
            this.RunButton.Location = new System.Drawing.Point(12, 43);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(136, 62);
            this.RunButton.TabIndex = 1;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = false;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.Black;
            this.QuitButton.ForeColor = System.Drawing.Color.White;
            this.QuitButton.Location = new System.Drawing.Point(85, 156);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(63, 34);
            this.QuitButton.TabIndex = 2;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // DataContainer
            // 
            this.DataContainer.BackColor = System.Drawing.Color.Black;
            this.DataContainer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DataContainer.ForeColor = System.Drawing.Color.White;
            this.DataContainer.Location = new System.Drawing.Point(159, 12);
            this.DataContainer.Name = "DataContainer";
            this.DataContainer.ReadOnly = true;
            this.DataContainer.Size = new System.Drawing.Size(256, 178);
            this.DataContainer.TabIndex = 3;
            this.DataContainer.Text = "";
            // 
            // ClearDataTxt
            // 
            this.ClearDataTxt.BackColor = System.Drawing.Color.Black;
            this.ClearDataTxt.ForeColor = System.Drawing.Color.White;
            this.ClearDataTxt.Location = new System.Drawing.Point(12, 156);
            this.ClearDataTxt.Name = "ClearDataTxt";
            this.ClearDataTxt.Size = new System.Drawing.Size(76, 34);
            this.ClearDataTxt.TabIndex = 4;
            this.ClearDataTxt.Text = "Clear";
            this.ClearDataTxt.UseVisualStyleBackColor = false;
            this.ClearDataTxt.Click += new System.EventHandler(this.ClearDataTxt_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.BackColor = System.Drawing.Color.Black;
            this.CopyButton.ForeColor = System.Drawing.Color.White;
            this.CopyButton.Location = new System.Drawing.Point(12, 111);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(136, 39);
            this.CopyButton.TabIndex = 5;
            this.CopyButton.Text = "Copy To Clipboard";
            this.CopyButton.UseVisualStyleBackColor = false;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(427, 193);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.ClearDataTxt);
            this.Controls.Add(this.DataContainer);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.TargetTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "IG Scraper | GitHub: @BrailyGuzman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TargetTxt;
        private Button RunButton;
        private Button QuitButton;
        private RichTextBox DataContainer;
        private Button ClearDataTxt;
        private Button CopyButton;
    }
}