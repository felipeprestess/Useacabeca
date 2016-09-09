using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACasa
{
    public partial class Form1 : Form
    {
        Location currentLocation;

        Room dinningRoom;
        RoomWithDoor kitchen;
        RoomWithDoor livingRoom;

        Outside garden;
        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Living Room","at antique carpet","an oak door with a brass knob");
            dinningRoom = new Room("Dinning Room","a crystal chandelier");
            kitchen = new RoomWithDoor("Kitchen","stainless steel appliances","a screen door");

            frontYard = new OutsideWithDoor("Front Yard",false,"an oak door with a brass knob");
            backYard = new OutsideWithDoor("Back Yard",true, "a screen door");
            garden = new Outside("Garden",false);

            dinningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { dinningRoom };
            kitchen.Exits = new Location[] { dinningRoom };
            frontYard.Exits = new Location[] {backYard,garden };
            garden.Exits = new Outside[] { backYard, frontYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }

        private void MoveToANewLocation(Location newLocation)
        {
            currentLocation = newLocation;

            cbxExits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
                cbxExits.Items.Add(currentLocation.Exits[i]);
            cbxExits.SelectedIndex = 0;

            txtDescription.Text = currentLocation.Description;

            if (currentLocation is IHasExteriorDoor)
                btnGoThroughTheDoor.Visible = true;
            else
                btnGoThroughTheDoor.Visible = false;
        }

        private void btnGoHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[cbxExits.SelectedIndex]);
        }

        private void btnGoThroughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }
    }
}
