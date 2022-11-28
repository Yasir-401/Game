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
    public class Lost : GameState, IDrawable, IStateWithTime
    {
        #region Fields
        private int _counter = 0; 
        #endregion
        #region Methods
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(FontInventory.GetInstance().GiveRequestedResource("File"), "GAME OVER", new Vector2(700, 600), Color.Black);

        }

        public Lost(MyGameWrapper machine) : base(machine)
        {

        }

        public void Handle(GameTime time)
        {
            if (++_counter > 100)
                Machine.ChangeState(new Running(Machine));
        } 
        #endregion
    }
}
