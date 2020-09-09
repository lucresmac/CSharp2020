using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Models
{
    class Vendedor
    {
        public string Id { get; set; }
        public string Nome { get; set;}
       
        public override string ToString()
        {
            return $"Id: {Id} | Nome: {Nome}";
        }

    }
}
