using Catalogofilmes.View;
using Catalogofilmes.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogofilmes.Controller
{
    internal class FilmeController
    {
       public void CadastrarFilme()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("InserirFilmeP", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nome", Filme.NomeFilme);
                cmd.Parameters.AddWithValue("@estreia", Filme.EstreiaFilme);
                cmd.Parameters.AddWithValue("@categoria", Filme.CategoriaFilme);
                cmd.Parameters.AddWithValue("@duracao", Filme.DuracaoFilme);

                SqlParameter nv = cmd.Parameters.Add("@id", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Filme Cadastro com sucesso, " + "Deseja Cadastrar outro Filme?",
                    "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resposta == DialogResult.Yes)
                {
                   TelaControllerFilme TelaFilme = new TelaControllerFilme();
                    
                    TelaFilme.Show();
                }
                else
                {
                    return;
                }
                    
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
