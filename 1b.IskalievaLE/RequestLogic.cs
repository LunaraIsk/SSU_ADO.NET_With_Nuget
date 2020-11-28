using _1b.IskalievaLE.BLL.Interface;
using _1b.IskalievaLE.DAL;
using _1b.IskalievaLE.DAL.Interface;
using _1b.IskalievaLE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1b.IskalievaLE.BLL
{
    public class RequestLogic: IRequestLogic
    {
        private readonly IRequestDao _requestDao;
        public RequestLogic(IRequestDao requestDao)
        {
            this._requestDao = new RequestDao();
        }
        public int AddRequest(Request request)
        {
            return this._requestDao.AddRequest(request);
        }

        public IEnumerable<Request> GetAllRequests()
        {
            return this._requestDao.GetAllRequests();
        }

        public IEnumerable<Request> GetRequest(int id)
        {
            return this._requestDao.GetRequest(id);
        }
    }
}
