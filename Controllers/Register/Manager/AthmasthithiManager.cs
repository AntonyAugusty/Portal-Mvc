//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Data;

//using stAntonyParish.Models.Register.Info;
//using stAntonyParish.Models.Register.Data;

//namespace stAntonyParish.Models.Register.Manager
//{
//    public class AthmasthithiManager
//    {
//        public static AthmasthithiDetailsInfo AthmasthithiDetails(int companyId)
//        {
//            AthmasthithiDetailsInfo listAthmasthithiDetails = new AthmasthithiDetailsInfo();
//            DataSet dsathDetails = AthmasthithiData.AthmasthithiDetails(companyId);
//            listAthmasthithiDetails = FillRegDetails(dsathDetails);
//            return listAthmasthithiDetails;
//        }

//        public static AthmasthithiDetailsInfo FillRegDetails(DataSet dsAthmathithiDetails)
//        {
//            AthmasthithiDetailsInfo AthmasthithiDetails = new AthmasthithiDetailsInfo();

//            DataTable dtFamilyUnit = dsAthmathithiDetails.Tables[0];
//            if (dtFamilyUnit.Rows.Count > 0)
//            {
//                foreach (DataRow dr in dtFamilyUnit.Rows)
//                {
//                    RegItems familyUnit = new RegItems();
//                    familyUnit.Id = Convert.ToInt32(dr["Id"]);
//                    familyUnit.Name = Convert.ToString(dr["Name"]);
//                    AthmasthithiDetails.familyUnitList.Add(familyUnit);
//                }
//            }

//            DataTable dtPanchayath = dsAthmathithiDetails.Tables[1];
//            if (dtPanchayath.Rows.Count > 0)
//            {
//                foreach (DataRow dr in dtPanchayath.Rows)
//                {
//                    RegItems Panchayath = new RegItems();
//                    Panchayath.Id = Convert.ToInt32(dr["Id"]);
//                    Panchayath.Name = Convert.ToString(dr["Name"]);
//                    AthmasthithiDetails.panchayathList.Add(Panchayath);
//                }
//            }

//            DataTable dtThaluk = dsAthmathithiDetails.Tables[2];
//            if (dtThaluk.Rows.Count > 0)
//            {
//                foreach (DataRow dr in dtThaluk.Rows)
//                {
//                    RegItems Thaluk = new RegItems();
//                    Thaluk.Id = Convert.ToInt32(dr["Id"]);
//                    Thaluk.Name = Convert.ToString(dr["Name"]);
//                    AthmasthithiDetails.thalukList.Add(Thaluk);
//                }
//            }

//            DataTable dtWard = dsAthmathithiDetails.Tables[3];
//            if (dtWard.Rows.Count > 0)
//            {
//                foreach (DataRow dr in dtWard.Rows)
//                {
//                    RegItems Ward = new RegItems();
//                    Ward.Id = Convert.ToInt32(dr["Id"]);
//                    Ward.Name = Convert.ToString(dr["Name"]);
//                    AthmasthithiDetails.WardList.Add(Ward);
//                }
//            }

//            DataTable dtLocation = dsAthmathithiDetails.Tables[4];
//            if (dtLocation.Rows.Count > 0)
//            {
//                foreach (DataRow dr in dtLocation.Rows)
//                {
//                    RegItems Location = new RegItems();
//                    Location.Id = Convert.ToInt32(dr["Id"]);
//                    Location.Name = Convert.ToString(dr["Name"]);
//                    AthmasthithiDetails.locationList.Add(Location);
//                }
//            }

//            DataTable dtOccupation = dsAthmathithiDetails.Tables[5];
//            if (dtOccupation.Rows.Count > 0)
//            {
//                foreach (DataRow dr in dtOccupation.Rows)
//                {
//                    RegItems Occupation = new RegItems();
//                    Occupation.Id = Convert.ToInt32(dr["Id"]);
//                    Occupation.Name = Convert.ToString(dr["Name"]);
//                    AthmasthithiDetails.occupationList.Add(Occupation);
//                }
//            }

//            // get the athmasamithi master details when edit occur
//            // checking athmasamithi details table exists  !!!
//            if (dsAthmathithiDetails.Tables.Count > 6)
//            {
//                DataTable dtAthmathithi = dsAthmathithiDetails.Tables[6];
//                if (dtAthmathithi.Rows.Count > 0)
//                {
//                    foreach (DataRow dr in dtAthmathithi.Rows)
//                    {
//                        AthmasthithiInfo athmasthithi = new Info.AthmasthithiInfo();
//                        athmasthithi.Id = Convert.ToInt32(dr["Id"]);
//                        athmasthithi.HouseNumber = Convert.ToString(dr["HouseNumber"]);
//                        athmasthithi.FamilyUnitXId = Convert.ToInt32(dr["FamilyUnitXId"]);
//                        athmasthithi.PermanentAddress = Convert.ToString(dr["PermanentAddress"]);
//                        athmasthithi.PresentAddress = Convert.ToString(dr["PresentAddress"]);
//                        athmasthithi.PanchayathXId = Convert.ToInt32(dr["PanchayathXId"]);
//                        athmasthithi.TalukXId = Convert.ToInt32(dr["TalukXId"]);
//                        athmasthithi.WardXId = Convert.ToInt32(dr["WardXId"]);
//                        athmasthithi.LocationXId = Convert.ToInt32(dr["LocationXId"]);
//                        athmasthithi.Phone = Convert.ToString(dr["Phone"]);
//                        athmasthithi.DocumentPath = Convert.ToString(dr["DocumentPath"]);
//                        AthmasthithiDetails.Athmasthithi.Add(athmasthithi);

//                    // AthmasthithiInfo athmasthithi = new Info.AthmasthithiInfo();
//                    //AthmasthithiDetails.AthmasthithiInfo.Id = Convert.ToInt32(dtAthmathithi.Rows[0]["Id"]);
//                    //AthmasthithiDetails.AthmasthithiInfo.HouseNumber = Convert.ToString(dtAthmathithi.Rows[0]["HouseNumber"]);
//                    //AthmasthithiDetails.AthmasthithiInfo.FamilyUnitXId = Convert.ToInt32(dtAthmathithi.Rows[0]["FamilyUnitXId"]);
//                    //AthmasthithiDetails.AthmasthithiInfo.PermanentAddress = Convert.ToString(dtAthmathithi.Rows[0]["PermanentAddress"]);
//                    //AthmasthithiDetails.AthmasthithiInfo.PresentAddress = Convert.ToString(dtAthmathithi.Rows[0]["PresentAddress"]);
//                    //AthmasthithiDetails.AthmasthithiInfo.PanchayathXId = Convert.ToInt32(dtAthmathithi.Rows[0]["PanchayathXId"]);
//                    //AthmasthithiDetails.AthmasthithiInfo.TalukXId = Convert.ToInt32(dtAthmathithi.Rows[0]["TalukXId"]);
//                    //AthmasthithiDetails.AthmasthithiInfo.WardXId = Convert.ToInt32(dtAthmathithi.Rows[0]["WardXId"]);
//                    //AthmasthithiDetails.AthmasthithiInfo.LocationXId = Convert.ToInt32(dtAthmathithi.Rows[0]["LocationXId"]);
//                    //AthmasthithiDetails.AthmasthithiInfo.Phone = Convert.ToString(dtAthmathithi.Rows[0]["Phone"]);
//                    //AthmasthithiDetails.AthmasthithiInfo.DocumentPath = Convert.ToString(dtAthmathithi.Rows[0]["DocumentPath"]);

//                    }
//                }
//            }
//            return AthmasthithiDetails;

//        }

//        public static int AthmasthithiSave(AthmasthithiInfo AthmasthithiInfo)
//        {
//            int  retVal = AthmasthithiData.AthmasthithiSave(AthmasthithiInfo);
//            return retVal;
//        }

//        public static AthmasthithiDetailsInfo AthmasthithiMemberDetails(int companyId)
//        {
//            AthmasthithiDetailsInfo listAthmasthithiDetails = new AthmasthithiDetailsInfo();
//            DataSet dsathMemeberDetails = AthmasthithiData.AthmasthithiMemberDetails(companyId);
//            listAthmasthithiDetails = FillMemeberDetails(dsathMemeberDetails);
//            return listAthmasthithiDetails;
//        }

//        public static AthmasthithiDetailsInfo FillRegMemeberDetails(DataSet dsathMemeberDetails)
//        {
//            AthmasthithiDetailsInfo AthmasthithiMemeberDetails = new AthmasthithiDetailsInfo();
//            DataTable dtBloodGroup = dsathMemeberDetails.Tables[0];
//            if (dtBloodGroup.Rows.Count > 0)
//            {
//                foreach (DataRow dr in dtBloodGroup.Rows)
//                {
//                    RegItems Qualication = new RegItems();
//                    Qualication.Id = Convert.ToInt32(dr["Id"]);
//                    Qualication.Name = Convert.ToString(dr["Name"]);
//                    AthmasthithiMemeberDetails.BloodGroupList.Add(Qualication);
//                }
//            }

//            DataTable dtRelation = dsathMemeberDetails.Tables[1];
//            if (dtRelation.Rows.Count > 0)
//            {
//                foreach (DataRow dr in dtRelation.Rows)
//                {
//                    RegItems Qualication = new RegItems();
//                    Qualication.Id = Convert.ToInt32(dr["Id"]);
//                    Qualication.Name = Convert.ToString(dr["Name"]);
//                    AthmasthithiMemeberDetails.RelationList.Add(Qualication);
//                }
//            }

//            DataTable dtQualication = dsathMemeberDetails.Tables[2];
//            if (dtQualication.Rows.Count > 0)
//            {
//                foreach (DataRow dr in dtQualication.Rows)
//                {
//                    RegItems Qualication = new RegItems();
//                    Qualication.Id = Convert.ToInt32(dr["Id"]);
//                    Qualication.Name = Convert.ToString(dr["Name"]);
//                    AthmasthithiMemeberDetails.QualicationList.Add(Qualication);
//                }
//            }

//            DataTable dtOccupation = dsathMemeberDetails.Tables[3];
//            if (dtOccupation.Rows.Count > 0)
//            {
//                foreach (DataRow dr in dtOccupation.Rows)
//                {
//                    RegItems Occupation = new RegItems();
//                    Occupation.Id = Convert.ToInt32(dr["Id"]);
//                    Occupation.Name = Convert.ToString(dr["Name"]);
//                    AthmasthithiMemeberDetails.occupationList.Add(Occupation);
//                }
//            }

//            DataTable dtMemeberStatus = dsathMemeberDetails.Tables[5];
//            if (dtMemeberStatus.Rows.Count > 0)
//            {
//                foreach (DataRow dr in dtMemeberStatus.Rows)
//                {
//                    //MemberStatusInfo MemberStatus = new MemberStatusInfo();
//                    //MemberStatus.Id = Convert.ToInt32(dr["Id"]);
//                    //MemberStatus.MemberStatus = Convert.ToString(dr["MemberStatus"]);
//                    //AthmasthithiMemeberDetails.MemberStatusList.Add(MemberStatus);

//                    RegItems MemberStatus = new RegItems();
//                    MemberStatus.Id = Convert.ToInt32(dr["Id"]);
//                    MemberStatus.Name = Convert.ToString(dr["MemberStatus"]);
//                    AthmasthithiMemeberDetails.MemberStatusList.Add(MemberStatus);
//                }
//            }

//            return AthmasthithiMemeberDetails;
//        }

//        public static int AthmasthithiMemberCreate(AthmathithiMembersInfo athmathithiMemberInfo, int companyId)
//        {
//            return AthmasthithiData.AthmasthithiMemberCreate(athmathithiMemberInfo, companyId);
//        }

//        public static List<AthmasthithiInfo> AthmasthithiList(int companyId)
//        {
//            List<AthmasthithiInfo> athmasthithiList = new List<AthmasthithiInfo>();
//            athmasthithiList = FillAthmasthithiCount(AthmasthithiData.athmasthithiList(companyId));
//            return athmasthithiList;
//        }

//        private static List<AthmasthithiInfo> FillAthmasthithiCount(DataSet dsAthmasthithi)
//        {
//            List<AthmasthithiInfo> athmasthithiList = new List<AthmasthithiInfo>();
//            if (dsAthmasthithi.Tables.Count > 0)
//            {
//                foreach (DataRow items in dsAthmasthithi.Tables[0].Rows)
//                {
//                    AthmasthithiInfo athmasthithi = new AthmasthithiInfo();
//                    athmasthithi.FamilyUnitXId = Convert.ToInt32(items["id"]);
//                    athmasthithi.FamilyUnitName = Convert.ToString(items["NAME"]);
//                    athmasthithi.HouseCount = Convert.ToInt32(items["HouseCount"]);
//                    athmasthithi.MemberCount = Convert.ToInt32(items["MemberCount"]);
//                    athmasthithiList.Add(athmasthithi);
//                }
//            }
//            return athmasthithiList;
//        }

//        //public static AthmasthithiDetailsInfo FamilyUnitList(int companyId)
//        //{
//        //    DataTable dsathDetails = AthmasthithiData.FamilyUnitList(companyId);
//        //    AthmasthithiDetailsInfo AthmasthithiDetails = new AthmasthithiDetailsInfo();
//        //    AthmasthithiDetails.familyUnitList.Add(FillFamilyUnit(dsathDetails));
//        //    return AthmasthithiDetails;
//        //}

//        public static List<RegItems> FamilyUnit(int companyId)
//        {
//            List<RegItems> FamilyUnit = new List<RegItems>();
//            DataTable dtFamilyUnit = AthmasthithiData.FamilyUnitList(companyId);
//            if (dtFamilyUnit.Rows.Count > 0)
//            {
//                foreach (DataRow dr in dtFamilyUnit.Rows)
//                {
//                    RegItems familyUnit = new RegItems();
//                    familyUnit.Id = Convert.ToInt32(dr["Id"]);
//                    familyUnit.Name = Convert.ToString(dr["Name"]);
//                    FamilyUnit.Add(familyUnit);
//                }
//            }
//            return FamilyUnit;
//        }

//        public static AthmasthithiDetailsInfo FamilyUnitList(int companyId)
//        {
//            AthmasthithiDetailsInfo AthmasthithiDetails = new AthmasthithiDetailsInfo();
//            DataTable dtFamilyUnit = AthmasthithiData.FamilyUnitList(companyId);
//            if (dtFamilyUnit.Rows.Count > 0)
//            {
//                foreach (DataRow dr in dtFamilyUnit.Rows)
//                {
//                    RegItems familyUnit = new RegItems();
//                    familyUnit.Id = Convert.ToInt32(dr["Id"]);
//                    familyUnit.Name = Convert.ToString(dr["Name"]);
//                    AthmasthithiDetails.familyUnitList.Add(familyUnit);
//                }
//            }
//            return AthmasthithiDetails;
//        }

//        public static List<AthmasthithiInfo> regAthmasthithibyUnitId(int familyUnitId)
//        {
//            return FillAthmasthithi(AthmasthithiData.regAthmasthithibyUnitId(familyUnitId, Convert.ToInt32(Configuration.Settings.CompanyId)));
//        }

//        private static List<AthmasthithiInfo> FillAthmasthithi(DataSet dsAthmasthithi)
//        {
//            List<AthmasthithiInfo> athmasthithiList = new List<AthmasthithiInfo>();           
//            if (dsAthmasthithi.Tables.Count > 0)
//            {
//                foreach (DataRow items in dsAthmasthithi.Tables[0].Rows)
//                {
//                    AthmasthithiInfo athmasthithi = new AthmasthithiInfo();
//                    athmasthithi.Id = Convert.ToInt32(items["Id"]);
//                    athmasthithi.FamilyUnitXId = Convert.ToInt32(items["FamilyUnitXId"]);
//                    athmasthithi.FamilyUnitName = Convert.ToString(items["FamilyUnit"]);
//                    athmasthithi.HouseNumber = Convert.ToString(items["housenumber"]);
//                    athmasthithi.Name = Convert.ToString(items["NAME"]);
//                    athmasthithi.PermanentAddress = Convert.ToString(items["permanentaddress"]);
//                    athmasthithi.Relation = Convert.ToString(items["Relation"]);
//                    athmasthithi.panchayath = Convert.ToString(items["panchayath"]);
//                    athmasthithi.Thaluk = Convert.ToString(items["Thaluk"]);
//                    athmasthithi.Ward = Convert.ToString(items["Ward"]);
//                    athmasthithi.Location = Convert.ToString(items["Location"]);
//                    athmasthithiList.Add(athmasthithi);
//                }
//            }
//            return athmasthithiList;
//        }

//        public static AthmasthithiDetailsInfo AthmasthithiDetailsbyId(Int32 Id, Int32 companyId)
//        {
//            AthmasthithiDetailsInfo listAthmasthithiDetails = new AthmasthithiDetailsInfo();
//            DataSet dsathDetails = AthmasthithiData.AthmasthithiDetailsbyId(Id, companyId);
//            listAthmasthithiDetails = FillRegDetails(dsathDetails);
//            return listAthmasthithiDetails;
//        }

//        public static AthmasthithiInfo AthmasthithiDocumentbyId(Int32 Id, Int32 companyId)
//        {
//            AthmasthithiInfo listAthmasthithiDetails = new AthmasthithiInfo();
//            DataTable dtAthDetails = AthmasthithiData.AthmasthithiDocumentbyId(Id, companyId);
//            listAthmasthithiDetails = FillDocument(dtAthDetails);
//            return listAthmasthithiDetails;
//        }

//        private static AthmasthithiInfo FillDocument(DataTable dtAthDetails)
//        {
//            AthmasthithiInfo athmasthithi = new AthmasthithiInfo();
//            if (dtAthDetails.Rows.Count > 0)
//            {
//                athmasthithi.Id =(int) dtAthDetails.Rows[0]["Id"];
//                athmasthithi.DocumentPath = Convert.ToString(dtAthDetails.Rows[0]["DocumentPath"]);
//            }
//            return athmasthithi;
//        }

//        public static List<AthmathithiMembersInfo> AthmasthithiMembersbyId(Int32 Id, Int32 companyId)
//        {
//            List<AthmathithiMembersInfo> listAthmasthithiDetails = new List<AthmathithiMembersInfo>();
//            DataTable dtathMemberDetails = AthmasthithiData.AthmasthithiMembersbyId(Id, companyId);
//            if (dtathMemberDetails.Rows.Count > 0)
//            {
//                listAthmasthithiDetails = FillMembersDetails(dtathMemberDetails);
//            }
//            return listAthmasthithiDetails;
//        }

//        private static List<AthmathithiMembersInfo> FillMembersDetails(DataTable dtathMemberDetails)
//        {
//            List<AthmathithiMembersInfo> AthmasthithiMembersList = new List<AthmathithiMembersInfo>();
//            if (dtathMemberDetails.Rows.Count > 0)
//            {
//                foreach (DataRow dr in dtathMemberDetails.Rows)
//                {
//                    AthmathithiMembersInfo AthmasthithiMembers = new AthmathithiMembersInfo();
//                    AthmasthithiMembers.Id = Convert.ToInt32(dr["MemberId"]);
//                    AthmasthithiMembers.AthmathithiXId = Convert.ToInt32(dr["AthmId"]);
//                    AthmasthithiMembers.Name = Convert.ToString(dr["NAME"]);
//                    //object jj = (object)Convert.ToDateTime(dr["birthdate"]);

//                    DateTime jj = Convert.ToDateTime(dr["birthdate"].ToString());
//                    AthmasthithiMembers.Baptism = Convert.ToDateTime(jj.ToString("yyyy-MM-dd"));

//                    AthmasthithiMembers.Relation = Convert.ToString(dr["Relation"]);
//                    AthmasthithiMembers.BirthDate = Convert.ToDateTime(dr["birthdate"]);
//                    AthmasthithiMembers.BloodGroup = Convert.ToString(dr["BloodGroup"]);
//                    AthmasthithiMembers.Baptism = Convert.ToDateTime(dr["baptism"]);
//                    AthmasthithiMembers.FirstHolycommuion = Convert.ToDateTime(dr["firstholycommuion"]);
//                    AthmasthithiMembers.Confirmation = Convert.ToDateTime(dr["confirmation"]);
//                    AthmasthithiMembers.Marriage = Convert.ToDateTime(dr["marriage"]);
//                    AthmasthithiMembers.Qualification = Convert.ToString(dr["Qualification"]);
//                    AthmasthithiMembers.Occupation = Convert.ToString(dr["Occupation"]);
//                    AthmasthithiMembers.PhotoPath = Convert.ToString(dr["photopath"]);
//                    AthmasthithiMembers.Createdby = Convert.ToInt32(dr["CreatedBy"]);
//                    AthmasthithiMembers.CreatedName = Convert.ToString(dr["CreatedName"]);
//                    AthmasthithiMembers.CreatedDate = Convert.ToDateTime(dr["CreatedDate"]);

//                    AthmasthithiMembers.FamilyUnit.Name = Convert.ToString(dr["FamilyUnit"]);
//                    AthmasthithiMembers.Address = Convert.ToString(dr["Address"]);
//                    AthmasthithiMembers.Location = Convert.ToString(dr["Location"]);

//                    AthmasthithiMembersList.Add(AthmasthithiMembers);
//                }
//            }
//            return AthmasthithiMembersList;
//        }

//        public static AthmathithiMembersInfo AthmasthithiMEMBERbyId(Int32 Id, Int32 companyId)
//        {
//           AthmathithiMembersInfo listAthmasthithiDetails = new AthmathithiMembersInfo();
//            DataSet dtathMemberDetails = AthmasthithiData.AthmasthithiMEMBERbyId(Id, companyId);
//            listAthmasthithiDetails = FillMEMBERDetails(dtathMemberDetails);
//            return listAthmasthithiDetails;
//        }

//        private static AthmathithiMembersInfo FillMEMBERDetails(DataSet dtathMemberDetails)
//        {
//            AthmathithiMembersInfo AthmasthithiMember = new AthmathithiMembersInfo();
//            if (dtathMemberDetails.Tables[4].Rows.Count > 0)
//            {
//                foreach (DataRow dr in dtathMemberDetails.Tables[4].Rows)
//                {
//                    AthmasthithiMember.Id = Convert.ToInt32(dr["MemberId"]);
//                    AthmasthithiMember.Name = Convert.ToString(dr["NAME"]);
//                    AthmasthithiMember.AthmathithiXId = Convert.ToInt32(dr["AthmId"]);
//                    //DateTime dtebirthdate = Convert.ToDateTime(dr["birthdate"]);
//                    AthmasthithiMember.Baptism = Convert.ToDateTime(dr["birthdate"]);

//                    AthmasthithiMember.RalationXId = Convert.ToInt32(dr["ralationxid"]);
//                    AthmasthithiMember.BirthDate = Convert.ToDateTime(dr["birthdate"]);
//                    AthmasthithiMember.BloodGroupXId = Convert.ToInt32(dr["bloodgroupxid"]);
//                    AthmasthithiMember.Baptism = Convert.ToDateTime(dr["baptism"]);
//                    AthmasthithiMember.FirstHolycommuion = Convert.ToDateTime(dr["firstholycommuion"]);
//                    AthmasthithiMember.Confirmation = Convert.ToDateTime(dr["confirmation"]);
//                    AthmasthithiMember.Marriage = Convert.ToDateTime(dr["marriage"]);
//                    AthmasthithiMember.QualificationXId = Convert.ToInt32(dr["qualificationxid"]);
//                    AthmasthithiMember.ProfessionXId = Convert.ToInt32(dr["professionxid"]);
//                    AthmasthithiMember.PhotoPath = Convert.ToString(dr["photopath"]);
//                    AthmasthithiMember.Createdby = Convert.ToInt32(dr["CreatedBy"]);
//                    AthmasthithiMember.CreatedName = Convert.ToString(dr["CreatedName"]);
//                    AthmasthithiMember.CreatedDate = Convert.ToDateTime(dr["CreatedDate"]);
//                    AthmasthithiMember.IsActive = Convert.ToBoolean(dr["IsActive"]);
//                    AthmasthithiMember.MemberStatusXId = Convert.ToInt32(dr["memberstatusXId"]);
//                }
//            }

//            AthmasthithiMember.athmasthithiDetailsInfo = FillRegMemeberDetails(dtathMemberDetails);
//            return AthmasthithiMember;
//        }

//        public static int AthmasthithiMemberUpdate(AthmathithiMembersInfo athmathithiMemberInfo, int companyId)
//        {
//            return AthmasthithiData.AthmasthithiMemberUpdate(athmathithiMemberInfo, companyId);
//        }

//        /// <summary>
//        /// invoking from AthmasthithiMemberDetails function
//        /// </summary>
//        /// <param name="dsathMemeberDetails"></param>
//        /// <returns></returns>
//        public static AthmasthithiDetailsInfo FillMemeberDetails(DataSet dsathMemeberDetails)
//        {
//            AthmasthithiDetailsInfo AthmasthithiMemeberDetails = new AthmasthithiDetailsInfo();
//            DataTable dtBloodGroup = dsathMemeberDetails.Tables[0];
//            if (dtBloodGroup.Rows.Count > 0)
//            {
//                foreach (DataRow dr in dtBloodGroup.Rows)
//                {
//                    RegItems Qualication = new RegItems();
//                    Qualication.Id = Convert.ToInt32(dr["Id"]);
//                    Qualication.Name = Convert.ToString(dr["Name"]);
//                    AthmasthithiMemeberDetails.BloodGroupList.Add(Qualication);
//                }
//            }

//            DataTable dtRelation = dsathMemeberDetails.Tables[1];
//            if (dtRelation.Rows.Count > 0)
//            {
//                foreach (DataRow dr in dtRelation.Rows)
//                {
//                    RegItems Qualication = new RegItems();
//                    Qualication.Id = Convert.ToInt32(dr["Id"]);
//                    Qualication.Name = Convert.ToString(dr["Name"]);
//                    AthmasthithiMemeberDetails.RelationList.Add(Qualication);
//                }
//            }

//            DataTable dtQualication = dsathMemeberDetails.Tables[2];
//            if (dtQualication.Rows.Count > 0)
//            {
//                foreach (DataRow dr in dtQualication.Rows)
//                {
//                    RegItems Qualication = new RegItems();
//                    Qualication.Id = Convert.ToInt32(dr["Id"]);
//                    Qualication.Name = Convert.ToString(dr["Name"]);
//                    AthmasthithiMemeberDetails.QualicationList.Add(Qualication);
//                }
//            }

//            DataTable dtOccupation = dsathMemeberDetails.Tables[3];
//            if (dtOccupation.Rows.Count > 0)
//            {
//                foreach (DataRow dr in dtOccupation.Rows)
//                {
//                    RegItems Occupation = new RegItems();
//                    Occupation.Id = Convert.ToInt32(dr["Id"]);
//                    Occupation.Name = Convert.ToString(dr["Name"]);
//                    AthmasthithiMemeberDetails.occupationList.Add(Occupation);
//                }
//            }

//            DataTable dtMemeberStatus = dsathMemeberDetails.Tables[4];
//            if (dtMemeberStatus.Rows.Count > 0)
//            {
//                foreach (DataRow dr in dtMemeberStatus.Rows)
//                {
//                    //MemberStatusInfo MemberStatus = new MemberStatusInfo();
//                    //MemberStatus.Id = Convert.ToInt32(dr["Id"]);
//                    //MemberStatus.MemberStatus = Convert.ToString(dr["MemberStatus"]);
//                    //AthmasthithiMemeberDetails.MemberStatusList.Add(MemberStatus);

//                    RegItems MemberStatus = new RegItems();
//                    MemberStatus.Id = Convert.ToInt32(dr["Id"]);
//                    MemberStatus.Name = Convert.ToString(dr["MemberStatus"]);
//                    AthmasthithiMemeberDetails.MemberStatusList.Add(MemberStatus);
//                }
//            }

//            return AthmasthithiMemeberDetails;
//        }

//        public static List<AthmathithiMembersInfo> AthmasthithiMemberbyUnitId(Int32 Id, Int32 companyId)
//        {
//            List<AthmathithiMembersInfo> listAthmasthithiDetails = new List<AthmathithiMembersInfo>();
//            DataTable dtathMemberDetails = AthmasthithiData.AthmasthithiMemberbyUnitId(Id, companyId);
//            if (dtathMemberDetails.Rows.Count > 0)
//            {
//                listAthmasthithiDetails = FillMembersDetails(dtathMemberDetails);
//            }
//            return listAthmasthithiDetails;
//        }

//    }
//}