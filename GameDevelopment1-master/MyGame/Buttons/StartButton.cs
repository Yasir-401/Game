using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MyGame.Animations;
using MyGame.BaseClasses;
using MyGame.CollisionDetectors;
using MyGame.Enums;
using MyGame.Factory_Classes;
using MyGame.Hitboxes;
using MyGame.inputreader;
using MyGame.inputreaders;
using MyGame.interfaces;

namespace MyGame.Buttons
{
    /// <summary>
    ///     implements the 2 interfaces because of it is clickable and we need to see it on the screen
    /// </summary>
    public class StartButton : Button, IClickableButton
    {
        #region Fields

        private readonly IInputReader<MouseState> inputReader;
        public override event EventHandler Click;
        public event EventHandler<EventArgs> UpdateOrderChanged;

        #endregion
        #region Properties

        public bool IsClicked { get; private set; }
        public bool IsHovered { get; private set; }

        public bool Enabled => throw new NotImplementedException();

        public int UpdateOrder => throw new NotImplementedException();

        #endregion
        #region Methods
        public StartButton(Texture2D texture) : base(texture)
        {
            inputReader = new MouseReaderButtons();
            collider = new ButtonCollisionDetector();
            Animation = new Animation();
            Position = new Vector2(512, 360);
            Animation.AddFrame(new AnimationFrame(new Rectangle(0, 0, 118, 80)));
            Animation.CurrentFrame.HitBoxes = new List<HitBox>();
            Animation.CurrentFrame.HitBoxes.Add(HitBoxFactory.CreateHitbox(Position, new Tuple<int, int>(118, 80),
                HitBoxType.Normal, new Rectangle(13, 37, 19, 37)));
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, Position, Animation.CurrentFrame.SourceRectangle, color);
        }

        public void Update()
        {
            var state = inputReader.ReadInput();
            IsHovered = collider.HasCollided(Animation.CurrentFrame.HitBoxes[0].Source,
                new Rectangle(state.X, state.Y, Animation.CurrentFrame.HitBoxes[0].Source.Width,
                    Animation.CurrentFrame.HitBoxes[0].Source.Height));
            color = IsHovered ? Color.Green : Color.White;
            if (IsHovered)
                IsClicked = state.LeftButton == ButtonState.Pressed || state.RightButton == ButtonState.Pressed;
            if (IsClicked) Click?.Invoke(this, new EventArgs());
        }
        #endregion
    }
}