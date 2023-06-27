using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogofilmes.View
{
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaControllerSerie serie = new TelaControllerSerie();
            serie.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaControllerFilme filme= new TelaControllerFilme();
            filme.Show();
        }
    }
}
