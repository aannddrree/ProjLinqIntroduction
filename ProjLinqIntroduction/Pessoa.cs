using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjLinqIntroduction
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public List<Pessoa> Pessoas()
        {
            List<Pessoa> lst = new List<Pessoa>();
            //Gerar uma massa de dados
            lst.Add(new Pessoa() { Id = 1, Name = "André Silva", Age = 35 });
            lst.Add(new Pessoa() { Id = 2, Name = "Daniel Silva", Age = 1 });
            lst.Add(new Pessoa() { Id = 3, Name = "Felipe Pestana", Age = 18 });
            lst.Add(new Pessoa() { Id = 4, Name = "Fabio Papine", Age = 40 });
            return lst;
        }

        public override string ToString()
        {
            return "Id: " + this.Id + " - " + "Nome: " + this.Name  + " - " + "Idade: " + this.Age;
        }

    }
}
