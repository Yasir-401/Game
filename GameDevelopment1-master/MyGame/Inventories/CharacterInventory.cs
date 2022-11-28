using System.Collections.Generic;
using Microsoft.Xna.Framework;
using MyGame.BaseClasses;
using MyGame.interfaces;

namespace MyGame.Inventories
{
    public class CharacterInventory : IInventory<Sprite>
    {
        #region Fields

        private static readonly CharacterInventory _instance = new CharacterInventory();

        #endregion
        #region Properties

        public List<Sprite> Items { get; set; }

        #endregion
        #region Methods
        private CharacterInventory()
        {
            Items = new List<Sprite>();
        }
        public static CharacterInventory GetInstance()
        {
            return _instance;
        }
        public List<Rectangle> GetHitboxesOfCharacters()
        {
            var temporaryList = new List<Rectangle>();
            for (var i = 0; i < Items.Count; i++)
                foreach (var hitbox in ((BaseCharacterState)Items[i].State).Animation.CurrentFrame.HitBoxes)
                    temporaryList.Add(hitbox.Source);
            return temporaryList;
        }
        #endregion
    }
}