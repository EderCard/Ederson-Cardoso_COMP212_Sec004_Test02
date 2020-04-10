namespace Ederson_Cardoso_Exercise02
{
    partial class PlayerQueries
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerQueries));
            this.playerDataGridView = new System.Windows.Forms.DataGridView();
            this.playerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.battingAverageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.playerIDLabel = new System.Windows.Forms.Label();
            this.playerIDTextBox = new System.Windows.Forms.TextBox();
            this.highestScoreResultLabel = new System.Windows.Forms.Label();
            this.highestScorebutton = new System.Windows.Forms.Button();
            this.battingAverageButton = new System.Windows.Forms.Button();
            this.battingAverageResultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingNavigator)).BeginInit();
            this.playerBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerDataGridView
            // 
            this.playerDataGridView.AutoGenerateColumns = false;
            this.playerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.battingAverageDataGridViewTextBoxColumn});
            this.playerDataGridView.DataSource = this.playerBindingSource;
            this.playerDataGridView.Location = new System.Drawing.Point(6, 138);
            this.playerDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playerDataGridView.Name = "playerDataGridView";
            this.playerDataGridView.Size = new System.Drawing.Size(534, 228);
            this.playerDataGridView.TabIndex = 0;
            // 
            // playerIDDataGridViewTextBoxColumn
            // 
            this.playerIDDataGridViewTextBoxColumn.DataPropertyName = "PlayerID";
            this.playerIDDataGridViewTextBoxColumn.HeaderText = "Player ID";
            this.playerIDDataGridViewTextBoxColumn.Name = "playerIDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // battingAverageDataGridViewTextBoxColumn
            // 
            this.battingAverageDataGridViewTextBoxColumn.DataPropertyName = "BattingAverage";
            this.battingAverageDataGridViewTextBoxColumn.HeaderText = "Batting Average";
            this.battingAverageDataGridViewTextBoxColumn.Name = "battingAverageDataGridViewTextBoxColumn";
            this.battingAverageDataGridViewTextBoxColumn.Width = 150;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(BaseballLibrary.Player);
            // 
            // playerBindingNavigator
            // 
            this.playerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.playerBindingNavigator.BindingSource = this.playerBindingSource;
            this.playerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.playerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.playerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.playerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.playerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.playerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.playerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.playerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.playerBindingNavigator.Name = "playerBindingNavigator";
            this.playerBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.playerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.playerBindingNavigator.Size = new System.Drawing.Size(784, 25);
            this.playerBindingNavigator.TabIndex = 1;
            this.playerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(197, 38);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(90, 20);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(295, 35);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(245, 26);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(295, 82);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(112, 35);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(428, 82);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 35);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // playerIDLabel
            // 
            this.playerIDLabel.AutoSize = true;
            this.playerIDLabel.Location = new System.Drawing.Point(13, 41);
            this.playerIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerIDLabel.Name = "playerIDLabel";
            this.playerIDLabel.Size = new System.Drawing.Size(77, 20);
            this.playerIDLabel.TabIndex = 6;
            this.playerIDLabel.Text = "Player ID:";
            // 
            // playerIDTextBox
            // 
            this.playerIDTextBox.Location = new System.Drawing.Point(98, 35);
            this.playerIDTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playerIDTextBox.Name = "playerIDTextBox";
            this.playerIDTextBox.Size = new System.Drawing.Size(78, 26);
            this.playerIDTextBox.TabIndex = 7;
            this.playerIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.playerIDTextBox_KeyPress);
            // 
            // highestScoreResultLabel
            // 
            this.highestScoreResultLabel.AutoSize = true;
            this.highestScoreResultLabel.BackColor = System.Drawing.Color.White;
            this.highestScoreResultLabel.Location = new System.Drawing.Point(548, 273);
            this.highestScoreResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.highestScoreResultLabel.Name = "highestScoreResultLabel";
            this.highestScoreResultLabel.Size = new System.Drawing.Size(0, 20);
            this.highestScoreResultLabel.TabIndex = 11;
            // 
            // highestScorebutton
            // 
            this.highestScorebutton.Location = new System.Drawing.Point(552, 233);
            this.highestScorebutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.highestScorebutton.Name = "highestScorebutton";
            this.highestScorebutton.Size = new System.Drawing.Size(219, 35);
            this.highestScorebutton.TabIndex = 12;
            this.highestScorebutton.Text = "Highest Score";
            this.highestScorebutton.UseVisualStyleBackColor = true;
            this.highestScorebutton.Click += new System.EventHandler(this.highestScorebutton_Click);
            // 
            // battingAverageButton
            // 
            this.battingAverageButton.Location = new System.Drawing.Point(552, 136);
            this.battingAverageButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.battingAverageButton.Name = "battingAverageButton";
            this.battingAverageButton.Size = new System.Drawing.Size(219, 35);
            this.battingAverageButton.TabIndex = 13;
            this.battingAverageButton.Text = "Batting Average";
            this.battingAverageButton.UseVisualStyleBackColor = true;
            this.battingAverageButton.Click += new System.EventHandler(this.battingAverageButton_Click);
            // 
            // battingAverageResultLabel
            // 
            this.battingAverageResultLabel.AutoSize = true;
            this.battingAverageResultLabel.BackColor = System.Drawing.Color.White;
            this.battingAverageResultLabel.Location = new System.Drawing.Point(552, 176);
            this.battingAverageResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.battingAverageResultLabel.Name = "battingAverageResultLabel";
            this.battingAverageResultLabel.Size = new System.Drawing.Size(0, 20);
            this.battingAverageResultLabel.TabIndex = 14;
            // 
            // PlayerQueries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.battingAverageResultLabel);
            this.Controls.Add(this.battingAverageButton);
            this.Controls.Add(this.highestScorebutton);
            this.Controls.Add(this.highestScoreResultLabel);
            this.Controls.Add(this.playerIDTextBox);
            this.Controls.Add(this.playerIDLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.playerBindingNavigator);
            this.Controls.Add(this.playerDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PlayerQueries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player Queries";
            this.Load += new System.EventHandler(this.PlayerQueries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingNavigator)).EndInit();
            this.playerBindingNavigator.ResumeLayout(false);
            this.playerBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView playerDataGridView;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.BindingNavigator playerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label playerIDLabel;
        private System.Windows.Forms.TextBox playerIDTextBox;
        private System.Windows.Forms.Label highestScoreResultLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn battingAverageDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button highestScorebutton;
        private System.Windows.Forms.Button battingAverageButton;
        private System.Windows.Forms.Label battingAverageResultLabel;
    }
}

