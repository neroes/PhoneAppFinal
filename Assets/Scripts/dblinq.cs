using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;


namespace ConsoleApplication1
{
    [Table]
    public class Entry
    {
        [Column(IsPrimaryKey = true)]
        public int ID=0;
        [Column]
        public int startTime;

        [Column]
        public int endTime;
        [Column]
        public bool isSynced;
        [Column]
        public int type;
        public Entry(int sTime, int eTime, int tID)
        {
            startTime = sTime;
            endTime = eTime;
            type = tID;
            isSynced = false;
        }
    }
}

