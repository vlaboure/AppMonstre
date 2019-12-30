using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System;
using System.IO;

namespace TestAvecEntitiesCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            ///génére des paramètres de configuration basés sur des clés/valeurs 
            ConfigurationBuilder builder = new ConfigurationBuilder();
            //récupération du chemin du fichier de base de données et connexion avec le fichier json avec AddJsonFile
            builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsetings.json");
            var config = builder.Build();
            ///DefaultContext: chaine de connexion de apseting.json
            string connectionString=config.GetConnectionString("DefaultContext");
            
            ///permet de se connecter à la bdd avec la prortiété Options
            DbContextOptionsBuilder optionBuilder = new DbContextOptionsBuilder();

            ///paramètrage du dbcontext en sql serveur
            optionBuilder.UseSqlServer(connectionString); 
            using (DefaultContext context = new DefaultContext(optionBuilder.Options))
            {
                var query = from droid in context.Droid
                            select droid;

                foreach(var item in query.ToList())
                {
                    Console.WriteLine(item.Matricule);                                                                                                                                                              
                }
            }
            Console.WriteLine("Hello World!");
        }
    }
}
