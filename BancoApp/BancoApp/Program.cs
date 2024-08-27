using BancoApp.Bussines;
using BancoApp.Domain;

namespace BancoApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Service oService = new Service();

            Client c = new Client("Gabriel", "Antico", 46032095);

            Account a = new Account();
            a.Cbu = Console.ReadLine();
            a.Client = c;
            a.Balance = Convert.ToInt32(Console.ReadLine());
            a.TypeAccount = "Caja de Ahorro";
            a.LastMove = Convert.ToInt32(Console.ReadLine());

            int affectedRows = oService.Register(a);

            if (affectedRows > 0)
            {
                Console.WriteLine("Se ha agregado una cuenta");
            }




        }
    }
}
