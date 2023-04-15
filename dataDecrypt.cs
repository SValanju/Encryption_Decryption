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
    public partial class dataDecrypt : UserControl
    {
        public dataDecrypt()
        {
            InitializeComponent();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Secure ss = new Secure();
                string strDecrypted = ss.GUPTDecrypt(txtDecrypt.Text);
                opDecrypt.Text = strDecrypted;
            }
        }

        private void txtDecrypt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDecrypt.Text))
            {
                e.Cancel = true;
                txtDecrypt.Focus();
                errDecrypt.SetError(txtDecrypt, "Please enter data!");
            }
            else
            {
                e.Cancel = false;
                errDecrypt.SetError(txtDecrypt, string.Empty);
            }
        }
    }
}
