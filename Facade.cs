using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Examples
{
    // Mainapp test application 
    class MainApp
    {
        public static void Main()
        {
            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();
            // Wait for user 
            Console.Read();
        }
    }


    // "Subsystem ClassA" 
    class WeddingServices
    {
        public void Wedding()
        {
            Console.WriteLine(" Wedding");
        }
    }

    // Subsystem ClassB" 
    class LaughtCompany
    {
        public void Party()
        {
            Console.WriteLine(" Fun party");
        }
    }


    // Subsystem ClassC" 
    class Restaurant
    {
        public void GetFood()
        {
            Console.WriteLine("Order food from restaurant");
        }
    }
    // Subsystem ClassD" 
    class CleaningCompany
    {
        public void Clean()
        {
            Console.WriteLine(" cleaning services");
        }
    }
    // "Facade" 
    class PartyManagerFacade
    {
        WeddingServices one;
        LaughtCompany two;
        Restaurant three;
        CleaningCompany four;

        public PartyManagerFacade()
        {
            one = new WeddingServices();
            two = new LaughtCompany();
            three = new Restaurant();
            four = new CleaningCompany();
        }

        public void Wedding()
        {
            Console.WriteLine("\nWedding() ---- ");
            one.Wedding();
            three.GetFood();
            four.Clean();
        }

        public void PartyForChildren()
        {
            Console.WriteLine("\nChildren`s party() ---- ");
            two.Party();
            three.GetFood();
            four.Clean();
        }
        public void PizzaParty()
        {
            Console.WriteLine("\nPizzaParty() ---- ");
            three.GetFood();
            four.Clean();
        }
    }
}
