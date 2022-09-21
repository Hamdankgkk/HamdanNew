using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace sprint0
{
    public class DecideItem
    {
        private Game1 game;
        public int currentItem { get; set; }
        public ItemFactory Factory { get; set; }
        
        public ItemFactory ItemFactory { get; set; }

        public DecideItem(Game1 game)
        {
            this.game = game;
        }
        public ISprite Decision(SpriteBatch sprite)
        {
            if (currentItem == 0)
            {
                return Factory.ZeldaArrow(sprite, new Vector2(0, 0), new Vector2(0, 0));
            }
            else if (currentItem == 1)
            {
                return Factory.ZeldaBow(sprite, new Vector2(0, 0), new Vector2(0, 0));
            }
            else if (currentItem == 2)
            {
                return Factory.ZeldaBomb(sprite, new Vector2(0, 0), new Vector2(0, 0));
            }
            else if (currentItem == 3)
            {
                return Factory.ZeldaBlueCandle(sprite, new Vector2(0, 0), new Vector2(0, 0));
            }
            else if (currentItem == 4)
            {
                return Factory.ZeldaCompass(sprite, new Vector2(0, 0), new Vector2(0, 0));
            }
            else if (currentItem == 5)
            {
                return Factory.ZeldaClock(sprite, new Vector2(0, 0), new Vector2(0, 0));
            }
            else if (currentItem == 6)
            {
                return Factory.ZeldaFairy(sprite, new Vector2(0, 0), new Vector2(0, 0));
            }
            else if (currentItem == 7)
            {
                return Factory.ZeldaFood(sprite, new Vector2(0, 0), new Vector2(0, 0));
            }
            else if (currentItem == 8)
            {
                return Factory.ZeldaHeart(sprite, new Vector2(0, 0), new Vector2(0, 0));
            }
            else if (currentItem == 9)
            {
                return Factory.ZeldaHeartContainer(sprite, new Vector2(0, 0), new Vector2(0, 0));
            }
            else if (currentItem == 10)
            {
                return Factory.ZeldaKey(sprite, new Vector2(0, 0), new Vector2(0, 0));
            }
            else
            {
                return Factory.ZeldaLetter(sprite, new Vector2(0, 0), new Vector2(0, 0));
            }
        }
    }
}
