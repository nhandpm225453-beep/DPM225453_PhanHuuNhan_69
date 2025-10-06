namespace DPM225423_NguyenNgocHuy_Real01_Composite
{
    /// <summary>
    /// The 'Component' Treenode
    /// </summary>
    public abstract class DrawingElement
    {
        protected string name;

        // Constructor
        public DrawingElement(string name)
        {
            this.name = name;
        }

        public abstract void Add(DrawingElement d);
        public abstract void Remove(DrawingElement d);
        public abstract void Display(int indent);
    }
}
