using KittensSports.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KittensSports.Model
{
    public class Treinamento
    {
        [Key]
        public int Id { get; private set; }
        public string NomeExercicio { get; private set; }
        public float Velocidade { get; private set; }
        public float Tempo { get; private set; }
        public float Inclinacao { get; private set; }
        public float Bpm { get; private set; }

        public Treinamento(int id, string nomeExercicio, float velocidade, float tempo, float inclinacao, float bpm)
        {
            Id = id;
            NomeExercicio = nomeExercicio;
            Velocidade = velocidade;
            Tempo = tempo;
            Inclinacao = inclinacao;
            Bpm = bpm;
        }
        public bool Gravar()
        {
            return new TreinamentoController().Gravar(this);
        }
        public bool Alterar()
        {
            return new TreinamentoController().Alterar(this);
        }
    }
}
