using System;
using System.Collections.Generic;
using System.Text;

namespace App1Javier.clases
{
  public   class Categories
    {
        public Response response { get; set; }
    }

    public class Response
    {
        public IList<Category> categories { get; set; }
    }
    public class Category
    {
        public string id { get; set; }
        public string name { get; set; }
        public string shortName { get; set; }

   }

}
