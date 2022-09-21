using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint0
{
    public class Player
    {
        public Sprite PlayerSprite;
        public void AssignPlayerSprite(SpriteBatch PlayerSpriteBatch, Vector2 PlayerPosition, Vector2 PlayerVelocity, Rectangle[] sourceRectangle, Texture2D PlayerTexture)
        {
            this.PlayerSprite = new Sprite(PlayerTexture, sourceRectangle, PlayerSpriteBatch, PlayerPosition, PlayerVelocity);
        }
        
    }
}
