using System;
using System.Windows.Forms;
using System.Drawing;

namespace Pong
{
    public class Player
    {
        const int movementspeed = 3;

        public bool isUpPressed, isDownPressed;
        bool? wasGoingLastTick;
        int numberOfTicksGoingInTheSameDirection;

        int _score;
        public int score {
            get
            {
                return _score;
            }
            set
            {
                _score = value;
                scoreLabel.Text = score.ToString();
            }
        }
        public PictureBox paddle;
        Label scoreLabel;


        public Player(PictureBox aPaddle1,Label scoreLabel)
        {
            this.paddle = aPaddle1;
            this.scoreLabel = scoreLabel;
        }

        internal void processMove()
        {
        
            bool? goingUp = null;

            if (isUpPressed)
            {
                goingUp = true;
            }
            if (isDownPressed)
            {
                if (goingUp.HasValue)
                {
                    goingUp = null;
                }
                else
                {
                    goingUp = false;
                }
            }
            if (wasGoingLastTick.HasValue)
            {
                if (!goingUp.HasValue)
                {
                    wasGoingLastTick = null;
                    numberOfTicksGoingInTheSameDirection = 0;
                }
                else if (wasGoingLastTick.Value == goingUp.Value)
                {
                    numberOfTicksGoingInTheSameDirection++;
                }
                else
                {
                    wasGoingLastTick = goingUp;
                    numberOfTicksGoingInTheSameDirection = 1;
                }
            }
            else if (goingUp.HasValue)
            {
                wasGoingLastTick = goingUp;
                numberOfTicksGoingInTheSameDirection = 1;
            }
            DoMove(goingUp);
        }

        private void DoMove(bool? goingUp)
        {
            if (goingUp.HasValue)
            {
                var speed = movementspeed * numberOfTicksGoingInTheSameDirection / 5;
                if (goingUp.Value)
                {
                    speed *= -1;
                }
                paddle.Location = new Point(paddle.Location.X,
                    Math.Max(PongWorldInfo.topOfWorld,
                    Math.Min(PongWorldInfo.bottomOfWorld - paddle.Size.Height, paddle.Location.Y + speed)
                    )
                    );
            }
        }

    }
}
