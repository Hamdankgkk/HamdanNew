using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint0
{
    public class ItemRectangle
    {
        //used for both arrow and silverarrow and bow
        public static Rectangle[] BowArrow = { new Rectangle(210, 0, 5, 16) };

        //red and blue candle
        public static Rectangle[] Candle = { new Rectangle(210, 0, 8, 16) };

        public static Rectangle[] Bomb = { new Rectangle(210, 0, 8, 14) };

        //boomerang and magical boomerang
        public static Rectangle[] Boomerang = { new Rectangle(210, 0, 5, 8) };

        public static Rectangle[] Clock = { new Rectangle(210, 0, 11, 16) };

        public static Rectangle[] Compass = { new Rectangle(210, 0, 11, 12) };

        public static Rectangle[] Fairy = { new Rectangle(210, 0, 8, 16) };

        public static Rectangle[] Food = { new Rectangle(210, 0, 8, 16) };

        public static Rectangle[] Heart = { new Rectangle(210, 0, 7, 8) };

        public static Rectangle[] HeartContainer = { new Rectangle(210, 0, 8, 16) };

        //used for both normal and magical keys
        public static Rectangle[] Key = { new Rectangle(210, 0, 8, 16) };

        public static Rectangle[] Letter = { new Rectangle(210, 0, 8, 16) };
    }
}
