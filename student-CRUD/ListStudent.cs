using System.Collections.Generic;

namespace student_CRUD
{
    internal class ListStudent
    {
        public static List<Student> Liste = new List<Student>();

    public static object liste { get; internal set; }

        public static void ajouter(Student S)
        {
            Liste.Add(S);
        }
     
        public ListStudent()
        {
           
        }
    }
}
