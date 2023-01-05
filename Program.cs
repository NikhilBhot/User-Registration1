namespace UserRegistration1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter The First Name : ");
            string FName = Console.ReadLine();
            UserRegistartion registration = new UserRegistartion();
            registration.ValidFirstName(FName);
            registration.ValidateFName(FName);
        }
    }
}