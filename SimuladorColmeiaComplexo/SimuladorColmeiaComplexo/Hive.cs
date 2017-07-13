using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorColmeiaComplexo
{
    class Hive
    {
        public double Honey { get; private set; }
        private Dictionary<string, Point> locations;
        private int beeCount = 0;
        private const int BeeInitials = 6;
        private const double AmountHoneyInitialize = 3.2;
        private const double MaxAmountHoneyStorage = 15.0;
        private const double ProportionNectarUnitProducingHoney = .25;
        private const double MinHoneyRequired = 4.0;
        private const int MaxNumberBee = 8;
        private World world;

        [NonSerialized]
        public BeeMessage MessageSender;
        public void InitializeLocations()
        {
            locations = new Dictionary<string, Point>();
            locations.Add("Entrada", new Point(600, 100));
            locations.Add("Berçário", new Point(95, 174));
            locations.Add("Fábrica de Mel", new Point(157, 98));
            locations.Add("Saída", new Point(194, 213));
        }

        public Point GetLocation(string location)
        {
            if (locations.Keys.Contains(location))
                return locations[location];
            else
                throw new ArgumentException(string.Format("Localização desconhecida: {0}", location));
        }

        public Hive(World world, BeeMessage MessageSender)
        {
            this.MessageSender = MessageSender;
            this.world = world;
            Honey = AmountHoneyInitialize;
            InitializeLocations();
            Random random = new Random();
            for (int i = 0; i < BeeInitials; i++)
            {
                AddBee(random);
            }
        }

        public bool AddHoney(double nectar)
        {
            double honeyToAdd = nectar * ProportionNectarUnitProducingHoney;
            if (honeyToAdd + Honey > MaxAmountHoneyStorage)
                return false;
            Honey += honeyToAdd;
            return true;
        }
        public bool ConsumeHoney(double amount)
        {
            if (amount > Honey)
                return false;
            else
            {
                Honey -= amount;
                return true;
            }
        }
        private void AddBee(Random random)
        {
            beeCount++;
            int r1 = random.Next(100) - 50;
            int r2 = random.Next(100) - 50;
            Point startPoint = new Point(locations["Berçário"].X + r1,
                                         locations["Berçário"].Y + r2);
            Bee newBee = new Bee(beeCount, startPoint, this, world);
            newBee.MessageSender += this.MessageSender;
            world.Bees.Add(newBee);
        }

        public void Go(Random random)
        {
            if (world.Bees.Count < MaxNumberBee
                && Honey > MinHoneyRequired
                && random.Next(10) == 1)
                AddBee(random);
        }
    }
}
