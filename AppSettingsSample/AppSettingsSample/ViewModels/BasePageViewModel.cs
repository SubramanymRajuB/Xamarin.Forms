using System.ComponentModel;
using System.Runtime.CompilerServices;
using AppSettingsSample.Helpers;
using Xamarin.Forms;

namespace AppSettingsSample.ViewModels
{
    public class BasePageViewModel : INotifyPropertyChanged {

        public INavigation _navigation;
        public string UserName  
        {  
            get => UserSettings.UserName; 
            set{
                UserSettings.UserName = value;
                NotifyPropertyChanged("UserName");
            }
        }     

        public string Password  
        {
            get => UserSettings.Password; 
            set { 
                UserSettings.Password = value; 
                NotifyPropertyChanged("Password");
            }
        }  

        public string MobileNumber  
        {
            get => UserSettings.MobileNumber; 
            set { 
                UserSettings.MobileNumber = value; 
                NotifyPropertyChanged("MobileNumber");
            }
        } 

        #region INotifyPropertyChanged    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = ""){
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
