
namespace Practice_3_04
{
    partial class AddEditMaterialFrm
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
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label countInPackLabel;
            System.Windows.Forms.Label countInStockLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label materialTypeIDLabel;
            System.Windows.Forms.Label minCountLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label unitLabel;
            System.Windows.Forms.Label imageLabel1;
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countInPackTextBox = new System.Windows.Forms.TextBox();
            this.countInStockTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.materialTypeIDComboBox = new System.Windows.Forms.ComboBox();
            this.materialTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.minCountTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSelectPic = new System.Windows.Forms.Button();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.ImgMaterial = new System.Windows.Forms.PictureBox();
            costLabel = new System.Windows.Forms.Label();
            countInPackLabel = new System.Windows.Forms.Label();
            countInStockLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            materialTypeIDLabel = new System.Windows.Forms.Label();
            minCountLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            unitLabel = new System.Windows.Forms.Label();
            imageLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(67, 330);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(43, 16);
            costLabel.TabIndex = 1;
            costLabel.Text = "Цена:";
            // 
            // countInPackLabel
            // 
            countInPackLabel.AutoSize = true;
            countInPackLabel.Location = new System.Drawing.Point(67, 143);
            countInPackLabel.Name = "countInPackLabel";
            countInPackLabel.Size = new System.Drawing.Size(113, 16);
            countInPackLabel.TabIndex = 3;
            countInPackLabel.Text = "Кол-воВупаковке:";
            // 
            // countInStockLabel
            // 
            countInStockLabel.AutoSize = true;
            countInStockLabel.Location = new System.Drawing.Point(67, 206);
            countInStockLabel.Name = "countInStockLabel";
            countInStockLabel.Size = new System.Drawing.Size(70, 16);
            countInStockLabel.TabIndex = 5;
            countInStockLabel.Text = "НаСкладе:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(66, 272);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(70, 16);
            descriptionLabel.TabIndex = 7;
            descriptionLabel.Text = "Описание:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(67, 64);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(25, 16);
            iDLabel.TabIndex = 9;
            iDLabel.Text = "ID:";
            // 
            // materialTypeIDLabel
            // 
            materialTypeIDLabel.AutoSize = true;
            materialTypeIDLabel.Location = new System.Drawing.Point(67, 458);
            materialTypeIDLabel.Name = "materialTypeIDLabel";
            materialTypeIDLabel.Size = new System.Drawing.Size(102, 16);
            materialTypeIDLabel.TabIndex = 13;
            materialTypeIDLabel.Text = "Тип материала:";
            // 
            // minCountLabel
            // 
            minCountLabel.AutoSize = true;
            minCountLabel.Location = new System.Drawing.Point(67, 238);
            minCountLabel.Name = "minCountLabel";
            minCountLabel.Size = new System.Drawing.Size(162, 16);
            minCountLabel.TabIndex = 15;
            minCountLabel.Text = "МинимальноеКоличество:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(67, 103);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(69, 16);
            titleLabel.TabIndex = 17;
            titleLabel.Text = "Название:";
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Location = new System.Drawing.Point(67, 174);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new System.Drawing.Size(126, 16);
            unitLabel.TabIndex = 19;
            unitLabel.Text = "ЕдиницаИзмерения:";
            // 
            // imageLabel1
            // 
            imageLabel1.AutoSize = true;
            imageLabel1.Location = new System.Drawing.Point(67, 362);
            imageLabel1.Name = "imageLabel1";
            imageLabel1.Size = new System.Drawing.Size(93, 16);
            imageLabel1.TabIndex = 23;
            imageLabel1.Text = "Изображение:";
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "Cost", true));
            this.costTextBox.Location = new System.Drawing.Point(233, 323);
            this.costTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(140, 23);
            this.costTextBox.TabIndex = 2;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = typeof(Practice_3_04.ModelIEF.Material);
            // 
            // countInPackTextBox
            // 
            this.countInPackTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "CountInPack", true));
            this.countInPackTextBox.Location = new System.Drawing.Point(232, 140);
            this.countInPackTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.countInPackTextBox.Name = "countInPackTextBox";
            this.countInPackTextBox.Size = new System.Drawing.Size(140, 23);
            this.countInPackTextBox.TabIndex = 4;
            // 
            // countInStockTextBox
            // 
            this.countInStockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "CountInStock", true));
            this.countInStockTextBox.Location = new System.Drawing.Point(232, 199);
            this.countInStockTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.countInStockTextBox.Name = "countInStockTextBox";
            this.countInStockTextBox.Size = new System.Drawing.Size(140, 23);
            this.countInStockTextBox.TabIndex = 6;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(232, 265);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(140, 50);
            this.descriptionTextBox.TabIndex = 8;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(232, 64);
            this.iDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(140, 23);
            this.iDTextBox.TabIndex = 10;
            // 
            // materialTypeIDComboBox
            // 
            this.materialTypeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.materialBindingSource, "MaterialTypeID", true));
            this.materialTypeIDComboBox.DataSource = this.materialTypeBindingSource;
            this.materialTypeIDComboBox.DisplayMember = "Title";
            this.materialTypeIDComboBox.FormattingEnabled = true;
            this.materialTypeIDComboBox.Location = new System.Drawing.Point(232, 450);
            this.materialTypeIDComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.materialTypeIDComboBox.Name = "materialTypeIDComboBox";
            this.materialTypeIDComboBox.Size = new System.Drawing.Size(140, 24);
            this.materialTypeIDComboBox.TabIndex = 14;
            this.materialTypeIDComboBox.ValueMember = "ID";
            // 
            // materialTypeBindingSource
            // 
            this.materialTypeBindingSource.DataSource = typeof(Practice_3_04.ModelIEF.MaterialType);
            // 
            // minCountTextBox
            // 
            this.minCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "MinCount", true));
            this.minCountTextBox.Location = new System.Drawing.Point(232, 231);
            this.minCountTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.minCountTextBox.Name = "minCountTextBox";
            this.minCountTextBox.Size = new System.Drawing.Size(140, 23);
            this.minCountTextBox.TabIndex = 16;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(232, 103);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(140, 23);
            this.titleTextBox.TabIndex = 18;
            // 
            // unitTextBox
            // 
            this.unitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "Unit", true));
            this.unitTextBox.Location = new System.Drawing.Point(232, 167);
            this.unitTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.Size = new System.Drawing.Size(140, 23);
            this.unitTextBox.TabIndex = 20;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(176, 18);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(42, 16);
            this.LblTitle.TabIndex = 21;
            this.LblTitle.Text = "label1";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(68, 521);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(84, 39);
            this.BtnSave.TabIndex = 22;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(297, 521);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(84, 39);
            this.BtnCancel.TabIndex = 22;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSelectPic
            // 
            this.BtnSelectPic.Location = new System.Drawing.Point(493, 272);
            this.BtnSelectPic.Name = "BtnSelectPic";
            this.BtnSelectPic.Size = new System.Drawing.Size(92, 42);
            this.BtnSelectPic.TabIndex = 25;
            this.BtnSelectPic.Text = "Выбрать фото";
            this.BtnSelectPic.UseVisualStyleBackColor = true;
            this.BtnSelectPic.Click += new System.EventHandler(this.BtnSelectPic_Click);
            // 
            // imageTextBox
            // 
            this.imageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "Image", true));
            this.imageTextBox.Location = new System.Drawing.Point(233, 362);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(148, 23);
            this.imageTextBox.TabIndex = 26;
            // 
            // ImgMaterial
            // 
            this.ImgMaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgMaterial.Location = new System.Drawing.Point(446, 348);
            this.ImgMaterial.Name = "ImgMaterial";
            this.ImgMaterial.Size = new System.Drawing.Size(240, 212);
            this.ImgMaterial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgMaterial.TabIndex = 27;
            this.ImgMaterial.TabStop = false;
            // 
            // AddEditMaterialFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 580);
            this.Controls.Add(this.ImgMaterial);
            this.Controls.Add(this.imageTextBox);
            this.Controls.Add(this.BtnSelectPic);
            this.Controls.Add(imageLabel1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(countInPackLabel);
            this.Controls.Add(this.countInPackTextBox);
            this.Controls.Add(countInStockLabel);
            this.Controls.Add(this.countInStockTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(materialTypeIDLabel);
            this.Controls.Add(this.materialTypeIDComboBox);
            this.Controls.Add(minCountLabel);
            this.Controls.Add(this.minCountTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(unitLabel);
            this.Controls.Add(this.unitTextBox);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddEditMaterialFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditMaterialFrm";
            this.Load += new System.EventHandler(this.AddEditMaterialFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource materialBindingSource;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox countInPackTextBox;
        private System.Windows.Forms.TextBox countInStockTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.ComboBox materialTypeIDComboBox;
        private System.Windows.Forms.TextBox minCountTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.BindingSource materialTypeBindingSource;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSelectPic;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.PictureBox ImgMaterial;
    }
}