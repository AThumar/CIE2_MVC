﻿namespace CIE2_MVC.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
        public string CoverImageUrl { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }


}
