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
            this.tabPageSaved = new System.Windows.Forms.TabPage();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelActivities = new System.Windows.Forms.Label();
            this.labelPressure = new System.Windows.Forms.Label();
            this.labelWindspeed = new System.Windows.Forms.Label();
            this.labelPressure2 = new System.Windows.Forms.Label();
            this.labelWind = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.labelCondition = new System.Windows.Forms.Label();
            this.labelSearchForCity = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.flowLayoutPanelDailyWeather = new System.Windows.Forms.FlowLayoutPanel();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.listViewActivities = new System.Windows.Forms.ListView();
            this.columnHeaderTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonConnectDB = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageCurrent.SuspendLayout();
            this.tabPageSaved.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCurrent);
            this.tabControl1.Controls.Add(this.tabPageSaved);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(858, 534);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCurrent
            // 
            this.tabPageCurrent.Controls.Add(this.buttonConnectDB);
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
            this.tabPageCurrent.Location = new System.Drawing.Point(4, 22);
            this.tabPageCurrent.Name = "tabPageCurrent";
            this.tabPageCurrent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCurrent.Size = new System.Drawing.Size(850, 508);
            this.tabPageCurrent.TabIndex = 0;
            this.tabPageCurrent.Text = "Current";
            this.tabPageCurrent.UseVisualStyleBackColor = true;
            // 
            // tabPageSaved
            // 
            this.tabPageSaved.Controls.Add(this.pictureBox2);
            this.tabPageSaved.Location = new System.Drawing.Point(4, 22);
            this.tabPageSaved.Name = "tabPageSaved";
            this.tabPageSaved.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSaved.Size = new System.Drawing.Size(850, 508);
            this.tabPageSaved.TabIndex = 1;
            this.tabPageSaved.Text = "Saved";
            this.tabPageSaved.UseVisualStyleBackColor = true;
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.Image = global::SkyNews.Properties.Resources.backgroundForm_03;
            this.pictureBoxBackground.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(844, 502);
            this.pictureBoxBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackground.TabIndex = 0;
            this.pictureBoxBackground.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SkyNews.Properties.Resources.backgroundForm_03;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(844, 502);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // labelActivities
            // 
            this.labelActivities.AutoSize = true;
            this.labelActivities.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActivities.ForeColor = System.Drawing.Color.White;
            this.labelActivities.Location = new System.Drawing.Point(646, 58);
            this.labelActivities.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelActivities.Name = "labelActivities";
            this.labelActivities.Size = new System.Drawing.Size(81, 23);
            this.labelActivities.TabIndex = 26;
            this.labelActivities.Text = "Activities";
            // 
            // labelPressure
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPressure.ForeColor = System.Drawing.Color.White;
            this.labelPressure.Location = new System.Drawing.Point(373, 233);
            this.labelPressure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(30, 17);
            this.labelPressure.TabIndex = 25;
            this.labelPressure.Text = "N/A";
            // 
            // labelWindspeed
            // 
            this.labelWindspeed.AutoSize = true;
            this.labelWindspeed.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindspeed.ForeColor = System.Drawing.Color.White;
            this.labelWindspeed.Location = new System.Drawing.Point(373, 205);
            this.labelWindspeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWindspeed.Name = "labelWindspeed";
            this.labelWindspeed.Size = new System.Drawing.Size(30, 17);
            this.labelWindspeed.TabIndex = 24;
            this.labelWindspeed.Text = "N/A";
            // 
            // labelPressure2
            // 
            this.labelPressure2.AutoSize = true;
            this.labelPressure2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPressure2.ForeColor = System.Drawing.Color.White;
            this.labelPressure2.Location = new System.Drawing.Point(292, 233);
            this.labelPressure2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPressure2.Name = "labelPressure2";
            this.labelPressure2.Size = new System.Drawing.Size(60, 17);
            this.labelPressure2.TabIndex = 23;
            this.labelPressure2.Text = "Pressure:";
            // 
            // labelWind
            // 
            this.labelWind.AutoSize = true;
            this.labelWind.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWind.ForeColor = System.Drawing.Color.White;
            this.labelWind.Location = new System.Drawing.Point(292, 205);
            this.labelWind.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWind.Name = "labelWind";
            this.labelWind.Size = new System.Drawing.Size(78, 17);
            this.labelWind.TabIndex = 22;
            this.labelWind.Text = "Wind Speed:";
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemp.ForeColor = System.Drawing.Color.White;
            this.labelTemp.Location = new System.Drawing.Point(58, 265);
            this.labelTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(82, 17);
            this.labelTemp.TabIndex = 21;
            this.labelTemp.Text = "Temperature";
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetails.ForeColor = System.Drawing.Color.White;
            this.labelDetails.Location = new System.Drawing.Point(58, 235);
            this.labelDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(47, 17);
            this.labelDetails.TabIndex = 20;
            this.labelDetails.Text = "Details";
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCondition.ForeColor = System.Drawing.Color.White;
            this.labelCondition.Location = new System.Drawing.Point(58, 205);
            this.labelCondition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(61, 17);
            this.labelCondition.TabIndex = 19;
            this.labelCondition.Text = "Condition";
            // 
            // labelSearchForCity
            // 
            this.labelSearchForCity.AutoSize = true;
            this.labelSearchForCity.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchForCity.ForeColor = System.Drawing.Color.White;
            this.labelSearchForCity.Location = new System.Drawing.Point(59, 58);
            this.labelSearchForCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSearchForCity.Name = "labelSearchForCity";
            this.labelSearchForCity.Size = new System.Drawing.Size(122, 23);
            this.labelSearchForCity.TabIndex = 18;
            this.labelSearchForCity.Text = "Search for City";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(64, 96);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(349, 20);
            this.textBoxCity.TabIndex = 27;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(418, 93);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(85, 25);
            this.buttonSearch.TabIndex = 28;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // flowLayoutPanelDailyWeather
            // 
            this.flowLayoutPanelDailyWeather.Location = new System.Drawing.Point(64, 336);
            this.flowLayoutPanelDailyWeather.Name = "flowLayoutPanelDailyWeather";
            this.flowLayoutPanelDailyWeather.Size = new System.Drawing.Size(708, 105);
            this.flowLayoutPanelDailyWeather.TabIndex = 29;
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(633, 11);
            this.labelDateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(35, 13);
            this.labelDateTime.TabIndex = 2;
            this.labelDateTime.Text = "label1";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountry.ForeColor = System.Drawing.Color.White;
            this.labelCountry.Location = new System.Drawing.Point(149, 157);
            this.labelCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(92, 29);
            this.labelCountry.TabIndex = 31;
            this.labelCountry.Text = "Country";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Location = new System.Drawing.Point(64, 138);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxIcon.TabIndex = 32;
            this.pictureBoxIcon.TabStop = false;
            // 
            // listViewActivities
            // 
            this.listViewActivities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitle});
            this.listViewActivities.HideSelection = false;
            this.listViewActivities.Location = new System.Drawing.Point(650, 96);
            this.listViewActivities.Name = "listViewActivities";
            this.listViewActivities.Size = new System.Drawing.Size(122, 186);
            this.listViewActivities.TabIndex = 33;
            this.listViewActivities.UseCompatibleStateImageBehavior = false;
            this.listViewActivities.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Title";
            // 
            // buttonConnectDB
            // 
            this.buttonConnectDB.Location = new System.Drawing.Point(427, 255);
            this.buttonConnectDB.Name = "buttonConnectDB";
            this.buttonConnectDB.Size = new System.Drawing.Size(146, 45);
            this.buttonConnectDB.TabIndex = 34;
            this.buttonConnectDB.Text = "Connect DB";
            this.buttonConnectDB.UseVisualStyleBackColor = true;
            this.buttonConnectDB.Click += new System.EventHandler(this.buttonConnectDB_Click);
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 558);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.tabControl1);
            this.Name = "WeatherForm";
            this.Text = "SkyView";
            this.Load += new System.EventHandler(this.WeatherForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageCurrent.ResumeLayout(false);
            this.tabPageCurrent.PerformLayout();
            this.tabPageSaved.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
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
        private System.Windows.Forms.Button buttonConnectDB;
    }
}