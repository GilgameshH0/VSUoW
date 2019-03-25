using System;
using System.Collections.Generic;
using System.Text;

namespace VSUoW
{
    public class MeropiList
    {
        public DateTime dt { get; set; }
        public string t1 { get; set; }
        public string T1 { get; set; }
        public string T2 { get; set; }

        public MeropiList(DateTime t, string t1, string t2)
        {
            dt = t;
            t1 = t.ToShortDateString();
            T1 = t1;
            T2 = t2;
        }
        public MeropiList()
        { }
    }
}
