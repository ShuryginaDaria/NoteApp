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
    /// Форма для добавления или редактирования заметки.
    /// </summary>
    public partial class AddEditForm : Form
    {
        // Данные заметки для изменения и передачи во внешнюю форму
        private Note _noteData = new Note();

        /// <summary>
		/// Возвращает и задает данные формы.
		/// </summary>
		public Note NoteData
		{
			get
			{
				return _noteData;
			}
			set 
			{
				_noteData = (Note)value.Clone();
                DisplayNote();
            }
		}

        public AddEditForm()
        {
            InitializeComponent();

            // Заполнение выпадающего списка категорий элементами.
            CategoryComboBox.Items.Add(NoteCategory.Document);
            CategoryComboBox.Items.Add(NoteCategory.Finance);
            CategoryComboBox.Items.Add(NoteCategory.HealthAndSport);
            CategoryComboBox.Items.Add(NoteCategory.Home);
            CategoryComboBox.Items.Add(NoteCategory.Other);
            CategoryComboBox.Items.Add(NoteCategory.People);
            CategoryComboBox.Items.Add(NoteCategory.Work);

            if (_noteData != null)
                DisplayNote();
        }

        /// <summary>
		/// Отображает имеющиеся данные по заметке.
		/// </summary>
		public void DisplayNote()
        {
            if (_noteData == null)
            {
                CreatedDateTimePicker.Value = DateTime.Now;
                ModifiedDateTimePicker.Value = DateTime.Now;

                return;
            }

            TitleTextBox.Text = _noteData.Title;
            CategoryComboBox.SelectedItem = _noteData.Category;
            NoteTextBox.Text = _noteData.Text;
            CreatedDateTimePicker.Value = _noteData.CreationTime;
            ModifiedDateTimePicker.Value = _noteData.LastChangeTime;
        }

        /// <summary>
		/// Обрабатывает событие изменения текста заголовка.
		/// </summary>
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (TitleTextBox.Text.Length <= 50)
                TitleTextBox.BackColor = Color.Empty;
        }

        /// <summary>
		/// Выбор категории заметки из списка.
		/// </summary>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _noteData.Category = (NoteCategory)CategoryComboBox.SelectedItem;

            // Изменение цвета элемента на стандартный на случай,
            // если ранее он был изменен из-за ошибки создания или редактирования
            CategoryComboBox.BackColor = Color.Empty;
        }

        /// <summary>
		/// Обрабатывает событие изменения основного текста заметки.
		/// </summary>
        private void NoteTextBox_TextChanged(object sender, EventArgs e)
        {
            _noteData.Text = NoteTextBox.Text;
        }

        /// <summary>
		/// Возвращает результат диалога "OK".
		/// </summary>
        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                _noteData.Title = TitleTextBox.Text;
            }
            catch (ArgumentException exception)
            {
                TitleTextBox.BackColor = Color.Red;

                MessageBox.Show(exception.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (CategoryComboBox.SelectedIndex == -1)
            {
                CategoryComboBox.BackColor = Color.Red;

                MessageBox.Show("Не выбрана категория категория заметки.", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
		/// Возвращает результат диалога "Cancel".
		/// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}