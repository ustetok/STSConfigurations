
namespace test
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patients2DataSet = new test.Patients2DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_PatientTableAdapter = new test.Patients2DataSetTableAdapters.T_PatientTableAdapter();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstFuriganaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.telHPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailHPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelBoxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.introducerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fPhotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.firstVisitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextApoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextApo2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextApo3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patients2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPatientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.patients2DataSet;
            this.bindingSource1.Position = 0;
            // 
            // patients2DataSet
            // 
            this.patients2DataSet.DataSetName = "Patients2DataSet";
            this.patients2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIDDataGridViewTextBoxColumn,
            this.familyIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.firstFuriganaDataGridViewTextBoxColumn,
            this.birthDayDataGridViewTextBoxColumn,
            this.maleDataGridViewCheckBoxColumn,
            this.telHPDataGridViewTextBoxColumn,
            this.eMailHPDataGridViewTextBoxColumn,
            this.modelBoxDataGridViewTextBoxColumn,
            this.schoolIDDataGridViewTextBoxColumn,
            this.schoolGradeDataGridViewTextBoxColumn,
            this.memoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.introducerIDDataGridViewTextBoxColumn,
            this.fPhotoDataGridViewImageColumn,
            this.firstVisitDataGridViewTextBoxColumn,
            this.nextApoDataGridViewTextBoxColumn,
            this.nextApo2DataGridViewTextBoxColumn,
            this.nextApo3DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tPatientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(278, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // tPatientBindingSource
            // 
            this.tPatientBindingSource.DataMember = "T_Patient";
            this.tPatientBindingSource.DataSource = this.bindingSource1;
            // 
            // t_PatientTableAdapter
            // 
            this.t_PatientTableAdapter.ClearBeforeFill = true;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // familyIDDataGridViewTextBoxColumn
            // 
            this.familyIDDataGridViewTextBoxColumn.DataPropertyName = "FamilyID";
            this.familyIDDataGridViewTextBoxColumn.HeaderText = "FamilyID";
            this.familyIDDataGridViewTextBoxColumn.Name = "familyIDDataGridViewTextBoxColumn";
            this.familyIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstFuriganaDataGridViewTextBoxColumn
            // 
            this.firstFuriganaDataGridViewTextBoxColumn.DataPropertyName = "FirstFurigana";
            this.firstFuriganaDataGridViewTextBoxColumn.HeaderText = "FirstFurigana";
            this.firstFuriganaDataGridViewTextBoxColumn.Name = "firstFuriganaDataGridViewTextBoxColumn";
            this.firstFuriganaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthDayDataGridViewTextBoxColumn
            // 
            this.birthDayDataGridViewTextBoxColumn.DataPropertyName = "BirthDay";
            this.birthDayDataGridViewTextBoxColumn.HeaderText = "BirthDay";
            this.birthDayDataGridViewTextBoxColumn.Name = "birthDayDataGridViewTextBoxColumn";
            this.birthDayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maleDataGridViewCheckBoxColumn
            // 
            this.maleDataGridViewCheckBoxColumn.DataPropertyName = "Male";
            this.maleDataGridViewCheckBoxColumn.HeaderText = "Male";
            this.maleDataGridViewCheckBoxColumn.Name = "maleDataGridViewCheckBoxColumn";
            this.maleDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // telHPDataGridViewTextBoxColumn
            // 
            this.telHPDataGridViewTextBoxColumn.DataPropertyName = "TelHP";
            this.telHPDataGridViewTextBoxColumn.HeaderText = "TelHP";
            this.telHPDataGridViewTextBoxColumn.Name = "telHPDataGridViewTextBoxColumn";
            this.telHPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMailHPDataGridViewTextBoxColumn
            // 
            this.eMailHPDataGridViewTextBoxColumn.DataPropertyName = "EMailHP";
            this.eMailHPDataGridViewTextBoxColumn.HeaderText = "EMailHP";
            this.eMailHPDataGridViewTextBoxColumn.Name = "eMailHPDataGridViewTextBoxColumn";
            this.eMailHPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelBoxDataGridViewTextBoxColumn
            // 
            this.modelBoxDataGridViewTextBoxColumn.DataPropertyName = "ModelBox";
            this.modelBoxDataGridViewTextBoxColumn.HeaderText = "ModelBox";
            this.modelBoxDataGridViewTextBoxColumn.Name = "modelBoxDataGridViewTextBoxColumn";
            this.modelBoxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // schoolIDDataGridViewTextBoxColumn
            // 
            this.schoolIDDataGridViewTextBoxColumn.DataPropertyName = "SchoolID";
            this.schoolIDDataGridViewTextBoxColumn.HeaderText = "SchoolID";
            this.schoolIDDataGridViewTextBoxColumn.Name = "schoolIDDataGridViewTextBoxColumn";
            this.schoolIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // schoolGradeDataGridViewTextBoxColumn
            // 
            this.schoolGradeDataGridViewTextBoxColumn.DataPropertyName = "SchoolGrade";
            this.schoolGradeDataGridViewTextBoxColumn.HeaderText = "SchoolGrade";
            this.schoolGradeDataGridViewTextBoxColumn.Name = "schoolGradeDataGridViewTextBoxColumn";
            this.schoolGradeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memoDataGridViewTextBoxColumn
            // 
            this.memoDataGridViewTextBoxColumn.DataPropertyName = "Memo";
            this.memoDataGridViewTextBoxColumn.HeaderText = "Memo";
            this.memoDataGridViewTextBoxColumn.Name = "memoDataGridViewTextBoxColumn";
            this.memoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // introducerIDDataGridViewTextBoxColumn
            // 
            this.introducerIDDataGridViewTextBoxColumn.DataPropertyName = "IntroducerID";
            this.introducerIDDataGridViewTextBoxColumn.HeaderText = "IntroducerID";
            this.introducerIDDataGridViewTextBoxColumn.Name = "introducerIDDataGridViewTextBoxColumn";
            this.introducerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fPhotoDataGridViewImageColumn
            // 
            this.fPhotoDataGridViewImageColumn.DataPropertyName = "FPhoto";
            this.fPhotoDataGridViewImageColumn.HeaderText = "FPhoto";
            this.fPhotoDataGridViewImageColumn.Name = "fPhotoDataGridViewImageColumn";
            this.fPhotoDataGridViewImageColumn.ReadOnly = true;
            // 
            // firstVisitDataGridViewTextBoxColumn
            // 
            this.firstVisitDataGridViewTextBoxColumn.DataPropertyName = "FirstVisit";
            this.firstVisitDataGridViewTextBoxColumn.HeaderText = "FirstVisit";
            this.firstVisitDataGridViewTextBoxColumn.Name = "firstVisitDataGridViewTextBoxColumn";
            this.firstVisitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nextApoDataGridViewTextBoxColumn
            // 
            this.nextApoDataGridViewTextBoxColumn.DataPropertyName = "NextApo";
            this.nextApoDataGridViewTextBoxColumn.HeaderText = "NextApo";
            this.nextApoDataGridViewTextBoxColumn.Name = "nextApoDataGridViewTextBoxColumn";
            this.nextApoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nextApo2DataGridViewTextBoxColumn
            // 
            this.nextApo2DataGridViewTextBoxColumn.DataPropertyName = "NextApo2";
            this.nextApo2DataGridViewTextBoxColumn.HeaderText = "NextApo2";
            this.nextApo2DataGridViewTextBoxColumn.Name = "nextApo2DataGridViewTextBoxColumn";
            this.nextApo2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nextApo3DataGridViewTextBoxColumn
            // 
            this.nextApo3DataGridViewTextBoxColumn.DataPropertyName = "NextApo3";
            this.nextApo3DataGridViewTextBoxColumn.HeaderText = "NextApo3";
            this.nextApo3DataGridViewTextBoxColumn.Name = "nextApo3DataGridViewTextBoxColumn";
            this.nextApo3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patients2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPatientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private Patients2DataSet patients2DataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tPatientBindingSource;
        private Patients2DataSetTableAdapters.T_PatientTableAdapter t_PatientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstFuriganaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn maleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telHPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailHPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelBoxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn introducerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fPhotoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstVisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextApoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextApo2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextApo3DataGridViewTextBoxColumn;
    }
}

