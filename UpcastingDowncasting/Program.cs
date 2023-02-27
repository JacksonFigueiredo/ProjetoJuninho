

using UpcastingDowncasting.Entities;

namespace UpcastingDowncasting
{
    internal class Program
    {

        //Upcasting
        //Casting da subclasse para supeclasse.
        //Uso Comum : Polimorfismo


        //Downcasting

        //Casting da superclasse para subclasse
        //palavra as
        //palavra is
        //uso comun : metodos que recebem parametros genericos.


        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1, "Bob", 0.0, 200);
            Account acc3 = new SavingsAccount(2, "Ana", 0.0, 0.01);


            //DOWNCASTING.

            BusinessAccount accountacc4 = (BusinessAccount)acc2;

            BusinessAccount accountacc5 = (BusinessAccount)acc3;


        }
    }
}