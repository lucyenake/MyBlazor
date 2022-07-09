using System;
using System.Collections.Generic;

namespace BlazorApp.Data
{
    public interface IAuthorService
    {
        List<Author> Authors { get; set; }
        DateTime CreationDate { get; set; }
        Author GetAuthorById(int authorId);
        List<Author> GetAuthors();
        void SaveAuthor(Author inAuthor);
        DateTime GetCreatedDate();
        string GetVersion();
    }
}