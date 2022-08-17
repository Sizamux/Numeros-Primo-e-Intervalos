namespace ProjetoNumeroPrimo
{
    internal class Program
    {
        public static bool TestarSeEhPrimo(float i)
        {
            for (float j = 1; j <= i; j++)
            {

                if ((i == 1) && (j == 1))
                {
                    return true;
                    break;
                }
                else if (i % j == 0)
                {
                    if (i / j == 1.0)
                    {
                        return true;
                    }
                    else if ((i / j != 1.0) && (j != 1))
                    {
                        return false;
                    }
                }

            }
            return false;
        }
        public static void TestarValorDe1aI(float quant)
        {
            List<float> numerosPrimos = new List<float>();
            for (float i = 1; i <= quant; i++)
            {
                for (float j = 1; j <= i; j++)
                {

                    if ((i == 1) && (j == 1))
                    {
                        //Console.WriteLine("é 1 1;" + i + "%" + j + "=" + i % j + " " + i + "/" + j + "=" + i / j);                    \\Debug
                        numerosPrimos.Add(i);
                        break;
                    }
                    else if (i % j == 0)
                    {
                        if (i / j == 1.0)
                        {
                            //Console.WriteLine("Ele Mesmo;" + i + "%" + j + "=" + i % j + " " + i + "/" + j + "=" + i / j);            \\Debug
                            numerosPrimos.Add(i);
                        }
                        else if ((i / j != 1.0) && (j != 1))
                        {
                            //Console.WriteLine("Divisivel por outro;" + i + "%" + j + "=" + i % j + " " + i + "/" + j + "=" + i / j);  
                            break;
                        }
                    }

                }

            }
            Console.WriteLine("\nImprimindo numeros Primos menores que " + quant + "\n");
            foreach (int i in numerosPrimos)
            {
                Console.Write(i + " ");
            }
            Console.Write("\n");
        }
        static void Main(string[] args)
        {
            bool menuFlag = true;
            while (menuFlag != false) { 
                Console.WriteLine("\nPrograma de Numero Primo em c# para teste!"+
                                    "\n1-Deseja Testar um Numero "+
                                    "\n2-Deseja Informar um Valor e visualizar todos os numeros primos de 1 ao Valor"+
                                    "\nesc-Sair");
                ConsoleKey menuKey = Console.ReadKey().Key;
                switch(menuKey)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine("Testar Valor De Numeros Primos!");
                        float valor = float.Parse(Console.ReadLine());
                        if(TestarSeEhPrimo(valor) == true)
                        {
                            Console.WriteLine(valor +"\n é Primo!");
                        }
                        else
                        {
                            Console.WriteLine(valor + "\nnão é Primo!");
                        }
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("Intervalos De Numeros Primos!");
                        float quant = float.Parse(Console.ReadLine());
                        TestarValorDe1aI(quant); //função Void
                        break;
                    case ConsoleKey.Escape:
                        menuFlag = false;
                        break;
                }
            }
        }
    }
}