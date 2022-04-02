using Practice_3_04.ModelIEF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_3_04.Resources.materials
{
    public partial class MinMaterialChangeForm : Form
    {
        public MinMaterialChangeForm()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (TxtMinMatChange.Text == "")
            {
                MessageBox.Show("Не задана величина изменения минимального количества!");
                return;
            }
            double minCount = Convert.ToDouble(TxtMinMatChange.Text);
            foreach (var id in Form1.lstselectedIdData)
            {
                Material mat = Program.db.Material.Find(id);
                mat.MinCount = minCount;
            }
            try
            {
                Program.db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void TxtMinMatChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void MinMaterialChangeForm_Load(object sender, EventArgs e)
        {
            double MaxMin = 0; //Переменная для нахождения наибольшего минимального количества среди выделенных материало
            foreach (double id in Form1.lstselectedIdData)
            {
                Material mat = Program.db.Material.Find(id);
                if (MaxMin < mat.MinCount)
                {
                    MaxMin = mat.MinCount;
                }
            }
            TxtMinMatChange.Text = MaxMin.ToString();
        }
    }
}
