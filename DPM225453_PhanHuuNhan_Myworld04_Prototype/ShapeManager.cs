using System.Collections.Generic;

namespace DPM225453_PhanHuuNhan_Myworld01_PrototypeRealWorld
{
    /// <summary>
    /// Prototype manager for Shapes
    /// </summary>
    public class ShapeManager
    {
        private Dictionary<string, ShapePrototype> shapes =
            new Dictionary<string, ShapePrototype>();

        // Indexer
        public ShapePrototype this[string key]
        {
            get { return shapes[key]; }
            set { shapes.Add(key, value); }
        }
    }
}
