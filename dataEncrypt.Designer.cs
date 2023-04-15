
namespace DataEncryption
{
    partial class dataEncrypt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEncrypt = new System.Windows.Forms.TextBox();
            this.opEncrypt = new System.Windows.Forms.MaskedTextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.errEncrypt = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errEncrypt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Data to Encrypt :";
            // 
            // txtEncrypt
            // 
            this.txtEncrypt.Location = new System.Drawing.Point(18, 48);
            this.txtEncrypt.Name = "txtEncrypt";
            this.txtEncrypt.Size = new System.Drawing.Size(365, 27);
            this.txtEncrypt.TabIndex = 1;
            this.txtEncrypt.Validating += new System.ComponentModel.CancelEventHandler(this.txtEncrypt_Validating);
            // 
            // opEncrypt
            // 
            this.opEncrypt.CausesValidation = false;
            this.opEncrypt.Location = new System.Drawing.Point(434, 48);
            this.opEncrypt.Name = "opEncrypt";
            this.opEncrypt.ReadOnly = true;
            this.opEncrypt.Size = new System.Drawing.Size(365, 27);
            this.opEncrypt.TabIndex = 2;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEncrypt.CausesValidation = false;
            this.btnEncrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEncrypt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEncrypt.Location = new System.Drawing.Point(18, 100);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(133, 35);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // errEncrypt
            // 
            this.errEncrypt.ContainerControl = this;
            // 
            // dataEncrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.opEncrypt);
            this.Controls.Add(this.txtEncrypt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "dataEncrypt";
            this.Size = new System.Drawing.Size(880, 445);
            ((System.ComponentModel.ISupportInitialize)(this.errEncrypt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEncrypt;
        private System.Windows.Forms.MaskedTextBox opEncrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.ErrorProvider errEncrypt;
    }
}
