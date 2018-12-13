﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SleighRush
{
    public partial class LeaderBoard : Form
    {
        private List<User> users;

        public LeaderBoard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            GameConfigurationManager gameConfig = new GameConfigurationManager();
            gameConfig.parseConfigurationFile();
            users = gameConfig.users;
        }

        private void backButtonClicked(object sender, EventArgs e)
        {
            this.Hide();
            GameScreen gameScreenForm = new GameScreen();
            gameScreenForm.ShowDialog();
            this.Close();
        }
        

    }
}
