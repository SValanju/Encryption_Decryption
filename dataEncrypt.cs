using SecureStore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataEncryption
{
    public partial class dataEncrypt : UserControl
    {
        public dataEncrypt()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Secure ss = new Secure();
                string strEncrypted = ss.GUPTEncrypt(txtEncrypt.Text);
                opEncrypt.Text = strEncrypted;
            }
        }

        private void txtEncrypt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEncrypt.Text))
            {
                e.Cancel = true;
                txtEncrypt.Focus();
                errEncrypt.SetError(txtEncrypt, "Please enter data!");
            }
            else
            {
                e.Cancel = false;
                errEncrypt.SetError(txtEncrypt, string.Empty);
            }
        }
    }
}
