using Practice_3_04.ModelIEF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_3_04
{
    public partial class AddEditMaterialFrm : Form
    {
        public Material material { get; set; } = null; //Создание свойства материал, куда будут записываться все данные
        public AddEditMaterialFrm()
        {
            InitializeComponent();
            
        }
        string filePath = "";
        private void AddEditMaterialFrm_Load(object sender, EventArgs e)
        {            
            materialTypeBindingSource.DataSource = Program.db.MaterialType.ToList();
            materialTypeIDComboBox.SelectedIndex = 0;
            if (material ==null)
            {
                Material mt = new Material();

                ImgMaterial.Image = Properties.Resources.Черновик;

                materialBindingSource.Add(mt);

                this.Text = "Добавление нового материала ";
                LblTitle.Text = "Ввод данных нового материала";

            }
            else
            {
                materialBindingSource.Add(material);
                if (material.Image !="")
                {
                    ImgMaterial.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory()+material.Image);
                    //System.IO.Path.DirectorySeparatorChar разделитель для директории, если бы слэша в базе данных не было
                }
                else
                {
                    ImgMaterial.Image = Properties.Resources.Черновик;
                }
                this.Text = "Редактирование данных материала " + material.ID.ToString();
                LblTitle.Text = "Изменение выбранного материала";
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (material == null)
            {
                material = (Material)materialBindingSource.Current;
                Program.db.Material.Add(material);
            }
            if (filePath !="")
            {
                material.Image = filePath;
            }
            try
            {
                Program.db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Возникла непредвиденная ошибка " + ex.Message);
            }
        }

        private void BtnSelectPic_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Файлы изображений|*.jpg;*.jpeg;*.png";
            ofd.InitialDirectory = Environment.CurrentDirectory;
            //ofd.InitialDirectory +=@"..\Папка с картинками\";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                FileInfo fileInf = new FileInfo(ofd.FileName);
                long size = fileInf.Length;
                if (size > 2000000)
                {
                    MessageBox.Show("Размер файла больше 2мб!");
                    return;
                }
                int n = ofd.FileName.IndexOf("Practice 3-04");
                if (n<0)
                {
                    return;
                }
                filePath = ofd.FileName.Substring(n);
                imageTextBox.Text = filePath;
                ImgMaterial.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
