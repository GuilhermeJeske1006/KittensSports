using KittensSports.DAO;
using KittensSports.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KittensSports.Controller
{
    public class TreinamentoController
    {
        public bool Gravar(Treinamento obj)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(
                    @"insert into Treinamento ( NomeTreinamento, Velocidade, Tempo, inclinacao, BPM, desabiltar) 
                        values (@nomeTreinamento, @velocidade, @tempo, @inclinacao, @bpm, 0)",
                     "@nomeTreinamento", obj.NomeExercicio,
                    "@velocidade", obj.Velocidade, "@tempo", obj.Tempo, "@inclinacao", obj.Inclinacao, "@bpm", obj.Bpm);
            }
        }

        public DataTable BuscarPorNome(string nomeExercicio)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                    @"select Id, NomeTreinamento, Velocidade, Tempo, inclinacao, BPM from Treinamento
                       where NomeTreinamento like @xpto and desabiltar = 0", out retorno,
                    "@xpto", "%" + nomeExercicio + "%");
                return retorno;
            }
        }
        public DataTable BuscarPorId(int Id)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                    @"select Id, NomeTreinamento, Velocidade, Tempo, inclinacao, BPM from Treinamento
                       where id = @xpto and desabiltar = 0", out retorno,
                    "@xpto", Id );
                return retorno;
            }
        }
        public DataTable BuscarTodos()
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select Id, NomeTreinamento, Velocidade, Tempo, inclinacao, BPM from Treinamento
                       where desabiltar = 0", out retorno);
                return retorno;
            }
        }
        public bool Excluir(int id)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(@"update Treinamento set desabiltar = 1 where Id = @param",
                    "@param", id);
            }
        }
        public DataTable BuscarTreinamento()
        {
            DataTable dt = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select Id, NomeTreinamento, Velocidade, Tempo, inclinacao, BPM from Treinamento", out dt);
                return dt;
            }
        }
        public bool Alterar(Treinamento obj)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(
                    @"update Treinamento set NomeTreinamento=@1, Velocidade=@2, Tempo=@3, inclinacao=@4, BPM=@5 where Id=@id",
                    "@1", obj.NomeExercicio, "@2", obj.Velocidade, "@3", obj.Tempo, "@4", obj.Inclinacao, "@5", obj.Bpm, "@id", obj.Id);
            }
        }
    }
}
