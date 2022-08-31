

namespace Vetor {
    internal class Vetoh {

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public int Telefone { get; set; }
        public string Dia { get; set; }

        public Vetoh(string nome, string email, string cpf, int telefone, string dia) {
            Nome = nome;
            Email = email;
            Cpf = cpf;
            Telefone = telefone;
            Dia = dia;
        }

        override public string ToString() {
            Console.WriteLine($"    Hóspede {Nome}");
            Console.WriteLine($"    Dados => E-mail: {Email} || Cpf: {Cpf} || Telefone: {Telefone}");
            Console.WriteLine($"    Check in dia: {Dia}");
            return "";

        }
    }
}
