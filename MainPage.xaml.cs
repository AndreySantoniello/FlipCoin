namespace FlipCoin
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            picker.SelectedIndex = 0;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Random rand = new Random();

            if (rand.Next(0,3) == 1)
            {
                result.Text = ((String)picker.SelectedItem == "Cara") ? "Você venceu!" : "Você perdeu!";
                coin.Source = ImageSource.FromFile("cara.jpg");
            }else
            {
                result.Text = ((String)picker.SelectedItem == "Coroa") ? "Você venceu!" : "Você perdeu!";
                coin.Source = ImageSource.FromFile("coroa.jpg");
            }
        }
    }

}
