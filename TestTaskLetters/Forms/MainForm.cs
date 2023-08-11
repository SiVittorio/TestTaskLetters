using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTaskLetters.Controllers;
using TestTaskLetters.Models;
using TestTaskLetters.Utilities;

namespace TestTaskLetters.Forms
{
    public partial class MainForm : Form
    {
        private Type _letterType = typeof(BaseLetter);
        private BaseLetterController _baseLetterController = new BaseLetterController();
        private IncomingLetterController _incomingLetterController = new IncomingLetterController();

        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            LettersDataGridViewDataBinder.LoadToDataGridView(lettersDataGridView, await _baseLetterController.GetAllAsync());
            baseLettersButton.Enabled = false;
        }

        private async void baseLettersButton_Click(object sender, EventArgs e)
        {
            _letterType = typeof(BaseLetter);
            Button button = (Button)sender;
            foreach (Control control in leftPanelButtons.Controls)
            {
                control.Enabled = true;
            }
            button.Enabled = false;
            LettersDataGridViewDataBinder.LoadToDataGridView(lettersDataGridView, await _baseLetterController.GetAllAsync());
        }

        private async void incomingLettersButton_Click(object sender, EventArgs e)
        {
            _letterType = typeof(IncomingLetter);
            Button button = (Button)sender;
            foreach (Control control in leftPanelButtons.Controls)
            {
                control.Enabled = true;
            }
            button.Enabled = false;
            LettersDataGridViewDataBinder.LoadToDataGridView(lettersDataGridView, await _incomingLetterController.GetAllAsync());
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (_letterType == typeof(BaseLetter))
                {
                    await _baseLetterController.DeleteAsync((int)lettersDataGridView.SelectedCells[0].Value);
                    LettersDataGridViewDataBinder.LoadToDataGridView(lettersDataGridView, await _baseLetterController.GetAllAsync());
                }
                else if (_letterType == typeof(IncomingLetter))
                {
                    await _incomingLetterController.DeleteAsync((int)lettersDataGridView.SelectedCells[0].Value);
                    LettersDataGridViewDataBinder.LoadToDataGridView(lettersDataGridView, await _incomingLetterController.GetAllAsync());
                }
                
                

                
            }
        }

        private async void createButton_Click(object sender, EventArgs e)
        {
            if (_letterType == typeof(BaseLetter))
            {
                BaseLetterForm baseLetterForm = new BaseLetterForm();

                if (baseLetterForm.ShowDialog() == DialogResult.OK)
                {
                    LettersDataGridViewDataBinder.LoadToDataGridView(lettersDataGridView, await _baseLetterController.GetAllAsync());
                }
            }
            else if (_letterType == typeof(IncomingLetter))
            {
                IncomingLetterForm incomingLetterForm = new IncomingLetterForm();

                if (incomingLetterForm.ShowDialog() == DialogResult.OK)
                {
                    LettersDataGridViewDataBinder.LoadToDataGridView(lettersDataGridView, await _incomingLetterController.GetAllAsync());
                }
            }
            
        }

        private async void openButton_Click(object sender, EventArgs e)
        {
            if (_letterType == typeof(BaseLetter))
            {
                BaseLetterForm baseLetterForm = new BaseLetterForm((int)lettersDataGridView.SelectedRows[0].Cells[0].Value);

                if (baseLetterForm.ShowDialog() == DialogResult.OK)
                {
                    LettersDataGridViewDataBinder.LoadToDataGridView(lettersDataGridView, await _baseLetterController.GetAllAsync());
                }
            }
            else if (_letterType == typeof(IncomingLetter))
            {
                IncomingLetterForm incomingLetterForm = new IncomingLetterForm((int)lettersDataGridView.SelectedRows[0].Cells[0].Value);

                if (incomingLetterForm.ShowDialog() == DialogResult.OK)
                {
                    LettersDataGridViewDataBinder.LoadToDataGridView(lettersDataGridView, await _incomingLetterController.GetAllAsync());
                }
            }
            
        }

        private void lettersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            openButton_Click(sender, e);
        }

        private async void filterButton_Click(object sender, EventArgs e)
        {

            FilterForm filterForm = new FilterForm(_letterType);
            if (_letterType == typeof(BaseLetter))
            {
                if (filterForm.ShowDialog() == DialogResult.OK)
                {
                    LettersDataGridViewDataBinder.ApplyFilter(lettersDataGridView, await _baseLetterController.GetAllAsync(), filterForm.FilterInfo);
                }
            }
            else if (_letterType == typeof(IncomingLetter))
            {
                if (filterForm.ShowDialog() == DialogResult.OK)
                {
                    LettersDataGridViewDataBinder.ApplyFilter(lettersDataGridView, await _incomingLetterController.GetAllAsync(), filterForm.FilterInfo);
                }
            }
            
        }
    }
}
