using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogofilmes.Model
{
    internal class Conexao
    {
       public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\samira.mferreira\source\repos\Catalogofilmes\Catalogofilmes\Model\Filmesbd.mdf;Integrated Security=True";
        }
    }
}
