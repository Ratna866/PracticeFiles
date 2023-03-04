namespace studentAdminportal.API.Model
{
    public class Address
    {
        public int Id { get; set; }
        public string physicalAddress{ get; set; }
        public string  PostalAddress { get; set; }
        public int  StudentId { get; set; }
    }
}