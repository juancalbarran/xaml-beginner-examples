using System.Collections.Generic;
using TemplateForListItems.Models;
using Windows.UI;

namespace TemplateForListItems.ViewModels
{
    public class ItemsViewModel
    {
        public List<Item> Items { get; set; }

        public ItemsViewModel()
        {
            Items = new List<Item>
{
    new Item { Title = "Denver", SymbolColor = Colors.Red },
    new Item { Title = "Easy", SymbolColor = Colors.Green },
    new Item { Title = "Frank", SymbolColor = Colors.Blue }
};
        }
    }
}
