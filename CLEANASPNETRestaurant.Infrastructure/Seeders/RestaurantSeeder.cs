
using CLEANASPNETRestaurant.Infrastructure.Persistence;
using CLEANASPNETRestaurant.Domain.Entities;
using CLEANASPNETRestaurant.Infrastructure.Repositories;

namespace CLEANASPNETRestaurant.Infrastructure.Seeders
{
    internal class RestaurantSeeder(IUnitOfWorkRestaurant context)
    {

        public async Task Seed()
        {
            if(await context.GetContext().Database.CanConnectAsync())
            {
                if (!context.Repository<Restaurant>().Read().Any())
                {
                    var newRestaurants = GetRestaurants();
                    await context.Repository<Restaurant>().AddRangeAsync(newRestaurants);
                }
            }
        }

        private IEnumerable<Restaurant> GetRestaurants()
        {
            var restaurants = new List<Restaurant>
            {
                new Restaurant
                {
                    Name = "KFC",
                    Address = new Address
                    {
                        City = "City 1",
                        Street = "Street 1",
                        ZipCode = "ZipCode 1"
                    },
                    Dishes = new List<Dish>
                    {
                        new Dish
                        {
                            Name = "Chiken Wings (Small)",
                            Price = 10
                        },
                        new Dish
                        {
                            Name = "Chiken Wings (Large)",
                            Price = 20
                        }
                    }
                },
                new Restaurant
                {
                    Name = "Mc Donalds",
                    Address = new Address
                    {
                        City = "City 2",
                        Street = "Street 2",
                        ZipCode = "ZipCode 2"
                    },
                    Dishes = new List<Dish>
                    {
                        new Dish
                        {
                            Name = "Big Mac (With Small SOda)",
                            Price = 30
                        },
                        new Dish
                        {
                            Name = "Big Mac (With Large SOda)",
                            Price = 40
                        }
                    }
                }
            };

            return restaurants;
        }
    }
}
