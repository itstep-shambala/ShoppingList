﻿namespace ShoppingList.Model
{
    public record ShopListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
    }
}