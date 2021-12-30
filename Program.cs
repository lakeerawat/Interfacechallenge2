using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceChallenge2
{
    public class ClasssiCar
    {
        public string m_Make;
        public string m_Model;
        public int m_Year;
        public int m_Value;

        public ClasssiCar(string make, string model, int year, int val)
        {
            m_Make = make;
            m_Model = model;
            m_Year = year;
            m_Value = val;

        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            List<ClasssiCar> carList = new List<ClasssiCar>();
            populateData(carList);

            Console.WriteLine("There are {0} cars in the entire collectoin.\n", carList.Count);
            List<ClasssiCar> fordList = carList.FindAll(FindFords);
            Console.WriteLine("there are {0} Fords in the entire collection. \n", fordList.Count);

            ClasssiCar mostValCar = null;
            int highValue = 0;
            foreach (ClasssiCar c in carList)
            {
                if(c.m_Value > highValue)
                {
                    mostValCar = c;
                    highValue = c.m_Value;
                }
            }
            Console.WriteLine("The most valueable car is {0} {1} {2} at ${3}\n", mostValCar.m_Year, mostValCar.m_Make, mostValCar.m_Value);
            int totalValue = 0;
            foreach(ClasssiCar c in carList)
            {
                totalValue += c.m_Value;
            }
            Console.WriteLine("The collection is worth ${0}\n", totalValue);
            Dictionary<string, bool> makes = new Dictionary<string, bool>();
            foreach(ClasssiCar c in carList)
            {
                try
                {
                    makes.Add(c.m_Make, true);
                }
                catch(Exception e) { }

            };
            Console.WriteLine("the collection contains {0} unique manufacturers.\n", makes.Keys.Count);
            Console.WriteLine("\nhit Enter key to continue...");
            Console.ReadLine();
        }
        static bool FindFords(ClasssiCar car)
        {
            if(car.m_Make == "Ford")
                return true;
            return false;
        }
        static void populateData(List<ClasssiCar> theList)
        {
            theList.Add(new ClasssiCar("Alfa Romeo", "spider veloce", 1965, 15000));
            theList.Add(new ClasssiCar("Alfa Romeo", "1750 Berlina", 1970, 20000));
            theList.Add(new ClasssiCar("Alfa Romeo", "Giuletta", 1978, 45000));

            theList.Add(new ClasssiCar("Ford", "Thunderbird", 1971, 35000));
            theList.Add(new ClasssiCar("Ford", "Mustang", 1976, 29800));
            theList.Add(new ClasssiCar("Ford", "corsair", 1970, 17900));
            theList.Add(new ClasssiCar("Ford", "LTD", 1969, 12000));

            theList.Add(new ClasssiCar("Chervolet", "spider camaro", 1979, 7000));
            theList.Add(new ClasssiCar("Chervolet", "corvette stringray", 1966, 21000));
            theList.Add(new ClasssiCar("Chervolet", "Monte carlo", 1984, 10000));

        }

    }
}
