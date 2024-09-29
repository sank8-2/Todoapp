using Project1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Project1.ViewModels
{
    public class PieEditViewModel
    {
        public IEnumerable<SelectListItem>? Categories { get; set; } = default!;
        public Pie Pie { get; set; }
        //public byte[] RowVersion { get; set; }
    }
}