
namespace Practice_3_04
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.materialTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSrch = new System.Windows.Forms.TextBox();
            this.CmbSort = new System.Windows.Forms.ComboBox();
            this.CmbFiltr = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ChkDown = new System.Windows.Forms.CheckBox();
            this.LblRng = new System.Windows.Forms.Label();
            this.BtnAddMaterial = new System.Windows.Forms.Button();
            this.BtnEditMaterial = new System.Windows.Forms.Button();
            this.BtnDelMaterial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialDataGridView
            // 
            this.materialDataGridView.AllowUserToAddRows = false;
            this.materialDataGridView.AllowUserToDeleteRows = false;
            this.materialDataGridView.AutoGenerateColumns = false;
            this.materialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.materialDataGridView.DataSource = this.materialBindingSource;
            this.materialDataGridView.Location = new System.Drawing.Point(30, 124);
            this.materialDataGridView.Name = "materialDataGridView";
            this.materialDataGridView.ReadOnly = true;
            this.materialDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materialDataGridView.RowTemplate.Height = 30;
            this.materialDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.materialDataGridView.Size = new System.Drawing.Size(915, 409);
            this.materialDataGridView.TabIndex = 1;
            this.materialDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.materialDataGridView_CellFormatting);
            this.materialDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.materialDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CountInPack";
            this.dataGridViewTextBoxColumn3.HeaderText = "Кол-воВупаковке";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Unit";
            this.dataGridViewTextBoxColumn4.HeaderText = "ЕдиницаИзмерения";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 133;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CountInStock";
            this.dataGridViewTextBoxColumn5.HeaderText = "НаСкладе";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 83;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MinCount";
            this.dataGridViewTextBoxColumn6.HeaderText = "МинимальноеКоличество";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 162;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn7.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Cost";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn8.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 58;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Image";
            this.dataGridViewTextBoxColumn9.HeaderText = "Image";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "MaterialTypeID";
            this.dataGridViewTextBoxColumn10.DataSource = this.materialTypeBindingSource;
            this.dataGridViewTextBoxColumn10.DisplayMember = "Title";
            this.dataGridViewTextBoxColumn10.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn10.HeaderText = "ТипМатериала";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn10.ValueMember = "ID";
            this.dataGridViewTextBoxColumn10.Width = 107;
            // 
            // materialTypeBindingSource
            // 
            this.materialTypeBindingSource.DataSource = typeof(Practice_3_04.ModelIEF.MaterialType);
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = typeof(Practice_3_04.ModelIEF.Material);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(379, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Бумажные материалы";
            // 
            // TxtSrch
            // 
            this.TxtSrch.Location = new System.Drawing.Point(27, 80);
            this.TxtSrch.Name = "TxtSrch";
            this.TxtSrch.Size = new System.Drawing.Size(200, 20);
            this.TxtSrch.TabIndex = 3;
            this.TxtSrch.TextChanged += new System.EventHandler(this.TxtSrch_TextChanged);
            // 
            // CmbSort
            // 
            this.CmbSort.FormattingEnabled = true;
            this.CmbSort.Items.AddRange(new object[] {
            "Без сортировки",
            "Название",
            "Стоимость"});
            this.CmbSort.Location = new System.Drawing.Point(407, 80);
            this.CmbSort.Name = "CmbSort";
            this.CmbSort.Size = new System.Drawing.Size(121, 21);
            this.CmbSort.TabIndex = 4;
            this.CmbSort.SelectedIndexChanged += new System.EventHandler(this.CmbSort_SelectedIndexChanged);
            // 
            // CmbFiltr
            // 
            this.CmbFiltr.FormattingEnabled = true;
            this.CmbFiltr.Location = new System.Drawing.Point(826, 80);
            this.CmbFiltr.Name = "CmbFiltr";
            this.CmbFiltr.Size = new System.Drawing.Size(121, 21);
            this.CmbFiltr.TabIndex = 4;
            this.CmbFiltr.SelectedIndexChanged += new System.EventHandler(this.CmbFiltr_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Поиск";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сортировка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(823, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Фильтрация";
            // 
            // ChkDown
            // 
            this.ChkDown.AutoSize = true;
            this.ChkDown.Location = new System.Drawing.Point(535, 83);
            this.ChkDown.Name = "ChkDown";
            this.ChkDown.Size = new System.Drawing.Size(94, 17);
            this.ChkDown.TabIndex = 6;
            this.ChkDown.Text = "По убыванию";
            this.ChkDown.UseVisualStyleBackColor = true;
            this.ChkDown.CheckedChanged += new System.EventHandler(this.ChkDown_CheckedChanged);
            // 
            // LblRng
            // 
            this.LblRng.AutoSize = true;
            this.LblRng.Location = new System.Drawing.Point(30, 13);
            this.LblRng.Name = "LblRng";
            this.LblRng.Size = new System.Drawing.Size(87, 13);
            this.LblRng.TabIndex = 7;
            this.LblRng.Text = "Всего товаров: ";
            // 
            // BtnAddMaterial
            // 
            this.BtnAddMaterial.Location = new System.Drawing.Point(33, 549);
            this.BtnAddMaterial.Name = "BtnAddMaterial";
            this.BtnAddMaterial.Size = new System.Drawing.Size(194, 30);
            this.BtnAddMaterial.TabIndex = 8;
            this.BtnAddMaterial.Text = "Добавить материал";
            this.BtnAddMaterial.UseVisualStyleBackColor = true;
            this.BtnAddMaterial.Click += new System.EventHandler(this.BtnAddMaterial_Click);
            // 
            // BtnEditMaterial
            // 
            this.BtnEditMaterial.Location = new System.Drawing.Point(407, 549);
            this.BtnEditMaterial.Name = "BtnEditMaterial";
            this.BtnEditMaterial.Size = new System.Drawing.Size(194, 30);
            this.BtnEditMaterial.TabIndex = 8;
            this.BtnEditMaterial.Text = "Изменить материал";
            this.BtnEditMaterial.UseVisualStyleBackColor = true;
            this.BtnEditMaterial.Click += new System.EventHandler(this.BtnEditMaterial_Click);
            // 
            // BtnDelMaterial
            // 
            this.BtnDelMaterial.Location = new System.Drawing.Point(751, 549);
            this.BtnDelMaterial.Name = "BtnDelMaterial";
            this.BtnDelMaterial.Size = new System.Drawing.Size(194, 30);
            this.BtnDelMaterial.TabIndex = 8;
            this.BtnDelMaterial.Text = "Удалить материал";
            this.BtnDelMaterial.UseVisualStyleBackColor = true;
            this.BtnDelMaterial.Click += new System.EventHandler(this.BtnDelMaterial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 600);
            this.Controls.Add(this.BtnDelMaterial);
            this.Controls.Add(this.BtnEditMaterial);
            this.Controls.Add(this.BtnAddMaterial);
            this.Controls.Add(this.LblRng);
            this.Controls.Add(this.ChkDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbFiltr);
            this.Controls.Add(this.CmbSort);
            this.Controls.Add(this.TxtSrch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialDataGridView);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource materialBindingSource;
        private System.Windows.Forms.DataGridView materialDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingSource materialTypeBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSrch;
        private System.Windows.Forms.ComboBox CmbSort;
        private System.Windows.Forms.ComboBox CmbFiltr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ChkDown;
        private System.Windows.Forms.Label LblRng;
        private System.Windows.Forms.Button BtnAddMaterial;
        private System.Windows.Forms.Button BtnEditMaterial;
        private System.Windows.Forms.Button BtnDelMaterial;
    }
}

