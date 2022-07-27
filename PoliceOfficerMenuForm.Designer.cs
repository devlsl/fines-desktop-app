namespace FinesDesktopApp
{
    partial class PoliceOfficerMenuForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.greetLabel = new System.Windows.Forms.Label();
            this.police_officerTableAdapter1 = new FinesDesktopApp.FinesDataSetTableAdapters.police_officerTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backToOfficerSignInFormButton
            // 
            this.backToOfficerSignInFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backToOfficerSignInFormButton.Location = new System.Drawing.Point(19, 12);
            this.backToOfficerSignInFormButton.Name = "backToOfficerSignInFormButton";
            this.backToOfficerSignInFormButton.Size = new System.Drawing.Size(486, 27);
            this.backToOfficerSignInFormButton.TabIndex = 0;
            this.backToOfficerSignInFormButton.Text = "Вернуться к онку авторизации";
            this.backToOfficerSignInFormButton.UseVisualStyleBackColor = true;
            this.backToOfficerSignInFormButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(19, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Учёт автомобилей";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // greetLabel
            // 
            this.greetLabel.AutoSize = true;
            this.greetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greetLabel.Location = new System.Drawing.Point(184, 64);
            this.greetLabel.Name = "greetLabel";
            this.greetLabel.Size = new System.Drawing.Size(149, 24);
            this.greetLabel.TabIndex = 5;
            this.greetLabel.Text = "Здравствуйте, ";
            // 
            // police_officerTableAdapter1
            // 
            this.police_officerTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button1.Location = new System.Drawing.Point(19, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(486, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Выписать новый штраф";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.button5.Location = new System.Drawing.Point(266, 117);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(239, 33);
            this.button5.TabIndex = 4;
            this.button5.Text = "Учёт водителей";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // PoliceOfficerMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(525, 202);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.greetLabel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.backToOfficerSignInFormButton);
            this.MaximizeBox = false;
            this.Name = "PoliceOfficerMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToOfficerSignInFormButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label greetLabel;
        private FinesDataSetTableAdapters.police_officerTableAdapter police_officerTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
    }
}