namespace student_CRUD
{
    public class Student
    {
        public Student() { }
        public Student(string nom,string prenom,string cne)
        {
            ids++;
            this.id = ids;
            this.nom = nom;
            this.prenom = prenom;
            this.cne = cne;

        }
        static int ids;
        public int id ;
        public string nom;
        public string prenom;
        public string cne;

    }
}