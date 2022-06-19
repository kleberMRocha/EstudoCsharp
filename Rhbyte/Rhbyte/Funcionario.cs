using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhbyte
{
    public class Funcionario
    {
        public Funcionario(string nome, int idade)
        {
            this.Idade = idade;
            this.Nome = nome;

        }
        public int Idade { get; private set; }
        public string Nome { get; private set; }

        public virtual void Cargo()
        {
            Console.WriteLine(Nome+" "+ "Meu cargo é Funcionario");
        }
    }
}
