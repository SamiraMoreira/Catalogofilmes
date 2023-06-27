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
    public partial class TelaControllerSerie : Form
    {
        public TelaControllerSerie()
        {
            InitializeComponent();
        }

        private void cBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Serie.NomeSerie = txBoxSerie.Text;
            Serie.EstreiaSerie = txBoxEstreia.Text;
            Serie.CategoriaSerie = cBoxCategoria.Text;
            Serie.DuracaoSerie = txBoxDuracao.Text;

            SerieController serie = new SerieController();
            serie.CadastrarSerie();
        }
    }
}
