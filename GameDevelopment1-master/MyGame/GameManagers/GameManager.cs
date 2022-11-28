using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyGame.BaseClasses;
using MyGame.CollisonHandlers;
using MyGame.FiniteStates.GameStates;
using MyGame.GameCharacters;
using MyGame.Hitboxes;
using MyGame.interfaces;
using MyGame.Inventories;
using MyGame.TrulyGame;

namespace MyGame.GameManagers
{
 public   class GameManager:IGameManager
 {
        #region Fields
        private static GameManager _instance = new GameManager();
        private ICollisionHandler collisionHandler=new GeneralCollisionHandler();
        #endregion
        #region Methods
        private GameManager() { }
        public static GameManager Getinstance() => _instance;
        public bool Manage(Sprite sprite, HitBox hitBox1, HitBox hitBox2)
        {
           var result= collisionHandler.HandleCollision(CharacterInventory.GetInstance().Items.ToList(), sprite, hitBox1, hitBox2);
           if (result != null && result is IMoveable a)
           {
               if (sprite is Hero h||sprite is Arrow)
               {
                   IMoveable moveeableItem = null;

                   var moveableEntities = CharacterInventory.GetInstance().Items.Where(x => x .GetType()!= typeof(Hero)&& x is IMoveable).ToList();
                   if (moveableEntities.Count <1)
                   {
                       CharacterInventory.GetInstance().Items.Clear();
                        CurrentMachineInventory.GetInstance().Items[0].ChangeState(new Won((MyGameWrapper)CurrentMachineInventory.GetInstance().Items[0]));
                        if( ((MyGameWrapper)CurrentMachineInventory.GetInstance().Items[0]).Level+1<=2)
                            ((MyGameWrapper)CurrentMachineInventory.GetInstance().Items[0]).Level++;
                   }
               }
             
           }
           else
           {
               if (CurrentMachineInventory.GetInstance().Items[0].State is Running)
               {


                   var hero = CharacterInventory.GetInstance().Items.Where(x => x is Hero).SingleOrDefault();
                   if (hero == null)
                   {
                       CharacterInventory.GetInstance().Items.Clear();
                       CurrentMachineInventory.GetInstance().Items[0]
                           .ChangeState(new Lost((MyGameWrapper)CurrentMachineInventory.GetInstance().Items[0]));
                   }
                      
               }

           }
            return true;
        } 
        #endregion
    }
}
