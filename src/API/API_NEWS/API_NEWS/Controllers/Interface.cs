using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_NEWS.Controllers
{
    public interface Interface
    {
        string ShowData();
        void InsertData(string id, string name, string desc);
    }
}