namespace CapstoneDemo.Shared
{
    public class Grade
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public double GradeAmount { get; set; }

        public Grade(int id, string name, string subject, double gradeAmount)
        {
            this.Id = id;
            this.Name = name; 
            this.Subject = subject;
            this.GradeAmount = gradeAmount;
        }
    }
}