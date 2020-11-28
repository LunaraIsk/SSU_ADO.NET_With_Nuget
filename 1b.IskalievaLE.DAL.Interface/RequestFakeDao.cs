using _1b.IskalievaLE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1b.IskalievaLE.DAL.Interface
{
    public class RequestFakeDao
    {
        private static Dictionary<int, Request> _repoRequest;

        public RequestFakeDao()
        {
            _repoRequest = new Dictionary<int, Request>();
        }
        public int AddRequest(Request request)
        {
            var lastId = _repoRequest.Any() ? _repoRequest.Keys.Max() : 0;
            request.IdRequest = ++lastId;
            _repoRequest.Add(request.IdRequest, request);
            return request.IdRequest;
        }

        public IEnumerable<Request> GetAllRequests()
        {
            return _repoRequest.Values;
        }

        public IEnumerable<Request> GetRequest(int id)
        {
            yield return _repoRequest[id];
        }
    }
}
