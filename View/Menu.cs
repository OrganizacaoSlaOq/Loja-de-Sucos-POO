using static Console;

public class Menu
{
    public void MenuIniciar()
    {
        TituloAbertura();
        WriteLine("============================\n");

        string opc;

        do
        {
            WriteLine("Bem vindo ao menu do Bora de Suco! Escolha uma das opções para continuar:\n");
            WriteLine("1 - ");
            WriteLine("2 - ");
            WriteLine("3 - ");
            WriteLine("4 - ");
            WriteLine("5 - ");
            WriteLine("0 - Sair do programa");

            Write("\n>>> ");

            opc = ReadLine();

            switch (opc)
            {
                case "1":
                    break;

                case "2":
                    break;

                case "3":
                    break;

                case "4":
                    break;

                case "5":
                    break;

                case "0":
                    ForegroundColor = ConsoleColor.Cyan;
                    WriteLine("\nVolte Sempre!!!");
                    Thread.Sleep(1000);
                    break;

                default:
                    Write("Opção inválida, tente novamente...");
                    ReadKey();
                    Clear();
                    break;
            }
        } while (opc != "0");
    }
    
    public void TituloAbertura()
    {
        WriteLine("Tecle qualquer tecla para iniciar");
        ReadKey();
        Clear();
        Write("Iniciando");
        Thread.Sleep(500);
        Write(".");
        Beep(5000, 100);
        Thread.Sleep(500);
        Write(".");
        Beep(5000, 100);
        Thread.Sleep(500);
        Write(".");
        Beep(5000, 100);
        Thread.Sleep(500);
        Clear();
        Beep(2500, 750);
        WriteLine("==============================================================");
        Thread.Sleep(100);
        WriteLine("||                                                          ||");
        Thread.Sleep(100);
        WriteLine("||   +----+   +----+   +----+     +----+                    ||");
        Thread.Sleep(100);
        WriteLine("||   |     |  |    |   |     |    |    |                    ||");
        Thread.Sleep(100);
        WriteLine("||   |     |  |    |   |     |    |    |                    ||");
        Thread.Sleep(100);
        WriteLine("||   +----+   |    |   +----+     |----|                    ||");
        Thread.Sleep(100);
        WriteLine("||   |     |  |    |   |    \\     |    |                    ||");
        Thread.Sleep(100);
        WriteLine("||   +----+   +----+   |     \\    |    |                    ||");
        Thread.Sleep(100);
        WriteLine("||                                                          ||");
        Thread.Sleep(100);
        WriteLine("||   +----+   +-----+                                       ||");
        Thread.Sleep(100);
        WriteLine("||   |     |  |                                             ||");
        Thread.Sleep(100);
        WriteLine("||   |     |  |                                             ||");
        Thread.Sleep(100);
        WriteLine("||   |     |  +----+                                        ||");
        Thread.Sleep(100);
        WriteLine("||   |     |  |                                             ||");
        Thread.Sleep(100);
        WriteLine("||   |     |  |                                             ||");
        Thread.Sleep(100);
        WriteLine("||   +----+   +-----+                                       ||");
        Thread.Sleep(100);
        WriteLine("||                                                          ||");
        Thread.Sleep(100);
        WriteLine("||   +----+   |     |   +----+   +----+                     ||");
        Thread.Sleep(100);
        WriteLine("||   |        |     |   |        |    |                     ||");
        Thread.Sleep(100);
        WriteLine("||   +----+   |     |   |        |    |                     ||");
        Thread.Sleep(100);
        WriteLine("||        |   |     |   |        |    |                     ||");
        Thread.Sleep(100);
        WriteLine("||        |   |     |   |        |    |                     ||");
        Thread.Sleep(100);
        WriteLine("||   +----+   \\_____/   +----+   +----+                     ||");
        Thread.Sleep(100);
        WriteLine("||                                                          ||");
        Thread.Sleep(100);
        WriteLine("==============================================================");
        Thread.Sleep(100);
        WriteLine("\n");
        WriteLine("Tecle qualquer tecla para continuar");
        ReadKey();

        WriteLine();
    }
}
