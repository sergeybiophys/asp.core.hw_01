using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw_01.Services
{
    public interface IHitCounter
    {
        int PageVisit(HttpContext ctx, string sessionName);
    }
}
