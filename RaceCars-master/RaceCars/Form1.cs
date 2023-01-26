using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;



namespace RaceCars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Variable to call speed, totalodometer, SpeedInMph, TotalOdometers & carNumber
        private int speed = 0;
        public int totalodometer = 0;
        public int SpeedInMph = 0;
        public int TotalOdometers = 0;
        public int carNumber = 0;

        //Variables currracer to save each racers in the Racer class list
        public int currracer = 0;

        //variable counter to call racer 1- 10 for the race.
        public int counter = 1;
        
        //variable to store current round.
        public int round = 1;
    

        List<Car> Racers = new List<Car>();

        public string[] Sponsor = new string[] {
            "Abercrombie & Fitch Co.", "ABM Industries Incorporated","Ace Hardware Corporation","ACT Manufacturing Inc.", 
            "Acterna Corp.", "Adams Resources ", "ADC Telecommunications, Inc.", "Adelphia Communications Corporation", 
            "Administaff, Inc.", "Adobe Systems Incorporated", "Adolph Coors Company", "Advance Auto Parts, Inc.", 
            "Advanced Micro Devices, Inc.", "AdvancePCS, Inc.", "Advantica Restaurant Group, Inc.","The AES Corporation", 
            "Aetna Inc.", "Affiliated Computer Services, Inc.", "AFLAC Incorporated", "AGCO Corporation", "Agilent Technologies, Inc.", 
            "Agway Inc.", "Apartment Investment and Management"+ " Company", "Air Products and Chemicals, Inc.", "Airborne, Inc.", 
            "Airgas, Inc.", "AK Steel Holding" + " Corporation", "Alaska Air Group, Inc.", "Alberto-Culver Company", 
            "Albertson's, Inc.", "Alcoa Inc.", "Alleghany Corporation", "Allegheny Energy, Inc.", "Allegheny Technologies Incorporated",
            "Allergan, Inc.", "ALLETE, Inc.", "Alliant Energy Corporation", "Allied Waste Industries, Inc.", "Allmerica Financial Corporation",
            "The Allstate Corporation", "ALLTEL Corporation", "The Alpine Group, Inc.", "Amazon.com, Inc.","AMC Entertainment Inc.", 
            "American Power Conversion Corporation", "Amerada Hess Corporation", "AMERCO", "Ameren Corporation", 
            "America West Holdings Corporation", "American Axle & Manufacturing Holdings," + " Inc.", 
            "American Eagle Outfitters, Inc.", "American Electric Power Company, Inc." };


        public string[] driverName = new string[] 
        {
            "William Swopes", "Margurite Miland", "Alva Liska", "Bruna Breen", "Luciana Deshotel",
            "Jeannetta Nesbitt", "Donny Ledger", "Modesto Tennant", "Imelda Hassler", "Karma Agar", 
            "Janis Wisneski", "Micha Dillow", "Mattie Boulden", "Ethelyn Boswell", "Erica Corvin", 
            "Marion Holliday", "Laticia Repka",  "Desirae Guarino", "Ines Wallach", "Deloris Kimbler", 
            "Elliot Shatley", "Millicent Koller", "Bess Medellin", "Marcy Lydick", "Garnet Mccabe", 
            "Donna Tannehill", "Dusti Devillier", "Leland Slemp", "Keiko Dolph", "Maybell Berggren", 
            "Jeni Crew", "Christi Birdwell", "Una Sprague", "Sheba Mirza", "Alanna Wawrzyniak", 
            "Francina Rippel", "Fermin Layne", "Taren Stetson", "Serina Reveles", "Maegan Arvizo", 
            "Tajuana Behringer", "Tamara Havel", "Anya Gemmill", "Mel Bustle", "Tandy Nash", "Hue Stefan", 
            "Reina Streett", "Glennie Kist", "Latricia Li", "Juliette Bureau"
        };


        private int GenerateSpeed(int speed)
        {
            Random random = new Random();
            speed = random.Next(60,120);

            return speed;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btncnt_Click(object sender, EventArgs e)
        {
                int maxcars = 10;

            for (int currracer = 0; currracer < maxcars; currracer++)
            {
                Thread.Sleep(5);
                Random random = new Random();
                int sponsorcount = random.Next(1, 52);

                Random random2 = new Random();
                int drivercount = random2.Next(1, 50);

                carNumber++;

                counter = carNumber;

                Racers.Add(new Car { CarNumber = carNumber, dName = driverName[drivercount], sponsor = Sponsor[sponsorcount], speedInMph = SpeedInMph, totalOdometers = TotalOdometers });

                lstbxname.Items.Add("Racer: " + Racers.ElementAt(currracer).CarNumber + ", Driver: " + Racers.ElementAt(currracer).dName + ", Sponsored by:" + Racers.ElementAt(currracer).sponsor);

                counter++;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnrace_Click(object sender, EventArgs e)
        {
            int maxdistance = 1000;
            int dis = 0;
            //Total number of cars

            //current round
            

            listBox2.Items.Add("Round: " + round);

            round++;


            Thread.Sleep(5);
            for (counter = 0; counter < Racers.Count(); counter++)
            {
                Thread.Sleep(5);
                Racers.ElementAt(counter).speedInMph = GenerateSpeed(speed);
                Racers.ElementAt(counter).totalOdometers = Racers.ElementAt(counter).totalOdometers + Racers.ElementAt(counter).speedInMph;
                listBox2.Items.Add("Racer :" + Racers.ElementAt(counter).CarNumber + ", Driver: " + Racers.ElementAt(counter).dName + "Gained: " + Racers.ElementAt(counter).speedInMph + "Speed. Making current total be: " + Racers.ElementAt(counter).totalOdometers);
                dis = Racers.ElementAt(counter).totalOdometers;

                if (counter == Racers.Count() -1)
                {
                    listBox2.Items.Add("\n");
                }

                else if (dis >= maxdistance)
                {
                    MessageBox.Show("Winner Racer: " + Racers.ElementAt(counter).CarNumber + ", Driver: " + Racers.ElementAt(counter).dName + ", Sponsored by:" + Racers.ElementAt(counter).sponsor);
                    this.Close();
                }
            }
        }
    }
}
