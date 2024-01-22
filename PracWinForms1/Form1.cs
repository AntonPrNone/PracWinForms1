using System;
using System.Linq;
using System.Windows.Forms;

namespace PracWinForms1
{
    public partial class Form1 : Form
    {
        int[] arr = { 1, 2, 3, 4 };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            SumTextBox.Text = arr.Sum().ToString();
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            int prod = 1;
            for (int i = 0; i < arr.Length; i++) prod *= arr[i];
            ProductTextBox.Text = prod.ToString();
        }

        private void MaxButton_Click(object sender, EventArgs e)
        {
            MaxTextBox.Text = arr.Max().ToString();
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            MinTextBox.Text = arr.Min().ToString();
        }
    }
}
