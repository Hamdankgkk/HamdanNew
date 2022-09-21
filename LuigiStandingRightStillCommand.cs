using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace sprint0
{
    internal class LuigiStandingRightStillCommand : ICommand
    {
        private Game1 game;
        public LuigiStandingRightStillCommand(Game1 game)
        {
            this.game = game;
        }
        public void Execute()
        {
            this.game.player.PlayerSprite.SourceRectangle = SpriteRectangle.LuigiStandingRight;
            this.game.player.PlayerSprite.Frame = 0;
            this.game.player.PlayerSprite.Velocity = new Vector2(0, 0);
        }
    }
}
