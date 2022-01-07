using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/* Comments on code from provided 'quiz' left unaltered if code left unaltered. */
/// <summary>
/// This part establishes some utilities
/// Was created by adding a new item --> Text File
/// </summary>
namespace World_Cities
{
	// Let's add a loading method
	public partial class Form_worldCities : Form
	{

		

		/// <summary>
		/// This method reads the file of Cities and Countries
		/// </summary>
		/// <returns>void</returns>
		private  void loadData()
		{
			// Get the filepath to the file
			// First let us get the path to bin
			string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
			// Now walk back up twice to get to the solution folder
			_filePath = Directory.GetParent(_filePath).FullName;
			_filePath = Directory.GetParent(_filePath).FullName;
			// Now add the name of the file
			_filePath += @"\City Country.txt";
			// Read each line of the file into a string array. Each element
			// of the array is one line of the file.
			rawCityCountryData = System.IO.File.ReadAllLines(_filePath);
			// Now go fill the dictionaries
			fillDictionaries();
			return;
		}

		/// <summary>
		/// Fill in the function that will fill the dictionaries
		/// </summary>
		public bool fillDictionaries()
		{
			// First, we instantiate the 2 dictionaries we will use
			// First the country dictionary
			countryOf = new Dictionary<string, string>();
			// Then the population dictionary
			populationOf = new Dictionary<string, int>();

			// Those will be the delimiters between our strings
			// The fields are separated by tabs ('\t')
			// We do not use space (' ') because of cities like "Abu Dhabi"
			char[] delimiterChars = { '\t' };
			// This will mark success or not
			bool success = true;
			// Scan the lines
			foreach (string line in rawCityCountryData)
			{
				// Now parse the line into substrings
				string[] words = line.Split(delimiterChars);
				// Get the city
				string cityString = words[1];
				// The population
				string popString = words[2];
				// The country
				string countryString = words[3];
				// Convert population string to int
				success = Int32.TryParse(popString, out int pop);
				// If this failed
				if (!success)
				{
					// Throw an execption
					throw new Exception("Bad population string:" + popString);
				}

				// Ok, we successfully read the information about 1 city
				// For now we simply skip existing cities
				if (countryOf.ContainsKey(cityString) == false)
				{
					// Update the dictionary of city/country
					countryOf.Add(cityString, countryString);
					// Update dictionary of city/population
					populationOf.Add(cityString, pop);
				}
			}
			// We made it to here. Thus success
			return success;
		}

		/* Fills Combobox for Cities. */
		public void fillListBox()
		{
			// Scan the countries dictionary and fill the 2 associated listboxes
			// This is done by scanning the KeyValuePairs 
			foreach (KeyValuePair<string, string> cityCountry in countryOf)
			{
				// From each KeyValuePair we have 
				// the city
				string city = cityCountry.Key;
				// Add it to the city combo box
				comboBox_City.Items.Add(city);
			}

			// Set the selected item to be the first one
			comboBox_City.SelectedIndex = 0;
			// Get the selected city
			string selectedCity = comboBox_City.Text;

			// and display its population
			label_Population.Text = populationOf[selectedCity].ToString("N0");

			/* Add its country as the only option shown in the Countries combobox, *
			 * and sets the display of the box to the indicated country. */
			comboBox_Country.Items.Add(countryOf[selectedCity]);
			comboBox_Country.SelectedIndex = 0;
		}


		/* Fills Combobox for Countries. */
		public void fillListBoxCountry()
		{
			/* Makes dictionary for the countries and int for loop use. */
			var countries = new Dictionary<int, string>();
			int i = 0;

			/* Foreach checks every entry in city/country dictionary and adds 1 copy of each country to new dictionary. */
			foreach (KeyValuePair<string, string> cityCountry in countryOf)
			{
				string country = cityCountry.Value;

				/* If-else checks to see if the dictionary already contains the country. */
				if (countries.ContainsValue(country))
                {
					continue;
                }else
                 {
					 countries.Add(i, country);
					 i++;
                 }
			}

			/* Foreach adds those countries to the Countries combobox while simultaniously organizing them *
			 * by alphabetical order. */
			foreach (KeyValuePair<int, string> count in countries.OrderBy(key => key.Value))
            {
				comboBox_Country.Items.Add(count.Value);
            }
		}


		/* Fills Combobox for Cities. Returns a dictionary filled with cities and population *
		 * for use in Pie Chart. Takes country variable. */
		public Dictionary<string, int> citiesOfCountry(string country)
        {
			/* Initializes variables and clears items within Cities combobox. */
			int totalPop = 0;
			string count = country;
			var cPop = new Dictionary<string, int>();

			comboBox_City.Items.Clear();

			/* Foreach handles adding cities and their population of the selected country to a new dictionary. */
			foreach (KeyValuePair<string, string> cityCountry in countryOf)
			{
				/* Checks through dictionary for if city is in provided country. */
				if (cityCountry.Value == count)
                {
					if(populationOf.ContainsKey(cityCountry.Key))
                    {
						/* Adds city and population to dictionary. */
						cPop.Add(cityCountry.Key, populationOf[cityCountry.Key]);
					}
				}
			}

			/* Foreach organizes cities of country by population in a descending order. Also sums the total population. */
			foreach (KeyValuePair<string, int> city in cPop.OrderByDescending(key => key.Value))
			{
				comboBox_City.Items.Add(city.Key);
				totalPop += city.Value;
			}
			/* Updates population label to display total population of country and returns the city/population dictionary. */
			label_Population.Text = totalPop.ToString("N0");
			return cPop;
		}
	}
}