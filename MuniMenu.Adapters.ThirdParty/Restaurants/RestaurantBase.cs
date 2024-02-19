﻿using MuniMenu.Core.Entities;
using MuniMenu.Domain.Entities;

namespace MuniMenu.Adapters.ThirdParty.Restaurants
{
    internal abstract class RestaurantBase : Domain.Contracts.IRestaurant
    {
        public RestaurantType Type { get; }

        public RestaurantBase(RestaurantType restaurantType) => Type = restaurantType;

        public async Task<Restaurant> GetInfoAsync(CancellationToken cancellationToken)
        {
            try
            {
                return await GetInfoCoreAsync(cancellationToken);
            }
            catch (Exception)
            {
                //Log
                return Restaurant.Create(Type, Menu.Empty);
            }
        }

        protected abstract Task<Restaurant> GetInfoCoreAsync(CancellationToken cancellationToken);


    }
}
