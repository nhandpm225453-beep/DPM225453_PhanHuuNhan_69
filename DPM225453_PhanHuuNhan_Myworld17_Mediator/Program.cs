using System;
using System.Collections.Generic;

namespace DPM225423_NguyenNgocHuy_Myworld16_Mediator
{
    /// <summary>
    /// Mediator Design Pattern - Ví dụ: Air Traffic Control
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Tạo tháp điều khiển (Mediator)
            ControlTower tower = new ControlTower();

            // Tạo các máy bay
            Aircraft plane1 = new PassengerPlane("VN123");
            Aircraft plane2 = new PassengerPlane("VN456");
            Aircraft plane3 = new CargoPlane("Cargo789");

            // Đăng ký máy bay với tháp điều khiển
            tower.Register(plane1);
            tower.Register(plane2);
            tower.Register(plane3);

            // Máy bay gửi tin nhắn qua tháp điều khiển
            plane1.Send("VN456", "Xin phép hạ cánh.");
            plane2.Send("VN123", "Đã nhận, nhường đường cho bạn.");
            plane3.Send("VN123", "Tôi sẽ bay vòng chờ thêm 10 phút.");

            Console.ReadKey();
        }
    }

    /// <summary>
    /// Mediator abstract class
    /// </summary>
    public abstract class AbstractControlTower
    {
        public abstract void Register(Aircraft aircraft);
        public abstract void Send(string from, string to, string message);
    }

    /// <summary>
    /// ConcreteMediator - Tháp điều khiển
    /// </summary>
    public class ControlTower : AbstractControlTower
    {
        private Dictionary<string, Aircraft> aircrafts = new Dictionary<string, Aircraft>();

        public override void Register(Aircraft aircraft)
        {
            if (!aircrafts.ContainsKey(aircraft.Code))
            {
                aircrafts[aircraft.Code] = aircraft;
            }
            aircraft.ControlTower = this;
        }

        public override void Send(string from, string to, string message)
        {
            if (aircrafts.ContainsKey(to))
            {
                Aircraft receiver = aircrafts[to];
                receiver.Receive(from, message);
            }
        }
    }

    /// <summary>
    /// AbstractColleague - Máy bay
    /// </summary>
    public abstract class Aircraft
    {
        private ControlTower controlTower;
        private string code;

        public Aircraft(string code)
        {
            this.code = code;
        }

        public string Code
        {
            get { return code; }
        }

        public ControlTower ControlTower
        {
            get { return controlTower; }
            set { controlTower = value; }
        }

        public void Send(string to, string message)
        {
            controlTower.Send(code, to, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine($"{from} → {Code}: '{message}'");
        }
    }

    /// <summary>
    /// ConcreteColleague - Máy bay chở khách
    /// </summary>
    public class PassengerPlane : Aircraft
    {
        public PassengerPlane(string code) : base(code) { }

        public override void Receive(string from, string message)
        {
            Console.Write("✈️ [Passenger Plane] ");
            base.Receive(from, message);
        }
    }

    /// <summary>
    /// ConcreteColleague - Máy bay chở hàng
    /// </summary>
    public class CargoPlane : Aircraft
    {
        public CargoPlane(string code) : base(code) { }

        public override void Receive(string from, string message)
        {
            Console.Write("🛫 [Cargo Plane] ");
            base.Receive(from, message);
        }
    }
}
