using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prac2.ModelData;
using Prac2.UserElement;

namespace Prac2
{
    public partial class Form1 : Form
    {
        private enum SvipeType
        {
            Left,
            Right
        }

        // Перечисление для удобной перемотки элементов
        private Model1 model = new Model1(); // Модель объекта для работы с БД
        private List<Product> products = new List<Product>(); // Список для хранения данных из таблицы Product
        private int SvipeID; // Переменная для номера записи текущего элемента.

        public Form1()
        {
            InitializeComponent();
            Loadproducts();
            CreateTile();
        }
        // Метод для загрузки первоначальных данных
        private void Loadproducts()
        {
            products.Clear();
            SvipeID = 0;
            products = model.Product.ToList();
        }

        // Метод для загрузки первоначальных данных
        private void SetTextLabel()
        {
            if (products.Count != 0)
            {
                labelCount.Text = products.Count >= 6 ? $"< {SvipeID + 1} по {SvipeID + 6} из {products.Count} Товаров" : $"< 1 по {products.Count} из {products.Count} Товаров";
            }
            else
                labelCount.Text = $"< 0 из {products.Count} Товаров";
        }

        // Метод для добавления элементов
        private void CreateTile()
        {
            // Метод удаления всех элементов из FlowLayoutPanel
            FLPTile.Controls.Clear(); // FLPTile - имя элемента FlowLayoutPanel
            SetTextLabel();

            for (int i = 0; i < 6; i++)
            {
                if (products.Count > i + SvipeID)
                {
                    int count = i + SvipeID;
                    // Создание нового объекта элемента UserFile
                    UserTile tile = new UserTile(products[count]);
                    // Добавление созданного объекта элемента UserFile в FLPTile (отображение на экране)
                    FLPTile.Controls.Add(tile);
                }
            }
        }

        // Метод для поиска элементов в БД по имени
        private void Search()
        {
            products.Clear();
            SvipeID = 0;
            // Поиск в БД, где поле Title содержит написанное в textBoxSearch
            products = model.Product.Where(x => x.Title.Contains(textBoxSearch.Text)).ToList();
            labelNothing.Visible = products.Count == 0 ? true : false;
            CreateTile();
        }

        // Метод перемотки элементов
        private void Svipe(SvipeType svipeType)
        {
            if (svipeType == SvipeType.Left && SvipeID != 0)
            {
                SvipeID--;
                CreateTile();
            }
            if (svipeType == SvipeType.Right && SvipeID + 5 < products.Count - 1)
            {
                SvipeID++;
                CreateTile();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLeftx2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
                Svipe(SvipeType.Left);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            Svipe(SvipeType.Left);
        }

        private void buttonRightx2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
                Svipe(SvipeType.Left);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            Svipe(SvipeType.Left);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}