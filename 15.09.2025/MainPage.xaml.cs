namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        string[] items = new string[10];
        string item = "";
        int number=0;

        public MainPage()
        {
            InitializeComponent();
        }


        private void Add_Clicked(object sender, EventArgs e)
        {
            item= Entry.Text;
            items[number]= item;
            number++;
        }
    }
}
