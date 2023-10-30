using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2Q10 //Finn Marable Unit Test 2 console app for question 10 that demonstrates polymorphism.
{
    using System;

    public abstract class SoccerPlayer
    {
        public virtual void startRun() { }
    }

    public interface PassInterface
    {
        void chooseTeammate();
        void KickAccurate();
    }

    public interface ShootInterface
    {
        void pickTarget();
        void KickHard();
    }

    public class Arsenal : SoccerPlayer, PassInterface, ShootInterface
    {
        private int goalsScored;
        private int assists;

        public Arsenal(int goalsScored, int assists)
        {
            this.goalsScored = goalsScored;
            this.assists = assists;
        }

        public override void startRun() { Console.WriteLine("Arsenal player starts running."); }

        public void chooseTeammate() { Console.WriteLine("Arsenal player chooses a teammate to pass to."); }
        public void KickAccurate() { Console.WriteLine("Arsenal player passes the ball."); }
        public void pickTarget() { Console.WriteLine("Arsenal player picks a target for their shot."); }
        public void KickHard() { Console.WriteLine("Arsenal player shoots the ball."); }
    }

    public class Tottenham : SoccerPlayer, PassInterface, ShootInterface
    {
        private int goalsScored;
        private int yellowcards;

        public Tottenham(int goalsScored, int yellowcards)
        {
            this.goalsScored = goalsScored;
            this.yellowcards = yellowcards;
        }

        public override void startRun() { Console.WriteLine("Tottenham player starts running."); }

        public void chooseTeammate() { Console.WriteLine("Tottenham player chooses a teammate to pass to."); }
        public void KickAccurate() { Console.WriteLine("Tottenham player passes the ball."); }
        public void pickTarget() { Console.WriteLine("Tottenham player picks a target for their shot."); }
        public void KickHard() { Console.WriteLine("Tottenham player shoots the ball."); }
    }

    class Program
    {
        static void MyMethod(object obj)
        {
            if (obj is SoccerPlayer)
            {
                SoccerPlayer player = (SoccerPlayer)obj;
                player.startRun();

                if (obj is PassInterface)
                {
                    PassInterface passer = (PassInterface)obj;
                    passer.chooseTeammate();
                    passer.KickAccurate();
                }

                if (obj is ShootInterface)
                {
                    ShootInterface shooter = (ShootInterface)obj;
                    shooter.pickTarget();
                    shooter.KickHard();
                }
            }
            else
            {
                Console.WriteLine("Invalid object type.");
            }
        }

        static void Main(string[] args) //polymorphism
        {
            Arsenal arsenalPlayer = new Arsenal(10, 5);
            Tottenham tottenhamPlayer = new Tottenham(8, 3);

            MyMethod(arsenalPlayer);
            MyMethod(tottenhamPlayer);
        }
    }
}
