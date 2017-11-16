namespace NotificationsUISample
{
    partial class TitlesDataset
    {
        public void AddNewTitlesTrackerRow(string title, string season, string country, string service, string type)
        {
            var newRow = this.TitlesTracker.NewTitlesTrackerRow();
            newRow.Title = title;
            newRow.Season = season;
            newRow.Country = country;
            newRow.Service = service;
            newRow.Type = type;
            this.TitlesTracker.AddTitlesTrackerRow(newRow);
        }

    }
}
