using Dal;
using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Bll
{
    public class MediationBll
    {
        public static List<SelectVolunteerByServiceAndDayNew_Result> selectvolunteerByServiceAndDay(long MotherId)
        {
            return MediationDal.SelectVolunteerByServiceAndDay(MotherId);

        }

        public static List<SelectVolunteerByServiceNew_Result> selectvolunteerByService(long MotherId)
        {
            return MediationDal.selectvolunteerByService(MotherId);

        }

        public static List<GetRequestByDay_Result> GetRequestByDay(long DayId)
        {
            return Dal.MediationDal.GetRequestByDay(DayId);
        }



        public static void mediationFindVolunteer(long motherId)
        {



            //  return Dal.MediationDal.Mediation(motherId); //שליחה לפונקציה המקורית שלנו
            //List<long> volunteerList = new List<long>();
            //List<long> ServicesList = new List<long>();

            List<SelectVolunteerByServiceAndDayNew_Result> serviceAndDay = new List<SelectVolunteerByServiceAndDayNew_Result>();
            // serviceAndDay = selectvolunteerByServiceAndDay(motherId);
            List<SelectVolunteerByServiceNew_Result> service = new List<SelectVolunteerByServiceNew_Result>();
            //        List<SelectVolunteerByDay_Result> day = new List<SelectVolunteerByDay_Result>();


            //        day = selectVolunteerByDay(motherId);


            //if (serviceAndDay != null)
            //{
            //    foreach (var item in serviceAndDay)
            //    {
            //        if (item.StatusRequest == 1)
            //        {
            //            string massage = "האם תוכלי להתנדב ביום:" + item.DescribeDay + "בתאריך: " + item.BirthDateOfService +
            //                 "לעשות:" + item.DescribeService
            //                 + "קוד אישור התנדבות" + item.ServiceManagementId +
            //                 "לינק לאישור התנדבות " + "http://localhost:4200/volunteer-approval.component";
            //            string subject = "אישור התנדבות";
            //            EmailBll.mail(item.volunteerEmail, massage, subject);
            //        }
            //        else
            //            break;
            //    }

            //}
            //else
            //{
            service = selectvolunteerByService(motherId);
            if (service != null)
            {
                int[] array = { 0, 0, 0, 0, 0, 0, 0, 0 };

                int count = 0;
                foreach (var item in service)
                {
                    array[(int)item.DayId] += 1;
                    // לבדוק האם זה יעיל!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    //count = 0;
                    //for (int i = 0; i <array.Length; i++)
                    //{
                    //    if (i != 0)
                    //        count++;
                    //}
                    //if (count == 7)
                    //    break;
                }
                List<string> day = new List<string>();

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != 0)
                    {
                        var code = DaysBll.GetDayById(i);
                        day.Add(code);

                    }
                }

                string massage;
                string subject = "בקשת התנדבות";
                massage = " השירות בתאריך המבוקש לא קיים אפשר לבחור בימים הבאים" +
                         "לבחירת ימים לחץ על הקישור" +

                         " http://localhost:4200/mother-approval.component";


                foreach (var item in day)
                {
                    massage += item;
                }
                var MotherEmail = UserDal.selectUserById(motherId);

                EmailBll.mail(MotherEmail.Email, massage, subject);

                //}
            }

        }



        public static long BirthId;
        public static long MotherId;
        public static int c = 0;
        public static string FirstName;
        public static long volunteerId;
        public static string TheService;
        public static long ServiceManagementId;
        public static string volunteerEmail;
        public static long serviceId;

        public static void VolunteerApproval(long ServiceManagmentId, long VolunteerId)
        {
            List<VolunteerApproval_Result> Approval = new List<VolunteerApproval_Result>();
            Approval = MediationDal.VolunteerApproval(ServiceManagmentId, VolunteerId);

            string subject = "אישור התנדבות";


            foreach (var item in Approval)
            {

                if (item.BeginningTime != null)
                {
                    if (item.EndTime != null)
                    {
                        string massage = "שלום" + item.MotherFirstName +
                      "נמצאה מתנדבת לבקשה שלך " + item.DescribeVolunteer
                      + "בתאריך: " + item.BirthDateOfService +
                      "בשעה" + item.BeginningTime +
                      "עד שעה" + item.EndTime +
                      "שם  המתנדבת" + item.VolunteerName +
                      "טלפון" + item.VolunteerPhone;
                        EmailBll.mail(item.MotherEmail, massage, subject);
                        BirthId = item.BirthId;
                        MotherId = item.MotherId;
                        ServiceManagmentToBirthDal.UpdateRequest(ServiceManagmentId);
                        ServiceVolunteerToBirthDal.AddServiceVolunteerToBirth(converterEF.ServiceVolunteerToBirthConverters.ToDalServiceVolunteerToBirth(item.BirthId, item.ServiceId, item.MotherId, VolunteerId, (TimeSpan)item.BeginningTime, (TimeSpan)item.EndTime, item.BirthDateOfService));


                        break;
                    }
                    else
                    {
                        string massage = "שלום" + item.MotherFirstName +
                            "נמצאה מתנדבת לבקשה שלך " + item.DescribeVolunteer
                            + "בתאריך: " + item.BirthDateOfService +
                            "בשעה" + item.BeginningTime +
                            "שם  המתנדבת" + item.VolunteerName +
                            "טלפון" + item.VolunteerPhone;
                        EmailBll.mail(item.MotherEmail, massage, subject);
                        BirthId = item.BirthId;
                        MotherId = item.MotherId;
                        ServiceManagmentToBirthDal.UpdateRequest(ServiceManagmentId);
                        ServiceVolunteerToBirthDal.AddServiceVolunteerToBirth(converterEF.ServiceVolunteerToBirthConverters.ToDalServiceVolunteerToBirth(item.BirthId, item.ServiceId, item.MotherId, VolunteerId, (TimeSpan)item.BeginningTime, (TimeSpan)item.EndTime, item.BirthDateOfService));

                        break;
                    }
                }
                else
                {
                    string massage = "שלום" + item.MotherFirstName +
                     "נמצאה מתנדבת לבקשה שלך " + item.DescribeVolunteer
                     + "בתאריך: " + item.BirthDateOfService +
                     "שם  המתנדבת" + item.VolunteerName +
                     "טלפון" + item.VolunteerPhone;
                    EmailBll.mail(item.MotherEmail, massage, subject);
                    item.BeginningTime = new TimeSpan(0);
                    item.EndTime = new TimeSpan(0);
                    BirthId = item.BirthId;
                    MotherId = item.MotherId;
                    ServiceManagmentToBirthDal.UpdateRequest(ServiceManagmentId);
                    ServiceVolunteerToBirthDal.AddServiceVolunteerToBirth(converterEF.ServiceVolunteerToBirthConverters.ToDalServiceVolunteerToBirth(item.BirthId, item.ServiceId, item.MotherId, VolunteerId, (TimeSpan)item.BeginningTime, (TimeSpan)item.EndTime, item.BirthDateOfService));



                }
                string massageToVolunteer = "שלום " + item.VolunteerName + " היקרה!!!!" +
                    "תודה על השתתפותך בחסד האדיר של " + "YoledetGroup" +
                    "פרטי ההתנדבות: " +
                    item.DescribeVolunteer +
                    "בתאריך: " + item.BirthDateOfService +
                     "שם היולדת: " + item.MotherFirstName + " " + item.MotherLastName +
                    "כתובת: " + item.MotherAddress + " " + item.MotherNumOfHouse +
                    "טלפון: " + item.MotherPhone +
                    "במידה ויש שינויים נא לעדכן את היולדת";
                break;

            }


            List<ServiceManagementToBirth> smtb = new List<ServiceManagementToBirth>();
            smtb = ServiceManagmentToBirthDal.CheckActiveRequest(BirthId);
            foreach (var item in smtb)
            {
                if (item.StatusRequest == 1)
                    c++;
                if (c > 0)
                    break;

            }
            if (c == 0)
                UserDal.UpdateUsersActive(MotherId);




        }
        public static int GetStatusRequest(long ServiceManagmentId)
        {
            return MediationDal.GetStatusRequest(ServiceManagmentId);
        }
        public static void PostServiceVolunteer(List<Dto.ServiceAndDayToVolunteerDto> d)
        {
            long a = MediationDal.PostServiceAndDayVolunteer(converterEF.ServiceAndDayToVolunteerConverters.ToDalServiceAndDayToVolunteer(d));
            List<SelectVolunteerByServiceNew_Result> VolunteerByService = new List<SelectVolunteerByServiceNew_Result>();
            VolunteerByService = MediationDal.SelectByService(a);
            foreach (var item in VolunteerByService)
            {
                volunteerEmail = item.volunteerEmail;
                serviceId = item.serviceId;
                break;
            }
            StringBuilder SB = new StringBuilder();
            SB.Append("http://localhost:4200/volunteer-approval.component");
            if (serviceId == 1)
            { SB.Append("?param1="); SB.Append(HttpUtility.UrlEncode("1")); }
            else if (serviceId == 2)
            { SB.Append("?param1="); SB.Append(HttpUtility.UrlEncode("2")); }
            else if (serviceId == 3)
            { SB.Append("?param1="); SB.Append(HttpUtility.UrlEncode("3")); }
            else if (serviceId == 4)
            { SB.Append("?param1="); SB.Append(HttpUtility.UrlEncode("4")); }
            else if (serviceId == 5)
            { SB.Append("?param1="); SB.Append(HttpUtility.UrlEncode("5")); }
            else if (serviceId == 6)
            { SB.Append("?param1="); SB.Append(HttpUtility.UrlEncode("6")); }

            string massage = " כל התוצאות עבור ההתנדבות שבחרת " +
                "לבחירת התנדבות לחצי על הלינק" + SB;
            string subject = "אישור התנדבות";
            EmailBll.mail(volunteerEmail, massage, subject);


            //פה אנחנו רוצות להחזיר לאנגולר את כל הרשימה של הסלקט לפי הסרוויס VolunteerByService
            //if (VolunteerByService != null)
            //{



            //    int[] array = { 0, 0, 0, 0, 0, 0, 0, 0 };

            //    int count = 0;
            //    foreach (var item in VolunteerByService)
            //    {
            //        volunteerId = item.volunteer;
            //        FirstName = item.VolunteerName;
            //        TheService = item.TheService;
            //        ServiceManagementId = item.ServiceManagementId;
            //        array[(int)item.MotherDay] += 1;
            // לבדוק האם זה יעיל!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //count = 0;
            //for (int i = 0; i <array.Length; i++)
            //{
            //    if (i != 0)
            //        count++;
            //}
            //if (count == 7)
            //    break;
            //}
            //List<string> day = new List<string>();

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] != 0)
            //    {
            //        var code = DaysBll.GetDayById(i);
            //        day.Add(code);

            //    }
            //}

            //string massage1;
            //string massage2;

            //string subject = "אישור התנדבות";
            //massage1 = " האם תוכלי להתנדב ב" + TheService
            //+ "  באחד מהימים הבאים";


            //massage2 = "לבחירת ימים לחץ על הקישור" +
            //      " http://localhost:4200/volunteer-approval.component" +
            //    "קוד אישור" + ServiceManagementId;
            //foreach (var item in day)
            //{
            //    massage1 += item;
            //}
            //var volunteerEmail = UserDal.selectUserById(volunteerId);
            //massage1 += massage2;
            //EmailBll.mail(volunteerEmail.Email, massage1, subject);


        }


        //public static void PostServiceAndDayVolunteer(List<Dto.ServiceAndDayToVolunteerDto> d)
        //{

        //    MediationDal.PostServiceAndDayVolunteer(converterEF.ServiceAndDayToVolunteerConverters.ToDalServiceAndDayToVolunteer(d));

        //}

        public static void MediationFindMother(long VolunteerId)
        {
            List<selectMotherByServiceAndDay_Result> Mother = new List<selectMotherByServiceAndDay_Result>();
            Mother = MediationDal.selectMotherByServiceAndDay(VolunteerId);
            if (Mother != null)

            {
                foreach (var item in Mother)
                {

                    string massage = "האם תוכלי להתנדב ביום:" + item.DescribeDay + "בתאריך: " + item.BirthDateOfService +
                         "לעשות:" + item.DescribeService
                         + "קוד אישור התנדבות" + item.ServiceManagementId +
                         "לינק לאישור התנדבות " + "http://localhost:4200/volunteer-approval.component";

                    string subject = "אישור התנדבות";
                    EmailBll.mail(item.volunteerEmail, massage, subject);
                    break;
                }

            }

        }

    }
}








