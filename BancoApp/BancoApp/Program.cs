using BancoApp.Bussines;
using BancoApp.Domain;
using System.Reflection.Emit;

namespace BancoApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Service oService = new Service();

            Client c = new Client("Gabriel", "Antico", 46032095);

            Account a = new Account();

            a.Client = c;

            string cbu = string.Empty;
            float balance = 0;
            string typeAccount = string.Empty;
            float lastMove = 0;

            try
            {
                Console.WriteLine("Ingrese el cbu de la cuenta a crear");
                cbu = Console.ReadLine();

                Console.WriteLine("Ingrese el saldo de la cuenta");
                balance = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el tipo de cuenta que posee el usuario");
                typeAccount = Console.ReadLine();

                Console.WriteLine("Ingrese el ultimo movimiento de la cuenta");
                lastMove = float.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Escribió un tipo de dato incorrecto");
            }

            a.Cbu = cbu;
            a.Balance = balance;
            a.TypeAccount = typeAccount;
            a.LastMove = lastMove;
            
            a.Balance = Convert.ToInt32(Console.ReadLine());
            a.TypeAccount = Console.ReadLine();
            a.LastMove = Convert.ToInt32(Console.ReadLine());

            int affectedRows = oService.Register(a);

            if (affectedRows > 0)
            {
                Console.WriteLine("Se ha agregado una cuenta");
            }
            else
            {
                Console.WriteLine("Error al agregar la cuenta");
            }




        }
    }
}
