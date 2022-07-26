namespace FinesDesktopApp
{
    partial class CheckFinesForm
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
            this.finesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finesTableAdapter = new FinesDesktopApp.FinesDataSetTableAdapters.finesTableAdapter();
            this.tableAdapterManager = new FinesDesktopApp.FinesDataSetTableAdapters.TableAdapterManager();
            this.finesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchFineType = new System.Windows.Forms.ComboBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchFineValue = new System.Windows.Forms.TextBox();
            this.searchFineButton = new System.Windows.Forms.Button();
            this.searchFineStatus = new System.Windows.Forms.ComboBox();
            this.searchSortCol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchSortType = new System.Windows.Forms.ComboBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.getAllFinesButton = new System.Windows.Forms.Button();
            this.payLabel = new System.Windows.Forms.Label();
            this.payFineInfo = new System.Windows.Forms.Label();
            this.payFineButton = new System.Windows.Forms.Button();
            this.backToMainFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.finesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // finesDataSet
            // 
            this.finesDataSet.DataSetName = "FinesDataSet";
            this.finesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // finesBindingSource
            // 
            this.finesBindingSource.DataMember = "fines";
            this.finesBindingSource.DataSource = this.finesDataSet;
            // 
            // finesTableAdapter
            // 
            this.finesTableAdapter.ClearBeforeFill = true;
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
            // finesDataGridView
            // 
            this.finesDataGridView.AllowUserToAddRows = false;
            this.finesDataGridView.AllowUserToDeleteRows = false;
            this.finesDataGridView.AutoGenerateColumns = false;
            this.finesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.finesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.finesDataGridView.DataSource = this.finesBindingSource;
            this.finesDataGridView.Location = new System.Drawing.Point(12, 49);
            this.finesDataGridView.Name = "finesDataGridView";
            this.finesDataGridView.ReadOnly = true;
            this.finesDataGridView.Size = new System.Drawing.Size(1282, 287);
            this.finesDataGridView.TabIndex = 1;
            this.finesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.finesDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Постановление";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 135;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "car_number_plate";
            this.dataGridViewTextBoxColumn2.HeaderText = "Гос. номер";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 63;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "make";
            this.dataGridViewTextBoxColumn3.HeaderText = "Марка";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 66;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "model";
            this.dataGridViewTextBoxColumn4.HeaderText = "Модель";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 52;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "color";
            this.dataGridViewTextBoxColumn5.HeaderText = "Цвет";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 73;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "driver_license_id";
            this.dataGridViewTextBoxColumn6.HeaderText = "Вод. уд.";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 70;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "surname";
            this.dataGridViewTextBoxColumn7.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 76;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn8.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 60;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "patronymic";
            this.dataGridViewTextBoxColumn9.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 87;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn10.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 84;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "date_issue";
            this.dataGridViewTextBoxColumn11.HeaderText = "Дата выписки";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 60;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn12.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 167;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "status";
            this.dataGridViewTextBoxColumn13.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 70;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "fine_name";
            this.dataGridViewTextBoxColumn14.HeaderText = "Штраф";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "amount";
            this.dataGridViewTextBoxColumn15.HeaderText = "Размер";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 52;
            // 
            // searchFineType
            // 
            this.searchFineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchFineType.FormattingEnabled = true;
            this.searchFineType.Location = new System.Drawing.Point(373, 374);
            this.searchFineType.Name = "searchFineType";
            this.searchFineType.Size = new System.Drawing.Size(174, 21);
            this.searchFineType.TabIndex = 2;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchLabel.Location = new System.Drawing.Point(370, 346);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(57, 18);
            this.searchLabel.TabIndex = 3;
            this.searchLabel.Text = "Поиск";
            // 
            // searchFineValue
            // 
            this.searchFineValue.Location = new System.Drawing.Point(553, 374);
            this.searchFineValue.Name = "searchFineValue";
            this.searchFineValue.Size = new System.Drawing.Size(221, 20);
            this.searchFineValue.TabIndex = 4;
            // 
            // searchFineButton
            // 
            this.searchFineButton.Location = new System.Drawing.Point(780, 372);
            this.searchFineButton.Name = "searchFineButton";
            this.searchFineButton.Size = new System.Drawing.Size(75, 23);
            this.searchFineButton.TabIndex = 5;
            this.searchFineButton.Text = "Найти";
            this.searchFineButton.UseVisualStyleBackColor = true;
            this.searchFineButton.Click += new System.EventHandler(this.searchFineButton_Click);
            // 
            // searchFineStatus
            // 
            this.searchFineStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchFineStatus.FormattingEnabled = true;
            this.searchFineStatus.Location = new System.Drawing.Point(373, 404);
            this.searchFineStatus.Name = "searchFineStatus";
            this.searchFineStatus.Size = new System.Drawing.Size(89, 21);
            this.searchFineStatus.TabIndex = 6;
            // 
            // searchSortCol
            // 
            this.searchSortCol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchSortCol.FormattingEnabled = true;
            this.searchSortCol.Location = new System.Drawing.Point(599, 404);
            this.searchSortCol.Name = "searchSortCol";
            this.searchSortCol.Size = new System.Drawing.Size(140, 21);
            this.searchSortCol.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(481, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Сортировать по";
            // 
            // searchSortType
            // 
            this.searchSortType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchSortType.FormattingEnabled = true;
            this.searchSortType.Location = new System.Drawing.Point(745, 404);
            this.searchSortType.Name = "searchSortType";
            this.searchSortType.Size = new System.Drawing.Size(110, 21);
            this.searchSortType.TabIndex = 9;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(742, 351);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 13);
            this.messageLabel.TabIndex = 10;
            // 
            // getAllFinesButton
            // 
            this.getAllFinesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getAllFinesButton.Location = new System.Drawing.Point(12, 372);
            this.getAllFinesButton.Name = "getAllFinesButton";
            this.getAllFinesButton.Size = new System.Drawing.Size(318, 53);
            this.getAllFinesButton.TabIndex = 11;
            this.getAllFinesButton.Text = "Загрузить все штрафы";
            this.getAllFinesButton.UseVisualStyleBackColor = true;
            this.getAllFinesButton.Click += new System.EventHandler(this.getAllFinesButton_Click);
            // 
            // payLabel
            // 
            this.payLabel.AutoSize = true;
            this.payLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payLabel.Location = new System.Drawing.Point(901, 346);
            this.payLabel.Name = "payLabel";
            this.payLabel.Size = new System.Drawing.Size(66, 18);
            this.payLabel.TabIndex = 12;
            this.payLabel.Text = "Оплата";
            // 
            // payFineInfo
            // 
            this.payFineInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payFineInfo.Location = new System.Drawing.Point(901, 374);
            this.payFineInfo.Name = "payFineInfo";
            this.payFineInfo.Size = new System.Drawing.Size(278, 51);
            this.payFineInfo.TabIndex = 13;
            this.payFineInfo.Text = "Чтобы оплатить штраф выбирите ячейку строки с неоплаченным штрафом, затем нажмите" +
    " на кнопку \"Оплатить\"";
            // 
            // payFineButton
            // 
            this.payFineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.payFineButton.Location = new System.Drawing.Point(1194, 372);
            this.payFineButton.Name = "payFineButton";
            this.payFineButton.Size = new System.Drawing.Size(90, 53);
            this.payFineButton.TabIndex = 14;
            this.payFineButton.Text = "Оплатить";
            this.payFineButton.UseVisualStyleBackColor = true;
            this.payFineButton.Click += new System.EventHandler(this.payFineButton_Click);
            // 
            // backToMainFormButton
            // 
            this.backToMainFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backToMainFormButton.Location = new System.Drawing.Point(11, 12);
            this.backToMainFormButton.Name = "backToMainFormButton";
            this.backToMainFormButton.Size = new System.Drawing.Size(1283, 27);
            this.backToMainFormButton.TabIndex = 15;
            this.backToMainFormButton.Text = "Вернуться на главное окно";
            this.backToMainFormButton.UseVisualStyleBackColor = true;
            this.backToMainFormButton.Click += new System.EventHandler(this.backToMainFormButton_Click);
            // 
            // CheckFinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1308, 449);
            this.Controls.Add(this.backToMainFormButton);
            this.Controls.Add(this.payFineButton);
            this.Controls.Add(this.payFineInfo);
            this.Controls.Add(this.payLabel);
            this.Controls.Add(this.getAllFinesButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.searchSortType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchSortCol);
            this.Controls.Add(this.searchFineStatus);
            this.Controls.Add(this.searchFineButton);
            this.Controls.Add(this.searchFineValue);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchFineType);
            this.Controls.Add(this.finesDataGridView);
            this.MaximizeBox = false;
            this.Name = "CheckFinesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск штрафов";
            this.Load += new System.EventHandler(this.CheckFinesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FinesDataSet finesDataSet;
        private System.Windows.Forms.BindingSource finesBindingSource;
        private FinesDataSetTableAdapters.finesTableAdapter finesTableAdapter;
        private FinesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView finesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.ComboBox searchFineType;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchFineValue;
        private System.Windows.Forms.Button searchFineButton;
        private System.Windows.Forms.ComboBox searchFineStatus;
        private System.Windows.Forms.ComboBox searchSortCol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox searchSortType;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button getAllFinesButton;
        private System.Windows.Forms.Label payLabel;
        private System.Windows.Forms.Label payFineInfo;
        private System.Windows.Forms.Button payFineButton;
        private System.Windows.Forms.Button backToMainFormButton;
    }
}