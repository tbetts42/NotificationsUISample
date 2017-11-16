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
        const string ANY_TYPE = "Any Type";

        private string SelectedTitle => titlesComboBox.SelectedItem?.ToString();

        public Form1()
        {
            InitializeComponent();
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            _sampleTitlesDataset = GetSampleTitlesDataset();
            LoadTitlesDropdown();
            LoadEvents();
        }

        private void LoadTitlesDropdown()
        {
            titlesComboBox.Items.Clear();
            titlesComboBox.Items.Add(ANY_TITLE);
            titlesComboBox.Items.AddRange(GetDistinctTitles().ToArray());
        }

        private void LoadEvents()
        {
            List<string> events = GetEvents();

            eventsComboBox.Items.Clear();
            eventsComboBox.Items.AddRange(events.ToArray());
        }

        private static List<string> GetEvents()
        {
            var events = new List<string>
            {
                "becomes available",
                "is no longer available",
                "availability changes to",
                "costs more than",
                "costs less than",
                "price decreased",
                "price increased"
            };
            return events;
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
            UpdateResultTextBox();
        }

        private void UpdateResultTextBox()
        {
            resultTextBox.Text = CalculateResultMessage();

        }

        string CalculateResultMessage()
        {
            if (string.IsNullOrEmpty(SelectedTitle))
            {
                return string.Empty;
            }

            StringBuilder result = new StringBuilder();
            result.Append("Notify me when ");
            result.Append(SelectedTitle);

            result.Append(GetSeasonQualifier());

            // TODO: handle different events
            result.Append($" {GetEventPhrase()}");

            result.Append($" on {GetServiceQualifier()}");

            return result.ToString();
        }

        private string GetEventPhrase()
        {
            if (eventsComboBox.SelectedItem == null)
            {
                return string.Empty;
            }

            return eventsComboBox.SelectedItem.ToString();
        }

        private string GetServiceQualifier()
        {
            var service = serviceComboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(service))
            {
                service = ANY_SERVICE;
            }

            return service;
        }

        private string GetSeasonQualifier()
        {
            string seasonQualifier;
            var selectedSeason = seasonComboBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedSeason) ||
                selectedSeason == ANY_SEASON)
            {
                seasonQualifier = $", {ANY_SEASON}";
            }
            else
            {
                seasonQualifier = $", season {selectedSeason}";
            }

            return seasonQualifier;
        }

        private void UpdateUIAfterTitleSelected()
        {
            // We could clear everything, but let's do this one step at a time
            UpdateAndShowSeasonPanel();
            UpdateAndShowAvailabilityGroupBox();
            UpdateAndShowEventGroupBox();

        }

        void UpdateAndShowSeasonPanel()
        {
            UpdateSeasonComboBox();
            seasonPanel.Enabled = true;
        }

        void UpdateSeasonComboBox()
        {
            IEnumerable<string> seasons;
            if (SelectedTitle== ANY_TITLE)
            {
                seasons = _sampleTitlesDataset.TitlesTracker.Select(t => t.Season).Distinct();
            }
            else
            {
                seasons = _sampleTitlesDataset.TitlesTracker.Where(t => t.Title == SelectedTitle).Select(t => t.Season).Distinct();
            }
            seasonComboBox.Items.Clear();
            seasonComboBox.Items.Add(ANY_SEASON);
            seasonComboBox.Items.AddRange(seasons.ToArray());
        }

        void UpdateAndShowAvailabilityGroupBox()
        {
            UpdateServiceComboBox();
            UpdateTypeComboBox();
            availabilityGroupBox.Enabled = true;
        }

        private void UpdateServiceComboBox()
        {
            IEnumerable<string> services;
            if (SelectedTitle== ANY_TITLE)
            {
                services = _sampleTitlesDataset.TitlesTracker.Select(t => t.Service).Distinct();
            }
            else
            {
                services = _sampleTitlesDataset.TitlesTracker.Where(t => t.Title == SelectedTitle).Select(t => t.Service).Distinct();
            }
            serviceComboBox.Items.Clear();
            serviceComboBox.Items.Add(ANY_SERVICE);
            serviceComboBox.Items.AddRange(services.ToArray());
        }

        private void UpdateTypeComboBox()
        {
            IEnumerable<string> type;
            if (SelectedTitle== ANY_TITLE)
            {
                type = _sampleTitlesDataset.TitlesTracker.Select(t => t.Type).Distinct();
            }
            else
            {
                type = _sampleTitlesDataset.TitlesTracker.Where(t => t.Title == SelectedTitle).Select(t => t.Type).Distinct();
            }
            typeComboBox.Items.Clear();
            typeComboBox.Items.Add(ANY_TYPE);
            typeComboBox.Items.AddRange(type.ToArray());
        }

        void UpdateAndShowEventGroupBox()
        {
            eventGroupBox.Enabled = true;
        }

        private void seasonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateResultTextBox();

        }

        private void serviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateResultTextBox();

        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateResultTextBox();

        }

        private void eventsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateResultTextBox();

        }

        private void secondServiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateResultTextBox();

        }

        private void secondTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateResultTextBox();

        }
    }
}
