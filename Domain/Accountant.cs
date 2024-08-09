
namespace Accurate_Finance.Domain
{

    internal class Accountant
    {
        public static int Id = 0;
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string Fone { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }

        public Accountant(string name, string address, string fone, string email, string cpf)
        {
            Id++;
            Name = name;
            Address = address;
            Fone = fone;
            Email = email;
            Cpf = cpf;
        }

        public override string ToString()
        {
            return $" \n Nome: {Name} " +
                    $"\n Address: {Address} " +
                    $"\n Fone: {Fone} " +
                    $"\n Email: {Email} " +
                    $"\n Cpf: {Cpf}";
        }
    }
}
