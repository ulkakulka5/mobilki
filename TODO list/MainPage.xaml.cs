using System;
using System.Collections.ObjectModel;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {

        public ObservableCollection<string> TodoItems { get; set; }

        public MainPage()
        {
            InitializeComponent();
            TodoItems = new ObservableCollection<string>();
            BindingContext = this;
        }

        private void addBtn_Clicked(object sender, EventArgs e)
        {
            string newTask = todoEntry.Text;

            if (string.IsNullOrEmpty(newTask))
                return;
            else
            {
                TodoItems.Add(newTask);
                Console.WriteLine(newTask);
                todoEntry.Text = string.Empty;
            }
        }
    }
}
