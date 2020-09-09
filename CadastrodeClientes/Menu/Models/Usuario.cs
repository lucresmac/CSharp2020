using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Menu.Models
{
    class Usuario
    {
        //construtores
        

        //Atributo , propriedades  e caracteristicas
        public Usuario()
        {
            CriandoEM = DateTime.Now;
        }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime CriandoEM {get; set;}

        public override string ToString()
        {
            return $"Nome: {Nome} | Email: {Email} | Criando em: {CriandoEM}";
        }

    }
}
