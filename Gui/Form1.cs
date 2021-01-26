using Bll;
using Dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Bll.users.getAllUsers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bll.users.adduser(new Dto.user()
            {
                UserId = 1111112222,
                RoleId = 12,
                LastName = "כהן",
                Password = "458521656",
                Email = "saracohen@gmail.com",
                Phone = 548474144,
                Address = "מג",
                NumOfHouse = 13,
                Locality = "רוממה",
                BirthDate = DateTime.Today,
                Active = 1

            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bll.users.UpdateUser(new Dto.user()
            {
                UserId = 452,
                RoleId = 12,
                LastName = "שלייפר",
                Password = "458521656",
                Email = "saracohen@gmail.com",
                Phone = 1111111111,
                Address = "מג",
                NumOfHouse = 13,
                Locality = "רוממה",
                BirthDate = DateTime.Today,
                Active = 1

            });
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //   dataGridView1.DataSource = Bll.
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bll.EmailBll.UpdatePassword(211442256);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Bll.MediationBll.MediationFindMother(2);


        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bll.MediationBll.VolunteerApproval(1, 3);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ////////להמששיך יש לשלוח כמה אוביקטים 
            List<Dto.ServiceAndDayToVolunteerDto> ss = new List<Dto.ServiceAndDayToVolunteerDto>();




            var a = new Dto.ServiceAndDayToVolunteerDto()
            {
                UserId = 9999,
                DayId = 1,
                // BeginningTime =null,
                // EndTime 
                ServiceId = 3

            };
            var b = new Dto.ServiceAndDayToVolunteerDto()
            {
                UserId = 9999,
                DayId = 1,
                // BeginningTime =null,
                // EndTime 
                ServiceId = 4

            };
            ss.Add(a);
            ss.Add(b);

            //  Bll.MediationBll.PostServiceAndDayVolunteer(ss);
            Bll.MediationBll.PostServiceVolunteer(ss);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            // dataGridView1.DataSource = Bll.ServiceManagmentToBirthBll.GetByService(1);
            dataGridView1.DataSource = Bll.MediationBll.GetRequestByDay(4);

       //int serviceId = 1;
       
       //     StringBuilder SB = new StringBuilder();
       //     SB.Append("http://localhost:4200/volunteer-approval.component?");
           
       //        if (serviceId == 1)
       //             SB.Append("param1="); SB.Append(HttpUtility.UrlEncode("1"));
            
       //     string massage = " כל התוצאות עבור ההתנדבות שבחרת " +
       //        "לבחירת התנדבות לחצי על הלינק" +
       //        SB;

       //     string subject = "אישור התנדבות";
       //     EmailBll.mail("noazaksh@gmail.com", massage, subject);
        }
    }
}
