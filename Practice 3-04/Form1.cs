using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practice_3_04.ModelIEF;

namespace Practice_3_04
{
    public partial class Form1 : Form
    {
        // параметры управления выполнением операций определения списка товаров
        string search = ""; // строка поиска
        string sort = "Без сортировки"; // вид сортировка
        string filtr = "Все материалы"; // название производителя
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            materialTypeBindingSource.DataSource = Program.db.MaterialType.ToList();
            materialBindingSource.DataSource = Program.db.Material.ToList();
            CmbSort.SelectedIndex = 0; //Устанавливаем начальное значение для комбобокса сортировки
            List<string> lstfiltr = Program.db.MaterialType.Select(a => a.Title).OrderBy(s => s).ToList(); //Создание стринг коллекции типа материала и сортировка ее по возрастанию
            lstfiltr.Insert(0, "Все материалы");
            CmbFiltr.DataSource = lstfiltr; // Присвоение кастомного источника данных комбобоксу фильтрации
            CmbFiltr.SelectedIndex = 0; //Уснавливаем начальное значение для комбобокса фильтрации по типу материала
            Podgotovka();
        }

        private void materialDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void materialDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (materialDataGridView[4, e.RowIndex].Value == null) return;
            double sklad = (double)(materialDataGridView[4, e.RowIndex].Value);
            double min = (double)materialDataGridView[5, e.RowIndex].Value;
            if (sklad < min)
            {
                e.CellStyle.BackColor = Color.FromArgb(0xF1, 0x92, 0x92);
            }
            if (sklad > min*3)
            {
                e.CellStyle.BackColor = Color.FromArgb(0xff, 0xba, 0x01);
            }
        }

        private void TxtSrch_TextChanged(object sender, EventArgs e)
        {
            search = TxtSrch.Text;
            Podgotovka();
        }

        private void CmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            sort = CmbSort.Text;
            Podgotovka();
        }

        private void ChkDown_CheckedChanged(object sender, EventArgs e)
        {
            Podgotovka();
        }

        private void CmbFiltr_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtr = CmbFiltr.Text;
            Podgotovka();
        }
        List<Material> lstFormatData = new List<Material>(); // Создание коллекции всех объектов типа material
        public void Podgotovka()
        {
            lstFormatData = Program.db.Material.ToList();
            if (filtr != "Все материалы")
            {
                lstFormatData = lstFormatData.Where(p => p.MaterialType.Title == filtr).ToList();//Присвоить LstFormatData то название типа материала, которое указано в filtr

            }
            if (search != "")
            {
                lstFormatData = lstFormatData.Where(s => s.Title.ToLower().Contains(search)).ToList(); //Найти, содержится ли введённое в поиске в каком-либо из названий материала

                if (lstFormatData.Count == 0) //Если результатов не найдено
                {
                    MessageBox.Show("Строка " + search + " не найдена!");
                }
            }
            if (sort != "Без сортировки")
            {
                if (sort == "Название")
                {
                    if (!ChkDown.Checked)
                    {
                        lstFormatData = lstFormatData.OrderBy(p => p.Title).ToList(); //Сортировать наименование по возрастанию (чекбокс не прожат)
                    }
                    else
                    {
                        lstFormatData = lstFormatData.OrderByDescending (p => p.Title).ToList(); //Сортировать по убыванию
                    }
                }
                if (sort == "Стоимость")
                {
                    if (!ChkDown.Checked)
                    {
                        lstFormatData = lstFormatData.OrderBy(c => c.Cost).ToList(); //Сортировать цену по возрастанию
                    }
                    else
                    {
                        lstFormatData = lstFormatData.OrderByDescending(c => c.Cost).ToList(); //Сортировать по убыванию
                    }
                }
            }
            LblRng.Text =$"Всего товаров: {lstFormatData.Count}";//Вывод информации о количестве товаров
            materialBindingSource.DataSource = lstFormatData; //Финальное обновление источника данных
        }

        private void BtnAddMaterial_Click(object sender, EventArgs e)
        {
            AddEditMaterialFrm addFrm = new AddEditMaterialFrm();
            addFrm.material = null;
            DialogResult dr = addFrm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Podgotovka();
            }
        }

        private void BtnEditMaterial_Click(object sender, EventArgs e)
        {
            Material material = (Material)materialBindingSource.Current;
            AddEditMaterialFrm eddFrm = new AddEditMaterialFrm();
            eddFrm.material = material;
            DialogResult dr2 = eddFrm.ShowDialog();
            if (dr2 == DialogResult.OK)
            {
                Podgotovka();
            }
        }

        private void BtnDelMaterial_Click(object sender, EventArgs e)
        {
            Material mat = (Material)materialBindingSource.Current;
            DialogResult dr = MessageBox.Show("Вы действительно хотите удалить данный товар?", "Удаление товара", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Program.db.Material.Remove(mat);
                try
                {
                    Program.db.SaveChanges();
                    Podgotovka();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
