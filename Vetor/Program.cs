
using System;

namespace Vetor {
    class Program {
        static void Main(string[] args) {

            Vetoh[] reserva = new Vetoh[10];

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("               POUSADA QUE DELICIA ");
            Console.WriteLine("            O LUGAR ONDE VOCÊ RELAXA ");
            Console.WriteLine();
            Console.WriteLine("           BANCO DE RESERVA DE HÓSPEDES");
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("          DIGITE A QUANTIDADE DE RESERVAS: ");

            int numero = int.Parse(Console.ReadLine());
            for(int i = 1; i <= numero; i++) {
                Console.WriteLine();
                Console.WriteLine($"  Reserva {i}");
                Console.Write("        Digite o dia da entrada: ");
                string dia = Console.ReadLine();
                Console.Write("        Nome: ");
                string nome = Console.ReadLine();
                Console.Write("        Email: ");
                string email = Console.ReadLine();
                Console.Write($"        Cpf: ");
                string cpf = Console.ReadLine();
                Console.Write("        Telefone: ");
                int telefone = int.Parse(Console.ReadLine());
                Console.Write("        Numero do quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                reserva[quarto] = new Vetoh(nome, email, cpf, telefone, dia);

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("   Quartos ocupados: ");
            for(int i = 0; i < 10; i++) {
                if (reserva[i] != null) {
                    Console.WriteLine();
                    Console.WriteLine($"      Quarto {i}");
                    Console.WriteLine($"      {reserva[i]}");
                }
            }


        }
    }
}
