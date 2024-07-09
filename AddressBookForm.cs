using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class AddressBookForm : Form
    {
        public AddressBookForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string email = textBoxEmail.Text;
            string phone = textBoxPhone.Text;
            MessageBox.Show($"Name: {name}\nEmail: {email}\nPhone: {phone}", "Saved Info");
        }

        private void buttonOpenDrawing_Click(object sender, EventArgs e)
        {
            DrawingForm drawingForm = new DrawingForm();
            drawingForm.Show();
        }
    }
}
