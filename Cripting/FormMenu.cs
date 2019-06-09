using System;
using System.Windows.Forms;

namespace Cripting
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void ButtonCes_Click(object sender, EventArgs e)
        {
            FormCes fCes = new FormCes();
            fCes.Show();
            Hide();
        }
    }
}
