//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//using System.Data;
//using DubaiShippingAgency.Models.DataManager;
//using stAntonyParish.Models.Register.Info;

//namespace stAntonyParish.Models.Register.Data
//{
//    public class AthmasthithiData
//    {
//        public static DataSet AthmasthithiDetails(int companyId)
//        {
//            using (DataProviderBase dataProvider = DataProviderFactory.DataProvider())
//            {
//                dataProvider.parameter.Add("@companyId", companyId);
//                return dataProvider.ExecuteDataset("regAthmasthithiItems");
//            }
//        }

//        public static int AthmasthithiSave(AthmasthithiInfo athmasthithi)
//        {
//            using (DataProviderBase dataProvider = DataProviderFactory.DataProvider())
//            {
//                dataProvider.parameter.Add("@AthmasthithiNoOutput", DbType.Int32, ParameterDirection.Output);
//                dataProvider.parameter.Add("@Id", athmasthithi.Id);
//                dataProvider.parameter.Add("@HouseNumber", athmasthithi.HouseNumber);
//                //dataProvider.parameter.Add("@FamilyUnitXId", athmasthithi.athmasthithiDetailsInfo.AthmasthithiInfo.FamilyUnitXId);
//                dataProvider.parameter.Add("@FamilyUnitXId", athmasthithi.FamilyUnitXId);
//                dataProvider.parameter.Add("@PermanentAddress", athmasthithi.PermanentAddress);
//                dataProvider.parameter.Add("@PresentAddress", athmasthithi.PresentAddress);
//                dataProvider.parameter.Add("@PanchayathXId", athmasthithi.PanchayathXId);
//                dataProvider.parameter.Add("@TalukXId", athmasthithi.TalukXId);
//                dataProvider.parameter.Add("@WardXId", athmasthithi.WardXId);
//                dataProvider.parameter.Add("@LocationXId", athmasthithi.LocationXId);
//                dataProvider.parameter.Add("@Phone", athmasthithi.Phone);
//                dataProvider.parameter.Add("@DocumentPath", athmasthithi.DocumentPath);
//                dataProvider.parameter.Add("@userId", Configuration.Settings.UserId);
//                dataProvider.parameter.Add("@CompanyXId", athmasthithi.CompanyXId);
//                dataProvider.parameter.Add("@IsActive", athmasthithi.IsActive);
 
//                //dataProvider.parameter.Add("@AthmasthithiNoOutput", ParameterDirection.Output);
//                 dataProvider.ExecuteProcedure("RegAthmasthithiSave");

//                 int retval = Convert.ToInt32(dataProvider.parameter[0].Value);
//                 return retval;               
//            }
//        }

//        public static DataSet AthmasthithiMemberDetails(int companyId)
//        {
//            using (DataProviderBase dataProvider = DataProviderFactory.DataProvider())
//            {
//                dataProvider.parameter.Add("@companyId", companyId);
//                return dataProvider.ExecuteDataset("regAthmasthithiMemberItems");
//            }
//        }


//        public static int AthmasthithiMemberCreate(AthmathithiMembersInfo athmathithiMemberInfo, int companyId)
//        {
//            using (DataProviderBase dataProvider = DataProviderFactory.DataProvider())
//            {
//                //dataProvider.parameter.Add("@AthmathithiXId", athmathithiMemberInfo.MemberRegisterNo);
//                dataProvider.parameter.Add("@AthmathithiXId", athmathithiMemberInfo.AthmathithiXId);
//                dataProvider.parameter.Add("@Name", athmathithiMemberInfo.Name);
//                dataProvider.parameter.Add("@RalationXId", athmathithiMemberInfo.RalationXId);
//                dataProvider.parameter.Add("@BirthDate", athmathithiMemberInfo.BirthDate.ToString("yyyy-MM-dd"));
//                dataProvider.parameter.Add("@BloodGroupXId", athmathithiMemberInfo.BloodGroupXId);
//                dataProvider.parameter.Add("@Baptism", athmathithiMemberInfo.Baptism.ToString("yyyy-MM-dd"));
//                dataProvider.parameter.Add("@FirstHolycommuion", athmathithiMemberInfo.FirstHolycommuion.ToString("yyyy-MM-dd"));
//                dataProvider.parameter.Add("@Confirmation", athmathithiMemberInfo.Confirmation.ToString("yyyy-MM-dd"));
//                dataProvider.parameter.Add("@Marriage", athmathithiMemberInfo.Marriage.ToString("yyyy-MM-dd"));
//                dataProvider.parameter.Add("@QualificationXId", athmathithiMemberInfo.QualificationXId);
//                dataProvider.parameter.Add("@ProfessionXId", athmathithiMemberInfo.ProfessionXId);
//                dataProvider.parameter.Add("@UserId", Configuration.Settings.UserId);
//                dataProvider.parameter.Add("@CompanyXId", athmathithiMemberInfo.CompanyXId);
//                dataProvider.parameter.Add("@IsActive", athmathithiMemberInfo.IsActive);
//                dataProvider.parameter.Add("@MemberStatus", Convert.ToInt32(athmathithiMemberInfo.MemberStatusXId));
//                return dataProvider.ExecuteProcedure("regAthmasthithiMemberDetailSave");
//            }
//        }

//        public static DataSet athmasthithiList(int companyId)
//        {
//            using (DataProviderBase dataProvider = DataProviderFactory.DataProvider())
//            {
//                dataProvider.parameter.Add("@comapnyId", companyId);
//                return dataProvider.ExecuteDataset("regAthmasthithiAll");
//            }
//        }


//        public static DataSet regAthmasthithibyUnitId(int familyUnitId, int companyId)
//        {
//            using (DataProviderBase dataProvider = DataProviderFactory.DataProvider())
//            {
//                dataProvider.parameter.Add("@familyUnitId", familyUnitId);
//                dataProvider.parameter.Add("@companyId", companyId);
//                return dataProvider.ExecuteDataset("regAthmasthithibyUnitId");
//            }
//        }


//        public static DataTable FamilyUnitList(int companyId)
//        {
//            using (DataProviderBase dataProvider = DataProviderFactory.DataProvider())
//            {
//                dataProvider.parameter.Add("@companyId", companyId);
//                return dataProvider.ExecuteDataset("regFamilyUnitList").Tables[0];
//            }
//        }

//        public static DataSet AthmasthithiDetailsbyId(int Id, int companyId)
//        {
//            using (DataProviderBase dataProvider = DataProviderFactory.DataProvider())
//            {
//                dataProvider.parameter.Add("@athmId", Id);
//                dataProvider.parameter.Add("@companyId", companyId);
//                return dataProvider.ExecuteDataset("regAthmasthithiDetailsbyId");
//            }
//        }

//        public static DataTable AthmasthithiDocumentbyId(int Id, int companyId)
//        {
//            using (DataProviderBase dataProvider = DataProviderFactory.DataProvider())
//            {
//                dataProvider.parameter.Add("@athmId", Id);
//                dataProvider.parameter.Add("@companyId", companyId);
//                return dataProvider.ExecuteDataset("regAthmasthithiDocumentbyId").Tables[0];
//            }
//        }

//        public static DataTable AthmasthithiMembersbyId(int Id, int companyId)
//        {
//            using (DataProviderBase dataProvider = DataProviderFactory.DataProvider())
//            {
//                dataProvider.parameter.Add("@athmId", Id);
//                dataProvider.parameter.Add("@companyId", companyId);
//                return dataProvider.ExecuteDataset("regAthmasthithiMembersbyId").Tables[0];
//            }
//        }

//        public static DataSet AthmasthithiMEMBERbyId(int Id, int companyId)
//        {
//            using (DataProviderBase dataProvider = DataProviderFactory.DataProvider())
//            {
//                dataProvider.parameter.Add("@memberId", Id);
//                dataProvider.parameter.Add("@companyId", companyId);
//                return dataProvider.ExecuteDataset("regAthmasthithiMemberbyId");
//            }
//        }

//        public static int AthmasthithiMemberUpdate(AthmathithiMembersInfo athmathithiMemberInfo, int companyId)
//        {
//            using (DataProviderBase dataProvider = DataProviderFactory.DataProvider())
//            {
//                dataProvider.parameter.Add("@Id", athmathithiMemberInfo.Id);
//                dataProvider.parameter.Add("@AthmathithiXId", athmathithiMemberInfo.AthmathithiXId);
//                dataProvider.parameter.Add("@Name", athmathithiMemberInfo.Name);
//                dataProvider.parameter.Add("@RalationXId", athmathithiMemberInfo.RalationXId);
//                dataProvider.parameter.Add("@BirthDate", athmathithiMemberInfo.BirthDate.ToString("yyyy-MM-dd"));
//                dataProvider.parameter.Add("@BloodGroupXId", athmathithiMemberInfo.BloodGroupXId);
//                dataProvider.parameter.Add("@Baptism", athmathithiMemberInfo.Baptism.ToString("yyyy-MM-dd"));
//                dataProvider.parameter.Add("@FirstHolycommuion", athmathithiMemberInfo.FirstHolycommuion.ToString("yyyy-MM-dd"));
//                dataProvider.parameter.Add("@Confirmation", athmathithiMemberInfo.Confirmation.ToString("yyyy-MM-dd"));
//                dataProvider.parameter.Add("@Marriage", athmathithiMemberInfo.Marriage.ToString("yyyy-MM-dd"));
//                dataProvider.parameter.Add("@QualificationXId", athmathithiMemberInfo.QualificationXId);
//                dataProvider.parameter.Add("@ProfessionXId", athmathithiMemberInfo.ProfessionXId);
//                dataProvider.parameter.Add("@UserId", Configuration.Settings.UserId);
//                dataProvider.parameter.Add("@CompanyXId", Configuration.Settings.CompanyId);
//                dataProvider.parameter.Add("@IsActive", athmathithiMemberInfo.IsActive);
//                dataProvider.parameter.Add("@MemberStatus", Convert.ToInt32(athmathithiMemberInfo.MemberStatusXId));
//                return dataProvider.ExecuteProcedure("RegathmasthithimemberdetailUpdate");
//            }
//        }

//        public static DataTable AthmasthithiMemberbyUnitId(int Id, int companyId)
//        {
//            using (DataProviderBase dataProvider = DataProviderFactory.DataProvider())
//            {
//                dataProvider.parameter.Add("@UnitId", Id);
//                dataProvider.parameter.Add("@companyId", companyId);
//                return dataProvider.ExecuteDataset("regAthmasthithiMemberbyUnitId").Tables[0];
//            }
//        }
//    }
//}