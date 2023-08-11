using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskLetters.Controllers
{
    public interface IFormGetController<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(int id);
    }
}
