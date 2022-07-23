public static class Mocks
{
    public static Business[] businesses = new[] {
        new Business("1","1","Pizzi-Pizza","Pizzi-Pizza is a new player in the restaurant industry.  The restaurant is in a comfortable, familiar, small town that has a strong need for additional dining options. ", "https://img.freepik.com/premium-vector/pizza-logo-design_9845-319.jpg?w=1480", "Israel", "Tel-Aviv","Dizingof 142", "037322821", "pizzi@gmail.com"),
        new Business("2","1","BurgerPlace","", "https://img.freepik.com/premium-vector/burger-logo-template_441059-21.jpg?w=2000", "Israel", "Tel-Aviv","Dizingof 142", "037322821", "pizzi@gmail.com"),
        new Business("3","1","Phone4You","", "https://previews.123rf.com/images/krustovin/krustovin1905/krustovin190500061/122378999-creative-colorful-smartphone-logo-design-concept.jpg", "Israel", "Tel-Aviv","Dizingof 142", "037322821", "pizzi@gmail.com"),
        };
    public static Post[] posts = new[] {
        new Post(new PostResponse("1","1","Have a good weekend!!!!","1","1","https://image.shutterstock.com/image-photo/fresh-homemade-italian-pizza-margherita-600w-1829205563.jpg", DateTime.Now),Mocks.businesses[0].Name, Mocks.businesses[0].ImageUrl),
        new Post(new PostResponse("6","2","Looking Good","1","1","https://images.unsplash.com/photo-1550547660-d9450f859349?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1365&q=80", DateTime.Now), Mocks.businesses[1].Name, Mocks.businesses[1].ImageUrl),
        new Post(new PostResponse("7","3","Last offer!!!","1","1","https://scontent.fhfa1-1.fna.fbcdn.net/v/t39.30808-6/274620132_5000181176684874_4100867682596187444_n.jpg?_nc_cat=101&ccb=1-7&_nc_sid=730e14&_nc_ohc=ugUcxvP8TcIAX8h-n-k&_nc_ht=scontent.fhfa1-1.fna&oh=00_AT8fgVaeoIv0Lu4byCmTa-myT7hpsXy70NQW1e3vJdpATQ&oe=62D22FE5", DateTime.Now), Mocks.businesses[2].Name, Mocks.businesses[2].ImageUrl),
        new Post(new PostResponse("4","2","Welcome :)","1","1","https://images.unsplash.com/photo-1530554764233-e79e16c91d08?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=987&q=80", DateTime.Now), Mocks.businesses[1].Name, Mocks.businesses[1].ImageUrl),
        new Post(new PostResponse("2","1","Visit us!!!!","1","1","https://image.shutterstock.com/image-photo/fresh-italian-pizza-tomato-mozzarella-600w-1705657663.jpg", DateTime.Now), Mocks.businesses[0].Name, Mocks.businesses[0].ImageUrl),
        new Post(new PostResponse("5","2","Yummy in my tammy","1","1","https://images.unsplash.com/photo-1607013251379-e6eecfffe234?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=987&q=80", DateTime.Now), Mocks.businesses[1].Name, Mocks.businesses[1].ImageUrl),
        new Post(new PostResponse("3","1","A special offer!!!!","1","1","https://image.shutterstock.com/image-photo/hot-italian-pizza-mozzarella-cherry-600w-619545302.jpg", DateTime.Now), Mocks.businesses[0].Name, Mocks.businesses[0].ImageUrl),
        };

    public static Coupon[] coupons = new[] {
        new Coupon(new CouponResponse("1", Mocks.businesses[1].Name, Mocks.businesses[1].ImageUrl, "30 NIS OFF !",DateTime.Now, DateTime.Now.AddDays(30),CouponStatus.available, false)),
        new Coupon(new CouponResponse("2", Mocks.businesses[0].Name, Mocks.businesses[0].ImageUrl, "Buy 2 Get 1 :)",DateTime.Now, DateTime.Now.AddDays(13),CouponStatus.redeemed, true)),
        new Coupon(new CouponResponse("3", Mocks.businesses[2].Name, Mocks.businesses[2].ImageUrl, "Buy Phone Get screen warranty",DateTime.Now, DateTime.Now.AddDays(14),CouponStatus.available, false)),
    };

    public static Subscription[] subscriptions = new[]
    {
        new Subscription(new SubscriptionResponse("111", "1", DateTime.Now)),
        new Subscription(new SubscriptionResponse("111", "2", DateTime.Now)),
        new Subscription(new SubscriptionResponse("111", "3", DateTime.Now)),
    };

    public static User user = new User("111", "Yossi", "Cohen", "now", "israel", "tel-aviv");

    public static Chat[] chats = new[]
    {
        new Chat(new ChatResponse("1", "111", "1", DateTime.Now)),
        new Chat(new ChatResponse("2", "111", "2", DateTime.Now)),
    };

    public static MessageResponse[] messages = new[]
    {
        new MessageResponse("1", "1", "111", "Hello", DateTime.Now),
        new MessageResponse("2", "1", "1", "Hey how are you?", DateTime.Now),
        new MessageResponse("3", "2", "2", "Welcome", DateTime.Now),
    };
}