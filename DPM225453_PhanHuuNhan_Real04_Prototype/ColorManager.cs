using System.Collections.Generic;

namespace DPM225423_NguyenNgocHuy_Pattern01_PrototypeRealWorld
{
    /// <summary>
    /// Prototype manager
    /// </summary>
    public class ColorManager
    {
        private Dictionary<string, ColorPrototype> colors =
            new Dictionary<string, ColorPrototype>();

        // Indexer
        public ColorPrototype this[string key]
        {
            get { return colors[key]; }
            set { colors.Add(key, value); }
        }
    }
}
