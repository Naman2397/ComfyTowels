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
                    TowelType = "Type 1",
                    Size = "Medium",
                    Color = "Black",
                    Price = 7
                },
                new Towels
                {
                    TowelType = "Type 2 ",
                    Size = "Small",
                    Color = "White",
                    Price = 5
                },
                new Towels
                {
                    TowelType = "Type 3",
                    Size = "Large",
                    Color = "Grey",
                    Price = 9
                },
                new Towels
                {
                    TowelType = "Type 4",
                    Size = "X-Large",
                    Color = "Yellow",
                    Price = 10
                }
            );
            context.SaveChanges();
        }
    }
}