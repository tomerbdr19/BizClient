using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BizModels.Model
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public UserInfo Info { get; set; } = new();


    }
    public partial class UserInfo : ObservableObject
    {
        [ObservableProperty]
        private string firstName;

        [ObservableProperty]
        private string lastName;

        [ObservableProperty]
        private string birthDate;

        [ObservableProperty]
        private string region;

        [ObservableProperty]
        private string city;
    }

}
