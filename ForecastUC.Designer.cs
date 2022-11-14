
namespace SkyNews
{
    partial class ForecastUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxWeatherIcon = new System.Windows.Forms.PictureBox();
            this.labeldt = new System.Windows.Forms.Label();
            this.labelMainWeather = new System.Windows.Forms.Label();
            this.labelWeatherDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxWeatherIcon
            // 
            this.pictureBoxWeatherIcon.Location = new System.Drawing.Point(3, 11);
            this.pictureBoxWeatherIcon.Name = "pictureBoxWeatherIcon";
            this.pictureBoxWeatherIcon.Size = new System.Drawing.Size(89, 90);
            this.pictureBoxWeatherIcon.TabIndex = 0;
            this.pictureBoxWeatherIcon.TabStop = false;
            // 
            // labeldt
            // 
            this.labeldt.AutoSize = true;
            this.labeldt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldt.Location = new System.Drawing.Point(98, 19);
            this.labeldt.Name = "labeldt";
            this.labeldt.Size = new System.Drawing.Size(80, 25);
            this.labeldt.TabIndex = 1;
            this.labeldt.Text = "Sunday";
            // 
            // labelMainWeather
            // 
            this.labelMainWeather.AutoSize = true;
            this.labelMainWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainWeather.Location = new System.Drawing.Point(98, 44);
            this.labelMainWeather.Name = "labelMainWeather";
            this.labelMainWeather.Size = new System.Drawing.Size(59, 25);
            this.labelMainWeather.TabIndex = 2;
            this.labelMainWeather.Text = "Clear";
            // 
            // labelWeatherDescription
            // 
            this.labelWeatherDescription.AutoSize = true;
            this.labelWeatherDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeatherDescription.Location = new System.Drawing.Point(98, 69);
            this.labelWeatherDescription.Name = "labelWeatherDescription";
            this.labelWeatherDescription.Size = new System.Drawing.Size(109, 25);
            this.labelWeatherDescription.TabIndex = 3;
            this.labelWeatherDescription.Text = "Description";
            // 
            // ForecastUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelWeatherDescription);
            this.Controls.Add(this.labelMainWeather);
            this.Controls.Add(this.labeldt);
            this.Controls.Add(this.pictureBoxWeatherIcon);
            this.Name = "ForecastUC";
            this.Size = new System.Drawing.Size(580, 113);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBoxWeatherIcon;
        public System.Windows.Forms.Label labeldt;
        public System.Windows.Forms.Label labelMainWeather;
        public System.Windows.Forms.Label labelWeatherDescription;
    }
}
