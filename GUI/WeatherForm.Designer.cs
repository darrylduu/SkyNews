namespace SkyNews.GUI
{
    partial class WeatherForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCurrent = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewActivities = new System.Windows.Forms.ListView();
            this.columnHeaderTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.flowLayoutPanelDailyWeather = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelActivities = new System.Windows.Forms.Label();
            this.labelPressure = new System.Windows.Forms.Label();
            this.labelWindspeed = new System.Windows.Forms.Label();
            this.labelPressure2 = new System.Windows.Forms.Label();
            this.labelWind = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.labelCondition = new System.Windows.Forms.Label();
            this.labelSearchForCity = new System.Windows.Forms.Label();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.tabPageSaved = new System.Windows.Forms.TabPage();
            this.labelFavorites = new System.Windows.Forms.Label();
            this.listBoxFavorites = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageCurrent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            this.tabPageSaved.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCurrent);
            this.tabControl1.Controls.Add(this.tabPageSaved);
            this.tabControl1.Location = new System.Drawing.Point(16, 18);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1144, 778);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCurrent
            // 
            this.tabPageCurrent.Controls.Add(this.button1);
            this.tabPageCurrent.Controls.Add(this.listViewActivities);
            this.tabPageCurrent.Controls.Add(this.pictureBoxIcon);
            this.tabPageCurrent.Controls.Add(this.labelCountry);
            this.tabPageCurrent.Controls.Add(this.flowLayoutPanelDailyWeather);
            this.tabPageCurrent.Controls.Add(this.buttonSearch);
            this.tabPageCurrent.Controls.Add(this.textBoxCity);
            this.tabPageCurrent.Controls.Add(this.labelActivities);
            this.tabPageCurrent.Controls.Add(this.labelPressure);
            this.tabPageCurrent.Controls.Add(this.labelWindspeed);
            this.tabPageCurrent.Controls.Add(this.labelPressure2);
            this.tabPageCurrent.Controls.Add(this.labelWind);
            this.tabPageCurrent.Controls.Add(this.labelTemp);
            this.tabPageCurrent.Controls.Add(this.labelDetails);
            this.tabPageCurrent.Controls.Add(this.labelCondition);
            this.tabPageCurrent.Controls.Add(this.labelSearchForCity);
            this.tabPageCurrent.Controls.Add(this.pictureBoxBackground);
            this.tabPageCurrent.Location = new System.Drawing.Point(4, 36);
            this.tabPageCurrent.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCurrent.Name = "tabPageCurrent";
            this.tabPageCurrent.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCurrent.Size = new System.Drawing.Size(1136, 738);
            this.tabPageCurrent.TabIndex = 0;
            this.tabPageCurrent.Text = "Current";
            this.tabPageCurrent.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(555, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 52);
            this.button1.TabIndex = 34;
            this.button1.Text = "Save To Favorites";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewActivities
            // 
            this.listViewActivities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitle});
            this.listViewActivities.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewActivities.HideSelection = false;
            this.listViewActivities.Location = new System.Drawing.Point(784, 123);
            this.listViewActivities.Margin = new System.Windows.Forms.Padding(4);
            this.listViewActivities.Name = "listViewActivities";
            this.listViewActivities.Size = new System.Drawing.Size(242, 347);
            this.listViewActivities.TabIndex = 33;
            this.listViewActivities.UseCompatibleStateImageBehavior = false;
            this.listViewActivities.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Title";
            this.columnHeaderTitle.Width = 200;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Location = new System.Drawing.Point(85, 175);
            this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(80, 88);
            this.pictureBoxIcon.TabIndex = 32;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountry.ForeColor = System.Drawing.Color.White;
            this.labelCountry.Location = new System.Drawing.Point(199, 202);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(137, 44);
            this.labelCountry.TabIndex = 31;
            this.labelCountry.Text = "Country";
            // 
            // flowLayoutPanelDailyWeather
            // 
            this.flowLayoutPanelDailyWeather.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelDailyWeather.Location = new System.Drawing.Point(85, 491);
            this.flowLayoutPanelDailyWeather.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelDailyWeather.Name = "flowLayoutPanelDailyWeather";
            this.flowLayoutPanelDailyWeather.Size = new System.Drawing.Size(944, 153);
            this.flowLayoutPanelDailyWeather.TabIndex = 29;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.White;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(555, 123);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(113, 25);
            this.buttonSearch.TabIndex = 28;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(83, 123);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(464, 33);
            this.textBoxCity.TabIndex = 27;
            // 
            // labelActivities
            // 
            this.labelActivities.AutoSize = true;
            this.labelActivities.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActivities.ForeColor = System.Drawing.Color.White;
            this.labelActivities.Location = new System.Drawing.Point(780, 85);
            this.labelActivities.Name = "labelActivities";
            this.labelActivities.Size = new System.Drawing.Size(189, 47);
            this.labelActivities.TabIndex = 26;
            this.labelActivities.Text = "Activities";
            // 
            // labelPressure
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelPressure.ForeColor = System.Drawing.Color.White;
            this.labelPressure.Location = new System.Drawing.Point(500, 332);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(51, 29);
            this.labelPressure.TabIndex = 25;
            this.labelPressure.Text = "N/A";
            // 
            // labelWindspeed
            // 
            this.labelWindspeed.AutoSize = true;
            this.labelWindspeed.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelWindspeed.ForeColor = System.Drawing.Color.White;
            this.labelWindspeed.Location = new System.Drawing.Point(500, 291);
            this.labelWindspeed.Name = "labelWindspeed";
            this.labelWindspeed.Size = new System.Drawing.Size(51, 29);
            this.labelWindspeed.TabIndex = 24;
            this.labelWindspeed.Text = "N/A";
            // 
            // labelPressure2
            // 
            this.labelPressure2.AutoSize = true;
            this.labelPressure2.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelPressure2.ForeColor = System.Drawing.Color.White;
            this.labelPressure2.Location = new System.Drawing.Point(392, 332);
            this.labelPressure2.Name = "labelPressure2";
            this.labelPressure2.Size = new System.Drawing.Size(102, 29);
            this.labelPressure2.TabIndex = 23;
            this.labelPressure2.Text = "Pressure:";
            // 
            // labelWind
            // 
            this.labelWind.AutoSize = true;
            this.labelWind.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelWind.ForeColor = System.Drawing.Color.White;
            this.labelWind.Location = new System.Drawing.Point(392, 291);
            this.labelWind.Name = "labelWind";
            this.labelWind.Size = new System.Drawing.Size(138, 29);
            this.labelWind.TabIndex = 22;
            this.labelWind.Text = "Wind Speed:";
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelTemp.ForeColor = System.Drawing.Color.White;
            this.labelTemp.Location = new System.Drawing.Point(80, 378);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(140, 29);
            this.labelTemp.TabIndex = 21;
            this.labelTemp.Text = "Temperature";
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Font = new System.Drawing.Font("Calibri", 12F);
            this.labelDetails.ForeColor = System.Drawing.Color.White;
            this.labelDetails.Location = new System.Drawing.Point(80, 334);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(81, 29);
            this.labelDetails.TabIndex = 20;
            this.labelDetails.Text = "Details";
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCondition.ForeColor = System.Drawing.Color.White;
            this.labelCondition.Location = new System.Drawing.Point(80, 291);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(110, 29);
            this.labelCondition.TabIndex = 19;
            this.labelCondition.Text = "Condition";
            // 
            // labelSearchForCity
            // 
            this.labelSearchForCity.AutoSize = true;
            this.labelSearchForCity.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchForCity.ForeColor = System.Drawing.Color.White;
            this.labelSearchForCity.Location = new System.Drawing.Point(79, 85);
            this.labelSearchForCity.Name = "labelSearchForCity";
            this.labelSearchForCity.Size = new System.Drawing.Size(288, 47);
            this.labelSearchForCity.TabIndex = 18;
            this.labelSearchForCity.Text = "Search for City";
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.Image = global::SkyNews.Properties.Resources.backgroundForm_03;
            this.pictureBoxBackground.Location = new System.Drawing.Point(4, 5);
            this.pictureBoxBackground.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(1128, 744);
            this.pictureBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackground.TabIndex = 0;
            this.pictureBoxBackground.TabStop = false;
            // 
            // tabPageSaved
            // 
            this.tabPageSaved.Controls.Add(this.labelFavorites);
            this.tabPageSaved.Controls.Add(this.listBoxFavorites);
            this.tabPageSaved.Controls.Add(this.pictureBox2);
            this.tabPageSaved.Location = new System.Drawing.Point(4, 36);
            this.tabPageSaved.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageSaved.Name = "tabPageSaved";
            this.tabPageSaved.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageSaved.Size = new System.Drawing.Size(1136, 738);
            this.tabPageSaved.TabIndex = 1;
            this.tabPageSaved.Text = "Saved";
            this.tabPageSaved.UseVisualStyleBackColor = true;
            // 
            // labelFavorites
            // 
            this.labelFavorites.AutoSize = true;
            this.labelFavorites.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFavorites.ForeColor = System.Drawing.Color.White;
            this.labelFavorites.Location = new System.Drawing.Point(82, 92);
            this.labelFavorites.Name = "labelFavorites";
            this.labelFavorites.Size = new System.Drawing.Size(192, 47);
            this.labelFavorites.TabIndex = 19;
            this.labelFavorites.Text = "Favorited";
            // 
            // listBoxFavorites
            // 
            this.listBoxFavorites.FormattingEnabled = true;
            this.listBoxFavorites.ItemHeight = 27;
            this.listBoxFavorites.Location = new System.Drawing.Point(88, 139);
            this.listBoxFavorites.Name = "listBoxFavorites";
            this.listBoxFavorites.Size = new System.Drawing.Size(948, 463);
            this.listBoxFavorites.TabIndex = 2;
            this.listBoxFavorites.SelectedIndexChanged += new System.EventHandler(this.listBoxFavorites_SelectedIndexChanged);
            this.listBoxFavorites.DoubleClick += new System.EventHandler(this.listBoxFavorites_DoubleClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SkyNews.Properties.Resources.backgroundForm_03;
            this.pictureBox2.Location = new System.Drawing.Point(4, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1128, 742);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(801, 22);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(60, 27);
            this.labelDateTime.TabIndex = 2;
            this.labelDateTime.Text = "Date";
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 809);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WeatherForm";
            this.Text = "SkyView";
            this.Load += new System.EventHandler(this.WeatherForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageCurrent.ResumeLayout(false);
            this.tabPageCurrent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            this.tabPageSaved.ResumeLayout(false);
            this.tabPageSaved.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCurrent;
        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.TabPage tabPageSaved;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelActivities;
        private System.Windows.Forms.Label labelPressure;
        private System.Windows.Forms.Label labelWindspeed;
        private System.Windows.Forms.Label labelPressure2;
        private System.Windows.Forms.Label labelWind;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Label labelSearchForCity;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDailyWeather;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.ListView listViewActivities;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ListBox listBoxFavorites;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelFavorites;
    }
}