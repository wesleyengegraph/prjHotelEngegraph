using Hotel.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engegraph.ADO
{
    
    // CRUD
    
    class TipoUhCrud
    {

        private readonly SqlConnection _conexao;

        /*
        public TipoUhCrud(string pStringConexao)
        {
            _conexao = new SqlConnection(pStringConexao);
        }
        */
        public TipoUhCrud(SqlConnection pConexao)
        {
            _conexao = pConexao;
            _conexao.Open();
        }

        public void Create(TipoUh pTipoUh)
        {
            // Insert
            var sql = @"INSERT INTO TipoUh
           (Id
		   ,QtdeAdt
           ,QtdeChd
           ,Descricao
           ,ValorDiaria
           ,ValorAdicional
           ,DataCriacao
)
     VALUES
           (@Id
           ,@QtdeAdt
           ,@QtdeChd
           ,@Descricao
           ,@ValorDiaria
           ,@ValorAdicional
           ,@DataCriacao
           )";

            // instancia um novo SqlCommand            
            var comando = new SqlCommand(sql, _conexao);

            // Adiciona parâmetros com seus respectivos valores
            comando.Parameters.AddWithValue("Id", pTipoUh.Id);
            comando.Parameters.AddWithValue("Descricao", pTipoUh.Descricao);
            comando.Parameters.AddWithValue("QtdeAdt", pTipoUh.QtdeAdt);
            comando.Parameters.AddWithValue("QtdeChd", pTipoUh.QtdeChd);
            comando.Parameters.AddWithValue("ValorDiaria", pTipoUh.ValorDiaria);
            comando.Parameters.AddWithValue("ValorAdicional", pTipoUh.ValorAdicional);
            comando.Parameters.AddWithValue("DataCriacao", pTipoUh.DataCriacao);

            //_conexao.Open();

            comando.ExecuteNonQuery();

        }

        public List<TipoUh> Read()
        {
            // Select
            // return null


            try
            {
                var sql = "select * from TipoUh";

                var comando = new SqlCommand(sql, _conexao);

                //_conexao.Open();

                var listaTiposUh = new List<TipoUh>();

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var tipoUh = new TipoUh();

                        tipoUh.Id = (Guid)reader["Id"];
                        tipoUh.Descricao = reader["Descricao"].ToString();
                        tipoUh.QtdeAdt = Convert.ToInt32(reader["QtdeAdt"]);
                        tipoUh.QtdeChd = Convert.ToInt32(reader["QtdeChd"]);
                        tipoUh.ValorDiaria = Convert.ToDouble(reader["ValorDiaria"]);
                        tipoUh.ValorAdicional = Convert.ToDouble(reader["ValorAdicional"]);
                        tipoUh.DataCriacao = Convert.ToDateTime(reader["DataCriacao"]);
                        //tipoUh.DataModificacao = Convert.ToDateTime(reader["DataModificacao"] ?? null);
                        //tipoUh. = Convert.ToInt32(reader[""]);

                        listaTiposUh.Add(tipoUh);

                    }
                }

                return listaTiposUh;

            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro: {ex.Message}");
            }

        }

        public List<TipoUh> Read(TipoUh pFiltro)
        {
            var sql = "Select * from TipoUh where ";


            return null;
        }

        public void Update(TipoUh pTipoUh)
        {
            // Update

            // comando sql de insert

            var sql = @"update TipoUh set
  Descricao = @Descricao
, QtdeAdt = @QtdeAdt
, QtdeChd = @QtdeChd
, ValorDiaria = @ValorDiaria
, ValorAdicional = @ValorAdicional
, DataModificacao = @DataModificacao
where
id = @Id
";
            var comando = new SqlCommand(sql, _conexao);


            comando.Parameters.AddWithValue("Id", pTipoUh.Id);
            comando.Parameters.AddWithValue("Descricao", pTipoUh.Descricao);
            comando.Parameters.AddWithValue("QtdeAdt", pTipoUh.QtdeAdt);
            comando.Parameters.AddWithValue("QtdeChd", pTipoUh.QtdeChd);
            comando.Parameters.AddWithValue("ValorDiaria", pTipoUh.ValorDiaria);
            comando.Parameters.AddWithValue("ValorAdicional", pTipoUh.ValorAdicional);
            comando.Parameters.AddWithValue("DataModificacao", pTipoUh.DataModificacao);
            //comando.Parameters.AddWithValue("", pTipoUh.);

            //_conexao.Open();

            comando.ExecuteNonQuery();

        }

        public void Delete(Guid pId)
        {
            // Delete

            var sql = @"delete from TipoUh where Id = @Id";

            var comando = new SqlCommand(sql, _conexao);

            comando.Parameters.AddWithValue("Id", pId);

            _conexao.Open();

            comando.ExecuteNonQuery();
        }


    }
}
