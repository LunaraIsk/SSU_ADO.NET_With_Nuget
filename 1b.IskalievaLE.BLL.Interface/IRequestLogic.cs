using _1b.IskalievaLE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1b.IskalievaLE.BLL.Interface
{
    public interface IRequestLogic
    {
        int AddRequest(Request request);

        IEnumerable<Request> GetAllRequests();

        IEnumerable<Request> GetRequest(int id);
    }
}
