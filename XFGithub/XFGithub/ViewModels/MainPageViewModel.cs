using Prism.Commands;
using Prism.Navigation;
using System.Collections.ObjectModel;

namespace XFGithub.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand<Sample> FileEditPopupCommand { get; private set; }

        private ObservableCollection<Sample> _samples;
        public ObservableCollection<Sample> Samples
        {
            get { return _samples; }
            set { SetProperty(ref _samples, value); }
        }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

            FileEditPopupCommand = new DelegateCommand<Sample>(FileEditPopup);
        }

        private void FileEditPopup(Sample file)
        {
            //await _navigationService.NavigateAsync("PhotoEditPopup", ("NewUploadParameter", file));
        }

        public override void Initialize(INavigationParameters parameters)
        {
            Samples = new ObservableCollection<Sample>()
            {
                new Sample() { Id = 1, Description = "Ford" },
                new Sample() { Id = 2, Description = "Volkswagen" },
                new Sample() { Id = 3, Description = "Toyota" },
                new Sample() { Id = 4, Description = "Tesla" },
                new Sample() { Id = 5, Description = "Lexus" },
            };
        }
    }
}
