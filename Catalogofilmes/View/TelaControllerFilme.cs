using Catalogofilmes.Controller;
using Catalogofilmes.Model;
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
    public partial class TelaControllerFilme : Form
    {
        public TelaControllerFilme()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txBoxFilme_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaControllerFilme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filme.NomeFilme = txBoxFilme.Text;
            Filme.EstreiaFilme = txBoxEstreia.Text;
            Filme.DuracaoFilme = txBoxDuracao.Text;
            Filme.CategoriaFilme = cBoxCategoria.Text;
            
            FilmeController filmeController = new FilmeController();
            filmeController.CadastrarFilme();
        }
    }
}
