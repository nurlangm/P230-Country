namespace CSharpLastTask
{
    internal class Country
    {
        public string Name;

        public  int count;

        public List<City> CityList = new List<City>();
        public Country(string name)
        {
            Name = name;
        }
        public int TotalPopulation()
        {
            foreach (var item in CityList)
            {
                count += item.Population;
         

            }
            Console.Write($"Country:{Name}||Population:");
            return count;

        }
        public void FindAllByPopulation(int min, int max)
        {
            List<City> city = new List<City>();

            foreach (var item in CityList)
            {
                if (item.Population > min || item.Population < max)
                {
                    city.Add(item);

                    Console.WriteLine($"{item.Name} {item.Population}");
                }

            }

        }


    }
}