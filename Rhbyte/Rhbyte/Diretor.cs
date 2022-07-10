using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhbyte
{
    public class Diretor : Funcionario, IAcessoSistema
    {
        public Diretor(string nome, int idade) : base(nome, idade) { }
        public override void Cargo()
        {
            Console.WriteLine(Nome + " " + "Meu cargo é Diretor");
        }
        public void Logar() {
            Console.WriteLine(this.Nome + " " + " Logado");
        }


    }
}
