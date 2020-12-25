using System;

namespace PrototypePattern
{
    public class Game:ICloneable
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public GameType GameType { get; set; }
        public bool State { get; set; }

        public object Clone()
        {
            var cloneObj = this.MemberwiseClone();
            ((Game) cloneObj).GameType = (GameType)this.GameType.Clone();
            return cloneObj;
        }
    }
}