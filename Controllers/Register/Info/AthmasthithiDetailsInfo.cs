using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace stAntonyParish.Models.Register.Info
{
    public class AthmasthithiDetailsInfo
    {
        List<RegItems> _familyUnitList;
        List<RegItems> _panchayathList;
        List<RegItems> _thalukList;
        List<RegItems> _wardList;
        List<RegItems> _locationList;
        List<RegItems> _occupationList;
        List<RegItems>  _bloodgroupList;
        List<RegItems> _relationListList;
        List<RegItems> _qualicationList;
        List<RegItems> _memberStatusList;
        List<AthmasthithiInfo> _athmasthithi;

        public AthmasthithiDetailsInfo()
        {
            _athmasthithi = new List<AthmasthithiInfo>();
            _familyUnitList = new List<RegItems>();
            _panchayathList = new List<RegItems>();
            _thalukList = new List<RegItems>();
            _wardList = new List<RegItems>();
            _locationList = new List<RegItems>();
            _occupationList = new List<RegItems>();
            _bloodgroupList = new List<RegItems>();
            _relationListList = new List<RegItems>();
            _qualicationList = new List<RegItems>();
            _memberStatusList = new List<RegItems>();

        }


        public List<RegItems> familyUnitList
        {
            get { return _familyUnitList; }
            set { _familyUnitList = value; }
        }

        public List<RegItems> panchayathList
        {
            get { return _panchayathList; }
            set { value = _panchayathList; }
        }

        public List<RegItems> thalukList
        {
            get { return _thalukList; }
            set { value = _thalukList; }
        }

        public List<RegItems> WardList
        {
            get { return _wardList; }
            set { value = _wardList; }
        }
        public List<RegItems> locationList
        {
            get { return _locationList; }
            set { value = _locationList; }
        }
        public List<RegItems> occupationList
        {
            get { return _occupationList; }
            set { value = _occupationList; }
        }



        public List<RegItems> BloodGroupList
        {
            get { return _bloodgroupList; }
            set { value = _bloodgroupList; }
        }

        public List<RegItems> RelationList
        {
            get { return _relationListList; }
            set { value = _relationListList; }
        }
        public List<RegItems> QualicationList
        {
            get { return _qualicationList; }
            set { value = _qualicationList; }
        }

        public List<AthmasthithiInfo> Athmasthithi
        {
            get { return _athmasthithi; }
            set { _athmasthithi = value; }
        }

        public AthmasthithiInfo AthmasthithiInfo
        {
            get;
            set;
        }

        public MemberStatusInfo MemberStatus
        {
            get;
            set;
        }

        //public List<MemberStatusInfo> MemberStatusList
        //{
        //    get;
        //    set;
        //}

        public List<RegItems> MemberStatusList
        {
            get { return _memberStatusList; }
            set { _memberStatusList = value; }
        }

    }
}