using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ComfyTowels.Models;

public class TowelColorViewModel
{
    public List<Towels>? Towels { get; set; }
    public SelectList? TowelType { get; set; }
    public string? TowelColor { get; set; }
    public string? SearchString { get; set; }
}
