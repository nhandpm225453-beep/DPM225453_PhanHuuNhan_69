namespace DPM225453_PhanHuuNhan_Myworld01_Singleton
{
    /// <summary>
    /// The 'Singleton' class
    /// </summary>
    public class Singleton
    {
        private static Singleton instance;

        // Constructor is 'protected'
        protected Singleton()
        {
        }

        public static Singleton Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }
    }
}
