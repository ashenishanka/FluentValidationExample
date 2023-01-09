using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluentValidationExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>Handles the Click event of the btnSaveCust control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnSaveCust_Click(object sender, EventArgs e)
        {
            customerBindingSource.EndEdit();
            Customer customer = customerBindingSource.Current as Customer;
            if (customer != null) {
                CustomerValidator validator = new CustomerValidator();
                ValidationResult results = validator.Validate(customer);
                IList<ValidationFailure> failures = results.Errors;
                if (!results.IsValid) {
                    foreach (ValidationFailure failure in failures) {
                        MessageBox.Show(failure.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
        }


        /// <summary>Handles the Load event of the Form1 control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            customerBindingSource.DataSource = new Customer();
        }
    }
}
