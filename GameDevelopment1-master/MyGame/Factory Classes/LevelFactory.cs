using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Microsoft.Xna.Framework;
using MyGame.BaseClasses;
using MyGame.Enums;
using MyGame.GameCharacters;
using MyGame.Hitboxes;
using MyGame.Inventories;
using MyGame.Level;
using MyGame.Menus;
using MyGame.Movers;

namespace MyGame.Factory_Classes
{
  public  class LevelFactory
  {
        #region Methods
        public static Level.Level CreateLevel(int level)
        {
            Level.Level createdLevel = new Level.Level();
            createdLevel.Elements = null;
            int[,] element = null;
            switch (level)
            {
                case 1:
                    createdLevel.Elements = new Sprite[11, 55];
                    element = new int[,]
                    {
                      {6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6},
                      {1,1,1,1,1,1,1,2,6,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1},
                      {6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,5,6,6,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6},
                      {1,1,1,1,1,1,1,1,1,3,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1,1},
                      {6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,6,6,1,4,1,1,1,1,6,6,6,6,6,6,6,6,6,6,6,6,6},
                      {1,1,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1},
                      {6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0},
                      {1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1},
                      {0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0},
                      {1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1},
                      {0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0},
                    };


                    break;
                case 2:
                    createdLevel.Elements = new Sprite[22, 50];
                    element = new int[,]
                    {
                      {6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6},
                      {1,1,1,1,1,1,1,2,6,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1,1,3,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1},
                      {6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,5,6,6,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6},
                      {1,1,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1,1},
                      {6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,6,6,1,4,1,1,1,1,6,6,6,6,6,6,6,6,6,6,6,6,6},
                      {1,1,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1},
                      {6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,6,6,6},
                      {1,1,1,1,1,1,1,1,1,2,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1,3,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1},
                      {6,6,6,6,6,6,6,6,6,6,1,4,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,6,6,6},
                      {1,1,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1},
                      {6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,6,6,6},
                      {6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6,6},
                      {1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1},
                      {6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6},
                      {1,1,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1,1},
                      {6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,6,6,6},
                      {1,1,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1},
                      {6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,6,6,6},
                      {1,1,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1},
                      {6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,6,6,6},
                      {1,1,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1},
                      {6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,6,6,6,6,6,6,6,6,6,6,6,6,6}
                    };
                    break;
            }
            for (int i = 0; i < element.GetLength(0); i++)
            {
                for (int j = 0; j < element.GetLength(1); j++)
                {
                    switch (element[i, j])
                    {
                        case 1:
                            createdLevel.Elements[i, j] = new Tile(TextureInventory.GetInstance()
                                .GiveRequestedResource("tileset"), new Vector2(j * 30, i * 149));
                            break;
                        case 2:
                            createdLevel.Elements[i, j] = new SmallNinja(TextureInventory.GetInstance()
                                .GiveRequestedResource("ninja2n"), (int)createdLevel.Elements[i, j - 1].Position.X, (int)createdLevel.Elements[i, j - 1].Position.Y, new EnemyMover());
                            break;
                        case 3:
                            createdLevel.Elements[i, j] = new LongNinja(TextureInventory.GetInstance()
                                .GiveRequestedResource("ninja1"), (int)createdLevel.Elements[i, j - 1].Position.X, (int)createdLevel.Elements[i, j - 1].Position.Y, new EnemyMover());
                            break;
                        case 4:
                            createdLevel.Elements[i, j] = new SpikyTrap(TextureInventory.GetInstance()
                                .GiveRequestedResource("spikeyTrap"), (int)createdLevel.Elements[i, j - 1].Position.X, (int)createdLevel.Elements[i, j - 1].Position.Y);
                            break;
                        case 5:
                            createdLevel.Elements[i, j] = Hero.GetInstance(TextureInventory.GetInstance()
                                .GiveRequestedResource("archer"), (int)createdLevel.Elements[i, j - 1].Position.X, (int)createdLevel.Elements[i, j - 1].Position.Y, new CharacterMover());
                            break;
                        case 6:
                            SpaceInventory.GetInstance().Items.Add(HitBoxFactory.CreateHitbox(new Vector2(j * 50, i * 149), new Tuple<int, int>(34, 33), HitBoxType.Space, new Rectangle(0, 0, 0, 0)));
                            break;
                    }
                    if (createdLevel.Elements[i, j] != null)
                        CharacterInventory.GetInstance().Items.Add(createdLevel.Elements[i, j]);
                }
            }

            return createdLevel;
        } 
        #endregion
    }
}
