using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;

namespace BindableAppBarWP.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        #region Commands
        private RelayCommand _buttonClick;
        public RelayCommand ButtonClick
        {
            get
            {
                return _buttonClick
                    ?? (_buttonClick = new RelayCommand(
                                          () =>
                                          {
                                              MessageBox.Show("AppBar Button Click!");
                                          }));
            }
        }


        private RelayCommand _menuItemclick;
        public RelayCommand MenuItemClick
        {
            get
            {
                return _menuItemclick
                    ?? (_menuItemclick = new RelayCommand(
                                          () =>
                                          {
                                              MessageBox.Show("AppBar MenuItem Click!");
                                          }));
            }
        }
        #endregion


        public MainViewModel()
        {
            
        }
    }
}