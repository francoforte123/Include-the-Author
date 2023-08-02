﻿namespace Include_the_Author.Models
{
    public class Request
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<Response> Responses { get; set; }
    }
}
