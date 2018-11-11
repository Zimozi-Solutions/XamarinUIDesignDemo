using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Prism.Logging;
using Prism.Services;

namespace Copenhagenapp.ViewModels
{
    public class TopShoesCarouselPageViewModel : ViewModelBase
    {
        public TopShoesCarouselPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService, IDeviceService deviceService) : base(navigationService, pageDialogService, deviceService)
        {
        }
    }
}
