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

            try
            {
                using (var conexao = new SqlConnection("Server=;Database=HotelEngegraph;User=ENGEGRAPH;password=DevEngegraph"))
                {
                    Console.WriteLine("Meu primeiro CRUD completo");

                    //var crud = new TipoUhCrud(@"Server=;Database=HotelEngegraph;User=ENGEGRAPH;password=DevEngegraph");
                    var crud = new TipoUhCrud(conexao);


                    var tipoUh = new TipoUh();

                    /*
                    tipoUh.Id = Guid.NewGuid();

                    tipoUh.Descricao = "Super Lux Suite";
                    tipoUh.QtdeAdt = 2;
                    tipoUh.QtdeChd = 2;
                    tipoUh.ValorDiaria = 499.00;
                    tipoUh.ValorAdicional = 699.00;
                    tipoUh.DataCriacao = DateTime.Now;

                    crud.Create(tipoUh);

                    Console.WriteLine("Dados inseridos com sucesso");
                    */

                    Console.WriteLine("Lendo dados do banco...");

                    var dados = crud.Read();

                    //Console.WriteLine("Id Descricao QtdAdt QtdChd Valor DiariaValorAdicional DataCriacao DataModificacao");

                    Console.WriteLine("");

                    // Esse não consegui executar, ocorreu erro (conexão aberta, parece).
                    foreach (var item in dados)
                    {
                        Console.WriteLine($"Id: {item.Id}");
                        Console.WriteLine($"Descrição: {item.Descricao}");
                        Console.WriteLine($"QtdeAdt: {item.QtdeAdt}");
                        Console.WriteLine($"QtdeChd: {item.QtdeChd}");
                        Console.WriteLine($"ValorDiaria: {item.ValorDiaria}");
                        Console.WriteLine($"ValorAdicional: {item.ValorAdicional}");
                        Console.WriteLine($"DataCriacao: {item.DataCriacao}");
                        Console.WriteLine($"DataModificacao: {item.DataModificacao}");

                        Console.WriteLine("-------------------------------------------------------");


                    }

                    Console.WriteLine("Atualização...");

                    //var tipoUh = new TipoUh();

                    //tipoUh.Id = Guid.NewGuid();
                    tipoUh.Id = Guid.Parse("03410385-587C-4CE0-AB3A-6A202BD76E98");
                    tipoUh.Descricao = "Super Lux Suite novo alterado";
                    tipoUh.QtdeAdt = 3;
                    tipoUh.QtdeChd = 4;
                    tipoUh.ValorDiaria = 599.00;
                    tipoUh.ValorAdicional = 799.00;
                    tipoUh.DataModificacao = DateTime.Now;

                    crud.Update(tipoUh);

                    //crud.Delete(new Guid("973A2891-5EFE-4729-B995-B9183E5E1C01")); 
                }


            }
            catch (Exception ex)
            {
                //throw new Exception($"Falha ao tentar gravar: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);


            }
            finally
            {
                Console.ReadKey();
            }

        }

        //private static CriarTipoUh()
        //{
        //
        //}
    }
}
