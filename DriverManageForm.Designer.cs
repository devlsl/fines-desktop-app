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
            this.driverDataGridView.Size = new System.Drawing.Size(348, 445);
            this.driverDataGridView.TabIndex = 4;
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
            // DriverManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(385, 624);
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
    }
}