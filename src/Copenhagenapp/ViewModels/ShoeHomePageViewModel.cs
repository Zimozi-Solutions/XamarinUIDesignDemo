using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Prism.Logging;
using Prism.Services;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Copenhagenapp.ViewModels
{
    public class SellerBuyerDialogModel
    {
        public string Type { get; set; }
        public string Message { get; set; }
        public string CreatedDate { get; set; }


    }
    /// <summary>
    /// Seller buyer template selector.
    /// </summary>
    public class SellerBuyerTemplateSelector : DataTemplateSelector
    {
        public DataTemplate SellerTemplate { get; set; }
        public DataTemplate BuyerTemplate { get; set; }
        public DataTemplate DefaultTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            //this is to return dummy template

            var retunTemplate = DefaultTemplate;

            var selectedItem = (SellerBuyerDialogModel)item;

            if (selectedItem.Type == "Buyer")
            {
                retunTemplate = BuyerTemplate;
            }

            else if (selectedItem.Type == "Seller")
            {
                retunTemplate = SellerTemplate;
            }


            return retunTemplate;

        }

    }

    /// <summary>
    /// Shoe home page view model.
    /// </summary>
    public class ShoeHomePageViewModel : ViewModelBase
    {

        public ObservableCollection<string> Shoes { get; set; }
        public ObservableCollection<SellerBuyerDialogModel> ChatList { get; set; }

        public ShoeHomePageViewModel(INavigationService navigationService, IPageDialogService pageDialogService, IDeviceService deviceService) : base(navigationService, pageDialogService, deviceService)
        {
            Shoes = new ObservableCollection<string>{
                "Shoes"
            };
            ChatList = new ObservableCollection<SellerBuyerDialogModel>
            {
                new SellerBuyerDialogModel{Type= "Seller", CreatedDate="27.09.2018 11:43 am", Message="I like Blue. Shall we be ShowMates?"},
                new SellerBuyerDialogModel{Type= "Buyer", CreatedDate="27.09.2018 11:43 am", Message="Good Idea :) My Number is +45424154"},
                 new SellerBuyerDialogModel{Type= "Seller", CreatedDate="27.09.2018 11:43 am", Message="I like Blue. Shall we be ShowMates?"},
                new SellerBuyerDialogModel{Type= "Buyer", CreatedDate="27.09.2018 11:43 am", Message="Good Idea :) My Number is +45424154"},
                 new SellerBuyerDialogModel{Type= "Seller", CreatedDate="27.09.2018 11:43 am", Message="I like Blue. Shall we be ShowMates?"},
                new SellerBuyerDialogModel{Type= "Buyer", CreatedDate="27.09.2018 11:43 am", Message="Good Idea :) My Number is +45424154"}


            };
        }
    }
}
