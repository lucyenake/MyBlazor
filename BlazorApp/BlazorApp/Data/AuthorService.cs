using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorApp.Data
{
    public class AuthorService : IAuthorService
    {
        public DateTime CreationDate { get; set; }
        public List<Author> Authors { get; set; }
        public AuthorService()
        {
            CreationDate = DateTime.Now;
            Authors = new List<Author>();

            Authors.Add(new Author(1, "172-32-1176", "Johnson", "White", "408 496 7223", "Manelo Park"));
            Authors.Add(new Author(2, "213-46-8915", "Marjorn", "Green", "408 496 7223", "Oakland"));
            Authors.Add(new Author(3, "238-95-7766", "Chery", "Carson", "408 496 7223", "Berkely"));
            Authors.Add(new Author(4, "267-41-2396", "Michael", "O'Lery", "408 496 7223", "San Jose"));
            Authors.Add(new Author(5, "274-80-9391", "Dean", "Straight", "408 496 7223", "Oakland"));
        }

        public List<Author> GetAuthors()
        {
            return Authors;
        }

        public Author GetAuthorById(int authorId)
        {
            return Authors.Where(auth => auth.AuthorId == authorId).FirstOrDefault();
        }
        public DateTime GetCreatedDate()
        {
            return CreationDate;
        }

        public string GetVersion()
        {
            return "V1";
        }
    }
}