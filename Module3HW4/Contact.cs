namespace Module3HW4
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FullName => $"{FirstName} {SecondName}";
        public string PhoneNumber { get; set; }
    }
}
