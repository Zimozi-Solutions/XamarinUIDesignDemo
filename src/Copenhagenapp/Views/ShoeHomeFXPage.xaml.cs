using Xamarin.Forms;

namespace Copenhagenapp.Views
{
    public partial class ShoeHomeFXPage
    {
        public ShoeHomeFXPage()
        {
            InitializeComponent();
            SizeChanged += (sender, args) =>
            {
                //string visualState = Width > Height ? "Landscape" : "Portrait";
                //VisualStateManager.GoToState(mainStack, visualState);
                //VisualStateManager.GoToState(menuScroll, visualState);
                //VisualStateManager.GoToState(menuStack, visualState);

                //foreach (View child in menuStack.Children)
                //{
                //    VisualStateManager.GoToState(child, visualState);
                //}
            };


        }
    }
}
