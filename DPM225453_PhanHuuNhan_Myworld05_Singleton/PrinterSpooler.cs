using System;
using System.Collections.Generic;

namespace DPM225423_NguyenNgocHuy_Myworld1_Singleton
{
    /// <summary>
    /// The 'Singleton' class - Printer Spooler
    /// </summary>
    public class PrinterSpooler
    {
        private static PrinterSpooler instance;
        private static object locker = new object();

        private Queue<string> jobQueue = new Queue<string>();

        // Protected constructor
        protected PrinterSpooler()
        {
            Console.WriteLine("Printer Spooler created.");
        }

        // Get Singleton Instance
        public static PrinterSpooler GetInstance()
        {
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new PrinterSpooler();
                    }
                }
            }
            return instance;
        }

        // Add print job
        public void AddJob(string document)
        {
            jobQueue.Enqueue(document);
            Console.WriteLine("Job added: " + document);
        }

        // Process all print jobs
        public void ProcessJobs()
        {
            Console.WriteLine("\nProcessing Print Jobs...");
            while (jobQueue.Count > 0)
            {
                string job = jobQueue.Dequeue();
                Console.WriteLine("Printing: " + job);
            }
        }
    }
}
