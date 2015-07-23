using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PCT.Contact.DAL
{
    /// <summary>
    /// 初始化数据库
    /// </summary>
    public class CommunicationInitializer:DropCreateDatabaseIfModelChanges<CommunicationContext>
    {
        protected override void Seed(CommunicationContext context)
        {
            var contacts = new List<PCT.Contact.Models.Contact>
            {
                new PCT.Contact.Models.Contact{Name="皇帝",EnrollmentDate=DateTime.Parse("2015-07-23")},
                new PCT.Contact.Models.Contact{Name="皇后",EnrollmentDate=DateTime.Parse("2015-07-23")},
                new PCT.Contact.Models.Contact{Name="太监",EnrollmentDate=DateTime.Parse("2015-07-23")},
                new PCT.Contact.Models.Contact{Name="侍女",EnrollmentDate=DateTime.Parse("2015-07-23")},
                new PCT.Contact.Models.Contact{Name="锦衣卫",EnrollmentDate=DateTime.Parse("2015-07-23")}
            };
            contacts.ForEach(c => context.Contacts.Add(c));
            context.SaveChanges();

            var groups = new List<PCT.Contact.Models.Group>
            {
                new PCT.Contact.Models.Group{GroupName=PCT.Contact.Models.GroupName.Colleague},
                new PCT.Contact.Models.Group{GroupName=PCT.Contact.Models.GroupName.Family},
                new PCT.Contact.Models.Group{GroupName=PCT.Contact.Models.GroupName.Friend},
                new PCT.Contact.Models.Group{GroupName=PCT.Contact.Models.GroupName.Schoolmate},
                new PCT.Contact.Models.Group{GroupName=PCT.Contact.Models.GroupName.Stranger}
            };
            groups.ForEach(c => context.Groups.Add(c));
            context.SaveChanges();

            var enrollments = new List<PCT.Contact.Models.Enrollment>
            {
                new PCT.Contact.Models.Enrollment{ ContactID=1,GroupID=1024},
                new PCT.Contact.Models.Enrollment{ ContactID=2,GroupID=1025},
                new PCT.Contact.Models.Enrollment{ ContactID=3,GroupID=1026},
                new PCT.Contact.Models.Enrollment{ ContactID=4,GroupID=1027},
                new PCT.Contact.Models.Enrollment{ ContactID=5,GroupID=1028}
            };
            enrollments.ForEach(c => context.Enrollments.Add(c));
            context.SaveChanges();
        }
    }
}