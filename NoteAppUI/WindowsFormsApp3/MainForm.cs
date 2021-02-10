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

            // Заполнение выпадающего списка категорий элементами.
            CategoryComboBox.Items.Add("All");
            CategoryComboBox.Items.Add(NoteCategory.Document);
            CategoryComboBox.Items.Add(NoteCategory.Finance);
            CategoryComboBox.Items.Add(NoteCategory.HealthAndSport);
            CategoryComboBox.Items.Add(NoteCategory.Home);
            CategoryComboBox.Items.Add(NoteCategory.Other);
            CategoryComboBox.Items.Add(NoteCategory.People);
            CategoryComboBox.Items.Add(NoteCategory.Work);

            if (_notes != null)
                UpdateListBox();
            else
                _notes = new Project();

            // Изначально отображаются заметки всех категорий
            CategoryComboBox.SelectedIndex = 0;
 
            ChangeVisiblePanel(true);
        }

        /// <summary>
        /// Возвращает список заметок, категория которых выбрана в CategoryComboBox,
        /// и отсортированных по времени последнего изменения.
        /// </summary>
        private List<Note> notesOfSelectedCategory()
        {
            List<Note> notesList = new List<Note>();

            if (CategoryComboBox.SelectedIndex == 0 || CategoryComboBox.SelectedItem == null)
                notesList = _notes.SortToLastChangeDate();
            else
                notesList = _notes.SortToLastChangeDate((NoteCategory)CategoryComboBox.SelectedItem);

            return notesList;
        }

        /// <summary>
        /// Обновляет список заметок на главной форме.
        /// </summary>
        private void UpdateListBox()
        {
            NoteListBox.Items.Clear();

            if (_notes != null)
            {
                List<Note> notesList = notesOfSelectedCategory();
                Note currentNote = new Note();

                for (int i = 0; i < notesList.Count; i++)
                {
                    // Если заметка имеет заголовок, он отображается в списке.
                    if (notesList[i].Title != "")
                        NoteListBox.Items.Add(notesList[i].Title);
                    // Если заметка не имеет названия, она отображается
                    // под заголовком "Без названия". 
                    else
                    {
                        NoteListBox.Items.Add("Без названия");
                    }

                    if (notesList[i].Title == _notes.CurrentNote.Title &&
                        notesList[i].Text == _notes.CurrentNote.Text &&
                        notesList[i].Category == _notes.CurrentNote.Category &&
                        notesList[i].CreationTime== _notes.CurrentNote.CreationTime &&
                        notesList[i].LastChangeTime == _notes.CurrentNote.LastChangeTime)
                    {
                        currentNote = notesList[i];
                    }
                }

                int currentNoteIndex = notesList.IndexOf(currentNote);

                if (currentNote != null && currentNoteIndex != -1)
                    NoteListBox.SetSelected(notesList.IndexOf(currentNote), true);
            }
        }

        /// <summary>
		/// Обработка события выбора записи из списка заметок.
		/// </summary>
        private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeVisiblePanel(true);
            List<Note> notesList = notesOfSelectedCategory();

            try
            {
                var selectedNote = notesList[NoteListBox.SelectedIndex];

                if (selectedNote.Title == "")
                    TitleLabel.Text = "Без названия";
                else
                    TitleLabel.Text = selectedNote.Title;

                CategoryLabel.Text = selectedNote.Category.ToString();

                CreatedDateTimePicker.Value = selectedNote.CreationTime;
                ModifiedDateTimePicker.Value = selectedNote.LastChangeTime;
                NoteTextBox.Text = selectedNote.Text;

                _notes.CurrentNote = selectedNote;
                ProjectManager.SaveToFile(_notes);
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

                    _notes.CurrentNote = editedNote;
                    //NoteListBox.Items.Insert(selectedIndex, editedNote.Title);
                    UpdateListBox();
                    //NoteListBox.SetSelected(selectedIndex, true);
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
                ChangeVisiblePanel(false);
            }

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

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBox();

            if (CategoryComboBox.SelectedIndex == 0)
                ChangeVisiblePanel(true);
            else if ((NoteCategory)CategoryComboBox.SelectedItem != _notes.CurrentNote.Category)
                ChangeVisiblePanel(false);
            else
                ChangeVisiblePanel(true);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void NoteListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                Remove();
        }
    }
}