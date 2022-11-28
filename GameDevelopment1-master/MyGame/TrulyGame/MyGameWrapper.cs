using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MyGame.BaseClasses;
using MyGame.interfaces;
using MyGame.Inventories;
using IDrawable = MyGame.interfaces.IDrawable;

namespace MyGame.TrulyGame
{
    public class MyGameWrapper : FiniteStateMachine, IDrawableUpdateWithTime
    {
        #region Fields

        private readonly List<IGameObject> gameCharacters = new List<IGameObject>();

        #endregion
        #region Properties
        public int Level { get; set; } = 1; 
        #endregion
        #region Methods
        public MyGameWrapper()
        {
            CurrentMachineInventory.GetInstance().Items.Add(this);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            if (State is IDrawable d)
                d.Draw(spriteBatch);
        }

        public void Update(GameTime time)
        {
            if (State is IStateWithTime temperorary)
                temperorary.Handle(time);
            else
                ((IStateWithoutTime)State).Handle();
            gameCharacters.ForEach(x => x.Update(time));
        }

        #endregion
    }
}