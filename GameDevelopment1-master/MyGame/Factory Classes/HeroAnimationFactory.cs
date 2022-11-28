using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using MyGame.Animations;
using MyGame.Enums;
using MyGame.Hitboxes;
using MyGame.interfaces;

namespace MyGame.Factory_Classes
{
    public class HeroAnimationFactory : IAnimationFactory
    {
        public Animation CreateAnimation(AnimationType type, Vector2 position)
        {
            var createdAnimation = new Animation();
            switch (type)
            {
                case AnimationType.JumpRight:
                    #region JumpRight
                    createdAnimation.CurrentFrame = new AnimationFrame(new Rectangle(0, 270, 125, 135));
                    createdAnimation.CurrentFrame.HitBoxes = new List<HitBox>()
                    {
                        HitBoxFactory.CreateHitbox(position,new Tuple<int, int>(125,135),HitBoxType.Normal,new Rectangle(15,5,25,21)),
                        HitBoxFactory.CreateHitbox(position,new Tuple<int, int>(125,135),HitBoxType.Top,new Rectangle(42,5,70,133)),
                        HitBoxFactory.CreateHitbox(position,new Tuple<int, int>(125,135),HitBoxType.Bottom,new Rectangle(18,120,83,133)),
                        HitBoxFactory.CreateHitbox(position,new Tuple<int, int>(125,135),HitBoxType.Left,new Rectangle(32,20,123,40)),
                        HitBoxFactory.CreateHitbox(position,new Tuple<int, int>(125,135),HitBoxType.Left,new Rectangle(25,80,123,115)),
                        HitBoxFactory.CreateHitbox(position,new Tuple<int, int>(125,135),HitBoxType.Left,new Rectangle(15,100,123,115)),
                        HitBoxFactory.CreateHitbox(position,new Tuple<int, int>(125,135),HitBoxType.Right,new Rectangle(76,20,2,100)),
                    };
                    createdAnimation.AddFrame(createdAnimation.CurrentFrame);
                    break; 
                #endregion
                case AnimationType.JumpLeft:
                    #region JumpLeft
                    createdAnimation.CurrentFrame = new AnimationFrame(new Rectangle(0, 270, 125, 135));
                    createdAnimation.CurrentFrame.HitBoxes = new List<HitBox>()
                    {
                        HitBoxFactory.CreateHitbox(position,new Tuple<int, int>(125,135),HitBoxType.Normal,new Rectangle(15,5,30,21)),
                        HitBoxFactory.CreateHitbox(position,new Tuple<int, int>(125,135),HitBoxType.Top,new Rectangle(22,5,61,133)),
                        HitBoxFactory.CreateHitbox(position,new Tuple<int, int>(125,135),HitBoxType.Bottom,new Rectangle(68,120,87,133)),
                        HitBoxFactory.CreateHitbox(position,new Tuple<int, int>(125,135),HitBoxType.Right,new Rectangle(93,20,123,40)),
                        HitBoxFactory.CreateHitbox(position,new Tuple<int, int>(125,135),HitBoxType.Right,new Rectangle(100,80,123,115)),
                        HitBoxFactory.CreateHitbox(position,new Tuple<int, int>(125,135),HitBoxType.Right,new Rectangle(108,100,123,115)),
                        HitBoxFactory.CreateHitbox(position,new Tuple<int, int>(125,135),HitBoxType.Left,new Rectangle(49,20,123,35)),
                    };
                    createdAnimation.AddFrame(createdAnimation.CurrentFrame);
                    break; 
                #endregion
                case AnimationType.IdleRight:
                    #region IdleRight

                    createdAnimation.CurrentFrame = new AnimationFrame(new Rectangle(0, 135, 125, 135));
                    createdAnimation.CurrentFrame.HitBoxes = new List<HitBox>
                    {
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(125, 135), HitBoxType.Normal,
                            new Rectangle(19, 7, 30, 14)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(125, 135), HitBoxType.Top,
                            new Rectangle(30, 7, 85, 130)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(125, 135), HitBoxType.Left,
                            new Rectangle(30, 20, 120, 75)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(125, 135), HitBoxType.Left,
                            new Rectangle(18, 80, 120, 132)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(125, 135), HitBoxType.Top,
                            new Rectangle(18, 80, 120, 132)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(125, 135), HitBoxType.Top,
                            new Rectangle(27, 80, 120, 95)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(125, 135), HitBoxType.Right,
                            new Rectangle(60, 80, 120, 95)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(125, 135), HitBoxType.Right,
                            new Rectangle(92, 53, 105, 132)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(125, 135), HitBoxType.Top,
                            new Rectangle(92, 53, 105, 132)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(125, 135), HitBoxType.Right,
                            new Rectangle(63, 20, 120, 75)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(125, 135), HitBoxType.Bottom,
                            new Rectangle(29, 120, 83, 130))
                    };
                    createdAnimation.AddFrame(createdAnimation.CurrentFrame);

                    #endregion
                    break;
                case AnimationType.IdleLeft:
                    #region IdleLeft

                    createdAnimation.CurrentFrame = new AnimationFrame(new Rectangle(0, 135, 125, 135));
                    createdAnimation.CurrentFrame.HitBoxes = new List<HitBox>
                    {
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(125, 135), HitBoxType.Normal,
                            new Rectangle(14, 7, 30, 14)),

                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(125, 135), HitBoxType.Top,
                            new Rectangle(52, 7, 80, 130)),

                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(125, 135), HitBoxType.Right,
                            new Rectangle(89, 20, 120, 75)),

                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(125, 135), HitBoxType.Right,
                            new Rectangle(99, 80, 120, 132)),

                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(125, 135), HitBoxType.Top,
                            new Rectangle(15, 55, 75, 130)),

                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(125, 135), HitBoxType.Left,
                            new Rectangle(60, 80, 120, 95)),

                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(125, 135), HitBoxType.Right,
                            new Rectangle(90, 53, 122, 110)),

                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(125, 135), HitBoxType.Top,
                            new Rectangle(14, 53, 105, 132)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(125, 135), HitBoxType.Left,
                            new Rectangle(14, 53, 105, 132)),

                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(125, 135), HitBoxType.Left,
                            new Rectangle(63, 20, 120, 70)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(125, 135), HitBoxType.Bottom,
                            new Rectangle(55, 120, 83, 130))
                    };
                    createdAnimation.AddFrame(createdAnimation.CurrentFrame);

                    #endregion
                    break;
                case AnimationType.FallingRight:
                case AnimationType.WalkRight:
                    #region WalkRight

                    createdAnimation.CurrentFrame = new AnimationFrame(new Rectangle(0, 0, 120, 135));
                    createdAnimation.CurrentFrame.HitBoxes = new List<HitBox>
                    {
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Normal,
                            new Rectangle(22, 8, 36, 20)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Top,
                            new Rectangle(50, 4, 80, 130)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Bottom,
                            new Rectangle(20, 119, 70, 133)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Left,
                            new Rectangle(23, 20, 119, 35)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Right,
                            new Rectangle(102, 20, 119, 35))
                    };
                    createdAnimation.AddFrame(createdAnimation.CurrentFrame);
                    createdAnimation.CurrentFrame = new AnimationFrame(new Rectangle(125, 0, 120, 135));
                    createdAnimation.CurrentFrame.HitBoxes = new List<HitBox>
                    {
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Normal,
                            new Rectangle(18, 8, 20, 25)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Top,
                            new Rectangle(50, 3, 80, 130)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Bottom,
                            new Rectangle(50, 121, 95, 127)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Left,
                            new Rectangle(25, 20, 119, 35)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Right,
                            new Rectangle(80, 20, 119, 35))
                    };
                    createdAnimation.AddFrame(createdAnimation.CurrentFrame);
                    createdAnimation.CurrentFrame = new AnimationFrame(new Rectangle(250, 0, 125, 135));
                    createdAnimation.CurrentFrame.HitBoxes = new List<HitBox>
                    {
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Normal,
                            new Rectangle(18, 8, 20, 22)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Top,
                            new Rectangle(50, 4, 80, 130)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Bottom,
                            new Rectangle(37, 119, 95, 133)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Left,
                            new Rectangle(45, 20, 119, 35)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Right,
                            new Rectangle(87, 20, 119, 35))
                    };
                    createdAnimation.AddFrame(createdAnimation.CurrentFrame);
                    createdAnimation.CurrentFrame = new AnimationFrame(new Rectangle(375, 0, 125, 135));
                    createdAnimation.CurrentFrame.HitBoxes = new List<HitBox>
                    {
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Normal,
                            new Rectangle(18, 8, 20, 18)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Top,
                            new Rectangle(42, 4, 77, 130)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Bottom,
                            new Rectangle(35, 119, 102, 125)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Left,
                            new Rectangle(20, 20, 119, 35)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Right,
                            new Rectangle(117, 20, 119, 35))
                    };
                    createdAnimation.AddFrame(createdAnimation.CurrentFrame);
                    createdAnimation.CurrentFrame = new AnimationFrame(new Rectangle(500, 0, 125, 135));
                    createdAnimation.CurrentFrame.HitBoxes = new List<HitBox>
                    {
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Normal,
                            new Rectangle(20, 12, 30, 22)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Top,
                            new Rectangle(58, 8, 23, 5)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Bottom,
                            new Rectangle(26, 123, 85, 130)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Left,
                            new Rectangle(22, 25, 115, 57)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Right,
                            new Rectangle(80, 22, 117, 35))
                    };
                    createdAnimation.AddFrame(createdAnimation.CurrentFrame); //
                    createdAnimation.CurrentFrame = new AnimationFrame(new Rectangle(625, 0, 125, 135));
                    createdAnimation.CurrentFrame.HitBoxes = new List<HitBox>
                    {
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Normal,
                            new Rectangle(25, 8, 23, 20)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Top,
                            new Rectangle(55, 6, 95, 133)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Bottom,
                            new Rectangle(50, 121, 103, 133)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Left,
                            new Rectangle(23, 20, 119, 42)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Right,
                            new Rectangle(80, 20, 119, 35))
                    };
                    break;
                #endregion
                case AnimationType.FallingLeft:
                case AnimationType.WalkLeft:
                    #region WalkLeft

                    createdAnimation.CurrentFrame = new AnimationFrame(new Rectangle(0, 0, 120, 135));
                    createdAnimation.CurrentFrame.HitBoxes = new List<HitBox>
                    {
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Normal,
                            new Rectangle(18, 8, 36, 20)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Top,
                            new Rectangle(31, 4, 77, 130)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Bottom,
                            new Rectangle(20, 119, 70, 133)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Right,
                            new Rectangle(72, 15, 119, 85)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Right,
                            new Rectangle(95, 50, 119, 75)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Right,
                            new Rectangle(30, 20, 119, 35))
                    };
                    createdAnimation.AddFrame(createdAnimation.CurrentFrame);
                    createdAnimation.CurrentFrame = new AnimationFrame(new Rectangle(125, 0, 120, 135));
                    createdAnimation.CurrentFrame.HitBoxes = new List<HitBox>
                    {
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Normal,
                            new Rectangle(18, 8, 33, 22)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Top,
                            new Rectangle(30, 3, 80, 130)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Bottom,
                            new Rectangle(42, 120, 70, 127)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Right,
                            new Rectangle(92, 20, 119, 35)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Left,
                            new Rectangle(30, 20, 119, 35))
                    };
                    createdAnimation.AddFrame(createdAnimation.CurrentFrame);
                    createdAnimation.CurrentFrame = new AnimationFrame(new Rectangle(250, 0, 125, 135));
                    createdAnimation.CurrentFrame.HitBoxes = new List<HitBox>
                    {
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Normal,
                            new Rectangle(18, 8, 35, 22)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Top,
                            new Rectangle(35, 4, 80, 130)),

                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Bottom,
                            new Rectangle(67, 119, 100, 133)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Right,
                            new Rectangle(85, 20, 119, 35)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Left,
                            new Rectangle(45, 20, 119, 35))
                    };
                    createdAnimation.AddFrame(createdAnimation.CurrentFrame);
                    createdAnimation.CurrentFrame = new AnimationFrame(new Rectangle(375, 0, 125, 135));
                    createdAnimation.CurrentFrame.HitBoxes = new List<HitBox>
                    {
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Normal,
                            new Rectangle(18, 8, 45, 22)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Top,
                            new Rectangle(42, 4, 81, 130)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Bottom,
                            new Rectangle(70, 119, 102, 133)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Right,
                            new Rectangle(100, 20, 119, 35)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Left,
                            new Rectangle(100, 20, 119, 35))
                    };
                    createdAnimation.AddFrame(createdAnimation.CurrentFrame); 
                    createdAnimation.CurrentFrame =
                        new AnimationFrame(new Rectangle(500, 0, 125, 135));
                    createdAnimation.CurrentFrame.HitBoxes = new List<HitBox>
                    {
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Normal,
                            new Rectangle(20, 12, 35, 22)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Top,
                            new Rectangle(46, 8, 78, 130)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Bottom,
                            new Rectangle(60, 120, 85, 130)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Left,
                            new Rectangle(36, 25, 115, 57)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Right,
                            new Rectangle(100, 22, 115, 35))
                    };
                    createdAnimation.AddFrame(createdAnimation.CurrentFrame);
                    createdAnimation.CurrentFrame = new AnimationFrame(new Rectangle(625, 0, 125, 135));
                    createdAnimation.CurrentFrame.HitBoxes = new List<HitBox>
                    {
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Normal,
                            new Rectangle(25, 8, 23, 20)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Top,
                            new Rectangle(55, 6, 95, 133)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Bottom,
                            new Rectangle(50, 121, 103, 133)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Left,
                            new Rectangle(23, 20, 119, 42)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Right,
                            new Rectangle(118, 20, 119, 35))
                    };
                    break;

                #endregion
                case AnimationType.AttackRight:
                    #region AttackRight

                    createdAnimation.CurrentFrame = new AnimationFrame(new Rectangle(125, 135, 125, 135));
                    createdAnimation.CurrentFrame.HitBoxes = new List<HitBox>
                    {
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Normal,
                            new Rectangle(22, 13, 33, 23)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Top,
                            new Rectangle(40, 11, 95, 133)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Bottom,
                            new Rectangle(30, 125, 70, 133)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Left,
                            new Rectangle(25, 18, 119, 35)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Right,
                            new Rectangle(70, 20, 119, 35))
                    };
                    createdAnimation.AddFrame(createdAnimation.CurrentFrame);
                    createdAnimation.CurrentFrame = new AnimationFrame(new Rectangle(250, 135, 125, 135));
                    createdAnimation.CurrentFrame.HitBoxes = new List<HitBox>
                    {
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Normal,
                            new Rectangle(24, 13, 37, 23)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Top,
                            new Rectangle(32, 11, 85, 133)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Bottom,
                            new Rectangle(27, 125, 70, 133)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Left,
                            new Rectangle(24, 18, 119, 35)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Right,
                            new Rectangle(65, 20, 119, 35))
                    };
                    createdAnimation.AddFrame(createdAnimation.CurrentFrame);
                    createdAnimation.CurrentFrame = new AnimationFrame(new Rectangle(375, 135, 125, 135));
                    createdAnimation.CurrentFrame.HitBoxes = new List<HitBox>
                    {
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Normal,
                            new Rectangle(24, 17, 37, 23)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Top,
                            new Rectangle(32, 15, 85, 133)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Bottom,
                            new Rectangle(27, 125, 70, 133)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Left,
                            new Rectangle(25, 18, 119, 35)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Right,
                            new Rectangle(60, 20, 119, 35))
                    };
                    createdAnimation.AddFrame(createdAnimation.CurrentFrame);
                    createdAnimation.CurrentFrame = new AnimationFrame(new Rectangle(625, 135, 155, 135));
                    createdAnimation.CurrentFrame.HitBoxes = new List<HitBox>
                    {
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(155, 135), HitBoxType.Normal,
                            new Rectangle(16, 12, 75, 25)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(155, 135), HitBoxType.Top,
                            new Rectangle(18, 11, 95, 133)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(155, 135), HitBoxType.Bottom,
                            new Rectangle(105, 125, 70, 133)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(155, 135), HitBoxType.Left,
                            new Rectangle(14, 18, 150, 35)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(155, 135), HitBoxType.Right,
                            new Rectangle(60, 20, 145, 35))
                    };
                    createdAnimation.AddFrame(createdAnimation.CurrentFrame);
                    break;

                #endregion
                case AnimationType.AttackLeft:
                    #region AttackLeft

                    createdAnimation.CurrentFrame = new AnimationFrame(new Rectangle(125, 135, 125, 135));
                    createdAnimation.CurrentFrame.HitBoxes = new List<HitBox>
                    {
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Normal,
                            new Rectangle(22, 13, 41, 23)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Top,
                            new Rectangle(55, 11, 85, 133)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Bottom,
                            new Rectangle(53, 125, 80, 133)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Left,
                            new Rectangle(60, 18, 119, 35)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Right,
                            new Rectangle(90, 20, 119, 35))
                    };
                    createdAnimation.AddFrame(createdAnimation.CurrentFrame);
                    createdAnimation.CurrentFrame = new AnimationFrame(new Rectangle(250, 135, 125, 135));
                    createdAnimation.CurrentFrame.HitBoxes = new List<HitBox>
                    {
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Normal,
                            new Rectangle(24, 13, 41, 23)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Top,
                            new Rectangle(50, 11, 75, 112)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Bottom,
                            new Rectangle(57, 125, 80, 133)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Right,
                            new Rectangle(98, 18, 119, 35)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Left,
                            new Rectangle(68, 20, 119, 35))
                    };
                    createdAnimation.AddFrame(createdAnimation.CurrentFrame);


                    createdAnimation.CurrentFrame = new AnimationFrame(new Rectangle(375, 135, 125, 135));
                    createdAnimation.CurrentFrame.HitBoxes = new List<HitBox>
                    {
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Normal,
                            new Rectangle(24, 17, 42, 25)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Top,
                            new Rectangle(60, 15, 85, 133)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Bottom,
                            new Rectangle(58, 125, 84, 133)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Left,
                            new Rectangle(70, 18, 119, 35)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(120, 135), HitBoxType.Right,
                            new Rectangle(95, 20, 119, 35))
                    };
                    createdAnimation.AddFrame(createdAnimation.CurrentFrame); //
                    createdAnimation.CurrentFrame = new AnimationFrame(new Rectangle(625, 135, 155, 135));
                    createdAnimation.CurrentFrame.HitBoxes = new List<HitBox>
                    {
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(155, 135), HitBoxType.Normal,
                            new Rectangle(70, 12, 79, 20)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(155, 135), HitBoxType.Top,
                            new Rectangle(75, 11, 95, 133)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(155, 135), HitBoxType.Bottom,
                            new Rectangle(100, 125, 115, 133)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(155, 135), HitBoxType.Left,
                            new Rectangle(100, 18, 119, 35)),
                        HitBoxFactory.CreateHitbox(position, new Tuple<int, int>(155, 135), HitBoxType.Right,
                            new Rectangle(135, 20, 119, 35))
                    };
                    createdAnimation.AddFrame(createdAnimation.CurrentFrame);
                    break;

                #endregion
            }

            return createdAnimation;
        }
    }
}