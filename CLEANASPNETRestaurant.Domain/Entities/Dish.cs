﻿
namespace CLEANASPNETRestaurant.Domain.Entities
{
    public class Dish
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public int? CaloriesPerKilo { get; set; }
        public decimal Price { get; set; }
    }
}
