using System;
using System.Collections.Generic;
using BookApi_Project.Models;

namespace BookApi_Project.Services
{
    public interface IAuthorRepositiry
    {
        ICollection<Author> GetAuthors();
        Author GetAuthor(int authorId);
        ICollection<Author> GetAuthorsOfABook(int bookId);
        ICollection<Book> GetBooksByAuthor(int authorId);
        bool AuthorExists(int authorId);
    }
}
