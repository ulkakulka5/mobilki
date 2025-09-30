using System;
using System.Collections.ObjectModel;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        
        private ObservableCollection<string> todoItems = new ObservableCollection<string>();

        public MainPage()
        {
            InitializeComponent();
            todoListView.ItemsSource = todoItems;
        }

        private void addBtn_Clicked(object sender, EventArgs e)
        {
            string newTask = todoEntry.Text;

            if (string.IsNullOrEmpty(newTask))
                return;
            else
            {
                todoItems.Add(newTask);
                todoEntry.Text = string.Empty;
            }
        }
    }
}
