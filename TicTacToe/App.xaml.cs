using System;

using Xamarin.Forms;

namespace TicTacToe
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            LoadStyle();

            MainPage = new GamePage();
        }

        public void LoadStyle()
        {
            var GameSquare = new Style(typeof(Button))
            {
                Setters =   {
                    new Setter { Property = Button.TextColorProperty,    Value = Color.Black },
                    new Setter { Property = Button.FontAttributesProperty,    Value = FontAttributes.Bold },
                    new Setter { Property = Button.BackgroundColorProperty,    Value = Color.YellowGreen },
                    new Setter { Property = Button.FontSizeProperty,    Value = Device.GetNamedSize(NamedSize.Large, typeof(Button)) }
                }
            };

            var GameMessage = new Style(typeof(Label))
            {
                Setters =   {
                    new Setter { Property = Label.TextColorProperty,    Value = Color.Black },
                    new Setter { Property = Label.FontAttributesProperty,    Value = FontAttributes.Bold },
                    new Setter { Property = Label.BackgroundColorProperty,    Value = Color.YellowGreen },
                    new Setter { Property = Label.FontSizeProperty,    Value = Device.GetNamedSize(NamedSize.Large, typeof(Label)) }
                }
            };

            Resources = new ResourceDictionary();
            Resources.Add("gameSquareStyle", GameSquare);
            Resources.Add("gameMessageStyle", GameMessage);
        }
    }
}
