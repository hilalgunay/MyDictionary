using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            GamerManager gamerManager = new GamerManager(new UserValitationManager());
            gamerManager.Add(new Gamer { Id = 1, Birthdate = 1985, FirstName = "Hilal", LastName = "Günay", IdentityNumber = 1234 });

            Console.WriteLine("Hello World!");

        }
    }
}
