using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DlugieCwiczenie
{
    public partial class Form1 : Form
    {
        private static int Moves;
        private static Room DiningRoom;      
        private static RoomWithDoor LivingRoom, Kitchen;
        private static Room Stairs;
        private static RoomWithHidingPlace Hallway, Bathroom, MasterBedroom, SecondBedroom;
        private static OutsideWithDoor Frontyard, Backyard; 
        private static OutsideWithHidingLocation Garden,DriveWay;
        Location StartingLocation = Frontyard;

        private static Opponent myOpponent;
        public Location CurrentLocation
        {
            get; set;
        }

       

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            RedrawForm(true);

        }


        private static void CreateObjects()
        {
            DiningRoom = new Room("Jadalnia", "Błyszczący żyrandol");
            Garden = new OutsideWithHidingLocation("Ogród", false, "Na drzewie");
            Frontyard = new OutsideWithDoor("Podwórze frontowe", true, "Małe ze sklejki bez zamka", "W żywopłocie");            
            Backyard = new OutsideWithDoor("Podwórze z tyłu", true, "Wielkie dębowe z mosiężną klamką", "Za płotem");
            Kitchen = new RoomWithDoor("Kuchnia", "Nierdzerwne błyszczące sztucznie  i ", "Małe ze sklejki bez zamka", "w szafie ściennej");               
            LivingRoom = new RoomWithDoor("Salon", "Dywan perski", "Wielkie dębowe z mosiężną klamką", "za łóżkiem");
            Stairs = new Room("Schody", "Drewniania poręcz");
            Hallway = new RoomWithHidingPlace("Korytarz", "Obrazek z psem", "W szafie ściennej");
            MasterBedroom = new RoomWithHidingPlace("Duża sypalnia", "Duże łóżko", "Pod łóżkiem");
            SecondBedroom = new RoomWithHidingPlace("Druga sypalnia", "Małe łóżko", "Pod łóżkiem");
            Bathroom = new RoomWithHidingPlace("Łazienka", "Umywalka i toaleta", "Pod  prysznicem");
            DriveWay = new OutsideWithHidingLocation("Droga dojazdowa", true, "W garażu");

            myOpponent = new Opponent(Frontyard);


            Garden.Exits = new Location[] { Frontyard, Backyard };
            Frontyard.Exits = new Location[] { Garden, LivingRoom };
            Backyard.Exits = new Location[] { Kitchen, Garden };
            Kitchen.Exits = new Location[] { Backyard, DiningRoom };
            DiningRoom.Exits = new Location[] { Kitchen, LivingRoom };
            LivingRoom.Exits = new Location[] { DiningRoom, Frontyard };
            Stairs.Exits = new Location[] { LivingRoom, Hallway };
            Hallway.Exits = new Location[] { MasterBedroom, SecondBedroom, Bathroom };

            Frontyard.DoorLocation = LivingRoom;
            LivingRoom.DoorLocation = Frontyard;

            Backyard.DoorLocation = Kitchen;
            Kitchen.DoorLocation = Backyard;


        }

        private void goToButton_Click(object sender, EventArgs e)
        {
            Location[] copyExits = CurrentLocation.Exits;
            MoveToNewLocation(copyExits[exitsLocation.SelectedIndex]);          
        }

        private void throughtTheDoorButton_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor withDoor = CurrentLocation as IHasExteriorDoor;
            MoveToNewLocation(withDoor.DoorLocation);
        }

        private void MoveToNewLocation(Location newLocation)
        {
            CurrentLocation = newLocation;
            descriptionTextBox.Text = CurrentLocation.Description;
            Moves++;
            UpdateComboBox();

            if (CurrentLocation is IHasExteriorDoor)
            {                
                throughtTheDoorButton.Visible = true;                
            }
            else
            {
                throughtTheDoorButton.Visible = false;
            }

            if (CurrentLocation is IHidingLocation)
            {
                checkButton1.Visible = true;
            }
            else
            {
                checkButton1.Visible = false;
            }
        }
      
        private void UpdateComboBox()
        {
            exitsLocation.Items.Clear();
            for (int i = 0; i < CurrentLocation.Exits.Length; i++)
            {
                exitsLocation.Items.Add(CurrentLocation.Exits[i].Name);
            }
            exitsLocation.SelectedIndex = 0;
        }

        private void checkButton1_Click(object sender, EventArgs e)
        {
            if (myOpponent.Check(CurrentLocation))
            {
                MessageBox.Show("Mam Cię!!! Wygrałem, odnalazłem Cię w " + Moves +" ruchach.");
                MoveToNewLocation(Frontyard);
                Moves = 0;
                RedrawForm(true);

            }

            else
            {
                MessageBox.Show("Niestety, tu go nie ma.");
            }

        }


        private void hideUpButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                descriptionTextBox.Text = i+1 + "...";
                System.Threading.Thread.Sleep(200);
                myOpponent.Move();
            }

            MessageBox.Show("SZUKAM!!");

            RedrawForm(false);
            MoveToNewLocation(Frontyard);
            Moves = 0;

        }

        private void RedrawForm(bool isNewGame)
        {
            hideUpButton.Visible = isNewGame;
            throughtTheDoorButton.Visible = !isNewGame;
            checkButton1.Visible = !isNewGame;
            exitsLocation.Visible = !isNewGame;
            goToButton.Visible = !isNewGame;
        }
     

    }
}
