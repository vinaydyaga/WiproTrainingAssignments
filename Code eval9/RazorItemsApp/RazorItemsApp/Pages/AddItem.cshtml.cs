using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorItemsApp.Models;

namespace RazorItemsApp.Pages
{
    public class AddItemModel : PageModel
    {
        [BindProperty]
        public Item NewItem { get; set; }

        public IActionResult OnPost()
        {
            IndexModel.ItemList.Add(NewItem);

            return RedirectToPage("Index");
        }
    }
}