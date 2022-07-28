namespace FinesDesktopApp
{
    partial class IssueFineForm
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
            this.backToOfficerSignInFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backToOfficerSignInFormButton
            // 
            this.backToOfficerSignInFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backToOfficerSignInFormButton.Location = new System.Drawing.Point(12, 12);
            this.backToOfficerSignInFormButton.Name = "backToOfficerSignInFormButton";
            this.backToOfficerSignInFormButton.Size = new System.Drawing.Size(608, 27);
            this.backToOfficerSignInFormButton.TabIndex = 4;
            this.backToOfficerSignInFormButton.Text = "Вернуться в меню";
            this.backToOfficerSignInFormButton.UseVisualStyleBackColor = true;
            this.backToOfficerSignInFormButton.Click += new System.EventHandler(this.backToOfficerSignInFormButton_Click);
            // 
            // IssueFineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this.backToOfficerSignInFormButton);
            this.MaximizeBox = false;
            this.Name = "IssueFineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выписка штрафа";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backToOfficerSignInFormButton;
    }
}