using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BizModels.Model
{
    public class User : BaseUserBusiness
    {
        public string Id { get; set; }
        public new string Name { get; set; }
        public new string ImageUrl { get; set; }
        public UserInfo Info { get; set; } = new();


    }
    public partial class UserInfo : ObservableObject
    {
        [ObservableProperty]
        private string firstName;

        [ObservableProperty]
        private string lastName;

        [ObservableProperty]
        private DateTime birthDate;

        [ObservableProperty]
        private string region;

        [ObservableProperty]
        private string city;
    }

}
