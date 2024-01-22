using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace PracWinForms1
{
    public partial class Form1 : Form
    {
        double[] arr = { 1, 2, 3, 4 }; // Используем double вместо int

        public Form1()
        {
            InitializeComponent();
            // Устанавливаем культуру, где дробная часть разделяется точкой
            CultureInfo culture = new CultureInfo("en-US"); // Здесь "en-US" - это культура США с точкой в качестве разделителя десятичной части
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            UpdateArrayTextBox();
        }

        // Метод, который будет вызываться при нажатии на кнопки
        private void Button_Click(object sender, EventArgs e)
        {
            // Вызываем метод для обновления массива из текста в ArrayTextBox
            UpdateArrayFromTextBox();

            if (arr.Length > 0)
            {
                // В зависимости от кнопки обновляем соответствующие текстбоксы
                if (sender == SumButton)
                {
                    SumTextBox.Text = arr.Sum().ToString();
                }

                else if (sender == ProductButton)
                {
                    double prod = 1;
                    for (int i = 0; i < arr.Length; i++) prod *= arr[i];
                    ProductTextBox.Text = prod.ToString();
                }

                else if (sender == MaxButton)
                {
                    MaxTextBox.Text = arr.Max().ToString();
                }

                else if (sender == MinButton)
                {
                    MinTextBox.Text = arr.Min().ToString();
                }
            }

            else
            {
                MessageBox.Show("Ошибка ввода. Пустой массив");
            }
        }

        // Метод для обновления массива из текста в ArrayTextBox
        private void UpdateArrayFromTextBox()
        {
            string input = ArrayTextBox.Text;

            // Разделяем строку на массив строк, используя запятую в качестве разделителя
            string[] inputArray = input.Split(',');

            // Фильтруем массив, удаляя пустые строки и строки, состоящие только из пробелов
            inputArray = inputArray.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();

            // Создаем новый массив для хранения чисел
            double[] newArray = new double[inputArray.Length]; // Используем double вместо int

            // Преобразуем каждую строку в дробное число и добавляем в новый массив
            for (int i = 0; i < inputArray.Length; i++)
            {
                // Удаляем лишние пробелы вокруг каждой строки
                string trimmedValue = inputArray[i].Trim();

                if (double.TryParse(trimmedValue, out double num)) // Используем double.TryParse вместо int.TryParse
                {
                    newArray[i] = num;
                }

                else
                {
                    MessageBox.Show("Ошибка ввода. Пожалуйста, введите корректные числа, разделенные запятой.");
                    return;
                }
            }

            // Присваиваем новый массив переменной arr
            arr = newArray;

            // Опционально: обновляем текстбокс с текущим массивом
            UpdateArrayTextBox();
        }

        private void UpdateArrayTextBox()
        {
            ArrayTextBox.Text = string.Join(", ", arr);
        }
    }
}
