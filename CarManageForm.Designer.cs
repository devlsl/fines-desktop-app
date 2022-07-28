namespace FinesDesktopApp
{
    partial class CarManageForm
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
            this.finesDataSet = new FinesDesktopApp.FinesDataSet();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new FinesDesktopApp.FinesDataSetTableAdapters.carsTableAdapter();
            this.tableAdapterManager = new FinesDesktopApp.FinesDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.backToOfficerSignInFormButton = new System.Windows.Forms.Button();
            this.carsDataGridView = new System.Windows.Forms.DataGridView();
            this.make = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberPlateValue = new System.Windows.Forms.TextBox();
            this.licenseIdValue = new System.Windows.Forms.ComboBox();
            this.driverBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finesDataSet1 = new FinesDesktopApp.FinesDataSet();
            this.driverTableAdapter = new FinesDesktopApp.FinesDataSetTableAdapters.driverTableAdapter();
            this.makeValue = new System.Windows.Forms.TextBox();
            this.modelValue = new System.Windows.Forms.TextBox();
            this.colorValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addCarButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.numberPlateDeleteValue = new System.Windows.Forms.ComboBox();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new FinesDesktopApp.FinesDataSetTableAdapters.carTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.deleteCarButton = new System.Windows.Forms.Button();
            this.addMessageLabel = new System.Windows.Forms.Label();
            this.deleteMessageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.finesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // finesDataSet
            // 
            this.finesDataSet.DataSetName = "FinesDataSet";
            this.finesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "cars";
            this.carsBindingSource.DataSource = this.finesDataSet;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.carTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.driverTableAdapter = null;
            this.tableAdapterManager.fineTableAdapter = null;
            this.tableAdapterManager.police_officerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FinesDesktopApp.FinesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.violationTableAdapter = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавить";
            // 
            // backToOfficerSignInFormButton
            // 
            this.backToOfficerSignInFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backToOfficerSignInFormButton.Location = new System.Drawing.Point(12, 12);
            this.backToOfficerSignInFormButton.Name = "backToOfficerSignInFormButton";
            this.backToOfficerSignInFormButton.Size = new System.Drawing.Size(608, 27);
            this.backToOfficerSignInFormButton.TabIndex = 3;
            this.backToOfficerSignInFormButton.Text = "Вернуться в меню";
            this.backToOfficerSignInFormButton.UseVisualStyleBackColor = true;
            this.backToOfficerSignInFormButton.Click += new System.EventHandler(this.backToOfficerSignInFormButton_Click);
            // 
            // carsDataGridView
            // 
            this.carsDataGridView.AllowUserToAddRows = false;
            this.carsDataGridView.AllowUserToDeleteRows = false;
            this.carsDataGridView.AutoGenerateColumns = false;
            this.carsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.make,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8});
            this.carsDataGridView.DataSource = this.carsBindingSource;
            this.carsDataGridView.Location = new System.Drawing.Point(12, 45);
            this.carsDataGridView.Name = "carsDataGridView";
            this.carsDataGridView.ReadOnly = true;
            this.carsDataGridView.Size = new System.Drawing.Size(608, 339);
            this.carsDataGridView.TabIndex = 3;
            this.carsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carsDataGridView_CellClick);
            // 
            // make
            // 
            this.make.DataPropertyName = "make";
            this.make.HeaderText = "Марка";
            this.make.Name = "make";
            this.make.ReadOnly = true;
            this.make.Width = 66;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "model";
            this.dataGridViewTextBoxColumn2.HeaderText = "Модель";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 52;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "color";
            this.dataGridViewTextBoxColumn3.HeaderText = "Цвет";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 73;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "number_plate";
            this.dataGridViewTextBoxColumn7.HeaderText = "Гос. номер";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 63;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "surname";
            this.dataGridViewTextBoxColumn4.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 76;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 60;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "patronymic";
            this.dataGridViewTextBoxColumn6.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 87;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "license_id";
            this.dataGridViewTextBoxColumn8.HeaderText = "Номер ВУ";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 70;
            // 
            // numberPlateValue
            // 
            this.numberPlateValue.Location = new System.Drawing.Point(15, 457);
            this.numberPlateValue.Name = "numberPlateValue";
            this.numberPlateValue.Size = new System.Drawing.Size(95, 20);
            this.numberPlateValue.TabIndex = 4;
            // 
            // licenseIdValue
            // 
            this.licenseIdValue.DataSource = this.driverBindingSource1;
            this.licenseIdValue.DisplayMember = "license_id";
            this.licenseIdValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.licenseIdValue.FormattingEnabled = true;
            this.licenseIdValue.Location = new System.Drawing.Point(116, 457);
            this.licenseIdValue.Name = "licenseIdValue";
            this.licenseIdValue.Size = new System.Drawing.Size(95, 21);
            this.licenseIdValue.TabIndex = 5;
            this.licenseIdValue.ValueMember = "license_id";
            // 
            // driverBindingSource1
            // 
            this.driverBindingSource1.DataMember = "driver";
            this.driverBindingSource1.DataSource = this.finesDataSet;
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataMember = "driver";
            this.driverBindingSource.DataSource = this.finesDataSet1;
            // 
            // finesDataSet1
            // 
            this.finesDataSet1.DataSetName = "FinesDataSet";
            this.finesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // driverTableAdapter
            // 
            this.driverTableAdapter.ClearBeforeFill = true;
            // 
            // makeValue
            // 
            this.makeValue.Location = new System.Drawing.Point(15, 502);
            this.makeValue.Name = "makeValue";
            this.makeValue.Size = new System.Drawing.Size(95, 20);
            this.makeValue.TabIndex = 6;
            // 
            // modelValue
            // 
            this.modelValue.Location = new System.Drawing.Point(116, 502);
            this.modelValue.Name = "modelValue";
            this.modelValue.Size = new System.Drawing.Size(95, 20);
            this.modelValue.TabIndex = 7;
            // 
            // colorValue
            // 
            this.colorValue.Location = new System.Drawing.Point(217, 502);
            this.colorValue.Name = "colorValue";
            this.colorValue.Size = new System.Drawing.Size(95, 20);
            this.colorValue.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Гос. номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Номер ВУ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Марка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Модель";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Цвет";
            // 
            // addCarButton
            // 
            this.addCarButton.Location = new System.Drawing.Point(217, 456);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(95, 23);
            this.addCarButton.TabIndex = 14;
            this.addCarButton.Text = "Добавить";
            this.addCarButton.UseVisualStyleBackColor = true;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(352, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Удалить";
            // 
            // numberPlateDeleteValue
            // 
            this.numberPlateDeleteValue.DataSource = this.carBindingSource;
            this.numberPlateDeleteValue.DisplayMember = "number_plate";
            this.numberPlateDeleteValue.FormattingEnabled = true;
            this.numberPlateDeleteValue.Location = new System.Drawing.Point(355, 456);
            this.numberPlateDeleteValue.Name = "numberPlateDeleteValue";
            this.numberPlateDeleteValue.Size = new System.Drawing.Size(121, 21);
            this.numberPlateDeleteValue.TabIndex = 16;
            this.numberPlateDeleteValue.ValueMember = "number_plate";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Гос. номер";
            // 
            // deleteCarButton
            // 
            this.deleteCarButton.Location = new System.Drawing.Point(482, 455);
            this.deleteCarButton.Name = "deleteCarButton";
            this.deleteCarButton.Size = new System.Drawing.Size(95, 23);
            this.deleteCarButton.TabIndex = 18;
            this.deleteCarButton.Text = "Удалить";
            this.deleteCarButton.UseVisualStyleBackColor = true;
            this.deleteCarButton.Click += new System.EventHandler(this.deleteCarButton_Click);
            // 
            // addMessageLabel
            // 
            this.addMessageLabel.AutoSize = true;
            this.addMessageLabel.Location = new System.Drawing.Point(12, 538);
            this.addMessageLabel.Name = "addMessageLabel";
            this.addMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.addMessageLabel.TabIndex = 19;
            // 
            // deleteMessageLabel
            // 
            this.deleteMessageLabel.AutoSize = true;
            this.deleteMessageLabel.Location = new System.Drawing.Point(354, 490);
            this.deleteMessageLabel.Name = "deleteMessageLabel";
            this.deleteMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.deleteMessageLabel.TabIndex = 20;
            // 
            // CarManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(629, 570);
            this.Controls.Add(this.deleteMessageLabel);
            this.Controls.Add(this.addMessageLabel);
            this.Controls.Add(this.deleteCarButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numberPlateDeleteValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addCarButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.colorValue);
            this.Controls.Add(this.modelValue);
            this.Controls.Add(this.makeValue);
            this.Controls.Add(this.licenseIdValue);
            this.Controls.Add(this.numberPlateValue);
            this.Controls.Add(this.carsDataGridView);
            this.Controls.Add(this.backToOfficerSignInFormButton);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "CarManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учёт автомобилей";
            this.Load += new System.EventHandler(this.CarManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FinesDataSet finesDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private FinesDataSetTableAdapters.carsTableAdapter carsTableAdapter;
        private FinesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backToOfficerSignInFormButton;
        private System.Windows.Forms.DataGridView carsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox numberPlateValue;
        private System.Windows.Forms.ComboBox licenseIdValue;
        private FinesDataSet finesDataSet1;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private System.Windows.Forms.BindingSource driverBindingSource1;
        private FinesDataSetTableAdapters.driverTableAdapter driverTableAdapter;
        private System.Windows.Forms.TextBox makeValue;
        private System.Windows.Forms.TextBox modelValue;
        private System.Windows.Forms.TextBox colorValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addCarButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox numberPlateDeleteValue;
        private System.Windows.Forms.BindingSource carBindingSource;
        private FinesDataSetTableAdapters.carTableAdapter carTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button deleteCarButton;
        private System.Windows.Forms.Label addMessageLabel;
        private System.Windows.Forms.Label deleteMessageLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn make;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        // private FinesDataSetTableAdapters.driverTableAdapter driverTableAdapter;
    }
}