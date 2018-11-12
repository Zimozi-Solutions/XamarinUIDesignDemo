using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Prism.Logging;
using Prism.Services;
using System.Collections.ObjectModel;

namespace Copenhagenapp.ViewModels
{
    public class ShoeHomeListPageViewModel : ViewModelBase
    {
        public ObservableCollection<string> Shoes { get; set; }
        public ObservableCollection<SellerBuyerDialogModel> ChatList { get; set; }

        public ShoeHomeListPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService, IDeviceService deviceService) : base(navigationService, pageDialogService, deviceService)
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
