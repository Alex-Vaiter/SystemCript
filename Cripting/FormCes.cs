using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cripting
{
    public partial class FormCes : Form
    {
        private string openText = "";
        public FormCes()
        {
            InitializeComponent();
        }

        private void FormCes_Load(object sender, EventArgs e)
        {

        }

        private void ButtonOpFile_Click(object sender, EventArgs e)
        {
            ClassInputFile input = new ClassInputFile();
            openText = input.GetText();
            textBoxOutput.Text = openText;
        }

        private void ButtonSaveFile_Click(object sender, EventArgs e)
        {

        }
    }
}
