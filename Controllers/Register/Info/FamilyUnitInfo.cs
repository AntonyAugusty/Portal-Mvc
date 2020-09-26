using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace stAntonyParish.Models.Register.Info
{
    public class FamilyUnitInfo
    {
        private long mId = 0;
        private string mName = string.Empty;

        public long Id
        {
            get { return mId; }
            set { mId = value; }
        }

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

    }
}