using MaimApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace MaimApp.Interfaces
{
    public interface IParser
    {
         Task<Result> Parse(string url);
    }
}