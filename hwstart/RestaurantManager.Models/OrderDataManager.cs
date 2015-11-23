using System.Collections.Generic;

namespace RestaurantManager.Models
{
    public class OrderDataManager : DataManager
    {    
        private List<MenuItem> menuItems;        
        private List<MenuItem> currentlySelectedMenuItems;   
        
        public List<MenuItem> MenuItems {
            get { return this.menuItems; }
            set {
                this.menuItems = value;
                this.OnPropertyChanged();
            } // end set
        } // end List<MenuItem> MenuItems

        public List<MenuItem> CurrentlySelectedMenuItems
        {
            get { return this.currentlySelectedMenuItems; }
            set {
                this.currentlySelectedMenuItems = value;
                this.OnPropertyChanged();
            } // end set
        } // end List<MenuItem> CurrentlySelectedMenuItems


        protected override void OnDataLoaded() {
            this.MenuItems = base.Repository.StandardMenuItems;

            this.CurrentlySelectedMenuItems = new List<MenuItem> {
                this.MenuItems[3],
                this.MenuItems[5]
            };
        } // end void OnDataLoaded()


    } // end class 
}// end namespace
