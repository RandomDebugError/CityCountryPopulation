namespace World_Cities
{
	partial class Form_worldCities
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label_City = new System.Windows.Forms.Label();
            this.label_CountryText = new System.Windows.Forms.Label();
            this.label_PopulationText = new System.Windows.Forms.Label();
            this.comboBox_City = new System.Windows.Forms.ComboBox();
            this.label_Population = new System.Windows.Forms.Label();
            this.comboBox_Country = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_City
            // 
            this.label_City.AutoSize = true;
            this.label_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_City.Location = new System.Drawing.Point(12, 46);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(86, 42);
            this.label_City.TabIndex = 1;
            this.label_City.Text = "City";
            // 
            // label_CountryText
            // 
            this.label_CountryText.AutoSize = true;
            this.label_CountryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CountryText.Location = new System.Drawing.Point(309, 46);
            this.label_CountryText.Name = "label_CountryText";
            this.label_CountryText.Size = new System.Drawing.Size(156, 42);
            this.label_CountryText.TabIndex = 2;
            this.label_CountryText.Text = "Country";
            // 
            // label_PopulationText
            // 
            this.label_PopulationText.AutoSize = true;
            this.label_PopulationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PopulationText.Location = new System.Drawing.Point(601, 46);
            this.label_PopulationText.Name = "label_PopulationText";
            this.label_PopulationText.Size = new System.Drawing.Size(205, 42);
            this.label_PopulationText.TabIndex = 3;
            this.label_PopulationText.Text = "Population";
            // 
            // comboBox_City
            // 
            this.comboBox_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_City.FormattingEnabled = true;
            this.comboBox_City.Location = new System.Drawing.Point(12, 116);
            this.comboBox_City.Name = "comboBox_City";
            this.comboBox_City.Size = new System.Drawing.Size(241, 50);
            this.comboBox_City.TabIndex = 1;
            this.comboBox_City.Text = "Abu";
            this.comboBox_City.SelectedIndexChanged += new System.EventHandler(this.comboBox_City_SelectedIndexChanged);
            this.comboBox_City.DropDownClosed += new System.EventHandler(this.comboBox_City_DropDownClosed);
            // 
            // label_Population
            // 
            this.label_Population.AutoSize = true;
            this.label_Population.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Population.Location = new System.Drawing.Point(601, 116);
            this.label_Population.Name = "label_Population";
            this.label_Population.Size = new System.Drawing.Size(315, 42);
            this.label_Population.TabIndex = 4;
            this.label_Population.Text = "0                         ";
            // 
            // comboBox_Country
            // 
            this.comboBox_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Country.FormattingEnabled = true;
            this.comboBox_Country.Location = new System.Drawing.Point(316, 116);
            this.comboBox_Country.Name = "comboBox_Country";
            this.comboBox_Country.Size = new System.Drawing.Size(209, 50);
            this.comboBox_Country.TabIndex = 8;
            this.comboBox_Country.Text = "Nigeria";
            this.comboBox_Country.DropDown += new System.EventHandler(this.comboBox_Country_DropDown);
            this.comboBox_Country.DropDownClosed += new System.EventHandler(this.comboBox_Country_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.AutoFitMinFontSize = 5;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(300, 313);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Cities";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(643, 380);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 180);
            this.button1.TabIndex = 10;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(648, 51);
            this.label1.TabIndex = 11;
            this.label1.Text = "Country Population Distribution";
            // 
            // Form_worldCities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 705);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.comboBox_Country);
            this.Controls.Add(this.label_Population);
            this.Controls.Add(this.comboBox_City);
            this.Controls.Add(this.label_PopulationText);
            this.Controls.Add(this.label_CountryText);
            this.Controls.Add(this.label_City);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_worldCities";
            this.Text = "Cities of the World";

            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label_City;
		private System.Windows.Forms.Label label_CountryText;
		private System.Windows.Forms.Label label_PopulationText;
		private System.Windows.Forms.ComboBox comboBox_City;
		private System.Windows.Forms.Label label_Population;
        private System.Windows.Forms.ComboBox comboBox_Country;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

