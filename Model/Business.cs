using System;
namespace BizClient.Model
{
	public class Business
	{
		public Business(string name, string imageUrl)
		{
			Name = name;
			ImageUrl = imageUrl;
		}

		public String Name { get; set;}
		public String ImageUrl { get; set;}
	}
}

