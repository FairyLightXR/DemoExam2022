namespace Practice_3_04.Resources.materials
{
    partial class MinMaterialChangeForm
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
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxtMinMatChange = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(74, 205);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 0;
            this.BtnEdit.Text = "Изменить";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(286, 205);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TxtMinMatChange
            // 
            this.TxtMinMatChange.Location = new System.Drawing.Point(303, 108);
            this.TxtMinMatChange.Name = "TxtMinMatChange";
            this.TxtMinMatChange.Size = new System.Drawing.Size(100, 20);
            this.TxtMinMatChange.TabIndex = 1;
            this.TxtMinMatChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMinMatChange_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "На сколько изменить минимальное количество:";
            // 
            // MinMaterialChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 304);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtMinMatChange);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnEdit);
            this.Name = "MinMaterialChangeForm";
            this.Text = "Изменение минимального количества материалов";
            this.Load += new System.EventHandler(this.MinMaterialChangeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtMinMatChange;
        private System.Windows.Forms.Label label1;
    }
}