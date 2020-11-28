using _1b.IskalievaLE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1b.IskalievaLE.DAL.Interface
{
    public interface IRequestDao
    {
        int AddRequest(Request request);

        IEnumerable<Request> GetAllRequests();

        IEnumerable<Request> GetRequest(int id);

    }
}
