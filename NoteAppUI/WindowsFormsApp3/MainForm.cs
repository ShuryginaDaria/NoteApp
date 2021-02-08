using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace WindowsFormsApp3
{
    /// <summary>
    /// Основная форма для работы с заметками.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список заметок, отображаемых в программе.
        /// </summary>
        private Project _notes;

        public MainForm()
        {
            InitializeComponent();

            // Загрузка данных из файла.
            _notes = ProjectManager.LoadFromFile();

            if (_notes != null)
                UpdateListBox();
            else
                _notes = new Project();

            // Заполнение выпадающего списка категорий элементами.
            CategoryComboBox.Items.Add(NoteCategory.Document);
            CategoryComboBox.Items.Add(NoteCategory.Finance);
            CategoryComboBox.Items.Add(NoteCategory.HealthAndSport);
            CategoryComboBox.Items.Add(NoteCategory.Home);
            CategoryComboBox.Items.Add(NoteCategory.Other);
            CategoryComboBox.Items.Add(NoteCategory.People);
            CategoryComboBox.Items.Add(NoteCategory.Work);

            // Изначально запись не выбрана и никакие данные не отображаются
            // на панели полной информации
            ChangeVisiblePanel(false);
        }

        /// <summary>
		/// Обновляет список заметок на главной форме.
		/// </summary>
		private void UpdateListBox()
        {
            NoteListBox.Items.Clear();

            if (_notes != null)
            {
                for (int i = 0; i < _notes.NotesList.Count; i++)
                {
                    // Если заметка имеет заголовок, он отображается в списке.
                    if (_notes.NotesList[i].Title != "")
                        NoteListBox.Items.Add(_notes.NotesList[i].Title);
                    // Если заметка не имеет названия, она отображается
                    // под заголовком "Без названия". 
                    else
                    {
                        NoteListBox.Items.Add("Без названия");
                    }  
                }
            }
        }

        /// <summary>
		/// Обработка события выбора записи из списка заметок.
		/// </summary>
        private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeVisiblePanel(true);

            try
            {
                var selectedNote = _notes.NotesList[NoteListBox.SelectedIndex];

                if (selectedNote.Title == "")
                    TitleLabel.Text = "Без названия";
                else
                    TitleLabel.Text = selectedNote.Title;

                CategoryLabel.Text = selectedNote.Category.ToString();

                CreatedDateTimePicker.Value = selectedNote.CreationTime;
                ModifiedDateTimePicker.Value = selectedNote.LastChangeTime;
                NoteTextBox.Text = selectedNote.Text;
            }
            catch
            {
                MessageBox.Show("Запись не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
		/// Изменяет видимость информации на правой панели главной формы.
		/// </summary>
		/// <remarks>Необходимо скрывать текст и элементы управления, относящиеся к определенной заметке, 
		/// в случае, когда из списка записей ничего не выбрано. При выборе записи из списка 
		/// соответствующая информация снова появляется на панели.</remarks>
		/// <param name="isVisible">true - visible, false - not visible</param>
		private void ChangeVisiblePanel(bool isVisible)
        {
            TitleLabel.Visible = isVisible;
            CategoryLabel.Visible = isVisible;
            CreatedDateTimePicker.Visible = isVisible;
            CreatedDateTimePicker.Visible = isVisible;
            ModifiedDateTimePicker.Visible = isVisible;
            ModifiedDateTimePicker.Visible = isVisible;

            if (!isVisible)
                NoteTextBox.Text = "";
        }

        /// <summary>
		/// Открывает окно AddEditForm для добавления заметки.
		/// </summary>
		private void AddNote()
        {
            var addForm = new AddEditForm();
            addForm.ShowDialog();

            if (addForm.DialogResult == DialogResult.OK)
            {
                var addedNote = addForm.NoteData;

                _notes.NotesList.Add(addedNote);
                //NoteListBox.Items.Add(addedNote);
                UpdateListBox();
            }
            else
                return;

            ProjectManager.SaveToFile(_notes);
        }

        /// <summary>
		/// Открывает окно AddEditForm для редактирования выбранной заметки.
		/// </summary>
		private void EditNote()
        {
            var selectedIndex = NoteListBox.SelectedIndex;

            if (selectedIndex == -1)
            {
                MessageBox.Show("Не выбрана запись для редактирования.", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var selectedNote = _notes.NotesList[selectedIndex];

                var editForm = new AddEditForm();
                editForm.NoteData = selectedNote;
                editForm.ShowDialog();

                if (editForm.DialogResult == DialogResult.OK)
                {
                    var editedNote = editForm.NoteData;
                    
                    // Если данные заметки были редактированы, необходимо установить новое время
                    // последнего изменения заметки.
                    if (selectedNote.Title != editedNote.Title ||selectedNote.Text != editedNote.Text ||
                        selectedNote.Category != editedNote.Category)
                    {
                        editedNote.LastChangeTime = DateTime.Now;
                    }

                    // Добавление измененной заметки на прежнее место в списке.
                    _notes.NotesList.Insert(selectedIndex, editedNote);

                    // Удаление заметки со старыми данными из списка.
                    _notes.NotesList.RemoveAt(selectedIndex + 1);

                    //NoteListBox.Items.Insert(selectedIndex, editedNote.Title);
                    UpdateListBox();
                    NoteListBox.SetSelected(selectedIndex, true);
                }
                else
                    return;
            }
            catch
            {
                MessageBox.Show("Запись не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ProjectManager.SaveToFile(_notes);
        }

        /// <summary>
		/// Удаляет выбранную заметку.
		/// </summary>
		private void Remove()
        {
            var selectedIndex = NoteListBox.SelectedIndex;

            if (selectedIndex == -1)
            {
                MessageBox.Show("Не выбрана запись для удаления.", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            var removeDialogResult = MessageBox.Show("Вы дейcтвительно хотите удалить запись " + "\"" +
                (_notes.NotesList[selectedIndex]).Title + "\"?", "Удаление записи",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (removeDialogResult == DialogResult.OK)
            {
                _notes.NotesList.RemoveAt(selectedIndex);
                UpdateListBox();
            }

            ChangeVisiblePanel(false);
            ProjectManager.SaveToFile(_notes);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void AboutToolStripMenu_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void AddNoteToolStripMenu_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        private void EditNoteToolStripMenu_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void RemoveNoteToolStripMenu_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}