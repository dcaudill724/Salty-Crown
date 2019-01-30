using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaltyCrown {
    public class Animation {
        private Texture2D spriteSheet;
        private Texture2D currentFrame;
        private int rows;
        private int columns;
        private int[,] frameSpeeds;

        //Row and column numbers operate in the range [0, total)
        public Animation(Texture2D spriteSheet, int rows, int columns, int frameSpeed) {
            this.spriteSheet = spriteSheet;
            this.rows = rows;
            this.columns = columns;
            frameSpeeds = new int[rows, columns];
            for (int row = 0; row < rows; ++row) {
                for (int column = 0; column < columns; ++column) {
                    frameSpeeds[row, column] = frameSpeed;
                }
            }
        }

        //Input: Coordinates of frame in spritesheet from [1, num of rows] and [1, num of columns] and desired frame speed
        //Function: Alters specified frame speed
        public Animation SetSpeed(int row, int column, int frameSpeed) {
            frameSpeeds[row - 1, column - 1] = frameSpeed; //Subtract one to change from [1, total] to [0, total)
            return this;
        }

        public void Update(GameTime gameTime) {
            //Increment a counter that keeps track of how long the current frame has been displayed
            //Check if current frame needs updated
            //Check if a state has occurred that requires the current frame to stop playing no matter how long it's been and show a different one
            //Such as interrupting a jump animation with the "getting hurt" animation
        }
    }
}