using LinqLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Person> people = ListManager.LoadSampleData();
        public Dashboard()
        {
            InitializeComponent();

            InitializeBindings();
        }

        private void InitializeBindings()
        {
            peopleComboBox.DataSource = people;
            peopleComboBox.DisplayMember = "FullName";

            peopleListBox.DataSource = people.Where(x => x.YearsExperience >= 5).OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();
            peopleListBox.DisplayMember = "FullName";
        }

        private void UpdateBindings()
        {
            peopleListBox.DataSource = people.Where(x => x.YearsExperience >= 5).OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();
        }

        private void peopleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person selectedPerson = (Person)peopleComboBox.SelectedItem;

            yearsExperiencePicker.Value = selectedPerson.YearsExperience;
        }


        private void update_button_Click(object sender, EventArgs e)
        {
            Person selectedPerson = (Person)peopleComboBox.SelectedItem;

            selectedPerson.YearsExperience = Convert.ToInt32(yearsExperiencePicker.Value);

            UpdateBindings();
        }
    }
}
