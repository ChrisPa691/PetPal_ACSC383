using System;
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
                MessageBox.Show($"Welcome to the game, {petName} the {petType}!");
            }
            else if (petType == "cat"){
                petPic.ImageLocation = "petCat.jpeg";
                petPic.Load();
                MessageBox.Show($"Welcome to the game, {petName} the {petType}!");
            }
            else{
                petPic.ImageLocation = "petPig.jpeg";
                petPic.Load();
                MessageBox.Show($"Welcome to the game, {petName} the {petType}!");
            }

            if(healthBar.Value == 0 | foodBar.Value == 0){
                deadLbl.Visible = true;
                retryBtn.Visible = true;
            }
        }

        private void game_Load(object sender, EventArgs e){
            sleepBar.Value = 50;
            foodBar.Value = 50;
            healthBar.Value = 75;
            exciteBar.Value = 50;

            if (sleepBar.Value >= 100){
                sleepBar.Value = 95;
                MessageBox.Show($"{petName} has had enough sleep");
            }
            if (foodBar.Value >= 100){
                foodBar.Value = 95;
                MessageBox.Show($"{petName} has had enough food");
            }
            if (healthBar.Value >= 100){
                healthBar.Value = 95;
                MessageBox.Show($"{petName} is healthy");
            }
            if (exciteBar.Value >= 100){
                exciteBar.Value = 95;
                MessageBox.Show($"{petName} is excited");
            }

            petPic.Height = 300;
            petPic.Width = 300;
        }

        private void sleepBtn_Click(object sender, EventArgs e){
            sleepBar.Value += 15;
            foodBar.Value -= 5;
            healthBar.Value -= 5;
            exciteBar.Value -= 5;

            if (petType == "dog"){
                petPic.ImageLocation = "dogSlepping.jpg";
                petPic.SizeMode = PictureBoxSizeMode.AutoSize;
                petPic.Load();
            }
            else if (petType == "cat"){
                petPic.ImageLocation = "catSleeping.jpeg";
                petPic.SizeMode = PictureBoxSizeMode.AutoSize;
                petPic.Load();
            }
            else{
                petPic.ImageLocation = "pigSleeping.jpeg";
                petPic.SizeMode = PictureBoxSizeMode.AutoSize;
                petPic.Load();
            }

            if (healthBar.Value == 0 | foodBar.Value == 0)
            {
                deadLbl.Visible = true;
                retryBtn.Visible = true;
            }
        }

        private void feedBtn_Click(object sender, EventArgs e){
            foodBar.Value += 15;
            sleepBar.Value -= 5;
            healthBar.Value += 10;
            exciteBar.Value += 10;

            if (petType == "dog"){
                petPic.ImageLocation = "dogEating.jpg";
                petPic.Load();
                petPic.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            else if (petType == "cat"){
                petPic.ImageLocation = "catEating.jpeg";
                petPic.Load();
                petPic.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            else{
                petPic.ImageLocation = "pigEating.jpeg";
                petPic.Load();
                petPic.SizeMode = PictureBoxSizeMode.AutoSize;
            }

            if (healthBar.Value == 0 | foodBar.Value == 0)
            {
                deadLbl.Visible = true;
                retryBtn.Visible = true;
            }
        }

        private void playBtn_Click(object sender, EventArgs e){
            healthBar.Value -= 5;
            sleepBar.Value -= 5;
            foodBar.Value -= 10;
            exciteBar.Value += 10;

            if (petType == "dog"){
                petPic.ImageLocation = "dogPlaying.jpg";
                petPic.Load();
                petPic.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            else if (petType == "cat"){
                petPic.ImageLocation = "catPlaying.jpeg";
                petPic.Load();
                petPic.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            else{
                petPic.ImageLocation = "pigPlaying.jpeg";
                petPic.Load();
                petPic.SizeMode = PictureBoxSizeMode.AutoSize;
            }

            if (healthBar.Value == 0 | foodBar.Value == 0)
            {
                deadLbl.Visible = true;
                retryBtn.Visible = true;
            }
        }

        private void petBtn_Click(object sender, EventArgs e){
            healthBar.Value += 5;
            sleepBar.Value -= 5;
            foodBar.Value -= 5;
            exciteBar.Value += 5;

            if (petType == "dog"){
                petPic.ImageLocation = "dogPetting.jpeg";
                petPic.Load();
                petPic.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            else if (petType == "cat"){
                petPic.ImageLocation = "catPetted.jpeg";
                petPic.Load();
                petPic.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            else{
                petPic.ImageLocation = "pigPetted.jpeg";
                petPic.Load();
                petPic.SizeMode = PictureBoxSizeMode.AutoSize;
            }
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
