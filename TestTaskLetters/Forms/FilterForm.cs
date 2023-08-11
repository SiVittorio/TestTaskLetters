using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTaskLetters.Controllers;
using TestTaskLetters.Models;

namespace TestTaskLetters.Forms
{
    public partial class FilterForm : Form
    {
        public FilterInfo FilterInfo;
        private OrganisationController _organisationController = new OrganisationController();
        private DeliveryMethodController _deliveryMethodController = new DeliveryMethodController();
        private IEnumerable<Organisation> _organisations;
        private IEnumerable<DeliveryMethod> _deliveryMethods;
        public FilterForm(Type type)
        {
            InitializeComponent();
            if (type == typeof(BaseLetter))
            {
                filterAttributesGroupBox.Enabled = false;
            }
        }

        private async void FilterForm_Load(object sender, EventArgs e)
        {
            filterDateOffRb.Checked = true;

            _organisations = await _organisationController.GetAllAsync();
            _deliveryMethods = await _deliveryMethodController.GetAllAsync();
            organisationCb.Items.AddRange(_organisations.Select(p => p.Name).ToArray());
            deliveryMethodCb.Items.AddRange(_deliveryMethods.Select(p => p.Name).ToArray());

        }

        private void filterNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            filterNameTextBox.Enabled = filterNameCheckBox.Checked;

            if (!filterNameCheckBox.Checked)
            {
                filterNameTextBox.Clear();
            }
        }

        private void filterDatePeriod_CheckedChanged(object sender, EventArgs e)
        {
            filterDateSelectMenu.Enabled = filterDatePeriod.Checked;

            if (!filterDatePeriod.Checked)
            {
                filterDateFromMtb.Clear();
                filterDateToMtb.Clear();
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            SqlDateTime? endDate = null;
            SqlDateTime? beginDate = null;
            if (filterDateWeekRb.Checked)
            {
                endDate = SqlDateTime.Parse(DateTime.Now.AddDays(1).ToString("MM.dd.yyyy"));
                beginDate = SqlDateTime.Parse(DateTime.Now.AddDays(-6).ToString("MM.dd.yyyy"));
            }
            else if (filterDateThirty.Checked)
            {
                endDate = SqlDateTime.Parse(DateTime.Now.AddDays(1).ToString("MM.dd.yyyy"));
                beginDate = SqlDateTime.Parse(DateTime.Now.AddDays(-29).ToString("MM.dd.yyyy"));
            }
            else if (filterDateNinety.Checked)
            {
                endDate = SqlDateTime.Parse(DateTime.Now.AddDays(1).ToString("MM.dd.yyyy"));
                beginDate = SqlDateTime.Parse(DateTime.Now.AddDays(-89).ToString("MM.dd.yyyy"));
            }
            else if (filterDatePeriod.Checked)
            {
                if (DateTime.TryParse(filterDateFromMtb.Text, out DateTime beginDateTime) 
                    && DateTime.TryParse(filterDateToMtb.Text, out DateTime endDateTime))
                {
                    if (beginDateTime < endDateTime)
                    {
                        beginDate = SqlDateTime.Parse(beginDateTime.ToString("MM.dd.yyyy"));
                        endDate = SqlDateTime.Parse(endDateTime.ToString("MM.dd.yyyy"));
                    }
                    else
                    {
                        MessageBox.Show("Период введён некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Период введён некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            FilterInfo = new FilterInfo(
                filterNameTextBox.Text,
                beginDate,
                endDate,
                _deliveryMethods.Where(p => p.Name == deliveryMethodCb.Text).Select(p => p.Id).SingleOrDefault(),
                _organisations.Where(p => p.Name == organisationCb.Text).Select(p => p.Id).SingleOrDefault()
                );
            this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }

    
}
