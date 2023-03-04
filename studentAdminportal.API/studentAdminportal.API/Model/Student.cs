namespace studentAdminportal.API.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email  { get; set; }
        public string  Contact { get; set; }
        public string profileImage { get; set; }
        public int genderId{ get; set; }
        public Gender  Gender{ get; set; }
        public Address Address { get; set; }
    }

}
