
namespace DataEncryption
{
    partial class winDataEncryption
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataEncrypt1 = new DataEncryption.dataEncrypt();
            this.dataDecrypt1 = new DataEncryption.dataDecrypt();
            this.SuspendLayout();
            // 
            // dataEncrypt1
            // 
            this.dataEncrypt1.AutoSize = true;
            this.dataEncrypt1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.dataEncrypt1.CausesValidation = false;
            this.dataEncrypt1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataEncrypt1.Location = new System.Drawing.Point(12, 13);
            this.dataEncrypt1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataEncrypt1.Name = "dataEncrypt1";
            this.dataEncrypt1.Size = new System.Drawing.Size(876, 148);
            this.dataEncrypt1.TabIndex = 0;
            // 
            // dataDecrypt1
            // 
            this.dataDecrypt1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.dataDecrypt1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDecrypt1.Location = new System.Drawing.Point(12, 221);
            this.dataDecrypt1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataDecrypt1.Name = "dataDecrypt1";
            this.dataDecrypt1.Size = new System.Drawing.Size(876, 173);
            this.dataDecrypt1.TabIndex = 1;
            // 
            // winDataEncryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(901, 429);
            this.Controls.Add(this.dataDecrypt1);
            this.Controls.Add(this.dataEncrypt1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "winDataEncryption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Encryption & Decryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dataEncrypt dataEncrypt1;
        private dataDecrypt dataDecrypt1;
    }
}