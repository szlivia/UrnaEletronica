using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.DataAccess;

namespace UrnaEletronica.Models
{
    /// <summary>
    /// Respositório onde realiza as operações de busca de informação da votação
    /// </summary>
    public static class Votacao
    {
        public static DataTable Categoria()
        {
            return (DataTable)Connection.ExecuteQuery("", ExecutionType.DataTable);
        }

        public static DataTable Candidatos(int categoria) 
        {
            return (DataTable)Connection.ExecuteQuery("", ExecutionType.DataTable);
        }
    }
}
