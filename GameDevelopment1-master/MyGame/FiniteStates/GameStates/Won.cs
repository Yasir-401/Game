using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MyGame.BaseClasses;
using MyGame.interfaces;
using MyGame.Inventories;
using MyGame.TrulyGame;
using IDrawable = MyGame.interfaces.IDrawable;

namespace MyGame.FiniteStates.GameStates
{
   public class Won: GameState, IDrawable, IStateWithTime
   {
        #region Fields
        private int counter = 0; 
        #endregion
        #region Methods
        public Won(MyGameWrapper machine) : base(machine)
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(FontInventory.GetInstance().GiveRequestedResource("File"), "You have won", new Vector2(500, 750), Color.Black);
        }

        public void Handle(GameTime time)
        {
            if (++counter > 70)
            {
                Machine.ChangeState(new Running(Machine));
            }
        } 
        #endregion
    }
}
