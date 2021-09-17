using System;

namespace Aula4
{
    class Program
    {
        static void Main(string[] args)
        {

            short valor = 10;
            int idade = 20;

            double velocidade = 32768;

            valor = Convert.ToInt16(idade);
            //idade = Convert.ToInt32(velocidade);
            //velocidade = idade;

            valor = Convert.ToInt16(velocidade);

            Console.WriteLine("Valor = " + valor);
            Console.WriteLine("Idade = " + idade);
            Console.WriteLine("Velocidade = " + velocidade);


            /*
            
            +
            -
            *
            /
            %
            

            A comparar com B
            B com C
            A com 0
            B com (C + 5 + B)

            >
            >=
            <
            <=
            ==
            !=

            &&
            ||
            ^

            AV1 = 5
            av1 < 5 ??




             */


             */
        }
    }
}
