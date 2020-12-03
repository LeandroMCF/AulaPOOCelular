using System;
using AulaPOOCelular.classes;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            string bloqueDesbloque;
            int ops = 0, ops3 = 0, ops4 = 0, nContatos = 0;
            string nomeContatos;

            configCel celular = new configCel();
            Console.Write("Comprando Celular.\nDigite o Modelo do seu celular: ");
            celular.modelo = Console.ReadLine();
            Console.Write($"Digite as polegadas da tela do seu celular: ");
            celular.tamanho = float.Parse(Console.ReadLine());
            Console.Write($"Por fim, digite a cor do seu celular: ");
            celular.cor = Console.ReadLine();
            Console.WriteLine($"Feito!\n----------------------\nAgora você pode mexer no seu celular!");
            celular.desbloqueado = true;
            do
            {
                do
                {
                    if (celular.desbloqueado == true){
                        bloqueDesbloque = "[1] Desbloquear celular";
                    }else{
                        bloqueDesbloque = "[2] Bloquear celular";
                    }
                        Console.WriteLine($"{bloqueDesbloque}\n[3] Fazer ligação\n[4] Eviar mensagem\n[0] Desligar celular");
                        ops = int.Parse(Console.ReadLine());
                        while (ops != 0 && ops != 1 && ops != 2 && ops != 3 && ops != 4)
                        {
                            Console.WriteLine($"Opção inválida.\n{bloqueDesbloque}\n[3] Fazer ligação\n[4] Eviar mensagem\n[0] Desligar celular");
                            ops = int.Parse(Console.ReadLine());
                        }

                        if(ops == 1){
                            Console.WriteLine($"Celular desbloqueado!");
                            celular.desbloqueado = false;
                        }else if(ops == 2){
                            Console.WriteLine($"Celular bloqueado!");
                            celular.desbloqueado = true;
                        }

                        while (celular.desbloqueado == true)
                        {
                            Console.WriteLine($"\n----------------------------------\nCelular bloqueado. Desbloqueie o celular para usar o recurso.\n----------------------------------\n");
                            break;
                        }
                }while(celular.desbloqueado == true);
                
                    switch (ops)
                    {
                        case 3:
                            Console.Write($"[0] para voltar para o menu\nDigite o número que deseja ligar: ");
                            int nLigacao = int.Parse(Console.ReadLine());
                            if (nLigacao == 0)
                            {
                                Console.WriteLine($"Voltando para o menu");
                            }
                            else
                            {
                                Console.WriteLine($"Ligando para {nLigacao}");
                                Console.WriteLine($"{nLigacao}\n[1] Finalizar chamada");
                                int ops2 = int.Parse(Console.ReadLine());
                                while (ops2 != 1)
                                {
                                    Console.WriteLine($"opição inválida\n[1] Finalizar chamada");
                                    ops2 = int.Parse(Console.ReadLine());
                                }
                                Console.WriteLine($"Chamada finalizada.");
                            }
                        break;
                        case 4:
                            do
                            {
                                Console.WriteLine($"[1] Enviar mensagem\n[0] Ir para o menu principal");
                                ops3 = int.Parse(Console.ReadLine()); 
                                while (ops3 != 1 && ops3 != 0)
                                {
                                    Console.WriteLine($"opição inválida\n[1] Enviar mensagem\n[0] Ir para o menu principal");
                                    ops3 = int.Parse(Console.ReadLine());
                                }
                                switch (ops3)
                                {
                                    case 1:
                                        do
                                        {
                                            Console.Write($"Digite sua mensagem ('Enter' para enviar): ");
                                            string msg = Console.ReadLine();
                                            Console.WriteLine($"Mensagem enviada\nEnviar outra mensagem?\n[1] Sim\n[2] Não");
                                            ops4 = int.Parse(Console.ReadLine());
                                            while (ops4 != 1 && ops4 != 2)
                                            {
                                                Console.WriteLine($"opição inválida\nEnviar outra mensagem?\n[1] Sim\n[2] Não");
                                                ops4 = int.Parse(Console.ReadLine());
                                            }
                                            
                                        } while (ops4 != 2);
                                        break;
                                    default:
                                        Console.WriteLine($"Voltando para o menu principal.");
                                        break;
                                }
                                
                            } while (ops3 != 0);
                        break;
                        case 0:
                            Console.WriteLine($"Desligando {celular.modelo}.");
                        break;
                    }
            } while (ops != 0);
            

            void CofigContatos(int[] a, string[] b)
            {
                
            }
        }
    }
}
