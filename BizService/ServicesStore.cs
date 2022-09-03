using System;
using BizService.Services;

namespace BizService
{
    public class ServicesStore
    {
        public AuthService AuthService { get; } = new();
        public UserService UserService { get; } = new();
        public PostService PostService { get; } = new();
        public SubscriptionService SubscriptionService { get; } = new();
        public BusinessService BusinessService { get; } = new();
        public CouponService CouponService { get; } = new();
        public ChatService ChatService { get; } = new();
        public FileService FileService { get; } = new();
        public DiscountService DiscountService { get; } = new();
    }
}

