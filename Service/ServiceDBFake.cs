using Accurate_Finance.Domain;
using Accurate_Finance.Repository;

namespace Accurate_Finance.Services
{
    internal class ServiceDBFake
    {

        public RepositoryAccountant RepositoryAccountant { get; private set; }
        public ServiceDBFake(RepositoryAccountant repositoryAccountant)
        {
            RepositoryAccountant = repositoryAccountant;
        }

        public void CreateTables() 
        {
            CreateAccountants();
        }

        public void CreateAccountants()
        {
            Accountant accountant = new Accountant("Railson Martins", "Rua Josefina", "035999839730", "railson@mail.com", "128.519.216-81");

            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Tiago Martins", "Rua Josefina", "035999839732", "tiago@mail.com", "128.519.217-82");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Ana Silva", "Rua das Flores", "035999839733", "ana@mail.com", "128.519.217-83");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Carlos Souza", "Avenida Brasil", "035999839734", "carlos@mail.com", "128.519.217-84");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Beatriz Oliveira", "Rua Santos Dumont", "035999839735", "beatriz@mail.com", "128.519.217-85");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("João Pedro", "Rua XV de Novembro", "035999839736", "joao@mail.com", "128.519.217-86");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Maria Clara", "Rua Independência", "035999839737", "maria@mail.com", "128.519.217-87");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Lucas Lima", "Avenida São João", "035999839738", "lucas@mail.com", "128.519.217-88");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Juliana Alves", "Rua das Palmeiras", "035999839739", "juliana@mail.com", "128.519.217-89");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Ricardo Ribeiro", "Rua da Paz", "035999839740", "ricardo@mail.com", "128.519.217-90");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Fernanda Costa", "Rua do Comércio", "035999839741", "fernanda@mail.com", "128.519.217-91");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Felipe Pinto", "Rua das Hortências", "035999839742", "felipe@mail.com", "128.519.217-92");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Mariana Castro", "Rua da Alegria", "035999839743", "mariana@mail.com", "128.519.217-93");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Bruno Rocha", "Rua Bela Vista", "035999839744", "bruno@mail.com", "128.519.217-94");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Patrícia Gomes", "Rua Primavera", "035999839745", "patricia@mail.com", "128.519.217-95");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Gustavo Mendes", "Rua Verde", "035999839746", "gustavo@mail.com", "128.519.217-96");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Camila Barbosa", "Rua Amarela", "035999839747", "camila@mail.com", "128.519.217-97");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("André Almeida", "Rua Azul", "035999839748", "andre@mail.com", "128.519.217-98");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Larissa Santos", "Rua Branca", "035999839749", "larissa@mail.com", "128.519.217-99");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Renato Cardoso", "Rua Preta", "035999839750", "renato@mail.com", "128.519.217-00");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Aline Pereira", "Rua Vermelha", "035999839751", "aline@mail.com", "128.519.217-01");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Daniel Costa", "Rua Rosa", "035999839752", "daniel@mail.com", "128.519.217-02");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Isabela Fernandes", "Rua Marrom", "035999839753", "isabela@mail.com", "128.519.217-03");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Mateus Rocha", "Rua Cinza", "035999839754", "mateus@mail.com", "128.519.217-04");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Paula Lima", "Rua Roxa", "035999839755", "paula@mail.com", "128.519.217-05");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Rafael Nogueira", "Rua Lilás", "035999839756", "rafael@mail.com", "128.519.217-06");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Carolina Souza", "Rua Dourada", "035999839757", "carolina@mail.com", "128.519.217-07");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Marcelo Oliveira", "Rua Prata", "035999839758", "marcelo@mail.com", "128.519.217-08");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Juliana Pereira", "Rua Ouro", "035999839759", "juliana@mail.com", "128.519.217-09");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Vinicius Silva", "Rua Platina", "035999839760", "vinicius@mail.com", "128.519.217-10");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Elaine Teixeira", "Rua Bronze", "035999839761", "elaine@mail.com", "128.519.217-11");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Maurício Costa", "Rua Diamante", "035999839762", "mauricio@mail.com", "128.519.217-12");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Natália Souza", "Rua Esmeralda", "035999839763", "natalia@mail.com", "128.519.217-13");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Rodrigo Martins", "Rua Safira", "035999839764", "rodrigo@mail.com", "128.519.217-14");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Suzana Almeida", "Rua Rubi", "035999839765", "suzana@mail.com", "128.519.217-15");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Leandro Santos", "Rua Ametista", "035999839766", "leandro@mail.com", "128.519.217-16");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Tatiane Lima", "Rua Topázio", "035999839767", "tatiane@mail.com", "128.519.217-17");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Douglas Oliveira", "Rua Pérola", "035999839768", "douglas@mail.com", "128.519.217-18");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Carla Nogueira", "Rua Cristal", "035999839769", "carla@mail.com", "128.519.217-19");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Alexandre Costa", "Rua Opala", "035999839770", "alexandre@mail.com", "128.519.217-20");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Roberta Fernandes", "Rua Jade", "035999839771", "roberta@mail.com", "128.519.217-21");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Rogério Souza", "Rua Quartzo", "035999839772", "rogerio@mail.com", "128.519.217-22");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);

            accountant = new Accountant("Simone Martins", "Rua Ágata", "035999839773", "simone@mail.com", "128.519.217-23");
            RepositoryAccountant.RepositoryTableAccountant.Add(Accountant.Id, accountant);
        }
    }
}
