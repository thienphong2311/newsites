using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_NEWS.Controllers
{
    public class HomeController : ApiController
    {
        public void tGet()
        {
            return;
        }
        [HttpGet]
        public HttpResponseMessage SetA(string id, string name, string desc)
        {
            Test objTest = new Test();
            objTest.InsertData(id, name, desc);
            HttpResponseMessage httpResponse = new HttpResponseMessage(HttpStatusCode.OK);
            httpResponse.Content = new StringContent(objTest.ShowData());
            return httpResponse;

        }


        public class Test : Interface
        {
            public string id;
            public string name;
            public string desc;
            public string ShowData()
            {
                string json = "[" + "{\"id\":\"" + id + "\",\"name\":\"" + name + "\",\"desc\":\"" + desc + "\"}]";
                return json;
            }
            public void InsertData(string pid, string pname, string pdesc)
            {
                id = pid;
                name = pname;
                desc = pdesc;
            }
        }
    }
}
