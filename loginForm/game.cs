using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace loginForm{
    public partial class gameF : Form{
        private string petName;
        private string petType;

        public gameF(string petName, string petType){
            InitializeComponent();
            this.petName = petName;
            this.petType = petType;
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            if (petType == "dog"){
                petPic.ImageLocation = "petDog.jpeg";
                petPic.Load();
            }
            else if (petType == "cat"){
                petPic.ImageLocation = "petCat.jpeg";
                petPic.Load();
            }
            else{
                petPic.ImageLocation = "petPig.jpeg";
                petPic.Load();
            }
            MessageBox.Show($"Welcome to the game, {petName} the {petType}!");

            if (healthBar.Value == 0 | foodBar.Value == 0){
                deadLbl.Visible = true;
                retryBtn.Visible = true;
            }
        }

        private void original_petPic(){
            if (petType == "dog"){
                petPic.ImageLocation = "petDog.jpeg";
                petPic.Refresh();
                petPic.Load();
            }
            else if (petType == "cat"){
                petPic.ImageLocation = "petCat.jpeg";
                petPic.Refresh();
                petPic.Load();
            }
            else{
                petPic.ImageLocation = "petPig.jpeg";
                petPic.Refresh();
                petPic.Load();
            }
        }

        private bool max_stats(){
            if (sleepBar.Value >= 100 || foodBar.Value >= 100 || healthBar.Value >= 100 || exciteBar.Value >= 100){
                sleepBar.Value = 95;
                foodBar.Value = 95;
                healthBar.Value = 95;
                exciteBar.Value = 95;

                if (sleepBar.Value >= 100){
                    MessageBox.Show($"{petName} has had enough sleep");
                    return true;
                } 
                else if (foodBar.Value >= 100) { }
                    MessageBox.Show($"{petName} has had enough food");
                    return true;
                }
                else if (healthBar.Value >= 100){
                    MessageBox.Show($"{petName} is healthy");
                    return true;
                }
                else if(exciteBar.Value >= 100){
                    MessageBox.Show($"{petName} is excited");
                    return true;
            }
            else
                return false;
        }

        private void game_Load(object sender, EventArgs e){
            sleepBar.Value = 50;
            foodBar.Value = 50;
            healthBar.Value = 75;
            exciteBar.Value = 50;

            petPic.Height = 300;
            petPic.Width = 300;
        }

        private void sleepBtn_Click(object sender, EventArgs e){

            int counter = 0;
            if (!max_stats()){
                sleepBar.Value += 15;
                foodBar.Value -= 5;
                healthBar.Value -= 5;
                exciteBar.Value -= 5;
            }

            do
            {
                if (petType == "dog")
                {
                    petPic.SizeMode = PictureBoxSizeMode.AutoSize;
                    petPic.ImageLocation = "dogSlepping.jpg";
                    petPic.Refresh();
                    petPic.Load();
                }
                else if (petType == "cat")
                {
                    petPic.SizeMode = PictureBoxSizeMode.AutoSize;
                    petPic.ImageLocation = "catSleeping.jpeg";
                    petPic.Refresh();
                    petPic.Load();
                }
                else
                {
                    petPic.SizeMode = PictureBoxSizeMode.AutoSize;
                    petPic.ImageLocation = "pigSleeping.jpeg";
                    petPic.Refresh();
                    petPic.Load();
                }
                counter++;
            } while (counter <= 1000);

            if (healthBar.Value == 0 | foodBar.Value == 0){
                deadLbl.Visible = true;
                retryBtn.Visible = true;
            }

            
        }

        private void feedBtn_Click(object sender, EventArgs e){
            int counter = 0;
            
            if(!max_stats()){
                foodBar.Value += 15;
                sleepBar.Value -= 5;
                healthBar.Value += 10;
                exciteBar.Value += 10;
            }

            while (counter <= 1000){
                if (petType == "dog")
                {
                    petPic.ImageLocation = "dogEating.jpg";
                    petPic.Load();
                    petPic.Refresh();
                    petPic.SizeMode = PictureBoxSizeMode.AutoSize;
                }
                else if (petType == "cat")
                {
                    petPic.ImageLocation = "catEating.jpeg";
                    petPic.Load();
                    petPic.Refresh();
                    petPic.SizeMode = PictureBoxSizeMode.AutoSize;
                }
                else
                {
                    petPic.ImageLocation = "pigEating.jpeg";
                    petPic.Load();
                    petPic.Refresh();
                    petPic.SizeMode = PictureBoxSizeMode.AutoSize;
                }
                counter++;
            }

            original_petPic();

            if (healthBar.Value == 0 | foodBar.Value == 0)
            {
                deadLbl.Visible = true;
                retryBtn.Visible = true;
            }
        }

        private void playBtn_Click(object sender, EventArgs e){
            int counter = 0;

            if (!max_stats()){
                healthBar.Value -= 5;
                sleepBar.Value -= 5;
                foodBar.Value -= 10;
                exciteBar.Value += 10;
            }

            while (counter <= 1000){
                if (petType == "dog")
                {
                    petPic.ImageLocation = "dogPlaying.jpg";
                    petPic.Load();
                    petPic.Refresh();
                    petPic.SizeMode = PictureBoxSizeMode.AutoSize;
                }
                else if (petType == "cat")
                {
                    petPic.ImageLocation = "catPlaying.jpeg";
                    petPic.Load();
                    petPic.Refresh();
                    petPic.SizeMode = PictureBoxSizeMode.AutoSize;
                }
                else
                {
                    petPic.ImageLocation = "pigPlaying.jpeg";
                    petPic.Load();
                    petPic.Refresh();
                    petPic.SizeMode = PictureBoxSizeMode.AutoSize;
                }
                counter++;
            }

            original_petPic();

            if (healthBar.Value == 0 | foodBar.Value == 0)
            {
                deadLbl.Visible = true;
                retryBtn.Visible = true;
            }
        }

        private void petBtn_Click(object sender, EventArgs e){
            int counter = 0;

            if (!max_stats()){
                healthBar.Value += 5;
                sleepBar.Value -= 5;
                foodBar.Value -= 5;
                exciteBar.Value += 5;
            }

                while (counter <= 1000){
                if (petType == "dog")
                {
                    petPic.ImageLocation = "dogPetting.jpeg";
                    petPic.Load();
                    petPic.Refresh();
                    petPic.SizeMode = PictureBoxSizeMode.AutoSize;
                }
                else if (petType == "cat")
                {
                    petPic.ImageLocation = "catPetted.jpeg";
                    petPic.Load();
                    petPic.Refresh();
                    petPic.SizeMode = PictureBoxSizeMode.AutoSize;
                }
                else
                {
                    petPic.ImageLocation = "pigPetted.jpeg";
                    petPic.Load();
                    petPic.Refresh();

                    petPic.SizeMode = PictureBoxSizeMode.AutoSize;
                }
                counter++; 
            }

            original_petPic();
        }

        private void retryBtn_Click(object sender, EventArgs e){
            sleepBar.Value = 50;
            foodBar.Value = 50;
            healthBar.Value = 75;
            exciteBar.Value = 50;
        }

        private void Bg1_Click(object sender, EventArgs e){
            this.BackgroundImage = Image.FromFile("background1.png");
            petPic.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void Bg2_Click(object sender, EventArgs e){
            this.BackgroundImage = Image.FromFile("background2.jpeg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            petPic.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void Bg3_Click(object sender, EventArgs e){
            this.BackgroundImage = Image.FromFile("background3.jpeg");
            petPic.SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}
