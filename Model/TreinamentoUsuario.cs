using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KittensSports.Controller;

namespace KittensSports.Model
{
    public class TreinamentoUsuario
    {
        public int Id { get; private set; }
        public string Usuario { get; private set; }
        public float Treinamento { get; private set; }
        public TreinamentoUsuario(int id, string usuario, float treinamento)
        {
            Id = id;
            Treinamento = treinamento;
            Usuario = usuario;
        }
        public bool Gravar()
        {
            return new TreinamentoUsuarioController().Gravar(this);
        }
    }
}
