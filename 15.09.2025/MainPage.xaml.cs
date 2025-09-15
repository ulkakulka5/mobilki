namespace MauiApp2
{
    using System.Collections.ObjectModel;

    public partial class MainPage : ContentPage
    {
        ObservableCollection<string> items = new ObservableCollection<string>();

        public MainPage()
        {
            InitializeComponent();
            itemlist.ItemsSource = items;
        }

        private void Add_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Entryitem.Text))
            {
                items.Add(Entryitem.Text);
                Entryitem.Text = string.Empty;
            }
        }
    }
}
