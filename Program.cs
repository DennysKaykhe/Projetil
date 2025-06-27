﻿        double velocidade;
        double angulo;
        double pi = 3.14159;
        double constante = 9.80665;
        double alcance;
        double altura;

        Console.Clear();

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("==========================================");
        Console.WriteLine("         SIMULADOR DE PROJÉTIL            ");
        Console.WriteLine("==========================================");

        Console.ResetColor();
        Console.WriteLine();

        Console.WriteLine("Este programa calcula a distância máxima (alcance) e a altura máxima atingida por um projétil lançado obliquamente.\n");

        Console.WriteLine("Você deverá informar:");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("- A velocidade inicial, em metros por segundo (m/s)");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("- O ângulo de lançamento, em graus");
        Console.ResetColor();

        Console.WriteLine("\n* Apenas valores inteiros positivos serão aceitos.\n");

        Thread.Sleep(5000);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Precione qualquer tecla para iniciar o programa!");
        Console.ResetColor();

        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("--------- Projétil ---------");

        
        int linhaInputVelocidade = Console.CursorTop;

        while (true)
        {
            Console.SetCursorPosition(0, linhaInputVelocidade);
            Console.Write("Entre com a velocidade, em m/s..: ");
            
            Console.Write(new string(' ', Console.WindowWidth - "Entre com a velocidade, em m/s..: ".Length));
            Console.SetCursorPosition("Entre com a velocidade, em m/s..: ".Length, linhaInputVelocidade);

            string inputVel = Console.ReadLine()!;

            
            Console.SetCursorPosition(0, linhaInputVelocidade + 1);
            Console.Write(new string(' ', Console.WindowWidth));

            if (double.TryParse(inputVel, out velocidade) && velocidade > 0)
            {
                break;
            }
            else
            {
                Console.SetCursorPosition(0, linhaInputVelocidade + 1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido! Digite um número inteiro maior que zero.");
                Console.ResetColor();
            }
        }

        int linhaInputAngulo = Console.CursorTop;

        while (true)
        {
            Console.SetCursorPosition(0, linhaInputAngulo);
            Console.Write("Entre com o Ângulo, em graus....: ");
            Console.Write(new string(' ', Console.WindowWidth - "Entre com o Ângulo, em graus....: ".Length));
            Console.SetCursorPosition("Entre com o Ângulo, em graus....: ".Length, linhaInputAngulo);

            string inputAng = Console.ReadLine()!;

            Console.SetCursorPosition(0, linhaInputAngulo + 1);
            Console.Write(new string(' ', Console.WindowWidth));

            if (double.TryParse(inputAng, out angulo) && angulo > 0)
            {
                break;
            }
            else
            {
                Console.SetCursorPosition(0, linhaInputAngulo + 1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido! Digite um número inteiro maior que zero.");
                Console.ResetColor();
            }
        }

double anguloRad = angulo * (pi / 180);

alcance = (Math.Pow(velocidade, 2) * Math.Sin(2 * anguloRad)) / constante;

altura = (Math.Pow(velocidade * Math.Sin(anguloRad), 2)) / (2 * constante);

Console.Write($"\nAlcance........: ");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"{alcance:F2}");
Console.ResetColor();
Console.Write(" m");

Console.Write($"\nAltura máxima..: ");

Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"{altura:F2}");
Console.ResetColor();
Console.Write(" m");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\n\nPrecione qualquer tecla para finalizar o programa!");
Console.ResetColor();
Console.ReadKey();