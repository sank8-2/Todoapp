using Project1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Project1.ViewModels
{
    public class PieSearchViewModel
    {
        public IEnumerable<Pie>? Pies { get; set; }
        public IEnumerable<SelectListItem>? Categories { get; set; } = default!;
        public string? SearchQuery { get; set; }
        public int? SearchCategory { get; set; }

    }
}
