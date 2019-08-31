using System;

namespace imccalculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            // variables
            string name, checkvar;
            int age;
            double heightvar, weightvar, imc, heightresult;
            bool verified = false;


            // welcome to imc calculator
            Console.WriteLine("Bem-vindo a Calculadora de IMC");
            Console.WriteLine("Digite 'C' para começar, lembre-se de escrever todos os dados corretamente.");
            checkvar = Console.ReadLine();

            if (checkvar == "C")
                verified = true;
            else 
                return;

            // questions
            Console.WriteLine("Digite seu nome: ");
            name = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            heightvar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite agora o seu peso: ");
            weightvar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Olá " + name + ", você tem " + age + " anos, e sua altura é " + heightvar + " e você pesa " + weightvar);

            // imc calculations
            heightresult = heightvar * heightvar;
            imc = weightvar / heightresult;

            Console.Clear();
            Console.WriteLine("Seu IMC é: " + Math.Round(imc, 0).ToString());

            // "if" moment
            if (imc <= 18)
                Console.WriteLine("O seu IMC está abaixo do normal! :( ");

            if (imc > 18 && imc <= 25)
                Console.WriteLine("O seu IMC está normal! :) ");

            if (imc > 25 && imc <= 30)
                Console.WriteLine("O seu IMC está acima do normal! :( ");

            if (imc > 30 && imc <= 35)
                Console.WriteLine("O seu IMC está bem acima do normal, é recomendado você procurar ajuda medica. :( ");

            if (imc > 35 && imc <= 40)
                Console.WriteLine("O seu IMC está muito acima do esperado, procure ajuda médica. :( ");

            if (imc > 40)
                Console.WriteLine("O seu IMC está MUITO ACIMA do esperado, por favor procure um médico urgente! ;( ");
        }
    }
}