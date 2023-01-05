namespace UserRegistration1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter The First Name : ");
            string FName = Console.ReadLine();
            Console.Write("Enter The Last Name : ");
            string LName = Console.ReadLine();
            Console.Write("Enter the Email : ");
            string Email = Console.ReadLine();


            UserRegistartion registration = new UserRegistartion();
            registration.ValidFirstName(FName);
            registration.ValidateFName(FName);

            UserRegistartion registration1 = new UserRegistartion();
            registration.ValidLastName(LName);
            registration.ValidateLName(LName);



            UserRegistartion registration2 = new UserRegistartion();
            registration.ValidEmail(Email);
            registration.ValidateEmail(Email);
        }
    }
}