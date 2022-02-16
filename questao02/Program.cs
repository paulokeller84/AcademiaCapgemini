using System;
using System.Text.RegularExpressions;

namespace questao02
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando a classe
            Password senha = new Password();
            
            //painel de informações para o usuário
            Console.WriteLine("Digite uma senha forte");
            Console.WriteLine("que possua no mínimo 6 caracteres\n" +
                "Contém no mínimo 1 digito,\n" +
                "Contém no mínimo 1 letra em minúsculo,\n" +
                "Contém no mínimo 1 letra em maiúsculo e tenha\n" +
                "no mínimo 1 caractere especial\n");

            //Leitura da senha fornecida pelo usuário
            senha.setPassword(Console.ReadLine());

            //teste de integridade com o resultado de todos os métodos
            int a, b, c, d, e, teste;

            a = PossuiDigito(senha.getPassword());
            b = TamanhoSenha(senha.getPassword());
            c = Maiuscula(senha.getPassword());
            d = Minuscula(senha.getPassword());
            e = CaracteresEspeciais(senha.getPassword());

            teste = a + b + c + d + e;
            if (teste < 5)
            {
                Console.WriteLine("Esta senha não atende aos padrões de segurança");
            }
            else
            {
                Console.WriteLine("Você possui uma senha Forte");

            }

            
            //chamar os metodos
        }

        //Método que verifica se a senha possui digitos ex:0,1,2,3....0)
        public static int PossuiDigito(string entradaInfo)
        {
            int verifica = entradaInfo.Length - Regex.Replace(entradaInfo, "[0-9]", "").Length;
            
            if (verifica >0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            
        }

        //Método de checagem da segurança se possui mais de 6 caracteres
        public static int TamanhoSenha(string entradaInfo)
        {

            if (entradaInfo.Length >= 6)
            {
                return 1;
            }

            else
            {
                return 0;
            }
        }

        //Método para checar se possui caracteres maisculos
        public static int Maiuscula (string entradaInfo)
        {
            int verifica = entradaInfo.Length - Regex.Replace(entradaInfo, "[A-Z]", "").Length;

            if (verifica > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //Método para checar se possui caracteres minusculos

        public static int Minuscula(string entradaInfo)
        {
            int verifica = entradaInfo.Length - Regex.Replace(entradaInfo, "[a-z]", "").Length;

            if (verifica > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        //Método para checar se possui caracteres especiais

        public static int CaracteresEspeciais(string entradaInfo)
        {
            int verifica = entradaInfo.Length - Regex.Replace(entradaInfo, "[!-^]", "").Length;

            if (verifica > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
 
    }
}

        
 
