using System;

namespace BizClient.Controls
{
    public class BusinessesSearchHandler : SearchHandler
    {
        // TODO: Change colors
        public BusinessesSearchHandler()
        {
            this.BackgroundColor = Color.FromHex("#FFFFFF");
            this.TextColor = Color.FromHex("#000000");
            this.CancelButtonColor = Color.FromHex("#000000");
            this.Placeholder = "Search a business";
            this.ShowsResults = false;
            this.BindingContext = this;
        }



        protected override async void OnQueryConfirmed()
        {
            base.OnQueryConfirmed();

            if (Query.Trim() == String.Empty)
            {
                return;
            }

            var businesses = await Store.ServicesStore.BusinessService.SearchBusinesses(Query);
            await Shell.Current.GoToAsync(Routes.BusinessesTab, new Dictionary<string, object> { { "BusinessesList", businesses } });
        }
    }
}