namespace czcionki
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        public List<string> Items { get; set; } = new() { "Dzień dobry", "Good morning", "Buenos Dias" };


        private void OnCounterClicked(object? sender, EventArgs e)
        {

        }
    }
}
