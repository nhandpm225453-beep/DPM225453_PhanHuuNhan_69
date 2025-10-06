using System;
using System.Collections.Generic;

namespace DPM225423_NguyenNgocHuy_Myworld18_Observer
{
    /// <summary>
    /// Observer Design Pattern - Weather Station Example
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Tạo đối tượng WeatherStation (Subject)
            WeatherStation weatherStation = new WeatherStation(30.0);

            // Gắn Observer
            weatherStation.Attach(new PhoneDisplay("Điện thoại của Huy"));
            weatherStation.Attach(new PhoneDisplay("Điện thoại của Lan"));
            weatherStation.Attach(new TVDisplay("Tivi Phòng Khách"));

            // Thay đổi nhiệt độ -> Notify observers
            weatherStation.Temperature = 31.5;
            weatherStation.Temperature = 28.0;
            weatherStation.Temperature = 29.3;

            Console.ReadKey();
        }
    }

    /// <summary>
    /// Subject (trạm thời tiết)
    /// </summary>
    public abstract class WeatherData
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(double temperature)
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature);
            }
            Console.WriteLine("");
        }
    }

    /// <summary>
    /// ConcreteSubject (WeatherStation)
    /// </summary>
    public class WeatherStation : WeatherData
    {
        private double temperature;

        public WeatherStation(double temperature)
        {
            this.temperature = temperature;
        }

        public double Temperature
        {
            get { return temperature; }
            set
            {
                if (temperature != value)
                {
                    temperature = value;
                    Console.WriteLine($"[WeatherStation] Nhiệt độ mới: {temperature}°C");
                    Notify(temperature);
                }
            }
        }
    }

    /// <summary>
    /// Observer interface
    /// </summary>
    public interface IObserver
    {
        void Update(double temperature);
    }

    /// <summary>
    /// ConcreteObserver - PhoneDisplay
    /// </summary>
    public class PhoneDisplay : IObserver
    {
        private string owner;

        public PhoneDisplay(string owner)
        {
            this.owner = owner;
        }

        public void Update(double temperature)
        {
            Console.WriteLine($"📱 {owner} nhận thông báo: Nhiệt độ hiện tại là {temperature}°C");
        }
    }

    /// <summary>
    /// ConcreteObserver - TVDisplay
    /// </summary>
    public class TVDisplay : IObserver
    {
        private string name;

        public TVDisplay(string name)
        {
            this.name = name;
        }

        public void Update(double temperature)
        {
            Console.WriteLine($"📺 {name} hiển thị: Nhiệt độ hiện tại là {temperature}°C");
        }
    }
}
