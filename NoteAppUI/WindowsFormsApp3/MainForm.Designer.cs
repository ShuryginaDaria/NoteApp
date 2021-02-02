namespace WindowsFormsApp3
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ShowCategoryLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.NoteListBox = new System.Windows.Forms.ListBox();
            this.ModifiedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ModifiedTitleLabel = new System.Windows.Forms.Label();
            this.CreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreatedTitleLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryTitleLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNoteToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditNoteToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveNoteToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 36);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.RemoveButton);
            this.MainSplitContainer.Panel1.Controls.Add(this.EditButton);
            this.MainSplitContainer.Panel1.Controls.Add(this.AddButton);
            this.MainSplitContainer.Panel1.Controls.Add(this.ShowCategoryLabel);
            this.MainSplitContainer.Panel1.Controls.Add(this.CategoryComboBox);
            this.MainSplitContainer.Panel1.Controls.Add(this.NoteListBox);
            this.MainSplitContainer.Panel1MinSize = 170;
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.ModifiedDateTimePicker);
            this.MainSplitContainer.Panel2.Controls.Add(this.ModifiedTitleLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.CreatedDateTimePicker);
            this.MainSplitContainer.Panel2.Controls.Add(this.CreatedTitleLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.CategoryLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.CategoryTitleLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.TitleLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.NoteTextBox);
            this.MainSplitContainer.Panel2MinSize = 322;
            this.MainSplitContainer.Size = new System.Drawing.Size(878, 458);
            this.MainSplitContainer.SplitterDistance = 296;
            this.MainSplitContainer.TabIndex = 3;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveButton.BackgroundImage")));
            this.RemoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemoveButton.Location = new System.Drawing.Point(99, 406);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(40, 40);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditButton.BackgroundImage")));
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditButton.Location = new System.Drawing.Point(53, 406);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(40, 40);
            this.EditButton.TabIndex = 2;
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.Location = new System.Drawing.Point(7, 406);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(40, 40);
            this.AddButton.TabIndex = 1;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ShowCategoryLabel
            // 
            this.ShowCategoryLabel.AutoSize = true;
            this.ShowCategoryLabel.Location = new System.Drawing.Point(3, 9);
            this.ShowCategoryLabel.Name = "ShowCategoryLabel";
            this.ShowCategoryLabel.Size = new System.Drawing.Size(121, 20);
            this.ShowCategoryLabel.TabIndex = 0;
            this.ShowCategoryLabel.Text = "Show Category:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(130, 6);
            this.CategoryComboBox.MaximumSize = new System.Drawing.Size(220, 0);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(156, 28);
            this.CategoryComboBox.TabIndex = 0;
            // 
            // NoteListBox
            // 
            this.NoteListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteListBox.FormattingEnabled = true;
            this.NoteListBox.ItemHeight = 20;
            this.NoteListBox.Location = new System.Drawing.Point(7, 45);
            this.NoteListBox.Name = "NoteListBox";
            this.NoteListBox.Size = new System.Drawing.Size(279, 344);
            this.NoteListBox.TabIndex = 0;
            // 
            // ModifiedDateTimePicker
            // 
            this.ModifiedDateTimePicker.Enabled = false;
            this.ModifiedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ModifiedDateTimePicker.Location = new System.Drawing.Point(311, 75);
            this.ModifiedDateTimePicker.Name = "ModifiedDateTimePicker";
            this.ModifiedDateTimePicker.Size = new System.Drawing.Size(135, 26);
            this.ModifiedDateTimePicker.TabIndex = 7;
            // 
            // ModifiedTitleLabel
            // 
            this.ModifiedTitleLabel.AutoSize = true;
            this.ModifiedTitleLabel.Location = new System.Drawing.Point(232, 80);
            this.ModifiedTitleLabel.Name = "ModifiedTitleLabel";
            this.ModifiedTitleLabel.Size = new System.Drawing.Size(73, 20);
            this.ModifiedTitleLabel.TabIndex = 6;
            this.ModifiedTitleLabel.Text = "Modified:";
            // 
            // CreatedDateTimePicker
            // 
            this.CreatedDateTimePicker.Enabled = false;
            this.CreatedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CreatedDateTimePicker.Location = new System.Drawing.Point(82, 75);
            this.CreatedDateTimePicker.Name = "CreatedDateTimePicker";
            this.CreatedDateTimePicker.Size = new System.Drawing.Size(135, 26);
            this.CreatedDateTimePicker.TabIndex = 5;
            // 
            // CreatedTitleLabel
            // 
            this.CreatedTitleLabel.AutoSize = true;
            this.CreatedTitleLabel.Location = new System.Drawing.Point(4, 80);
            this.CreatedTitleLabel.Name = "CreatedTitleLabel";
            this.CreatedTitleLabel.Size = new System.Drawing.Size(70, 20);
            this.CreatedTitleLabel.TabIndex = 4;
            this.CreatedTitleLabel.Text = "Created:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(78, 45);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(89, 20);
            this.CategoryLabel.TabIndex = 3;
            this.CategoryLabel.Text = "Категория";
            // 
            // CategoryTitleLabel
            // 
            this.CategoryTitleLabel.AutoSize = true;
            this.CategoryTitleLabel.Location = new System.Drawing.Point(4, 45);
            this.CategoryTitleLabel.Name = "CategoryTitleLabel";
            this.CategoryTitleLabel.Size = new System.Drawing.Size(77, 20);
            this.CategoryTitleLabel.TabIndex = 2;
            this.CategoryTitleLabel.Text = "Category:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(3, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(212, 25);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Заголовок заметки";
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextBox.Enabled = false;
            this.NoteTextBox.Location = new System.Drawing.Point(3, 112);
            this.NoteTextBox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(563, 334);
            this.NoteTextBox.TabIndex = 0;
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenu,
            this.EditToolStripMenu,
            this.HelpToolStripMenu});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.MenuStrip.Size = new System.Drawing.Size(878, 33);
            this.MenuStrip.TabIndex = 4;
            this.MenuStrip.Text = "menuStrip";
            // 
            // FileToolStripMenu
            // 
            this.FileToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenu});
            this.FileToolStripMenu.Name = "FileToolStripMenu";
            this.FileToolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.FileToolStripMenu.Size = new System.Drawing.Size(46, 29);
            this.FileToolStripMenu.Text = "File";
            // 
            // ExitToolStripMenu
            // 
            this.ExitToolStripMenu.Image = ((System.Drawing.Image)(resources.GetObject("ExitToolStripMenu.Image")));
            this.ExitToolStripMenu.Name = "ExitToolStripMenu";
            this.ExitToolStripMenu.Size = new System.Drawing.Size(123, 30);
            this.ExitToolStripMenu.Text = "Exit";
            // 
            // EditToolStripMenu
            // 
            this.EditToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNoteToolStripMenu,
            this.EditNoteToolStripMenu,
            this.RemoveNoteToolStripMenu});
            this.EditToolStripMenu.Name = "EditToolStripMenu";
            this.EditToolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.EditToolStripMenu.Size = new System.Drawing.Size(50, 29);
            this.EditToolStripMenu.Text = "Edit";
            // 
            // AddNoteToolStripMenu
            // 
            this.AddNoteToolStripMenu.Image = ((System.Drawing.Image)(resources.GetObject("AddNoteToolStripMenu.Image")));
            this.AddNoteToolStripMenu.Name = "AddNoteToolStripMenu";
            this.AddNoteToolStripMenu.Size = new System.Drawing.Size(204, 30);
            this.AddNoteToolStripMenu.Text = "Add Note";
            // 
            // EditNoteToolStripMenu
            // 
            this.EditNoteToolStripMenu.Image = ((System.Drawing.Image)(resources.GetObject("EditNoteToolStripMenu.Image")));
            this.EditNoteToolStripMenu.Name = "EditNoteToolStripMenu";
            this.EditNoteToolStripMenu.Size = new System.Drawing.Size(204, 30);
            this.EditNoteToolStripMenu.Text = "Edit Note";
            // 
            // RemoveNoteToolStripMenu
            // 
            this.RemoveNoteToolStripMenu.Image = ((System.Drawing.Image)(resources.GetObject("RemoveNoteToolStripMenu.Image")));
            this.RemoveNoteToolStripMenu.Name = "RemoveNoteToolStripMenu";
            this.RemoveNoteToolStripMenu.Size = new System.Drawing.Size(204, 30);
            this.RemoveNoteToolStripMenu.Text = "Remove Note";
            // 
            // HelpToolStripMenu
            // 
            this.HelpToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenu});
            this.HelpToolStripMenu.Name = "HelpToolStripMenu";
            this.HelpToolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.HelpToolStripMenu.Size = new System.Drawing.Size(57, 29);
            this.HelpToolStripMenu.Text = "Help";
            // 
            // AboutToolStripMenu
            // 
            this.AboutToolStripMenu.Image = ((System.Drawing.Image)(resources.GetObject("AboutToolStripMenu.Image")));
            this.AboutToolStripMenu.Name = "AboutToolStripMenu";
            this.AboutToolStripMenu.Size = new System.Drawing.Size(146, 30);
            this.AboutToolStripMenu.Text = "About";
            this.AboutToolStripMenu.Click += new System.EventHandler(this.AboutToolStripMenu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 494);
            this.Controls.Add(this.MainSplitContainer);
            this.Controls.Add(this.MenuStrip);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel1.PerformLayout();
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            this.MainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem AddNoteToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem EditNoteToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem RemoveNoteToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenu;
        private System.Windows.Forms.ListBox NoteListBox;
        private System.Windows.Forms.Label ShowCategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.DateTimePicker ModifiedDateTimePicker;
        private System.Windows.Forms.Label ModifiedTitleLabel;
        private System.Windows.Forms.DateTimePicker CreatedDateTimePicker;
        private System.Windows.Forms.Label CreatedTitleLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label CategoryTitleLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
    }
}

