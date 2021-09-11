using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw_01.Services
{
    public class HitCounter : IHitCounter
    {
        public int PageVisit(HttpContext ctx, string sessionName)
        {
            if(ctx.Session.Keys.Contains(sessionName))
            {
                int time = Convert.ToInt32(ctx.Session.GetInt32(sessionName));
                ctx.Session.SetInt32(sessionName, ++time);
                return time;
            }
            else
            {
                ctx.Session.SetInt32(sessionName, 1);
                return 1;
            }
        }
    }
}
