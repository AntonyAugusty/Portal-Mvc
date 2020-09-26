using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace stAntonyParish.Models.Register.Info
{
    public class MemberStatusInfo
    {
        private long mId = 0;
        private string mMemberStatus = "";
        private string mDescription = "";
        private bool mIsActive = false;
        private long mCompanyXId = 0;


        public long Id
        {
            get { return mId; }
            set { mId = value; }
        }

        public string MemberStatus
        {
            get { return mMemberStatus; }
            set { mMemberStatus = value; }
        }

        public string Description
        {
            get { return mDescription; }
            set { mDescription = value; }
        }

        public bool IsActive
        {
            get { return mIsActive; }
            set { mIsActive = value; }
        }

        public long CompanyXId
        {
            get { return mCompanyXId; }
            set { mCompanyXId = value; }
        }

        private string mWhereClause = "";
        public string WhereClause
        {
            get { return mWhereClause; }
            set { mWhereClause = value; }
        }

        public string TableName
        {
            get { return "dbo.usrMemberStatus"; }
        }
        public string ExcludeFields
        {
            get { return ",Id,"; }
        }
    }
}