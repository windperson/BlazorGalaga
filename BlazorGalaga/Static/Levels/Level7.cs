﻿using System;
using System.Collections.Generic;
using System.Drawing;
using BlazorGalaga.Interfaces;
using BlazorGalaga.Models;
using BlazorGalaga.Models.Paths.Intros;
using BlazorGalaga.Models.Paths.Challenges;
using BlazorGalaga.Services;

namespace BlazorGalaga.Static.Levels
{
    public static class Level7
    {
        public static void InitIntro(AnimationService animationService, int introspeedincrease)
        {
            //two groups of four from top
            for (int i = 0; i < 5; i++)
                animationService.Animatables.Add(BugFactory.CreateAnimatable_BugIntro(i, i * Constants.BugIntroSpacing, new Intro1(), Sprite.SpriteTypes.BlueBug,1, introspeedincrease, Utils.Rnd(1, 10) % 2 == 0, i==4));
            for (int i = 0; i < 5; i++)
                animationService.Animatables.Add(BugFactory.CreateAnimatable_BugIntro(i + 4, i * Constants.BugIntroSpacing, new Intro2(), Sprite.SpriteTypes.RedBug,1, introspeedincrease, Utils.Rnd(1, 10) % 2 == 0, i==4));

            //two groups of eight from bottom
            for (int i = 0; i < 8; i++)
                animationService.Animatables.Add(BugFactory.CreateAnimatable_BugIntro(i + 8, i * Constants.BugIntroSpacing, new Intro3(), i % 2 != 0 ? Sprite.SpriteTypes.GreenBug : Sprite.SpriteTypes.RedBug, 2, introspeedincrease, Utils.Rnd(1, 10) % 2 == 0));
            for (int i = 0; i < 8; i++)
                animationService.Animatables.Add(BugFactory.CreateAnimatable_BugIntro(i + 16, i * Constants.BugIntroSpacing, new Intro4(), Sprite.SpriteTypes.RedBug, 3, introspeedincrease, Utils.Rnd(1, 10) % 2 == 0));

            //two groups of eight from top
            for (int i = 0; i < 9; i++)
                animationService.Animatables.Add(BugFactory.CreateAnimatable_BugIntro(i + 24, i * Constants.BugIntroSpacing, new Intro1(), Sprite.SpriteTypes.BlueBug, 4, introspeedincrease, Utils.Rnd(1, 10) % 2 == 0, i==8));
            for (int i = 0; i < 9; i++)
                animationService.Animatables.Add(BugFactory.CreateAnimatable_BugIntro(i + 32, i * Constants.BugIntroSpacing, new Intro2(), Sprite.SpriteTypes.BlueBug, 5, introspeedincrease, Utils.Rnd(1, 10) % 2 == 0, i==8));
        }
    }
}
