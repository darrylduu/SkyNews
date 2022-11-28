
namespace SkyNews
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.labelActivities = new System.Windows.Forms.Label();
            this.listViewActivities = new System.Windows.Forms.ListView();
            this.columnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureIcon = new System.Windows.Forms.PictureBox();
            this.labelPressure = new System.Windows.Forms.Label();
            this.labelWindspeed = new System.Windows.Forms.Label();
            this.labelPressure2 = new System.Windows.Forms.Label();
            this.labelWind = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.labelCondition = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelSearchForCity = new System.Windows.Forms.Label();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(860, 536);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxCity);
            this.tabPage1.Controls.Add(this.flowLayoutPanel);
            this.tabPage1.Controls.Add(this.labelActivities);
            this.tabPage1.Controls.Add(this.listViewActivities);
            this.tabPage1.Controls.Add(this.pictureIcon);
            this.tabPage1.Controls.Add(this.labelPressure);
            this.tabPage1.Controls.Add(this.labelWindspeed);
            this.tabPage1.Controls.Add(this.labelPressure2);
            this.tabPage1.Controls.Add(this.labelWind);
            this.tabPage1.Controls.Add(this.labelCountry);
            this.tabPage1.Controls.Add(this.labelTemp);
            this.tabPage1.Controls.Add(this.labelDetails);
            this.tabPage1.Controls.Add(this.labelCondition);
            this.tabPage1.Controls.Add(this.buttonSearch);
            this.tabPage1.Controls.Add(this.labelSearchForCity);
            this.tabPage1.Controls.Add(this.pictureBoxBackground);
            this.tabPage1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(852, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Current Location";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(47, 80);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(346, 23);
            this.textBoxCity.TabIndex = 20;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(39, 360);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(777, 108);
            this.flowLayoutPanel.TabIndex = 18;
            // 
            // labelActivities
            // 
            this.labelActivities.AutoSize = true;
            this.labelActivities.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActivities.ForeColor = System.Drawing.Color.White;
            this.labelActivities.Location = new System.Drawing.Point(664, 54);
            this.labelActivities.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelActivities.Name = "labelActivities";
            this.labelActivities.Size = new System.Drawing.Size(81, 23);
            this.labelActivities.TabIndex = 17;
            this.labelActivities.Text = "Activities";
            // 
            // listViewActivities
            // 
            this.listViewActivities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTitle,
            this.columnDescription,
            this.columnLink});
            this.listViewActivities.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewActivities.HideSelection = false;
            this.listViewActivities.Location = new System.Drawing.Point(663, 80);
            this.listViewActivities.Name = "listViewActivities";
            this.listViewActivities.Size = new System.Drawing.Size(153, 221);
            this.listViewActivities.TabIndex = 16;
            this.listViewActivities.UseCompatibleStateImageBehavior = false;
            this.listViewActivities.View = System.Windows.Forms.View.Details;
            // 
            // columnTitle
            // 
            this.columnTitle.Text = "Title";
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "Description";
            // 
            // columnLink
            // 
            this.columnLink.Text = "Link";
            // 
            // pictureIcon
            // 
            this.pictureIcon.Location = new System.Drawing.Point(47, 114);
            this.pictureIcon.Margin = new System.Windows.Forms.Padding(2);
            this.pictureIcon.Name = "pictureIcon";
            this.pictureIcon.Size = new System.Drawing.Size(59, 52);
            this.pictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureIcon.TabIndex = 13;
            this.pictureIcon.TabStop = false;
            // 
            // labelPressure
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPressure.ForeColor = System.Drawing.Color.White;
            this.labelPressure.Location = new System.Drawing.Point(363, 207);
            this.labelPressure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(30, 17);
            this.labelPressure.TabIndex = 12;
            this.labelPressure.Text = "N/A";
            // 
            // labelWindspeed
            // 
            this.labelWindspeed.AutoSize = true;
            this.labelWindspeed.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindspeed.ForeColor = System.Drawing.Color.White;
            this.labelWindspeed.Location = new System.Drawing.Point(363, 179);
            this.labelWindspeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWindspeed.Name = "labelWindspeed";
            this.labelWindspeed.Size = new System.Drawing.Size(30, 17);
            this.labelWindspeed.TabIndex = 11;
            this.labelWindspeed.Text = "N/A";
            this.labelWindspeed.Click += new System.EventHandler(this.label9_Click);
            // 
            // labelPressure2
            // 
            this.labelPressure2.AutoSize = true;
            this.labelPressure2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPressure2.ForeColor = System.Drawing.Color.White;
            this.labelPressure2.Location = new System.Drawing.Point(282, 207);
            this.labelPressure2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPressure2.Name = "labelPressure2";
            this.labelPressure2.Size = new System.Drawing.Size(60, 17);
            this.labelPressure2.TabIndex = 10;
            this.labelPressure2.Text = "Pressure:";
            // 
            // labelWind
            // 
            this.labelWind.AutoSize = true;
            this.labelWind.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWind.ForeColor = System.Drawing.Color.White;
            this.labelWind.Location = new System.Drawing.Point(282, 179);
            this.labelWind.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWind.Name = "labelWind";
            this.labelWind.Size = new System.Drawing.Size(78, 17);
            this.labelWind.TabIndex = 9;
            this.labelWind.Text = "Wind Speed:";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountry.ForeColor = System.Drawing.Color.White;
            this.labelCountry.Location = new System.Drawing.Point(125, 123);
            this.labelCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(92, 29);
            this.labelCountry.TabIndex = 6;
            this.labelCountry.Text = "Country";
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemp.ForeColor = System.Drawing.Color.White;
            this.labelTemp.Location = new System.Drawing.Point(48, 239);
            this.labelTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(82, 17);
            this.labelTemp.TabIndex = 5;
            this.labelTemp.Text = "Temperature";
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetails.ForeColor = System.Drawing.Color.White;
            this.labelDetails.Location = new System.Drawing.Point(48, 209);
            this.labelDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(47, 17);
            this.labelDetails.TabIndex = 4;
            this.labelDetails.Text = "Details";
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCondition.ForeColor = System.Drawing.Color.White;
            this.labelCondition.Location = new System.Drawing.Point(48, 179);
            this.labelCondition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(61, 17);
            this.labelCondition.TabIndex = 3;
            this.labelCondition.Text = "Condition";
            this.labelCondition.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(406, 80);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(85, 25);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelSearchForCity
            // 
            this.labelSearchForCity.AutoSize = true;
            this.labelSearchForCity.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchForCity.ForeColor = System.Drawing.Color.White;
            this.labelSearchForCity.Location = new System.Drawing.Point(46, 48);
            this.labelSearchForCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSearchForCity.Name = "labelSearchForCity";
            this.labelSearchForCity.Size = new System.Drawing.Size(122, 23);
            this.labelSearchForCity.TabIndex = 0;
            this.labelSearchForCity.Text = "Search for City";
            this.labelSearchForCity.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.BackgroundImage = global::SkyNews.Properties.Resources.backgroundForm_03;
            this.pictureBoxBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(852, 509);
            this.pictureBoxBackground.TabIndex = 19;
            this.pictureBoxBackground.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(852, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Saved";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SkyNews.Properties.Resources.backgroundForm_03;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(852, 509);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(675, 11);
            this.labelDateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(35, 13);
            this.labelDateTime.TabIndex = 1;
            this.labelDateTime.Text = "label1";
            this.labelDateTime.Click += new System.EventHandler(this.labelDateTime_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 558);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkyView";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label labelSearchForCity;
        private System.Windows.Forms.Label labelPressure;
        private System.Windows.Forms.Label labelWindspeed;
        private System.Windows.Forms.Label labelPressure2;
        private System.Windows.Forms.Label labelWind;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.PictureBox pictureIcon;
        private System.Windows.Forms.Label labelActivities;
        private System.Windows.Forms.ListView listViewActivities;
        private System.Windows.Forms.ColumnHeader columnTitle;
        private System.Windows.Forms.ColumnHeader columnDescription;
        private System.Windows.Forms.ColumnHeader columnLink;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxCity;
    }
}

