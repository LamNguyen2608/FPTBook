using FPTBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FPTBook.Data.Service
{
    public interface IAuthorService
    {
        Task<IEnumerable<Author>> GetAllAsync();

        Task<Author> GetByIdAsync(int id);
        Task AddAsync(Author author);
        Task<Author> UpdateAsync(int id, Author newAuthor);
        Task DeleteAsync(int id);
    }
}