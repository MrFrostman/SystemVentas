using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemVentas
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void catalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategorias Cate = new FormCategorias();
            Cate.Show();
        }
    }
}
