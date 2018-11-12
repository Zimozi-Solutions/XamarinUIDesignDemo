using Xamarin.Forms.Internals;
using Xamarin.Forms;
namespace Copenhagenapp.Views
{
    public partial class ShoeHomePage
    {
        public ShoeHomePage()
        {
            InitializeComponent();

            SizeChanged += (sender, args) =>
            {
                if (Width >= 480)
                {
                    MainGrid.RowDefinitions[0].Height = new GridLength(3, GridUnitType.Star);
                    MainGrid.RowDefinitions[1].Height = new GridLength(2, GridUnitType.Star);
                    MainGrid.RowDefinitions[2].Height = new GridLength(2.5, GridUnitType.Star);
                    MainGrid.RowDefinitions[3].Height = new GridLength(2, GridUnitType.Star);
                    MainGrid.RowDefinitions[4].Height = new GridLength(1, GridUnitType.Star);

                    SubGridTitle.RowDefinitions[0].Height = new GridLength(7, GridUnitType.Star);
                    SubGridTitle.RowDefinitions[1].Height = new GridLength(1, GridUnitType.Star);
                    SubGridTitle.RowDefinitions[2].Height = new GridLength(2, GridUnitType.Star);

                    SubGridUserData.RowSpacing = 10;
                    SubGridUserData.Margin = 10;
                    SubGridUserData.ColumnDefinitions[0].Width = new GridLength(2, GridUnitType.Star);
                    SubGridUserData.ColumnDefinitions[1].Width = new GridLength(3.5, GridUnitType.Star);
                    SubGridUserData.ColumnDefinitions[2].Width = new GridLength(1, GridUnitType.Star);
                    SubGridUserData.ColumnDefinitions[3].Width = new GridLength(3.5, GridUnitType.Star);
                }
                else if (Width > 320)
                {
                    MainGrid.RowDefinitions[0].Height = new GridLength(.5, GridUnitType.Star);
                    MainGrid.RowDefinitions[1].Height = new GridLength(1, GridUnitType.Star);
                    MainGrid.RowDefinitions[2].Height = new GridLength(1, GridUnitType.Star);
                    MainGrid.RowDefinitions[3].Height = new GridLength(.5, GridUnitType.Star);
                    MainGrid.RowDefinitions[4].Height = new GridLength(1, GridUnitType.Auto);

                    SubGridTitle.RowDefinitions[0].Height = new GridLength(.5, GridUnitType.Auto);
                    SubGridTitle.RowDefinitions[1].Height = new GridLength(.5, GridUnitType.Auto);
                    SubGridTitle.RowDefinitions[2].Height = new GridLength(.5, GridUnitType.Star);

                    SubGridUserData.RowSpacing = 0;
                    SubGridUserData.Margin = 0;
                    SubGridUserData.ColumnDefinitions[0].Width = new GridLength(1, GridUnitType.Star);
                    SubGridUserData.ColumnDefinitions[1].Width = new GridLength(2.5, GridUnitType.Star);
                    SubGridUserData.ColumnDefinitions[2].Width = new GridLength(1, GridUnitType.Star);
                    SubGridUserData.ColumnDefinitions[3].Width = new GridLength(2.5, GridUnitType.Star);

                    BlueBtn.Scale = 0.8;
                    RedBtn.Scale = 0.8;
                    SendBtn.Scale = 0.8;
                }
                else
                {
                    MainGrid.RowDefinitions[0].Height = new GridLength(.5, GridUnitType.Star);
                    MainGrid.RowDefinitions[1].Height = new GridLength(1, GridUnitType.Star);
                    MainGrid.RowDefinitions[2].Height = new GridLength(.8, GridUnitType.Star);
                    MainGrid.RowDefinitions[3].Height = new GridLength(.3, GridUnitType.Star);
                    MainGrid.RowDefinitions[4].Height = new GridLength(1, GridUnitType.Auto);

                    SubGridTitle.RowDefinitions[0].Height = new GridLength(.5, GridUnitType.Auto);
                    SubGridTitle.RowDefinitions[1].Height = new GridLength(.5, GridUnitType.Auto);
                    SubGridTitle.RowDefinitions[2].Height = new GridLength(.5, GridUnitType.Star);

                    SubGridUserData.RowSpacing = 0;
                    SubGridUserData.Margin = 0;
                    SubGridUserData.ColumnDefinitions[0].Width = new GridLength(1, GridUnitType.Star);
                    SubGridUserData.ColumnDefinitions[1].Width = new GridLength(2.5, GridUnitType.Star);
                    SubGridUserData.ColumnDefinitions[2].Width = new GridLength(1, GridUnitType.Star);
                    SubGridUserData.ColumnDefinitions[3].Width = new GridLength(2.5, GridUnitType.Star);

                    BlueBtn.Scale = 0.7;
                    RedBtn.Scale = 0.7;
                    SendBtn.Scale = 0.7;
                }
            };
        }
    }
}
