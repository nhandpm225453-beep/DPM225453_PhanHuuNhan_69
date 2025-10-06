using System;

namespace DPM225453_PhanHuuNhan_Myworld01_Singleton
{
    /// <summary>
    /// Singleton Design Pattern - Demo Program
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Constructor is protected -- cannot use new

            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            // Test for same instance
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}
