
namespace DataEncryption
{
    partial class dataDecrypt
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
            this.txtDecrypt = new System.Windows.Forms.TextBox();
            this.errDecrypt = new System.Windows.Forms.ErrorProvider(this.components);
            this.opDecrypt = new System.Windows.Forms.MaskedTextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errDecrypt)).BeginInit();
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
            this.label1.Text = "Enter Data to Decrypt :";
            // 
            // txtDecrypt
            // 
            this.txtDecrypt.Location = new System.Drawing.Point(18, 48);
            this.txtDecrypt.Name = "txtDecrypt";
            this.txtDecrypt.Size = new System.Drawing.Size(365, 27);
            this.txtDecrypt.TabIndex = 1;
            this.txtDecrypt.Validating += new System.ComponentModel.CancelEventHandler(this.txtDecrypt_Validating);
            // 
            // errDecrypt
            // 
            this.errDecrypt.ContainerControl = this;
            // 
            // opDecrypt
            // 
            this.opDecrypt.CausesValidation = false;
            this.opDecrypt.Location = new System.Drawing.Point(434, 48);
            this.opDecrypt.Name = "opDecrypt";
            this.opDecrypt.ReadOnly = true;
            this.opDecrypt.Size = new System.Drawing.Size(365, 27);
            this.opDecrypt.TabIndex = 2;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDecrypt.CausesValidation = false;
            this.btnDecrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDecrypt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDecrypt.Location = new System.Drawing.Point(18, 100);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(133, 35);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // dataDecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.opDecrypt);
            this.Controls.Add(this.txtDecrypt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "dataDecrypt";
            this.Size = new System.Drawing.Size(1009, 394);
            ((System.ComponentModel.ISupportInitialize)(this.errDecrypt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDecrypt;
        private System.Windows.Forms.ErrorProvider errDecrypt;
        private System.Windows.Forms.MaskedTextBox opDecrypt;
        private System.Windows.Forms.Button btnDecrypt;
    }
}
