namespace MatchGame4838081
{
    ///<Summary>
    ///<Createddate>29/05/2024</createddate>
    ///<company></company>
    ///<lastmodificationdate>02/06/2024</lastmodificationdate>
    ///<lastmodificationdescription>
    ///
    ///</lastmodificationdescription>
    ///<lastmodifierautor>Jasson Navarro</lastmodifierautor>
    ///</Summary>
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();

            SetUpGame();
        }

        Button ultimoButtonCliked;
        bool encontradoMatch = false;
        private void Button_Clicked(object sender, EventArgs e)
        {
           

            Button button = sender as Button;
            if (encontradoMatch == false)
            {
                button.IsVisible = false;
                ultimoButtonCliked = button;
                encontradoMatch = true;
            }
            else if (button.Text == ultimoButtonCliked.Text)
            {
                button.IsVisible = false;
                encontradoMatch = false;
            }
            else
            {
                ultimoButtonCliked.IsVisible = true;
                encontradoMatch = false;
            }
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
            "🐶","🐶",
            "🐵","🐵",
            "🐙","🐙",
            "🐘","🐘",
            "🦓","🦓",
            "🦒","🦒",
            "🦆","🦆",
            "🐬","🐬",
            };

            Random ramdom = new Random();
            foreach (Button view in Grid1.Children)
            {
                int index = ramdom.Next(animalEmoji.Count);
                string nextEmoji = animalEmoji[index];
                view.Text = nextEmoji;
                animalEmoji.RemoveAt(index);
            }
            
        }
    }

}
