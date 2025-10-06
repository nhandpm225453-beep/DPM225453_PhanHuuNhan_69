namespace DPM225453_PhanHuuNhan_Myworld01_Bridge
{
    /// <summary>
    /// The 'Abstraction' class
    /// </summary>
    public class ShapeBase
    {
        protected ColorImplementor color;

        public ColorImplementor Color
        {
            set { color = value; }
            get { return color; }
        }

        protected string shapeName;

        public ShapeBase(string shapeName)
        {
            this.shapeName = shapeName;
        }

        public virtual void Draw()
        {
            color.Paint(shapeName);
        }
    }
}
    