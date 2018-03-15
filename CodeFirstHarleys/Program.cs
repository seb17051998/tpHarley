using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using codeFirstDAL;
using codeFirstDTO;



namespace CodeFirstHarleys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("début");
            AjouterHarleys();
            AfficheAllVehicule();
            MAJ();
            AfficheAllVehicule();
            Delete();
            AfficheAllVehicule();
            Console.WriteLine("Fin");
            Console.ReadLine();
        }
        static void AfficheAllVehicule()
        {
            HarleyProvider harleyProvider = new HarleyProvider();
            foreach (EntityHarley harley in harleyProvider.GetAllHarleys())
            {
                Console.WriteLine(harley);
            }
        }
        static void AjouterHarleys()
        {
            Console.WriteLine("==== Création d'Harley dans le garage ====");
            HarleyProvider provider = new HarleyProvider();
            provider.Create(new EntityHarley { Couleur = "Verte", Modele = "538 iron", Reservoir = 60 });
            
            provider.Create(new EntityHarley { Couleur = "Jaune", Modele = "787 silver", Reservoir = 45 });
            Console.WriteLine("===========================");
        }
        static void MAJ()
        {
            Console.WriteLine("==== Mise à jour de la couleur ====");
            HarleyProvider provider = new HarleyProvider();
            foreach (EntityHarley harley in provider.GetAllHarleys())
            {
                if (harley.Couleur == "Jaune")
                {
                    harley.Couleur = "Jaune et noir";
                    provider.Update(harley);
                }
            }
            Console.WriteLine("===========================");
        }

        static void Delete()
        {
            Console.WriteLine("==== Effacement de la couleur ====");
            HarleyProvider provider = new HarleyProvider();
            foreach (EntityHarley harley in provider.GetAllHarleys())
            {
                if(harley.Couleur == "Verte")
                {
                    harley.Couleur = "Verte";
                    provider.Delete(harley);
                }
                    
            }
        }

   }
}
