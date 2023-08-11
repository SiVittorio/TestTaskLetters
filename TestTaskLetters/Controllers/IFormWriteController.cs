using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskLetters.Models;

namespace TestTaskLetters.Controllers
{
    public interface IFormWriteController<T>
    {
        Task InsertAsync(T data);
        Task DeleteAsync(int id);
        Task UpdateAsync(T data);
    }
}
