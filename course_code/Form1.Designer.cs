namespace course_code
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;



        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора код.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnQuery4 = new System.Windows.Forms.Button();
            this.btnQuery3 = new System.Windows.Forms.Button();
            this.btnQuery1 = new System.Windows.Forms.Button();
            this.btnQuery2 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.numLaboratories = new System.Windows.Forms.NumericUpDown();
            this.numPractices = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDisciplineName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSpecializationCode = new System.Windows.Forms.TextBox();
            this.txtDepartmentCode = new System.Windows.Forms.TextBox();
            this.numLectures = new System.Windows.Forms.NumericUpDown();
            this.cmbSign = new System.Windows.Forms.ComboBox();
            this.ColumnSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKaf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLaboratories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPractices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLectures)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSpec,
            this.ColumnName,
            this.ColumnKaf,
            this.ColumnLek,
            this.ColumnPrak,
            this.ColumnLab,
            this.ColumnSign});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(650, 561);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnQuery4);
            this.panelButtons.Controls.Add(this.btnQuery3);
            this.panelButtons.Controls.Add(this.btnQuery1);
            this.panelButtons.Controls.Add(this.btnQuery2);
            this.panelButtons.Controls.Add(this.btnCancel);
            this.panelButtons.Controls.Add(this.btnSave);
            this.panelButtons.Controls.Add(this.btnDelete);
            this.panelButtons.Controls.Add(this.btnEdit);
            this.panelButtons.Controls.Add(this.btnAdd);
            this.panelButtons.Controls.Add(this.groupBoxEdit);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(664, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(320, 561);
            this.panelButtons.TabIndex = 1;
            // 
            // btnQuery4
            // 
            this.btnQuery4.Location = new System.Drawing.Point(10, 490);
            this.btnQuery4.Name = "btnQuery4";
            this.btnQuery4.Size = new System.Drawing.Size(290, 30);
            this.btnQuery4.TabIndex = 10;
            this.btnQuery4.Text = "Дисциплины кафедры";
            this.btnQuery4.UseVisualStyleBackColor = true;
            this.btnQuery4.Click += new System.EventHandler(this.btnQuery4_Click);
            // 
            // btnQuery3
            // 
            this.btnQuery3.Location = new System.Drawing.Point(10, 450);
            this.btnQuery3.Name = "btnQuery3";
            this.btnQuery3.Size = new System.Drawing.Size(290, 30);
            this.btnQuery3.TabIndex = 9;
            this.btnQuery3.Text = "Лекции по кафедрам";
            this.btnQuery3.UseVisualStyleBackColor = true;
            this.btnQuery3.Click += new System.EventHandler(this.btnQuery3_Click);
            // 
            // btnQuery1
            // 
            this.btnQuery1.Location = new System.Drawing.Point(10, 370);
            this.btnQuery1.Name = "btnQuery1";
            this.btnQuery1.Size = new System.Drawing.Size(290, 30);
            this.btnQuery1.TabIndex = 8;
            this.btnQuery1.Text = "Занятия кафедры";
            this.btnQuery1.UseVisualStyleBackColor = true;
            this.btnQuery1.Click += new System.EventHandler(this.btnQuery1_Click);
            // 
            // btnQuery2
            // 
            this.btnQuery2.Location = new System.Drawing.Point(10, 410);
            this.btnQuery2.Name = "btnQuery2";
            this.btnQuery2.Size = new System.Drawing.Size(290, 30);
            this.btnQuery2.TabIndex = 7;
            this.btnQuery2.Text = "Дисциплины спец.";
            this.btnQuery2.UseVisualStyleBackColor = true;
            this.btnQuery2.Click += new System.EventHandler(this.btnQuery2_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Image = global::course_code.Properties.Resources.cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(85, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 30);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "       Отменить";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Image = global::course_code.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(160, 280);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "       Сохранить";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::course_code.Properties.Resources.delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(10, 280);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "       Удалить";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::course_code.Properties.Resources.edit;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(160, 240);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 30);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "       Изменить";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(10, 240);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "       Добавить";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxEdit.Location = new System.Drawing.Point(10, 10);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(300, 220);
            this.groupBoxEdit.TabIndex = 0;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Редактирование записи";
            this.groupBoxEdit.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel1.Controls.Add(this.numLaboratories, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.numPractices, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDisciplineName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSpecializationCode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDepartmentCode, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.numLectures, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbSign, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 199);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // numLaboratories
            // 
            this.numLaboratories.Location = new System.Drawing.Point(160, 143);
            this.numLaboratories.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numLaboratories.Name = "numLaboratories";
            this.numLaboratories.Size = new System.Drawing.Size(120, 22);
            this.numLaboratories.TabIndex = 16;
            // 
            // numPractices
            // 
            this.numPractices.Location = new System.Drawing.Point(160, 115);
            this.numPractices.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPractices.Name = "numPractices";
            this.numPractices.Size = new System.Drawing.Size(120, 22);
            this.numPractices.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Признак";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Лабораторные";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Практики";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Лекции";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Шифр кафедры";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDisciplineName
            // 
            this.txtDisciplineName.Location = new System.Drawing.Point(160, 31);
            this.txtDisciplineName.Name = "txtDisciplineName";
            this.txtDisciplineName.Size = new System.Drawing.Size(100, 22);
            this.txtDisciplineName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дисциплина";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Шифр специальности";
            // 
            // txtSpecializationCode
            // 
            this.txtSpecializationCode.Location = new System.Drawing.Point(160, 3);
            this.txtSpecializationCode.Name = "txtSpecializationCode";
            this.txtSpecializationCode.Size = new System.Drawing.Size(100, 22);
            this.txtSpecializationCode.TabIndex = 1;
            // 
            // txtDepartmentCode
            // 
            this.txtDepartmentCode.Location = new System.Drawing.Point(160, 59);
            this.txtDepartmentCode.Name = "txtDepartmentCode";
            this.txtDepartmentCode.Size = new System.Drawing.Size(100, 22);
            this.txtDepartmentCode.TabIndex = 4;
            // 
            // numLectures
            // 
            this.numLectures.Location = new System.Drawing.Point(160, 87);
            this.numLectures.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numLectures.Name = "numLectures";
            this.numLectures.Size = new System.Drawing.Size(120, 22);
            this.numLectures.TabIndex = 14;
            // 
            // cmbSign
            // 
            this.cmbSign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSign.FormattingEnabled = true;
            this.cmbSign.Items.AddRange(new object[] {
            "Нет",
            "Зачет",
            "Экзамен"});
            this.cmbSign.Location = new System.Drawing.Point(160, 171);
            this.cmbSign.Name = "cmbSign";
            this.cmbSign.Size = new System.Drawing.Size(121, 24);
            this.cmbSign.TabIndex = 17;
            // 
            // ColumnSpec
            // 
            this.ColumnSpec.HeaderText = "Шифр спец.";
            this.ColumnSpec.MinimumWidth = 50;
            this.ColumnSpec.Name = "ColumnSpec";
            this.ColumnSpec.ReadOnly = true;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Дисциплина";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 95;
            // 
            // ColumnKaf
            // 
            this.ColumnKaf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnKaf.HeaderText = "Шифр каф.";
            this.ColumnKaf.MinimumWidth = 50;
            this.ColumnKaf.Name = "ColumnKaf";
            this.ColumnKaf.ReadOnly = true;
            this.ColumnKaf.Width = 50;
            // 
            // ColumnLek
            // 
            this.ColumnLek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnLek.HeaderText = "Лекции";
            this.ColumnLek.MinimumWidth = 6;
            this.ColumnLek.Name = "ColumnLek";
            this.ColumnLek.ReadOnly = true;
            // 
            // ColumnPrak
            // 
            this.ColumnPrak.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPrak.HeaderText = "Практики";
            this.ColumnPrak.MinimumWidth = 6;
            this.ColumnPrak.Name = "ColumnPrak";
            this.ColumnPrak.ReadOnly = true;
            // 
            // ColumnLab
            // 
            this.ColumnLab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnLab.HeaderText = "Лабораторные";
            this.ColumnLab.MinimumWidth = 110;
            this.ColumnLab.Name = "ColumnLab";
            this.ColumnLab.ReadOnly = true;
            // 
            // ColumnSign
            // 
            this.ColumnSign.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSign.HeaderText = "Признак";
            this.ColumnSign.MinimumWidth = 6;
            this.ColumnSign.Name = "ColumnSign";
            this.ColumnSign.ReadOnly = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учебный план";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.groupBoxEdit.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLaboratories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPractices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLectures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1; 
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numLaboratories;
        private System.Windows.Forms.NumericUpDown numPractices;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDisciplineName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSpecializationCode;
        private System.Windows.Forms.TextBox txtDepartmentCode;
        private System.Windows.Forms.NumericUpDown numLectures;
        private System.Windows.Forms.ComboBox cmbSign;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnQuery4;
        private System.Windows.Forms.Button btnQuery3;
        private System.Windows.Forms.Button btnQuery1;
        private System.Windows.Forms.Button btnQuery2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKaf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLek;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrak;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLab;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSign;
    }
}