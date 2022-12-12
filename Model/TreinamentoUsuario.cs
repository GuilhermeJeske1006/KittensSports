using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KittensSports.Model
{
    public class TreinamentoUsuario
    {
        public int Id { get; private set; }
        public Treinamento treinamento { get; private set; }
        public Usuario usuario { get; private set; }
        public TreinamentoUsuario(int id, Usuario usuario, Treinamento treinamento)
        {
            Id = id;
            this.treinamento = treinamento;
            this.usuario = usuario;
        }
    }
}
