using Microsoft.Xna.Framework;
using System;
using System.Reflection;
using System.Windows.Input;

namespace sprint0
{
    internal class LuigiRunningRightMovingCommand : ICommand
    {
        private Game1 game;
        public LuigiRunningRightMovingCommand(Game1 game)
        {
            this.game = game;
        }
        public void Execute()
        {
            this.game.player.PlayerSprite.SourceRectangle = SpriteRectangle.LuigiRunningRight;
            this.game.player.PlayerSprite.Frame = 0;
            this.game.player.PlayerSprite.Velocity = new Vector2(0, 0);
            
        }
    }
}
