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
            frameSpeeds[row - 1, column - 1] = frameSpeed;
            return this;
        }
    }
}