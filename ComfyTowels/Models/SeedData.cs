using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ComfyTowels.Data;
using System;
using System.Linq;

namespace ComfyTowels.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new ComfyTowelsContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<ComfyTowelsContext>>()))
        {
            // Look for any towels.
            if (context.Towels.Any())
            {
                return;   // DB has been seeded
            }
            context.Towels.AddRange(
                new Towels
                {
                    TowelType = "Organic Towels",
                    Size = "Medium",
                    Color = "Black",
                    Price = 7
                },
                new Towels
                {
                    TowelType = "Quick Dry",
                    Size = "Small",
                    Color = "White",
                    Price = 5
                },
                new Towels
                {
                    TowelType = "Fibresoft Towels",
                    Size = "Large",
                    Color = "Grey",
                    Price = 9
                },
                new Towels
                {
                    TowelType = "Spa Organic Towels",
                    Size = "X-Large",
                    Color = "Yellow",
                    Price = 10
                },
                new Towels
                 {
                     TowelType = "Soft Turkish Cotton",
                     Size = "Medium",
                     Color = "Red",
                     Price = 14
                 },
                new Towels
                {
                    TowelType = "Marche Egypt Cotton",
                    Size = "Small",
                    Color = "Blue",
                    Price = 12
                },
                new Towels
                {
                    TowelType = "American soft",
                    Size = "Large",
                    Color = "Violet",
                    Price = 15
                },
                new Towels
                {
                    TowelType = "Linen",
                    Size = "X Large",
                    Color = "Yellow",
                    Price = 18
                },
                new Towels
                {
                    TowelType = "Rayon from Bamboo",
                    Size = "Large",
                    Color = "Grey",
                    Price = 20
                },
                new Towels
                {
                    TowelType = "Terry cloth",
                    Size = "X Large",
                    Color = "Yellow",
                    Price = 22
                }
            );
            context.SaveChanges();
        }
    }
}