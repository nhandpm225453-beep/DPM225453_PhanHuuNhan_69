using System;

namespace DPM225453_PhanHuuNhan_Pattern06_Bridge
{
    /// <summary>
    /// Bridge Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Abstraction ab = new RefinedAbstraction();

            // Set implementation and call
            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();

            // Change implementation and call
            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();

            // Wait for user
            Console.ReadKey();
        }
    }
}