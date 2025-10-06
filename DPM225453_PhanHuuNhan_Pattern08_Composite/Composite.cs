using System;
using System.Collections.Generic;

namespace DPM225423_NguyenNgocHuy_Pattern01_Composite
{
    /// <summary>
    /// The 'Composite' class
    /// </summary>
    public class Composite : Component
    {
        private List<Component> children = new List<Component>();

        // Constructor
        public Composite(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);

            // Recursively display child nodes
            foreach (Component component in children)
            {
                component.Display(depth + 2);
            }
        }
    }
}
