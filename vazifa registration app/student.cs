namespace vazifa_registration_app
{
    internal class IDlar
    {
        public int id = 0;

        public void IDqoshish()
        {
            this.id+=1;
        }
    }

    internal class Student
    {
        public string name;
        public string surname;
        public byte age;
        public string number;
        public string password;

        public Student(string name, string surname, byte age, string number, string password)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.number = number;
            this.password = password;
        }
    }
    internal class recordStudent
    {
        private static IDlar IDson = new IDlar();
        private static List<Student> studentList = new List<Student>();

        public static void StudentQoshish(string name, string surname, byte age, string number, string password)
        {
            IDson.IDqoshish();
            int num = IDson.id;

            Student newStudent = new Student(name, surname, age, number, password);
            studentList.Add(newStudent);

            Console.WriteLine($"Student {num} qo'shildi");
        }
        public static void PrintStudents()
        {
            Console.WriteLine("Studentlar:");
            foreach (var student in studentList)
            {
                Console.WriteLine($"Ismi va Familyasi:  {student.name} {student.surname}\nYoshi:              {student.age}\nNomeri:            {student.number}");
            }
        }
        public static void Kirish(string inputNumber, string inputPassword)
        {
            var matchingStudent = studentList.Find(student => student.number == inputNumber && student.password == inputPassword);

            if (matchingStudent != null)
            {
                Console.WriteLine("login qildingiz");
            }
            else
            {
                Console.WriteLine("Xato: Nomer yoki Parol noto'g'ri kiritildi");
            }
        }
    }
}
