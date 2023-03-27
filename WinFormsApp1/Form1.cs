using System;
using System.Drawing.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void listCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = listCity.GetItemText(listCity.SelectedItem);
            MessageBox.Show(text);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;

            MessageBox.Show("Name:" + name + " \nAddress:" + address);

        }
    }
}