using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace stAntonyParish.Models.Register.Info
{
    public class AthmathithiMembersInfo
    {
        private long mId = 0;
        private long mAthmathithiXId = 0;
        private string mName = "";
        private long mRalationXId = 0;
        private DateTime mBirthDate = DateTime.Now;
        private long mBloodGroupXId = 0;
        private DateTime mBaptism = DateTime.Now;
        private DateTime mFirstHolycommuion = DateTime.Now;
        private DateTime mConfirmation = DateTime.Now;
        private DateTime mMarriage = DateTime.Now;
        private long mQualificationXId = 0;
        private long mProfessionXId = 0;
        private long mCompanyXId = 0;
        private bool mIsActive;
        AthmasthithiDetailsInfo athmasthithiDetails;

        public AthmathithiMembersInfo()
        {
            athmasthithiDetails = new AthmasthithiDetailsInfo();
            FamilyUnit = new FamilyUnitInfo();
            MemberStatus = new MemberStatusInfo();
        }

        public long Id
        {
            get { return mId; }
            set { mId = value; }
        }

        public long AthmathithiXId
        {
            get { return mAthmathithiXId; }
            set { mAthmathithiXId = value; }
        }

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public long RalationXId
        {
            get { return mRalationXId; }
            set { mRalationXId = value; }
        }

        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate
        {
            get { return mBirthDate; }
            set { mBirthDate = value; }
        }

        public long BloodGroupXId
        {
            get { return mBloodGroupXId; }
            set { mBloodGroupXId = value; }
        }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Baptism
        {
            get { return mBaptism; }
            set { mBaptism = value; }
        }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FirstHolycommuion
        {
            get { return mFirstHolycommuion; }
            set { mFirstHolycommuion = value; }
        }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Confirmation
        {
            get { return mConfirmation; }
            set { mConfirmation = value; }
        }

        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date )]
        public DateTime Marriage
        {
            get { return mMarriage; }
            set { mMarriage = value; }
        }

        public long QualificationXId
        {
            get { return mQualificationXId; }
            set { mQualificationXId = value; }
        }

        public long ProfessionXId
        {
            get { return mProfessionXId; }
            set { mProfessionXId = value; }
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

        public AthmasthithiDetailsInfo athmasthithiDetailsInfo
        {
            get;
            set;
        }

        public int MemberRegisterNo
        {
            get;
            set;
        }

        public string PhotoPath
        {
            get;
            set;
        }

        public int Createdby
        {
            get;
            set;
        }

        public string CreatedName
        {
            get;
            set;
        }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate
        {
            get;
            set;
        }

        public string Relation
        {
            get;
            set;
        }

        public string BloodGroup
        {
            get;
            set;
        }

        public string Qualification
        {
            get;
            set;
        }

        public string Occupation
        {
            get;
            set;
        }

        public int MemberStatusXId
        {
            get;
            set;
        }

        public FamilyUnitInfo FamilyUnit
        {
            get;
            set;
        }

        public MemberStatusInfo MemberStatus
        {
            get;
            set;
        }

        public string Address
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