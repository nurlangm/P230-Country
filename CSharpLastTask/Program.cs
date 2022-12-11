

namespace CSharpLastTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Country Azerbaijan = new Country("Azerbaycan");

            Azerbaijan.CityList.Add(new City("Baki", 20000));
            Azerbaijan.CityList.Add(new City("Gence", 10000));
            Azerbaijan.CityList.Add(new City("Xacmaz", 15000));

            Country Fransa = new Country("Fransa");

            Fransa.CityList.Add(new City("Paris", 2181371));
            Fransa.CityList.Add(new City("Marsel", 839043));
            Fransa.CityList.Add(new City("Lyon", 472305));


            Console.WriteLine(Azerbaijan.TotalPopulation());
            Azerbaijan.FindAllByPopulation(11000, 50000);
            Console.WriteLine("-----");
            Console.WriteLine("-----");
            Console.WriteLine(Fransa.TotalPopulation());
            Fransa.FindAllByPopulation(11000, 100000000);


        }

    }
}