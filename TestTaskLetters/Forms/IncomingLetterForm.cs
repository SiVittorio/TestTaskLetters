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
    public partial class IncomingLetterForm : Form
    {
        private IEnumerable<Organisation> _organisations;
        private IEnumerable<DeliveryMethod> _deliveryMethods;
        private OrganisationController _organisationController = new OrganisationController();
        private DeliveryMethodController _deliveryMethodController = new DeliveryMethodController();
        private IncomingLetterController _incomingLetterController = new IncomingLetterController();
        private bool _isOpenedLetter = false;
        private int _letterId = 0;
        private IncomingLetter _letter = null;
        public IncomingLetterForm()
        {
            InitializeComponent();
            editButton.Visible = false;

        }

        public IncomingLetterForm(int id)
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
            organisationCb.Enabled = mode;
            deliveryMethodCb.Enabled = mode;
            editButton.Visible = !mode;
        }

        private void FillToControls(IncomingLetter incomingLetter)
        {
            if (incomingLetter != null)
            {
                nameTextBox.Text = incomingLetter.Name;
                subjectTextBox.Text = incomingLetter.Subject;
                letterNumberTextBox.Text = incomingLetter.DocumentNumber;
                organisationCb.SelectedItem = _organisations.Where(p => p.Id == incomingLetter.OrganisationId).Select(x => x.Name).SingleOrDefault();
                deliveryMethodCb.SelectedItem = _deliveryMethods.Where(p => p.Id == incomingLetter.DeliveryMethodId).Select(x => x.Name).SingleOrDefault();
            }
        }

        private async void IncomingLetterForm_Load(object sender, EventArgs e)
        {
            _organisations = await _organisationController.GetAllAsync();
            _deliveryMethods = await _deliveryMethodController.GetAllAsync();

            organisationCb.Items.AddRange(_organisations.Select(p => p.Name).ToArray());
            deliveryMethodCb.Items.AddRange(_deliveryMethods.Select(p => p.Name).ToArray());

            if (_isOpenedLetter)
            {
                _letter = await _incomingLetterController.GetAsync(_letterId);
                FillToControls(_letter);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private async void createButton_Click(object sender, EventArgs e)
        {
            int deliveryMethodId = _deliveryMethods.Where(p => p.Name == deliveryMethodCb.Text).Select(x => x.Id).SingleOrDefault();
            int organisationId = _organisations.Where(p => p.Name == organisationCb.Text).Select(x => x.Id).FirstOrDefault();
            _letter = new IncomingLetter(nameTextBox.Text, subjectTextBox.Text, letterNumberTextBox.Text) 
            { Id = _letterId, OrganisationId = organisationId, DeliveryMethodId = deliveryMethodId, AddresseeId = 1, CounterpartyId = 1 };
            if (!_isOpenedLetter)
            {
                await _incomingLetterController.InsertAsync(_letter);
            }
            else
            {
                await _incomingLetterController.UpdateAsync(_letter);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ChangeEditMode(true);
        }
    }
}
