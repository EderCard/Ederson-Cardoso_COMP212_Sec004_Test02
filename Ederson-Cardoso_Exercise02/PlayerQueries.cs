using BaseballLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ederson_Cardoso_Exercise02
{
    public partial class PlayerQueries : Form
    {
        public PlayerQueries()
        {
            InitializeComponent();
        }

        BaseballEntities dbContext = new BaseballEntities();

        /// <summary>
        /// This method load players table to the playerDataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayerQueries_Load(object sender, EventArgs e)
        {
            // Load players table
            dbContext.Players.Load();

            // Specify DataSource for playerBindingSource
            playerBindingSource.DataSource = dbContext.Players.Local;
        }

        /// <summary>
        /// This method returns a list of players matching the PlayerID and LastName 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e)
        {
            // Giver PlayerID
            if (playerIDTextBox.Text != string.Empty && lastNameTextBox.Text == string.Empty)
            {
                int playerId = int.Parse(playerIDTextBox.Text);
                findPlayer(playerId);
            }
            // Given LastName
            if (playerIDTextBox.Text == string.Empty && lastNameTextBox.Text != string.Empty)
            {
                string lastName = lastNameTextBox.Text.ToLower();
                findPlayer(lastName);
            }
            // Given PlayerID and LastNAme
            if (lastNameTextBox.Text != string.Empty && playerIDTextBox.Text != string.Empty)
            {
                int playerId = int.Parse(playerIDTextBox.Text);
                string lastName = lastNameTextBox.Text.ToLower();
                findPlayer(playerId, lastName);
            }
        }

        /// <summary>
        /// This method returns the player based on PlayerID
        /// </summary>
        /// <param name="playerId"></param>
        private void findPlayer(int playerId)
        {
            try
            {
                var queryPlayer =
                    from player in dbContext.Players
                    .Where(player => player.PlayerID.Equals(playerId))
                    select player;

                playerDataGridView.DataSource = queryPlayer.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// This overloaded method returns the player based on LastName
        /// </summary>
        /// <param name="lastName"></param>
        private void findPlayer(string lastName)
        {
            try
            {
                var queryPlayer =
                    from player in dbContext.Players
                    .Where(player => player.LastName.ToLower().Contains(lastName))
                    select player;

                playerDataGridView.DataSource = queryPlayer.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// This overloaded method retunrs the player based on PlayerID and LastName
        /// </summary>
        /// <param name="playerId"></param>
        /// <param name="lastName"></param>
        private void findPlayer(int playerId, string lastName)
        {
            try
            {
                var queryPlayer =
                    from player in dbContext.Players
                    .Where(player => player.PlayerID.Equals(playerId) && player.LastName.ToLower().Contains(lastName))
                    select player;

                playerDataGridView.DataSource = queryPlayer.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// This method returns a clearButton_Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            playerIDTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            findPlayer(string.Empty);
        }

        private void battingAverageButton_Click(object sender, EventArgs e)
        {
            calculateBattingAverage();
        }

        private void highestScorebutton_Click(object sender, EventArgs e)
        {
            findHighestScorePlayer();
        }
        /// <summary>
        /// This method calculates the batting average
        /// </summary>
        private void calculateBattingAverage()
        {
            try
            {
                var queryPlayer =
                (from player in dbContext.Players
                 select player.BattingAverage).Average();

                // show batting average
                battingAverageResultLabel.Text = queryPlayer.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// This method returs the player's name who has the highest batting average
        /// </summary>
        private void findHighestScorePlayer()
        {
            try
            {
                // select the max batting average from players
                var maxBatting =
                    (from player in dbContext.Players
                     select player.BattingAverage).Max();

                // select the player who has the highest batting average
                var queryPlayer =
                    from player in dbContext.Players
                    .Where(player => player.BattingAverage.Equals(maxBatting))
                    select player;

                // show player's name
                foreach (var p in queryPlayer)
                {
                    string playerName = p.FirstName + " " + p.LastName;
                    highestScoreResultLabel.Text = playerName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Generic Field Validations
        /// <summary>
        /// This method validate field content for only numeric values
        /// </summary>
        /// <param name="e"></param>
        private static void ValidateNumericDigit(KeyPressEventArgs e)
        {
            // Allow "number" and "backscape"
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// This is the event handler for the playerIDTextBox_KeyPress event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playerIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumericDigit(e);
        }

        #endregion
    } // end class
} // end namespace
