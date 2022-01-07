using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/* Comments on code from provided 'quiz' left unaltered if code left unaltered. */
namespace World_Cities
{

	public partial class Form_worldCities : Form
	{
		
		// This holds the raw data read from the City Country file
		private string[] rawCityCountryData = null;
		// Here we store the mapping from city to Country
		Dictionary<string, string> countryOf = null;
		// Here we store the mapping from city to population
		Dictionary<string, int> populationOf = null;

		public Form_worldCities()
		{
			// This initializes the form and all of its components
			InitializeComponent();

			// Now that the form's components have been initialized
			// We can go load the City Country data
			loadData();
			// And then we fill the combo box
			fillListBox();
		}


		/// <summary>
		/// Handle the selection of a new city event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void comboBox_City_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Get the selected city;
			string city = comboBox_City.SelectedItem.ToString();

			/* Clears country combobox, then adds whatever country of city at location 0 of dictionary. */
			comboBox_Country.Items.Clear();
			comboBox_Country.Items.Add(countryOf[city]);
			comboBox_Country.SelectedIndex = 0;
		}


		/* Handles when a new country is selected. */
		private void comboBox_Country_SelectedIndexChanged(object sender, EventArgs e)
        {
			/* Initializes dictionary for use in Pir Chart */
			var citPop = new Dictionary<string, int>();
			// Get the selected country;
			string country = comboBox_Country.SelectedItem.ToString();

			/* Assign dictionary of cities and population by invoking function citiesOfCountry() */
			citPop = citiesOfCountry(country);

			/* Initialize variables for loops. */
			int i = 0,
			num = citPop.Count();

			/* Arrays to use for Country Population Pie Chart. */
			double[] populations = new double[num];
			string[] cities = new string[num];

			/* Clear the Pie Chart of any current values. */
			chart1.Series[0].Points.Clear();

			/* Foreach populates cities array */
			foreach (KeyValuePair<string, int> pop in citPop)
            {
				populations[i] = Convert.ToDouble(pop.Value);
				cities[i] = pop.Key;
				i++;
            }

			/* Changes city displayed to biggest city by population. */
			comboBox_City.SelectedIndex = 0;

			/* For loop adds the cities and their populations to the Country Populations Pie Chart. */
			for (int j = 0; j < populations.Count(); j++)
			{
				double pop = populations[j];
				chart1.Series[0].Points.AddXY(cities[j], pop);
			}
		}


		/* Fills Countries combobox with entries when dropdown selected, as opposed to populating it when program starts. */
		private void comboBox_Country_DropDown(object sender, EventArgs e)
        {
			/* Clears all current entries from Countries combobox then repopulates it with all countries. */
			comboBox_Country.Items.Clear();
			fillListBoxCountry();
		}


		/* Changes population displayed when city choice is made, but when the list closes. */
		private void comboBox_City_DropDownClosed(object sender, EventArgs e)
        {
			string city = comboBox_City.SelectedItem.ToString();
			label_Population.Text = populationOf[city].ToString("N0");
		}


		/* Resets program to load state. */
		private void button1_Click(object sender, EventArgs e)
        {
			/* Clears Cities combobox. */
			comboBox_City.Items.Clear();

			/* Reloads Cities combobox and by extension Country combobox(the single country of city[0]. *
			 * Loads name of city[0] to display of Cities combobox. */
			fillListBox();

			/* Clears Country Population Pie Chart. */
			chart1.Series[0].Points.Clear();
		}
    }
}
