namespace FinesDesktopApp
{
    partial class PoliceOfficerForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.policeOfficerId = new System.Windows.Forms.ComboBox();
            this.finesDataSet = new FinesDesktopApp.FinesDataSet();
            this.finesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.policeofficerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.police_officerTableAdapter = new FinesDesktopApp.FinesDataSetTableAdapters.police_officerTableAdapter();
            this.signInButton = new System.Windows.Forms.Button();
            this.backToMainFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.finesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeofficerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(67, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Укажите код сотрудника";
            // 
            // policeOfficerId
            // 
            this.policeOfficerId.DataSource = this.policeofficerBindingSource;
            this.policeOfficerId.DisplayMember = "id";
            this.policeOfficerId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.policeOfficerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.policeOfficerId.FormattingEnabled = true;
            this.policeOfficerId.Location = new System.Drawing.Point(71, 110);
            this.policeOfficerId.Name = "policeOfficerId";
            this.policeOfficerId.Size = new System.Drawing.Size(121, 28);
            this.policeOfficerId.TabIndex = 2;
            this.policeOfficerId.ValueMember = "id";
            // 
            // finesDataSet
            // 
            this.finesDataSet.DataSetName = "FinesDataSet";
            this.finesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // finesDataSetBindingSource
            // 
            this.finesDataSetBindingSource.DataSource = this.finesDataSet;
            this.finesDataSetBindingSource.Position = 0;
            // 
            // policeofficerBindingSource
            // 
            this.policeofficerBindingSource.DataMember = "police_officer";
            this.policeofficerBindingSource.DataSource = this.finesDataSetBindingSource;
            // 
            // police_officerTableAdapter
            // 
            this.police_officerTableAdapter.ClearBeforeFill = true;
            // 
            // signInButton
            // 
            this.signInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInButton.Location = new System.Drawing.Point(217, 109);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(77, 30);
            this.signInButton.TabIndex = 3;
            this.signInButton.Text = "Войти";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // backToMainFormButton
            // 
            this.backToMainFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backToMainFormButton.Location = new System.Drawing.Point(12, 12);
            this.backToMainFormButton.Name = "backToMainFormButton";
            this.backToMainFormButton.Size = new System.Drawing.Size(340, 24);
            this.backToMainFormButton.TabIndex = 4;
            this.backToMainFormButton.Text = "Вернуться на главное окно";
            this.backToMainFormButton.UseVisualStyleBackColor = true;
            this.backToMainFormButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PoliceOfficerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(364, 179);
            this.Controls.Add(this.backToMainFormButton);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.policeOfficerId);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "PoliceOfficerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация сотрудника ГИБДД";
            this.Load += new System.EventHandler(this.PoliceOfficerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeofficerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox policeOfficerId;
        private System.Windows.Forms.BindingSource finesDataSetBindingSource;
        private FinesDataSet finesDataSet;
        private System.Windows.Forms.BindingSource policeofficerBindingSource;
        private FinesDataSetTableAdapters.police_officerTableAdapter police_officerTableAdapter;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Button backToMainFormButton;
    }
}