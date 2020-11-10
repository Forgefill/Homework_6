using System;
namespace FactoryMethodExample
{
    //абстрактний клас творця, який має абстрактний метод FactoryMethod, що приймає тип продукта
    public abstract class Creator
    {

        public abstract Product CreateDetail(int i); // FactoryMethod
    }

    public class DetailCreator : Creator
    {
        

        public override Product CreateDetail(int i)
        {
            switch (i)
            {
                case 1:
                    return new WoodDetail();
                case 2:
                    return new IronDetail();
                case 3:
                    return new PlasticDetail();
                case 4:
                    return new GoldenDetail();
                default: throw new ArgumentException("Invalid type.", "type");
            }

        }
    }

    public abstract class Product 
    {
        public abstract string GetDType();
    } //абстрактний клас продукт

    //конкретні продукти з різною реалізацією
    public class WoodDetail : Product 
    {
        public override string GetDType()
        {
            return "Wood";
        }
    }

    public class IronDetail : Product
    {
        public override string GetDType()
        {
            return "Iron";
        }
    }

    public class PlasticDetail : Product
    {
        public override string GetDType()
        {
            return "Plastic";
        }
    }

    public class GoldenDetail : Product
    {
        public override string GetDType()
        {
            return "Gold";
        }
    }

    class MainApp
    {
        static void Main()
        {       //створюємо творця
            Creator creator = new DetailCreator();
            for (int i = 1; i <= 4; i++)
            {
                //створюємо спочатку продукт з типом 1, потім з типом 2
                var product = creator.CreateDetail(i);
                Console.WriteLine("Where id = {0}, Created {1} ", i, product.GetDType());
            }
            Console.ReadKey();
        }
    }
}

