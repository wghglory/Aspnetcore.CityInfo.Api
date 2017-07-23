﻿using System.Collections.Generic;
using System.Linq;
using Aspnetcore.CityInfo.Api.Entities;

namespace Aspnetcore.CityInfo.Api.Entities
{
    public static class AppDbContextExtensions
    {
        public static void Seed(this AppDbContext context)
        {
            if (context.Cities.Any())
            {
                return;
            }

            // init seed data
            var cities = new List<City>()
            {
                new City()
                {
                    Name = "New York City",
                    Description = "The one with that big park.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Central Park",
                            Description = "The most visited urban park in the United States."
                        },
                        new PointOfInterest()
                        {
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper located in Midtown Manhattan."
                        },
                        new PointOfInterest()
                        {
                            Name = "Statue of Liberty",
                            Description =
                                "The Statue of Liberty is a colossal neoclassical sculpture on Liberty Island in New York Harbor in New York City, in the United States."
                        }
                    }
                },
                new City()
                {
                    Name = "Antwerp",
                    Description = "The one with the cathedral that was never really finished.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Cathedral",
                            Description = "A Gothic style cathedral, conceived by architects Jan and Pieter Appelmans."
                        },
                        new PointOfInterest()
                        {
                            Name = "Antwerp Central Station",
                            Description = "The the finest example of railway architecture in Belgium."
                        },
                    }
                },
                new City()
                {
                    Name = "Paris",
                    Description = "The one with that big tower.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Eiffel Tower",
                            Description =
                                "A wrought iron lattice tower on the Champ de Mars, named after engineer Gustave Eiffel."
                        },
                        new PointOfInterest()
                        {
                            Name = "The Louvre",
                            Description = "The world's largest museum."
                        },
                    }
                }
            };

            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}