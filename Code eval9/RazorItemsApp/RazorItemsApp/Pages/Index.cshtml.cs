using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorItemsApp.Models;
public class IndexModel : PageModel
{
    public static List<Item> ItemList = new List<Item>();

    public List<Item> Items { get; set; }

    public void OnGet()
    {
        Items = ItemList;
    }
}