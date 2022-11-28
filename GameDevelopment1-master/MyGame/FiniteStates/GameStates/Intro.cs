using System;
using Microsoft.Xna.Framework.Graphics;
using MyGame.BaseClasses;
using MyGame.Binders;
using MyGame.interfaces;
using MyGame.TrulyGame;

namespace MyGame.FiniteStates.GameStates
{
    public class Intro : GameState, IDrawable, IStateWithoutTime
    {
        #region Fields

        private readonly IMenu menu;

        #endregion
        #region Methods
        public Intro(MyGameWrapper machine, IMenu menuInput) : base(machine)
        {
            menu = menuInput;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (menu is IDrawable d) d.Draw(spriteBatch);
        }

        public void Handle()
        {
            menu.Buttons[0].Click += Intro_Click;
            if (menu is IUpdateable u) u.Update();
        }

        private void Intro_Click(object sender, EventArgs e)
        {
            Machine.ChangeState(ButtonToStateBinder.GetInstance().BindButtonToState((Button)sender));
        }

        #endregion
    }
}