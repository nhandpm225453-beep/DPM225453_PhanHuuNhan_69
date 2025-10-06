using System;

namespace DPM225423_NguyenNgocHuy_Myworld11_Proxy
{
    /// <summary>
    /// Proxy Design Pattern - MyWorld Example
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Tạo proxy cho ảnh
            IImage image = new ProxyImage("landscape.png");

            // Ảnh chỉ được load khi lần đầu hiển thị
            Console.WriteLine("Chưa gọi Display nên ảnh chưa load...");
            Console.WriteLine();

            // Hiển thị ảnh lần đầu -> sẽ load ảnh thật sự
            image.Display();

            Console.WriteLine();

            // Hiển thị ảnh lần 2 -> dùng lại ảnh đã load
            image.Display();

            Console.ReadKey();
        }
    }

    /// <summary>
    /// Subject interface
    /// </summary>
    public interface IImage
    {
        void Display();
    }

    /// <summary>
    /// RealSubject: Ảnh thật
    /// </summary>
    public class RealImage : IImage
    {
        private string fileName;

        public RealImage(string fileName)
        {
            this.fileName = fileName;
            LoadFromDisk();
        }

        private void LoadFromDisk()
        {
            Console.WriteLine("Loading image from disk: " + fileName);
        }

        public void Display()
        {
            Console.WriteLine("Displaying image: " + fileName);
        }
    }

    /// <summary>
    /// Proxy: Ảnh đại diện
    /// </summary>
    public class ProxyImage : IImage
    {
        private RealImage realImage;
        private string fileName;

        public ProxyImage(string fileName)
        {
            this.fileName = fileName;
        }

        public void Display()
        {
            if (realImage == null)
            {
                realImage = new RealImage(fileName);
            }
            realImage.Display();
        }
    }
}
