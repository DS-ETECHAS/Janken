using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedraPapelETesoura.Models
{
    public sealed class Jogador
    {
        public string Nome { get; set; }
        public Opcao Escolha { get; set; }
        public int Pontuação { get; set; }
    }
}
