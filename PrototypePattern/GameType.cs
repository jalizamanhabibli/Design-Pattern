using System;

namespace PrototypePattern
{
    public class GameType:ICloneable
    {
        public string TypeName { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}