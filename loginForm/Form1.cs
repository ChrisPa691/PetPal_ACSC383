﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace loginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //Login credentials
            /*
             admin: username: admin password: admin
             1st user: username: user1 password: pass1
             2nd user: username: user2 password: pass2
             3rd user: username: user3 password: pass3
             */
            StreamReader sr = new StreamReader("userDetails.txt");
            string line = sr.ReadLine();
            while ( line != null)
            {
                string[] parts = line.Split(' ');
                string username = parts[0];
                string password = parts[1];
                if (username != userNameTxt.Text && password != passTxt.Text){
                    line = sr.ReadLine();
                }
                else{
                    this.Hide();
                    choose chooseForm = new choose();
                    chooseForm.ShowDialog();
                    this.Close();            
                }    
            }

            MessageBox.Show("Invalid username or password");
        }

    }
}
