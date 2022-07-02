using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_03
{
    public partial class TelaImagem : Form
    {
        public TelaImagem()
        {
            InitializeComponent();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            openFileDialogFoto.Filter = "Arquivos jpg | *.jpg | Arquivos png | *.png";

            if (openFileDialogFoto.ShowDialog() == DialogResult.OK)
            {
                pbxFoto.ImageLocation = openFileDialogFoto.FileName;
            }
        }
    }
}
