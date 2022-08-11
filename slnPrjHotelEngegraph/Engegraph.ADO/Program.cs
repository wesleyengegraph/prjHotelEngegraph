using Hotel.Comum.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Engegraph.ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Acessando dados com ADO.Net.");

            var ID = "973A2891-5EFE-4729-B995-B9183E5E1C01";

            var sql = $"select * from tipouh where ID = @ID";

            //var sql = "select * from TipoUh";

            using (var conexao = new SqlConnection())

            {
                conexao.ConnectionString = "Server=ESI-DEV04;database=HotelEngegraph;user=ENGEGRAPH;password=DevEngegraph;Trusted_Connection=True";
                var comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("ID", ID);
                conexao.Open();

                List<TipoUh> tiposUh = new List<TipoUh>();

                using(var reader = comando.ExecuteReader())
                {

                    while(reader.Read())
                    {

                        tiposUh.Add(new TipoUh()
                        {
                            Id = (Guid)reader["Id"],
                            Descricao = reader["Descricao"].ToString(),
                            ValorDiaria = Convert.ToDouble(reader["ValorDiaria"])
                        });
                        
                        Console.WriteLine($"Descricao,{reader["Descricao"]}; ValorDiaria: {reader["ValorDiaria"]}");
                    }
                }

                foreach(var item in tiposUh)
                {
                    Console.WriteLine($"Descrição: {item.Descricao}, Valor Diária: {item.ValorDiaria.ToString("0.00")}");
                }

            }

            Console.WriteLine("Conectado ao banco de dados.");

            Console.ReadKey();


        }
    }
}
