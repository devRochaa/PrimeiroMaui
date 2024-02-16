namespace PrimeiroMaui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txt_n1.Text);
            double n2 = Convert.ToDouble(txt_n2.Text);

            double res = n1 + n2;

            string msg = $"O resultado é: "+ res;

            DisplayAlert("Maui", msg, "Fechar");
        }
    }

}
