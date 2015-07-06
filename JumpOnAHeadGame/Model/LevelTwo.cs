﻿using JumpOnAHeadGame.Model.Players;
using JumpOnAHeadGame.View;
using JumpOnAHeadGame.View.UI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JumpOnAHeadGame.Model
{
    public class LevelTwo : Level
    {
        public override void Initialize()
        {
            Player1 = new Player(Keys.Left, Keys.Right, Keys.Up, Keys.Down, new Vector2(50, 800), AnimationFactory.CreatePlayerAnimation(Color.Aquamarine), true);
            Player2 = new Player(Keys.A, Keys.D, Keys.W, Keys.S, new Vector2(1150, 800), AnimationFactory.CreatePlayerAnimation(Color.Peru), false); this.ListOfPlayers = new List<Player> { Player1, Player2 };

            this.ListOfSnowballs = new List<Snowball>();

            this.ListOfPilesOfSnow = new List<PileOfSnow>
            {
                new PileOfSnow(new Vector2(650, 880), UIInitializer.CreateSprite("PileOfSnow")), 
                new PileOfSnow(new Vector2(510, 880), UIInitializer.CreateSprite("PileOfSnow")), 
                new PileOfSnow(new Vector2(-20, 230), UIInitializer.CreateSprite("PileOfSnow")), 
                new PileOfSnow(new Vector2(1185, 230), UIInitializer.CreateSprite("PileOfSnow")), 
            };

            this.ListOfBlocks = new List<Block> 
            { 
                // TOP BLOCK LINE
                new Block(new Vector2(0, 70), UIInitializer.CreateSprite("IceCube")), 
                new Block(new Vector2(40, 70), UIInitializer.CreateSprite("IceCube")), 
                new Block(new Vector2(80, 70), UIInitializer.CreateSprite("IceCube")), 
                new Block(new Vector2(120, 70), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(160, 70), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(200, 70), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(240, 70), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(280, 70), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(320, 70), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(360, 70), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(400, 70), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(440, 70), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(480, 70), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(520, 70), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(560, 70), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(600, 70), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(640, 70), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(680, 70), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(720, 70), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(760, 70), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(800, 70), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(840, 70), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(880, 70), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(920, 70), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(960, 70), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(1000, 70), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(1040, 70), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(1080, 70), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(1120, 70), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(1160, 70), UIInitializer.CreateSprite("IceCube")),        
                new Block(new Vector2(1200, 70), UIInitializer.CreateSprite("IceCube")),        
                new Block(new Vector2(1240, 70), UIInitializer.CreateSprite("IceCube")),        
                //// BOT BLOCK LINE
                new Block(new Vector2(0, 950), UIInitializer.CreateSprite("IceBlock")), 
                new Block(new Vector2(80, 950), UIInitializer.CreateSprite("IceBlock")), 
                new Block(new Vector2(160, 950), UIInitializer.CreateSprite("IceBlock")), 
                new Block(new Vector2(240, 950), UIInitializer.CreateSprite("IceBlock")),
                new Block(new Vector2(320, 950), UIInitializer.CreateSprite("IceBlock")),
                new Block(new Vector2(400, 950), UIInitializer.CreateSprite("IceBlock")),
                new Block(new Vector2(480, 950), UIInitializer.CreateSprite("IceBlock")),
                new Block(new Vector2(560, 950), UIInitializer.CreateSprite("IceBlock")),
                new Block(new Vector2(640, 950), UIInitializer.CreateSprite("IceBlock")),
                new Block(new Vector2(720, 950), UIInitializer.CreateSprite("IceBlock")),
                new Block(new Vector2(800, 950), UIInitializer.CreateSprite("IceBlock")),
                new Block(new Vector2(880, 950), UIInitializer.CreateSprite("IceBlock")),
                new Block(new Vector2(960, 950), UIInitializer.CreateSprite("IceBlock")),
                new Block(new Vector2(1040, 950), UIInitializer.CreateSprite("IceBlock")),
                new Block(new Vector2(1120, 950), UIInitializer.CreateSprite("IceBlock")),
                new Block(new Vector2(1200, 950), UIInitializer.CreateSprite("IceBlock")),
                //// Left Cube line
                //new Block(new Vector2(40, 750), UIInitializer.CreateSprite("IceBlock")),   
                new Block(new Vector2(0, 750), UIInitializer.CreateSprite("IceBlock")),   
                new Block(new Vector2(0, 800), UIInitializer.CreateSprite("IceCube")),   
                new Block(new Vector2(0, 850), UIInitializer.CreateSprite("IceCube")),   
                new Block(new Vector2(0, 900), UIInitializer.CreateSprite("IceCube")),
                //// Right Cube Line
                new Block(new Vector2(1200, 750), UIInitializer.CreateSprite("IceBlock")),
                new Block(new Vector2(1240, 800), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(1240, 850), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(1240, 900), UIInitializer.CreateSprite("IceCube")),
                //// Center Down Cube Line
                new Block(new Vector2(600, 800), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(600, 850), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(600, 900), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(640, 800), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(640, 850), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(640, 900), UIInitializer.CreateSprite("IceCube")),
                new Block(new Vector2(520, 750), UIInitializer.CreateSprite("IceBlock")),
                new Block(new Vector2(600, 750), UIInitializer.CreateSprite("IceBlock")),
                new Block(new Vector2(680, 750), UIInitializer.CreateSprite("IceBlock")),
                new Block(new Vector2(250, 580), UIInitializer.CreateSprite("IceBlock")),
                new Block(new Vector2(200, 620), UIInitializer.CreateSprite("IceBlock")),
                new Block(new Vector2(950, 580), UIInitializer.CreateSprite("IceBlock")),
                new Block(new Vector2(1000, 620), UIInitializer.CreateSprite("IceBlock")),
                //// Central Upper Blocks
                new Block(new Vector2(560, 385), UIInitializer.CreateSprite("IceBlock")),
                new Block(new Vector2(640, 385), UIInitializer.CreateSprite("IceBlock")),
                new Block(new Vector2(520, 430), UIInitializer.CreateSprite("IceBlock")),
                new Block(new Vector2(720, 430), UIInitializer.CreateSprite("IceBlock")),
                //// Left blocks
                new Block(new Vector2(0, 300), UIInitializer.CreateSprite("IceBlock")),
                new Block(new Vector2(80, 350), UIInitializer.CreateSprite("IceBlock")),
                //// Right blocks
                new Block(new Vector2(1120, 350), UIInitializer.CreateSprite("IceBlock")),
                new Block(new Vector2(1200, 300), UIInitializer.CreateSprite("IceBlock")),
            };
        }
    }
}
