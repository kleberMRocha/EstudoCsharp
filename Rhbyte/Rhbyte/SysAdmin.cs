using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhbyte
{
    public class SysAdmin : Diretor
    {
        protected int Id;
        public SysAdmin(string nome, int idade) : base(nome, idade)
        {
            Id = 45454545;
        }
        public override void Cargo()
        {
            Console.WriteLine(Nome + " " + "Meu cargo é SysAdmin e meu  id é" + " " + Id);
        }


    }
}
