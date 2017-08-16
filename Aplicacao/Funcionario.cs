using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao
{
    public class Funcionario
    {
        public string Nome { get; private set; }

        public string Cargo { get; private set; }

        public decimal Salario { get; private set; }

        public Funcionario(string nome, string cargo, decimal salario)
        {
            Nome = nome;
            Cargo = cargo;
            Salario = salario;
        }

        public string Apresentar()
        {
            return $"Olá! Meu nome é {Nome} e eu trabalho como {Cargo}.";
        }

        public void DarAumento(decimal percentual)
        {
            if (percentual < 0)
                return;
            Salario = Salario + (Salario * (percentual / 100));
        }
    }
}