using System.Collections.ObjectModel;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Item> Products { get; set; }
        public MainPage()
        {
            InitializeComponent();
            Products = new ObservableCollection<Item>();
            BindingContext = this;
        }

        private void Add_Clicked(object sender, EventArgs e)
        {
            var name = addItem.Text?.Trim();
            if (string.IsNullOrEmpty(name)) return;

            addItem.Text = "";

            Item item = null;
            foreach (var p in Products)
            {
                if (string.Equals(p.Name, name, StringComparison.OrdinalIgnoreCase))
                {
                    item = p;
                    break;
                }
            }

            if (item != null)
            {
                item.Quantity++;
            }
            else
            {
                Products.Add(new Item { Name = name, Quantity = 1 });
            }
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            if (collectionview.SelectedItem is Item item)
            {
                Products.Remove(item);
            }
        }
    }
}
