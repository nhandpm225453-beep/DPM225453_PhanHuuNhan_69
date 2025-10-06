using System;
using System.Collections.Generic;

namespace DPM225423_NguyenNgocHuy_Myworld10_Flyweight
{
    /// <summary>
    /// Flyweight Design Pattern - MyWorld Example
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Tạo rừng và trồng cây
            Forest forest = new Forest();

            forest.PlantTree(1, 2, "Oak", "Green");
            forest.PlantTree(2, 3, "Oak", "Green");
            forest.PlantTree(5, 7, "Pine", "Dark Green");
            forest.PlantTree(10, 15, "Cherry", "Pink");
            forest.PlantTree(12, 17, "Cherry", "Pink");

            // Hiển thị toàn bộ rừng
            forest.Display();

            Console.ReadKey();
        }
    }

    /// <summary>
    /// Flyweight Factory: TreeFactory
    /// </summary>
    public class TreeFactory
    {
        private Dictionary<string, TreeType> treeTypes = new Dictionary<string, TreeType>();

        public TreeType GetTreeType(string name, string color)
        {
            string key = name + "_" + color;

            if (!treeTypes.ContainsKey(key))
            {
                treeTypes[key] = new TreeType(name, color);
                Console.WriteLine("Created new TreeType: " + key);
            }

            return treeTypes[key];
        }
    }

    /// <summary>
    /// The Flyweight class: TreeType (chứa trạng thái dùng chung)
    /// </summary>
    public class TreeType
    {
        public string Name { get; private set; }
        public string Color { get; private set; }

        public TreeType(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public void Display(int x, int y)
        {
            Console.WriteLine($"Tree {Name} with color {Color} at ({x}, {y})");
        }
    }

    /// <summary>
    /// Context: Tree (chứa extrinsic state: x, y)
    /// </summary>
    public class Tree
    {
        private int x;
        private int y;
        private TreeType type;

        public Tree(int x, int y, TreeType type)
        {
            this.x = x;
            this.y = y;
            this.type = type;
        }

        public void Display()
        {
            type.Display(x, y);
        }
    }

    /// <summary>
    /// Client: Forest
    /// </summary>
    public class Forest
    {
        private List<Tree> trees = new List<Tree>();
        private TreeFactory factory = new TreeFactory();

        public void PlantTree(int x, int y, string name, string color)
        {
            TreeType type = factory.GetTreeType(name, color);
            Tree tree = new Tree(x, y, type);
            trees.Add(tree);
        }

        public void Display()
        {
            foreach (var tree in trees)
            {
                tree.Display();
            }
        }
    }
}
