using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotificationsUISample
{
    public partial class Form1 : Form
    {
        const string ANY_TITLE = "Any Title";
        const string ANY_SEASON = "Any Season";
        const string ANY_SERVICE = "Any Service";

        public Form1()
        {
            InitializeComponent();
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            _sampleTitlesDataset = GetSampleTitlesDataset();
            LoadTitlesDropdown();
        }

        private void LoadTitlesDropdown()
        {
            titlesComboBox.Items.Clear();
            titlesComboBox.Items.Add(ANY_TITLE);
            titlesComboBox.Items.AddRange(GetDistinctTitles().ToArray());
        }

        private IEnumerable<string> GetDistinctTitles()
        {
            var titles = _sampleTitlesDataset.TitlesTracker.Select(row => row.Title).Distinct();
            return titles;
        }

        private static TitlesDataset GetSampleTitlesDataset()
        {
            var titles = new TitlesDataset();
            titles.AddNewTitlesTrackerRow("Game of Thrones", "1", "UK", "Netflix", "Subscription");
            titles.AddNewTitlesTrackerRow("Game of Thrones", "1", "UK", "iTunes", "Buy");
            titles.AddNewTitlesTrackerRow("Game of Thrones", "2", "UK", "Netflix", "Subscription");
            titles.AddNewTitlesTrackerRow("Game of Thrones", "2", "UK", "iTunes", "Buy");
            return titles;
        }

        private void titlesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUIAfterTitleSelected();
        }

        private void UpdateUIAfterTitleSelected()
        {
            // We could clear everything, but let's do this one step at a time
            UpdateAndShowSeasonPanel();
            UpdateAvailabilityGroupBox();

        }

        void UpdateAndShowSeasonPanel()
        {
            UpdateSeasonComboBox();
            seasonPanel.Visible = true;
        }

        void UpdateSeasonComboBox()
        {
            IEnumerable<string> seasons;
            if (titlesComboBox.SelectedItem.ToString() == ANY_TITLE)
            {
                seasons = _sampleTitlesDataset.TitlesTracker.Select(t => t.Season).Distinct();
            }
            else
            {
                seasons = _sampleTitlesDataset.TitlesTracker.Where(t => t.Title == titlesComboBox.SelectedItem.ToString()).Select(t => t.Season).Distinct();
            }
            seasonComboBox.Items.Clear();
            seasonComboBox.Items.Add(ANY_SEASON);
            seasonComboBox.Items.AddRange(seasons.ToArray());
        }

        void UpdateAvailabilityGroupBox()
        {
            UpdateServiceComboBox();
            availabilityGroupBox.Visible = true;
        }

        private void UpdateServiceComboBox()
        {
            IEnumerable<string> services;
            if (titlesComboBox.SelectedItem.ToString() == ANY_TITLE)
            {
                services = _sampleTitlesDataset.TitlesTracker.Select(t => t.Service).Distinct();
            }
            else
            {
                services = _sampleTitlesDataset.TitlesTracker.Where(t => t.Title == titlesComboBox.SelectedItem.ToString()).Select(t => t.Service).Distinct();
            }
            serviceComboBox.Items.Clear();
            serviceComboBox.Items.Add(ANY_SERVICE);
            serviceComboBox.Items.AddRange(services.ToArray());
        }
    }
}
