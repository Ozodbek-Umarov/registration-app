using vazifa_registration_app;
class Program
{
    static void Main()
    {
        Console.WriteLine("Studentlarni kirish qismiga Xush kelibsiz");

        bool chiqish = true;
        while (chiqish)
        {
            Console.WriteLine("1:Registratsiya");
            Console.WriteLine("2.Kirish");
            Console.WriteLine("3.Studentlar Ro'yxati");
            Console.WriteLine("4.Consolni tozalash");
            Console.WriteLine("5.Dasturdan chiqish");
            Console.Write("O'zingiz uchun kerakli bo'limni tanlang: ");
            byte buyruq = byte.Parse(Console.ReadLine());
            switch (buyruq)
            {
                case 1:
                    Console.Write("Ismingizni kiriting: ");
                    string name = Console.ReadLine();
                    Console.Write("Familyangizni kiriting: ");
                    string surname = Console.ReadLine();
                    Console.Write("yoshingizni kiriting: ");
                    byte age = byte.Parse(Console.ReadLine());
                    Console.Write("Tel nomeringizni kiriting (+998xxxxxxxxx): ");
                    string number = Console.ReadLine();
                    Console.Write("Parol o'ylab toping: ");
                    string password = Console.ReadLine();
                    recordStudent.StudentQoshish(name, surname, age, number, password);
                    break;

                case 2:
                    Console.Write("Tel nomeringizni kiriting: ");
                    string number_lg = Console.ReadLine();
                    Console.Write("Parolingizni kiriting: ");
                    string password_lg = Console.ReadLine();
                    recordStudent.Kirish(number_lg, password_lg);
                    break;
                case 3:
                    recordStudent.PrintStudents();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Console tozalandi:)");
                    break;

                case 5:
                    chiqish = false;
                    Console.WriteLine("Siz dasturdan chiqdingiz:(►__◄)");
                    break;

                default:
                    Console.WriteLine("Xato buyruq kiritdingiz( •̀ ω •́ )y");
                    break;
            }
        }
    }
}