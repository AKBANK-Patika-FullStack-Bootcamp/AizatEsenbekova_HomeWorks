namespace DAL.Model
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int ? Age { get; set; }
        public int ? GuideId { get; set; }
        public int ? AddressId { get; set; }
    }
}
