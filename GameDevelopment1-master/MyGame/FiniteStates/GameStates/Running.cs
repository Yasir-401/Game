using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MyGame.BaseClasses;
using MyGame.Enums;
using MyGame.Factory_Classes;
using MyGame.GameCharacters;
using MyGame.Hitboxes;
using MyGame.interfaces;
using MyGame.Inventories;
using MyGame.TrulyGame;
using IDrawable = MyGame.interfaces.IDrawable;

namespace MyGame.FiniteStates.GameStates
{
    public class Running : GameState, IDrawable, IStateWithTime
    {
        #region Methods
        public Running(MyGameWrapper machine) : base(machine)
        {
            var level=LevelFactory.CreateLevel(((MyGameWrapper)CurrentMachineInventory.GetInstance().Items[0]).Level);
            ScreenBoundsInventory.GetInstance().ScreenWidth *=
                ((MyGameWrapper)CurrentMachineInventory.GetInstance().Items[0]).Level;
            ScreenBoundsInventory.GetInstance().ScreenHeight *=
                ((MyGameWrapper)CurrentMachineInventory.GetInstance().Items[0]).Level;
          int counter = 0;
          for (int i = 0; i < level.Elements.GetLength(0); i++)
          {
              for (int j = 0; j < level.Elements.GetLength(1); j++)
              {
                  if (level.Elements[i, j] != null)
                  {
                      CharacterInventory.GetInstance().Items[counter]=level.Elements[i,j];
                      counter++;
                  }
              }
          }

            ScreenBoundsInventory.GetInstance().Items[0]=new HitBox(new Rectangle(0, -ScreenBoundsInventory.GetInstance().ScreenWidth, ScreenBoundsInventory.GetInstance().ScreenWidth, ScreenBoundsInventory.GetInstance().ScreenWidth),HitBoxType.Bottom,new Rectangle(0,0,0,0),new Tuple<int, int>(ScreenBoundsInventory.GetInstance().ScreenWidth*2,0));
            ScreenBoundsInventory.GetInstance().Items[1]=new HitBox(new Rectangle(-ScreenBoundsInventory.GetInstance().ScreenWidth, 0, ScreenBoundsInventory.GetInstance().ScreenWidth+20,ScreenBoundsInventory.GetInstance(). ScreenHeight),HitBoxType.Right,new Rectangle(0,0,200,ScreenBoundsInventory.GetInstance().ScreenHeight),new Tuple<int, int>(200*2,ScreenBoundsInventory.GetInstance().ScreenHeight*2));
            ScreenBoundsInventory.GetInstance().Items[2]=new HitBox(new Rectangle(ScreenBoundsInventory.GetInstance().ScreenWidth, 0, 1000, ScreenBoundsInventory.GetInstance().ScreenHeight),HitBoxType.Left,new Rectangle(0,0,200,ScreenBoundsInventory.GetInstance().ScreenHeight),new Tuple<int, int>(200*2,ScreenBoundsInventory.GetInstance().ScreenHeight*2));
            ScreenBoundsInventory.GetInstance().Items[3] = new HitBox(
                new Rectangle(0, ScreenBoundsInventory.GetInstance().ScreenHeight,
                    ScreenBoundsInventory.GetInstance().ScreenWidth, 500), HitBoxType.Top,
                new Rectangle(0, 0, ScreenBoundsInventory.GetInstance().ScreenWidth,
                    ScreenBoundsInventory.GetInstance().ScreenHeight),
                new Tuple<int, int>(ScreenBoundsInventory.GetInstance().ScreenWidth * 2, 100 * 2));


        }
        public void Draw(SpriteBatch spriteBatch)
        {
            if(((MyGameWrapper)CurrentMachineInventory.GetInstance().Items[0]).Level==1)
                spriteBatch.Draw(TextureInventory.GetInstance().GiveRequestedResource("BackgroundTile"),new Vector2(0,0),Color.White);
            else
                spriteBatch.Draw(TextureInventory.GetInstance().GiveRequestedResource("3background2"),new Vector2(0,0),Color.White);
            CharacterInventory.GetInstance().Items.ForEach(x=>x.Draw(spriteBatch));
        }
        public void Handle(GameTime time)
        {
            CharacterInventory.GetInstance().Items.ToList().ForEach(x => x.Update(time));
        }

        #endregion
    }
}