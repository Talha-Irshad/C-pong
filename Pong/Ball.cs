using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Pong
{
    public class Ball
    {
        private PictureBox ball;
        Random rand=new Random();
        Player leftSidePlayer, rightSidePlayer;
        int xSpeed, ySpeed;
        public Ball(PictureBox aBall, Player leftSidePlayer,Player rightSidePlayer)
        {
            this.ball = aBall;
            this.leftSidePlayer = leftSidePlayer;
            this.rightSidePlayer = rightSidePlayer;
            xSpeed = 1;
            ySpeed = 2;
            ResetBall();
        }

        internal void processMove()
        {
            DoMove();
            var bottom = PongWorldInfo.bottomOfWorld - ball.Height;
            if (ball.Location.Y >= bottom || ball.Location.Y <= PongWorldInfo.topOfWorld)
            {
                ySpeed *= -1;
            }
            if (ball.Location.X <= PongWorldInfo.leftOfWorld)
            {
                Score(leftSidePlayer);
            }
            else if (ball.Location.X >= PongWorldInfo.rightOfWorld - ball.Width)
            {
                Score(rightSidePlayer);
            }

            if (leftSidePlayer.paddle.Bounds.IntersectsWith(ball.Bounds)
                || (rightSidePlayer.paddle.Bounds.IntersectsWith(ball.Bounds)))
            {
                xSpeed *= -2;
                while (leftSidePlayer.paddle.Bounds.IntersectsWith(ball.Bounds)
                        || (rightSidePlayer.paddle.Bounds.IntersectsWith(ball.Bounds)))
                {
                    DoMove();

                }
            }

        }

        private int DoMove()
        {
            var bottom = PongWorldInfo.bottomOfWorld - ball.Height;
            ball.Location = new Point(ball.Location.X + xSpeed, Math.Max(PongWorldInfo.topOfWorld,
                Math.Min(bottom, ball.Location.Y + ySpeed)));
            return bottom;
        }

        private void Score(Player winningPlayer)
        {
            winningPlayer.score++;
            ResetBall();

        }

        private void ResetBall()
        {
            ball.Location = new Point((PongWorldInfo.leftOfWorld + PongWorldInfo.rightOfWorld) / 2, (PongWorldInfo.topOfWorld + PongWorldInfo.bottomOfWorld) / 2);
            do
            {
                xSpeed = rand.Next(-3, 3);
                ySpeed = rand.Next(-3, 3);
            } while (Math.Abs(xSpeed) + Math.Abs(ySpeed) <= 3);
        }
    }
}
