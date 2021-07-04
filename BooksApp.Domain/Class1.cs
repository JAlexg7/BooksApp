using BooksApp.Domain;
using System;
using System.Collections.Generic;

namespace BooksApp.Domain
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

    public class Publisher 
    { 
        public int Id { get; set; } 
        public string PublisherName { get; set; } 
    }

public class Book
{
    public Book() { Authors = new List<Author>(); }
    public int Id { get; set; }
    public string Isbn { get; set; }
    public string Title { get; set; }
    public int EditionNumber { get; set; }
    public string Copyright { get; set; }
    public List<Author> Authors { get; set; }
    public Publisher PublishingHouse { get; set; }
    public void AddAuthor(Author author) { if (author != null) { Authors.Add(author); } }
}