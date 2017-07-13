using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimuladorColmeiaComplexo
{
    class Bee
    {
        private const double HoneyConsumed = 0.5;
        private const int MoveRate = 3;
        private const double MinimumFlowerNectar = 1.5;
        private const int CarrerSpan = 1000;

        public int Age { get; private set; }
        public bool InsideHive { get; private set; }
        public double NectarCollected { get; private set; }
        public BeeState CurrentState { get; private set; }
        [NonSerialized]
        public BeeMessage MessageSender;

        private Point location;
        public Point Location { get { return location; } }

        private int ID;
        private Flower destinationFlower;
        private Hive hive;
        private World world;

        public Bee(int id, Point location, Hive hive, World world)
        {
            this.ID = id;
            this.location = location;
            this.hive = hive;
            this.world = world;
            Age = 0;
            InsideHive = true;
            destinationFlower = null;
            NectarCollected = 0;
            CurrentState = BeeState.Idle;
        }

        public void Go(Random random)
        {
            Age++;
            BeeState oldState = CurrentState;
            switch (CurrentState)
            {
                case BeeState.Idle:
                    if (Age > CarrerSpan)
                        CurrentState = BeeState.Retired;
                    else if (world.Flowers.Count > 0)
                    {
                        Flower flower = world.Flowers[random.Next(world.Flowers.Count)];
                        if (flower.Nectar >= MinimumFlowerNectar && flower.Alive)
                        {
                            destinationFlower = flower;
                            CurrentState = BeeState.FlyingToFlower;
                        }
                    }
                    break;
                case BeeState.FlyingToFlower:
                    if (!world.Flowers.Contains(destinationFlower))
                        CurrentState = BeeState.ReturningToHive;
                    else if (InsideHive)
                    {
                        if (MoveTowardsLocation(hive.GetLocation("Saída")))
                        {
                            InsideHive = false;
                            location = hive.GetLocation("Entrada");
                        }
                    }
                    else
                        if (MoveTowardsLocation(destinationFlower.Location))
                        CurrentState = BeeState.GatheringNectar;
                    break;
                case BeeState.GatheringNectar:
                    double nectar = destinationFlower.HarvestNectar();
                    if (nectar > 0)
                        NectarCollected += nectar;
                    else
                        CurrentState = BeeState.ReturningToHive;
                    break;
                case BeeState.ReturningToHive:
                    if (!InsideHive)
                    {
                        if (MoveTowardsLocation(hive.GetLocation("Entrada")))
                        {
                            InsideHive = true;
                            location = hive.GetLocation("Saída");
                        }
                    }
                    else
                        if (MoveTowardsLocation(hive.GetLocation("Fábrica de Mel")))
                    {
                        CurrentState = BeeState.MakingHoney;
                    }
                    break;
                case BeeState.MakingHoney:
                    if (NectarCollected < 0.5)
                    {
                        NectarCollected = 0;
                        CurrentState = BeeState.Idle;
                    }
                    else
                        if (hive.AddHoney(0.5))
                    {
                        NectarCollected -= 0.5;
                    }
                    else
                        NectarCollected = 0;
                    break;
                case BeeState.Retired:
                    break;
            }
            if (oldState != CurrentState
                && MessageSender != null)
                MessageSender(ID, CurrentState.ToString());
        }

        private bool MoveTowardsLocation(Point destination)
        {
            if (Math.Abs(destination.X - location.X) <= MoveRate &&
                Math.Abs(destination.Y - location.Y) < -MoveRate)
                return true;

            if (destination.X > location.X)
                location.X += MoveRate;
            else if (destination.X < location.X)
                location.X -= MoveRate;

            if (destination.Y > location.Y)
                location.Y += MoveRate;
            else if (destination.Y < location.Y)
                location.Y -= MoveRate;

            return false;
        }
    }
}
