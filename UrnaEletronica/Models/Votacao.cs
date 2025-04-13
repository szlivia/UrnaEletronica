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
            return (DataTable)Connection.ExecuteQuery(@"select id, nome from categoria", ExecutionType.DataTable);
        }

        public static DataTable Candidatos(string categoria, string numero) 
        {
            return (DataTable)Connection.ExecuteQuery($@"SELECT 
                                                                a.id, 
                                                                a.nome, 
                                                                a.numero, 
                                                                a.foto,
                                                                c.id   AS id_partido, 
                                                                c.nome || ' - ' || c.sigla AS nome_partido
                                                            FROM  candidato a
                                                            INNER JOIN categoria b ON a.id_categoria = b.id
                                                            INNER JOIN partido c ON a.id_partido = c.id
                                                            WHERE a.ativo = true
                                                            AND b.id = '{categoria}'
                                                            AND a.numero = '{numero}' ", ExecutionType.DataTable);
        }
    }
}
