using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Menu
{
    class Cliente
    {
        //Atributo , propriedades  e caracteristicas
        public Cliente()
        {
            CriandoEM = DateTime.Now;
        }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime CriandoEM {get; set;}

        public override string ToString()
        {
            return $"Nome: {Nome} | CPF: {Cpf} | Criando em: {CriandoEM}";
        }

    }
}
