using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dating_App
{
    static class SharedData
    {
        static public int PUAID { get; set; }

        static SharedData()
        {
            PUAID = 0;
        }
    }
}
