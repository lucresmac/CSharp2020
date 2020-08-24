using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.Util
{
    class Validacao
    {
        
         private static bool ValidarTamanhoCpf(string cpf)
        {
            return cpf.Length == 11;
        }
        
        public static bool ValidarCpf(string cpf)
        {
            int peso = 10;
            int multip, digito1, digito2;
            int soma = 0;
            int resto = 0;
            // subistituir . e - por "" nada para o cpf 
            cpf = cpf.Replace(".", "").Replace("-", "");
            // menor q 11 já não passa
            if (!ValidarTamanhoCpf(cpf))
            {
                return false;
            }
            // verificar numeros iguais
            switch (cpf)
            {
                case "11111111111": return false;
                case "22222222222": return false;
                case "33333333333": return false;
                case "44444444444": return false;
                case "55555555555": return false;
                case "66666666666": return false;
                case "77777777777": return false;
                case "88888888888": return false;
                case "99999999999": return false;
                case "00000000000": return false;
            }
            //Digito1
            for (int i = 0; i < cpf.Length - 2; i++)
            {

                multip = Convert.ToInt32(cpf[i].ToString()) * peso;
                soma = soma + multip;
                // Console.WriteLine($"{cpf[i]} x {peso} = {multip} | total:{soma} "); mostrar calculo
                peso--;

            }
            resto = soma % 11;
            if (resto < 2)
            {
                digito1 = 0;
            }
            else
            {
                digito1 = 11 - resto;
            }
            if (Convert.ToInt32(cpf[9].ToString()) != digito1)
            {
                return false;
            }

            //digito2
            peso = 11;
            soma = 0;
            for (int i = 0; i < cpf.Length - 1; i++)
            {

                multip = Convert.ToInt32(cpf[i].ToString()) * peso;
                soma = soma + multip;
                // Console.WriteLine($"{cpf[i]} x {peso} = {multip} | total:{soma} "); mostrar calculo
                peso--;

            }
            resto = soma % 11;
            if (resto < 2)
            {
                digito2 = 0;
            }
            else
            {
                digito2 = 11 - resto;
            }
            if (Convert.ToInt32(cpf[10].ToString()) != digito2)
            {
                return false;
            }

            return true;
        }
    }
}
