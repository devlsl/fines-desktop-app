namespace FinesDesktopApp
{
    partial class DriverManageForm
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
            this.finesDataSet = new FinesDesktopApp.FinesDataSet();
            this.tableAdapterManager = new FinesDesktopApp.FinesDataSetTableAdapters.TableAdapterManager();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driverTableAdapter = new FinesDesktopApp.FinesDataSetTableAdapters.driverTableAdapter();
            this.driverDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.surnameValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.patronymicValue = new System.Windows.Forms.TextBox();
            this.addDriverButton = new System.Windows.Forms.Button();
            this.licenseIdValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteDriverButton = new System.Windows.Forms.Button();
            this.deleteMessageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.finesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backToOfficerSignInFormButton
            // 
            this.backToOfficerSignInFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backToOfficerSignInFormButton.Location = new System.Drawing.Point(12, 12);
            this.backToOfficerSignInFormButton.Name = "backToOfficerSignInFormButton";
            this.backToOfficerSignInFormButton.Size = new System.Drawing.Size(348, 27);
            this.backToOfficerSignInFormButton.TabIndex = 4;
            this.backToOfficerSignInFormButton.Text = "Вернуться в меню";
            this.backToOfficerSignInFormButton.UseVisualStyleBackColor = true;
            this.backToOfficerSignInFormButton.Click += new System.EventHandler(this.backToOfficerSignInFormButton_Click);
            // 
            // finesDataSet
            // 
            this.finesDataSet.DataSetName = "FinesDataSet";
            this.finesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carTableAdapter = null;
            this.tableAdapterManager.driverTableAdapter = this.driverTableAdapter;
            this.tableAdapterManager.fineTableAdapter = null;
            this.tableAdapterManager.police_officerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FinesDesktopApp.FinesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.violationTableAdapter = null;
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
            // driverDataGridView
            // 
            this.driverDataGridView.AllowUserToAddRows = false;
            this.driverDataGridView.AllowUserToDeleteRows = false;
            this.driverDataGridView.AutoGenerateColumns = false;
            this.driverDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.driverDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.driverDataGridView.DataSource = this.driverBindingSource;
            this.driverDataGridView.Location = new System.Drawing.Point(12, 45);
            this.driverDataGridView.Name = "driverDataGridView";
            this.driverDataGridView.ReadOnly = true;
            this.driverDataGridView.Size = new System.Drawing.Size(361, 445);
            this.driverDataGridView.TabIndex = 4;
            this.driverDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.driverDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "license_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Вод. уд.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "surname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 76;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "patronymic";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 87;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchLabel.Location = new System.Drawing.Point(12, 513);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(85, 18);
            this.searchLabel.TabIndex = 5;
            this.searchLabel.Text = "Добавить";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 606);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Удалить";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 545);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Фамилия";
            // 
            // surnameValue
            // 
            this.surnameValue.Location = new System.Drawing.Point(12, 563);
            this.surnameValue.Name = "surnameValue";
            this.surnameValue.Size = new System.Drawing.Size(82, 20);
            this.surnameValue.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 545);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Имя";
            // 
            // nameValue
            // 
            this.nameValue.Location = new System.Drawing.Point(100, 563);
            this.nameValue.Name = "nameValue";
            this.nameValue.Size = new System.Drawing.Size(82, 20);
            this.nameValue.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 545);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Отчество";
            // 
            // patronymicValue
            // 
            this.patronymicValue.Location = new System.Drawing.Point(188, 563);
            this.patronymicValue.Name = "patronymicValue";
            this.patronymicValue.Size = new System.Drawing.Size(82, 20);
            this.patronymicValue.TabIndex = 21;
            // 
            // addDriverButton
            // 
            this.addDriverButton.Location = new System.Drawing.Point(276, 562);
            this.addDriverButton.Name = "addDriverButton";
            this.addDriverButton.Size = new System.Drawing.Size(97, 22);
            this.addDriverButton.TabIndex = 23;
            this.addDriverButton.Text = "Добавить";
            this.addDriverButton.UseVisualStyleBackColor = true;
            this.addDriverButton.Click += new System.EventHandler(this.addDriverButton_Click);
            // 
            // licenseIdValue
            // 
            this.licenseIdValue.Location = new System.Drawing.Point(12, 647);
            this.licenseIdValue.Name = "licenseIdValue";
            this.licenseIdValue.Size = new System.Drawing.Size(82, 20);
            this.licenseIdValue.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 631);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Вод. уд.";
            // 
            // deleteDriverButton
            // 
            this.deleteDriverButton.Location = new System.Drawing.Point(99, 646);
            this.deleteDriverButton.Name = "deleteDriverButton";
            this.deleteDriverButton.Size = new System.Drawing.Size(97, 22);
            this.deleteDriverButton.TabIndex = 26;
            this.deleteDriverButton.Text = "Удалить";
            this.deleteDriverButton.UseVisualStyleBackColor = true;
            this.deleteDriverButton.Click += new System.EventHandler(this.deleteDriverButton_Click);
            // 
            // deleteMessageLabel
            // 
            this.deleteMessageLabel.AutoSize = true;
            this.deleteMessageLabel.Location = new System.Drawing.Point(12, 682);
            this.deleteMessageLabel.Name = "deleteMessageLabel";
            this.deleteMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.deleteMessageLabel.TabIndex = 27;
            // 
            // DriverManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(385, 722);
            this.Controls.Add(this.deleteMessageLabel);
            this.Controls.Add(this.deleteDriverButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.licenseIdValue);
            this.Controls.Add(this.addDriverButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.patronymicValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.surnameValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.driverDataGridView);
            this.Controls.Add(this.backToOfficerSignInFormButton);
            this.MaximizeBox = false;
            this.Name = "DriverManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учёт водителей";
            this.Load += new System.EventHandler(this.DriverManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToOfficerSignInFormButton;
        private FinesDataSet finesDataSet;
        private FinesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private FinesDataSetTableAdapters.driverTableAdapter driverTableAdapter;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private System.Windows.Forms.DataGridView driverDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox surnameValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox patronymicValue;
        private System.Windows.Forms.Button addDriverButton;
        private System.Windows.Forms.TextBox licenseIdValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteDriverButton;
        private System.Windows.Forms.Label deleteMessageLabel;
    }
}