using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace stAntonyParish.Models.Register.Info
{
    public class AthmasthithiInfo
    {
        private long mId = 0;
        private string mHouseNumber = "";
        private long? mFamilyUnitXId = 0;
        private string mPermanentAddress = "";
        private string mPresentAddress = "";
        private long mPanchayathXId = 0;
        private long mTalukXId = 0;
        private long mWardXId = 0;
        private long mLocationXId = 0;
        private string mPhone = "";
        private string mDocumentPath= "";
        private long mCompanyXId = 0;
        private bool mIsActive = false;
        private AthmasthithiDetailsInfo athmasthithiDetails;
        public AthmasthithiInfo()
        {
            athmasthithiDetails = new AthmasthithiDetailsInfo();
        }

        public long Id
        {
            get { return mId; }
            set { mId = value; }
        }

        public string HouseNumber
        {
            get { return mHouseNumber; }
            set { mHouseNumber = value; }
        }

        public long? FamilyUnitXId
        {
            get { return mFamilyUnitXId; }
            set { mFamilyUnitXId = value; }
        }

        public string PermanentAddress
        {
            get { return mPermanentAddress; }
            set { mPermanentAddress = value; }
        }

        public string PresentAddress
        {
            get { return mPresentAddress; }
            set { mPresentAddress = value; }
        }

        public long PanchayathXId
        {
            get { return mPanchayathXId; }
            set { mPanchayathXId = value; }
        }

        public long TalukXId
        {
            get { return mTalukXId; }
            set { mTalukXId = value; }
        }

        public long WardXId
        {
            get { return mWardXId; }
            set { mWardXId = value; }
        }

        public long LocationXId
        {
            get { return mLocationXId; }
            set { mLocationXId = value; }
        }

        public string Phone
        {
            get { return mPhone; }
            set { mPhone = value; }
        }

        public string DocumentPath
        {
            get { return mDocumentPath; }
            set { mDocumentPath = value; }
        }

        public long CompanyXId
        {
            get { return mCompanyXId; }
            set { mCompanyXId = value; }
        }

        public bool IsActive
        {
            get { return mIsActive; }
            set { mIsActive = value; }
        }

        private string mWhereClause = "";
        public string WhereClause
        {
            get { return mWhereClause; }
            set { mWhereClause = value; }
        }

        public string TableName
        {
            get { return "dbo.regAthmathithi"; }
        }
        public string ExcludeFields
        {
            get { return ",Id,"; }
        }

        public AthmasthithiDetailsInfo athmasthithiDetailsInfo
        {
            get;
            set;
        }

        public int HouseCount
        {
            get;
            set;
        }

        public int MemberCount
        {
            get;
            set;
        }

        public string  FamilyUnitName
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Relation
        {
            get;
            set;
        }

        public string FamilyUnit
        {
            get;
            set;
        }

        public string panchayath
        {
            get;
            set;
        }

        public string Thaluk
        {
            get;
            set;
        }

        public string Ward
        {
            get;
            set;
        }

         public string Location
        {
            get;
            set;
        }
    }
}