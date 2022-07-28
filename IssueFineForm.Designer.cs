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
            this.components = new System.ComponentModel.Container();
            this.backToOfficerSignInFormButton = new System.Windows.Forms.Button();
            this.dateValue = new System.Windows.Forms.DateTimePicker();
            this.issueFineButton = new System.Windows.Forms.Button();
            this.violationTableAdapter1 = new FinesDesktopApp.FinesDataSetTableAdapters.violationTableAdapter();
            this.fineValue = new System.Windows.Forms.ComboBox();
            this.finesDataSet = new FinesDesktopApp.FinesDataSet();
            this.fineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fineTableAdapter = new FinesDesktopApp.FinesDataSetTableAdapters.fineTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numberPlateValue = new System.Windows.Forms.ComboBox();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driverTableAdapter = new FinesDesktopApp.FinesDataSetTableAdapters.driverTableAdapter();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new FinesDesktopApp.FinesDataSetTableAdapters.carTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addressValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.licenseIdValue = new System.Windows.Forms.ComboBox();
            this.driverBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.finesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // backToOfficerSignInFormButton
            // 
            this.backToOfficerSignInFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backToOfficerSignInFormButton.Location = new System.Drawing.Point(12, 12);
            this.backToOfficerSignInFormButton.Name = "backToOfficerSignInFormButton";
            this.backToOfficerSignInFormButton.Size = new System.Drawing.Size(722, 27);
            this.backToOfficerSignInFormButton.TabIndex = 4;
            this.backToOfficerSignInFormButton.Text = "Вернуться в меню";
            this.backToOfficerSignInFormButton.UseVisualStyleBackColor = true;
            this.backToOfficerSignInFormButton.Click += new System.EventHandler(this.backToOfficerSignInFormButton_Click);
            // 
            // dateValue
            // 
            this.dateValue.CustomFormat = "dd-MM-yyyy hh:mm:ss";
            this.dateValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateValue.Location = new System.Drawing.Point(294, 128);
            this.dateValue.MaxDate = new System.DateTime(2022, 7, 28, 0, 0, 0, 0);
            this.dateValue.Name = "dateValue";
            this.dateValue.Size = new System.Drawing.Size(122, 20);
            this.dateValue.TabIndex = 5;
            this.dateValue.Value = new System.DateTime(2022, 7, 28, 0, 0, 0, 0);
            // 
            // issueFineButton
            // 
            this.issueFineButton.Location = new System.Drawing.Point(619, 161);
            this.issueFineButton.Name = "issueFineButton";
            this.issueFineButton.Size = new System.Drawing.Size(115, 23);
            this.issueFineButton.TabIndex = 6;
            this.issueFineButton.Text = "Выписать штраф";
            this.issueFineButton.UseVisualStyleBackColor = true;
            this.issueFineButton.Click += new System.EventHandler(this.issueFineButton_Click);
            // 
            // violationTableAdapter1
            // 
            this.violationTableAdapter1.ClearBeforeFill = true;
            // 
            // fineValue
            // 
            this.fineValue.DataSource = this.fineBindingSource;
            this.fineValue.DisplayMember = "name";
            this.fineValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fineValue.FormattingEnabled = true;
            this.fineValue.Location = new System.Drawing.Point(12, 79);
            this.fineValue.Name = "fineValue";
            this.fineValue.Size = new System.Drawing.Size(722, 21);
            this.fineValue.TabIndex = 7;
            this.fineValue.ValueMember = "id";
            // 
            // finesDataSet
            // 
            this.finesDataSet.DataSetName = "FinesDataSet";
            this.finesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fineBindingSource
            // 
            this.fineBindingSource.DataMember = "fine";
            this.fineBindingSource.DataSource = this.finesDataSet;
            // 
            // fineTableAdapter
            // 
            this.fineTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Штраф";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageLabel.Location = new System.Drawing.Point(12, 168);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 16);
            this.messageLabel.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Гос. номер";
            // 
            // numberPlateValue
            // 
            this.numberPlateValue.DataSource = this.carBindingSource;
            this.numberPlateValue.DisplayMember = "number_plate";
            this.numberPlateValue.FormattingEnabled = true;
            this.numberPlateValue.Location = new System.Drawing.Point(12, 127);
            this.numberPlateValue.Name = "numberPlateValue";
            this.numberPlateValue.Size = new System.Drawing.Size(121, 21);
            this.numberPlateValue.TabIndex = 25;
            this.numberPlateValue.ValueMember = "number_plate";
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataMember = "driver";
            this.driverBindingSource.DataSource = this.finesDataSet;
            // 
            // driverTableAdapter
            // 
            this.driverTableAdapter.ClearBeforeFill = true;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "car";
            this.carBindingSource.DataSource = this.finesDataSet;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Дата нарушения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Адрес нарушения";
            // 
            // addressValue
            // 
            this.addressValue.Location = new System.Drawing.Point(436, 128);
            this.addressValue.Name = "addressValue";
            this.addressValue.Size = new System.Drawing.Size(298, 20);
            this.addressValue.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Вод. уд.";
            // 
            // licenseIdValue
            // 
            this.licenseIdValue.DataSource = this.driverBindingSource1;
            this.licenseIdValue.DisplayMember = "license_id";
            this.licenseIdValue.FormattingEnabled = true;
            this.licenseIdValue.Location = new System.Drawing.Point(154, 127);
            this.licenseIdValue.Name = "licenseIdValue";
            this.licenseIdValue.Size = new System.Drawing.Size(121, 21);
            this.licenseIdValue.TabIndex = 32;
            this.licenseIdValue.ValueMember = "license_id";
            // 
            // driverBindingSource1
            // 
            this.driverBindingSource1.DataMember = "driver";
            this.driverBindingSource1.DataSource = this.finesDataSet;
            // 
            // IssueFineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(746, 203);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.licenseIdValue);
            this.Controls.Add(this.addressValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numberPlateValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fineValue);
            this.Controls.Add(this.issueFineButton);
            this.Controls.Add(this.dateValue);
            this.Controls.Add(this.backToOfficerSignInFormButton);
            this.MaximizeBox = false;
            this.Name = "IssueFineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выписка штрафа";
            this.Load += new System.EventHandler(this.IssueFineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToOfficerSignInFormButton;
        private System.Windows.Forms.DateTimePicker dateValue;
        private System.Windows.Forms.Button issueFineButton;
        private FinesDataSetTableAdapters.violationTableAdapter violationTableAdapter1;
        private System.Windows.Forms.ComboBox fineValue;
        private FinesDataSet finesDataSet;
        private System.Windows.Forms.BindingSource fineBindingSource;
        private FinesDataSetTableAdapters.fineTableAdapter fineTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox numberPlateValue;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private FinesDataSetTableAdapters.driverTableAdapter driverTableAdapter;
        private System.Windows.Forms.BindingSource carBindingSource;
        private FinesDataSetTableAdapters.carTableAdapter carTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addressValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox licenseIdValue;
        private System.Windows.Forms.BindingSource driverBindingSource1;
    }
}