namespace WindowsFormsApp3
{
    partial class AboutForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.EmailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.GitHubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.GitHubLabel = new System.Windows.Forms.Label();
            this.CopyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(24, 29);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(15, 20, 30, 8);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(133, 32);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "NoteApp";
            // 
            // EmailLinkLabel
            // 
            this.EmailLinkLabel.AutoSize = true;
            this.EmailLinkLabel.Location = new System.Drawing.Point(174, 182);
            this.EmailLinkLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.EmailLinkLabel.Name = "EmailLinkLabel";
            this.EmailLinkLabel.Size = new System.Drawing.Size(153, 20);
            this.EmailLinkLabel.TabIndex = 1;
            this.EmailLinkLabel.TabStop = true;
            this.EmailLinkLabel.Text = "tillmedie@gmail.com";
            // 
            // GitHubLinkLabel
            // 
            this.GitHubLinkLabel.AutoSize = true;
            this.GitHubLinkLabel.Location = new System.Drawing.Point(90, 208);
            this.GitHubLinkLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.GitHubLinkLabel.Name = "GitHubLinkLabel";
            this.GitHubLinkLabel.Size = new System.Drawing.Size(185, 20);
            this.GitHubLinkLabel.TabIndex = 2;
            this.GitHubLinkLabel.TabStop = true;
            this.GitHubLinkLabel.Text = "ShuryginaDaria/NoteApp";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(26, 69);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(59, 20);
            this.VersionLabel.TabIndex = 3;
            this.VersionLabel.Text = "v. 1.0.0";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(26, 124);
            this.AuthorLabel.Margin = new System.Windows.Forms.Padding(3, 35, 3, 35);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(178, 20);
            this.AuthorLabel.TabIndex = 4;
            this.AuthorLabel.Text = "Author: Daria Shurygina";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(26, 182);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(148, 20);
            this.EmailLabel.TabIndex = 5;
            this.EmailLabel.Text = "e-mail for feedback:";
            // 
            // GitHubLabel
            // 
            this.GitHubLabel.AutoSize = true;
            this.GitHubLabel.Location = new System.Drawing.Point(26, 208);
            this.GitHubLabel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 30);
            this.GitHubLabel.Name = "GitHubLabel";
            this.GitHubLabel.Size = new System.Drawing.Size(64, 20);
            this.GitHubLabel.TabIndex = 6;
            this.GitHubLabel.Text = "GitHub:";
            // 
            // CopyLabel
            // 
            this.CopyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CopyLabel.AutoSize = true;
            this.CopyLabel.Location = new System.Drawing.Point(26, 355);
            this.CopyLabel.Margin = new System.Windows.Forms.Padding(3, 30, 3, 10);
            this.CopyLabel.Name = "CopyLabel";
            this.CopyLabel.Size = new System.Drawing.Size(177, 20);
            this.CopyLabel.TabIndex = 7;
            this.CopyLabel.Text = "2021 Daria Shurygina ©";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 394);
            this.Controls.Add(this.CopyLabel);
            this.Controls.Add(this.GitHubLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.GitHubLinkLabel);
            this.Controls.Add(this.EmailLinkLabel);
            this.Controls.Add(this.NameLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.LinkLabel EmailLinkLabel;
        private System.Windows.Forms.LinkLabel GitHubLinkLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label GitHubLabel;
        private System.Windows.Forms.Label CopyLabel;
    }
}