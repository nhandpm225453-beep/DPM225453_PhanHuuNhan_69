using System;

namespace DPM225423_NguyenNgocHuy_Myworld1_Singleton
{
    /// <summary>
    /// Singleton Design Pattern - MyWorld01 Example
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            PrinterSpooler spooler1 = PrinterSpooler.GetInstance();
            PrinterSpooler spooler2 = PrinterSpooler.GetInstance();

            // Same instance?
            if (spooler1 == spooler2)
            {
                Console.WriteLine("Same PrinterSpooler instance\n");
            }

            // Add print jobs
            spooler1.AddJob("Document A");
            spooler1.AddJob("Document B");
            spooler2.AddJob("Document C");

            // Process jobs
            spooler1.ProcessJobs();

            // Wait for user
            Console.ReadKey();
        }
    }
}
