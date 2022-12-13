using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KittensSports.DAO;
using KittensSports.Model;

namespace KittensSports.Controller
{
    public class TreinamentoUsuarioController
    {
        public bool Gravar(TreinamentoUsuario obj)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(
                    @"insert into Treinamento_usuario (username, idTreinamento) 
                        values (@usuario, @Treinamento)",
                    "@usuario", obj.Usuario, "@Treinamento", obj.Treinamento);
            }
        }
        public DataTable BuscarTodos()
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select u.IdTreinamento_usuario, u.username, t.NomeTreinamento from Treinamento_usuario u, Treinamento t where u.IdTreinamento = t.Id", out retorno);
                return retorno;
            }
        }

        public DataTable BuscarPortreino(string Nome)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select u.IdTreinamento_usuario, u.username, t.NomeTreinamento from Treinamento_usuario u, Treinamento t where u.IdTreinamento = t.Id and t.NomeTreinamento like @param", out retorno, "@param", "%" + Nome + "%");
                return retorno;
            }
        }

        public DataTable BuscarPorNome(string Name)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select u.IdTreinamento_usuario, u.username, t.NomeTreinamento from Treinamento_usuario u, Treinamento t where u.IdTreinamento = t.Id and u.username like @param", out retorno, "@param", Name);
                return retorno;
            }
        }
        public bool Excluir(int IdTreinam)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(@"delete from Treinamento_usuario where IdTreinamento_usuario = @param",
                    "@param", IdTreinam);
            }
        }
    }
}
