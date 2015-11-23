using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RestaurantManager.Models
{
    public abstract class DataManager : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;
        protected RestaurantContext Repository { get; private set; }

        public DataManager() {
            LoadData();
        } // end DataManager()



        private async void LoadData() {
            this.Repository = new RestaurantContext();
            await this.Repository.InitializeContextAsync();
            OnDataLoaded();
        } // end LoadData()

        protected abstract void OnDataLoaded();

        public void OnPropertyChanged([CallerMemberName]string propName = null) {
            if (PropertyChanged != null) {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            } // end if (PropertyChanged != null) 

        } // end OnPropertyChanged



    } // end class
} // end namespace
