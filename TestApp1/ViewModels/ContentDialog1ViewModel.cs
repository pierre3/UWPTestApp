using TestApp1.Mvvm;

namespace TestApp1.ViewModels
{
    class ContentDialog1ViewModel
    {
        public DelegateCommand TestCommand { get; }

        public ContentDialog1ViewModel()
        {
             TestCommand = new DelegateCommand(_ => Execute());
        }

        public void Execute()
        {
            System.Diagnostics.Debug.WriteLine("Done!");
        }
    }

   
}
