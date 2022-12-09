using KittensSports.DAO;
using KittensSports.Model;
using System.Data;

namespace KittensSports.Controller
{
    public class UsuarioController
    {
        public bool Gravar(Usuario obj)
        {
            BancoInstance banco;
            using(banco = new BancoInstance())
            {
                return banco.Banco.ExecuteNonQuery(
                    @"insert into usuario (username, senha, fullName, email) 
                        values (@un, @senha, @nome, @mail)",
                    "@un", obj.Username, "@senha", obj.Password,
                    "@nome", obj.NomeCompleto, "@mail", obj.Email);
            }
        }
        public DataTable BuscarUsuarios()
        {
            DataTable dt = new DataTable();
            BancoInstance banco;
            using(banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select * from usuario", out dt);
                return dt;
            }
        }

        public DataTable BuscaLogin(string user, string senha)
        {
            DataTable dt = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select * from usuario where 
                    username = @user and senha = @senha", out dt,
                    "@user", user, "@senha", senha);
                return dt;
            };
        }
    }
}
