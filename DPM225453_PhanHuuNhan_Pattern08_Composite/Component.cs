namespace DPM225423_NguyenNgocHuy_Pattern01_Composite
{
    /// <summary>
    /// The 'Component' abstract class
    /// </summary>
    public abstract class Component
    {
        protected string name;

        // Constructor
        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }
}

