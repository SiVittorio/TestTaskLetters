using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTaskLetters.Controllers;
using TestTaskLetters.Models;

namespace TestTaskLetters.Forms
{
    public partial class BaseLetterForm : Form
    {
        private bool _isOpenedLetter = false;
        private int _letterId = 0;
        private BaseLetter _letter = null;
        private BaseLetterController _letterController = new BaseLetterController();
        public BaseLetterForm()
        {
            InitializeComponent();

            editButton.Visible = false;
        }

        public BaseLetterForm(int id)
        {
            InitializeComponent();

            ChangeEditMode(false);
            _isOpenedLetter = true;
            _letterId = id;
        }

        private void ChangeEditMode(bool mode)
        {
            nameTextBox.Enabled = mode;
            subjectTextBox.Enabled = mode;
            letterNumberTextBox.Enabled = mode;
            createButton.Enabled = mode;
            editButton.Visible = !mode;
        }

        private void FillToControls(BaseLetter baseLetter)
        {
            if (baseLetter != null)
            {
                nameTextBox.Text = baseLetter.Name;
                subjectTextBox.Text = baseLetter.Subject;
                letterNumberTextBox.Text = baseLetter.DocumentNumber;
            }
        }

        private async void BaseLetterForm_Load(object sender, EventArgs e)
        {
            if (_isOpenedLetter)
            {
                _letter = await _letterController.GetAsync(_letterId);
                FillToControls(_letter);
            }
        }
        private async void createButton_Click(object sender, EventArgs e)
        {
            _letter = new BaseLetter(nameTextBox.Text, subjectTextBox.Text, letterNumberTextBox.Text) { Id = _letterId };
            if (!_isOpenedLetter)
            {
                await _letterController.InsertAsync(_letter);
            }
            else
            {
                await _letterController.UpdateAsync(_letter);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ChangeEditMode(true);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
