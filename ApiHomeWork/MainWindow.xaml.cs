using ApiHomeWork.Utils;
using System.Windows;

namespace ApiHomeWork
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AnimeAPI api = new AnimeAPI("https://animechan.vercel.app/api/");
        private JsonParser jsonParser = new JsonParser();

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Get_Random_Quote(object sender, RoutedEventArgs e)
        {
            string randomQuoteJson = await api.GetRandomQuote();
            setData(randomQuoteJson);
        }

        private async void Get_Quote_By_Character_Name(object sender, RoutedEventArgs e)
        {
            string characterJson = await api.GetQuoteByCharacterName(Query_TextBox.Text);
            setData(characterJson);
        }
        
        private async void Get_Quote_By_Anime_Name(object sender, RoutedEventArgs e)
        {
            string animeNameJson = await api.GetQuoteByName(Query_TextBox.Text);
            setData(animeNameJson);
        }

        private void setData(string json)
        {
            Anime_Title.Text = "Anime: " + jsonParser.getValueByKey(json, "anime");
            Quote.Text = "Quote: " + jsonParser.getValueByKey(json, "quote");
            Character.Text = "Character: " + jsonParser.getValueByKey(json, "character");
        }
    }
}
