using System.Collections.Generic;

namespace DemoAutomation
{
    /// <summary>
    /// Class created in ordeer to get and set values for API tests
    /// </summary>
    /// 

    public partial class Data
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string First_Name { get; set; }

        public string Job { get; set; }
    }

    public partial class UsersList
    {
        public List<Data> Data{ get; set; }

        public long Page { get; set; }

        public long Per_Page { get; set; }

        public long Total { get; set; }

        public long Total_Pages { get; set; }
    }
}
