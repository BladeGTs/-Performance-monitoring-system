using StudyControl.Data;
using StudyControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyControl
{
    public class SampleData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (!context.Students.Any())
            {
                context.Students.AddRange(

                    new Student
                    {
                        FirstName = "Валентинн",
                        SecondName = "Погодаев",
                        LastName = "adasfa",
                        GroupId = 1,
                    },
                    new Student
                    {
                        FirstName = "asdasfa",
                        SecondName = "Погоsdaasdasдаев",
                        LastName = "adasdasdasdfa",
                        GroupId = 1
                    });

            };
            if (!context.Groups.Any())
            {
                context.Groups.AddRange(

                    new Group
                    {
                        NumberGroup = "1130"
                    },
                    new Group
                    {
                        NumberGroup = "1290"
                    });

            };


            context.SaveChanges();
        }
    }
}
