using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoEventos
{
    class Pitcher
    {
        public Pitcher(Ball ball)
        {
            ball.BallInPlay += new EventHandler(Ball_BallInPlay);
        }

        private void Ball_BallInPlay(object sender, EventArgs e)
        {
            if(e is EventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if ((ballEventArgs.Distance < 95) && (ballEventArgs.Trajectory < 60))
                    CatchBall();
                else
                    CoverFirstBase();
            }
        }

        private void CatchBall()
        {
            Console.WriteLine("I caught the ball");
        }

        private void CoverFirstBase()
        {
            Console.WriteLine("I covered first base");
        }
    }
}
