namespace DPM225453_PhanHuuNhan_Pattern06_Bridge
{
    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    public class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }
}