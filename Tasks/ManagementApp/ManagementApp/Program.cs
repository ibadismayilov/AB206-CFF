using ManagementApp.Models;
using static ManagementApp.Models.UserDepartment;
using static ManagementApp.Models.UserGender;

namespace ManagementApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;

            do
            {
                Console.WriteLine("====================");
                Console.WriteLine("1. Yeni xəstə əlavə et");
                Console.WriteLine("2. Yeni həkim əlavə et");
                Console.WriteLine("3. Həkimə xəstə təyin et");
                Console.WriteLine("4. Xəstələrin siyahısı");
                Console.WriteLine("5. Həkimlərin siyahısı");
                Console.WriteLine("6. Statistikaya bax");
                Console.WriteLine("7. Çıxış");
                Console.WriteLine("====================");

                bool check = int.TryParse(Console.ReadLine(), out result);
                if (check)
                {
                    switch (result)
                    {
                        case 1:
                            Console.Write("Xəstə name: ");
                            string name = Console.ReadLine();

                            Console.Write("Xəstə surname: ");
                            string surname = Console.ReadLine();

                            Console.Write("Xəstə gender: ");
                            string gender = Console.ReadLine();
                            Enum.TryParse(gender, out Genders type);

                            Patient patient = new Patient(name, surname, type);

                            DBContext.AddNewPatient(patient);
                            break;

                        case 2:
                            Console.Write("Doctor name: ");
                            string doctorName = Console.ReadLine();

                            Console.Write("Doctor surname: ");
                            string doctorSurname = Console.ReadLine();

                            Console.Write("Doctor age: ");
                            int age = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Doctor departmentEnum: ");
                            string departmentEnum = Console.ReadLine();
                            Enum.TryParse(departmentEnum, out Department departmentType);

                            Console.Write("Doctor experienceYear: ");
                            int experienceYear = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Doctor gender: ");
                            string doctorGender = Console.ReadLine();
                            Enum.TryParse(doctorGender, out Genders doctorGenderType);

                            Console.WriteLine("Patient List: ");

                            Doctor doctor = new Doctor(doctorName, doctorSurname, age, experienceYear, doctorGenderType, departmentType);

                            DBContext.AddNewDoctor(doctor);

                            break;

                        case 3:
                            DBContext.GetAllAppointment();
                            break;
                        case 4:
                            DBContext.GetAllPatient();
                            break;
                        case 5:
                            DBContext.GetAllDoctor();
                            break;

                        case 6:
                            DBContext.GetAllDoctor();
                            break;

                        case 7:
                            Console.WriteLine("Programdan cixildi");
                            break;
                    }
                }
            }
            while (result != 0);
        }
    }
}
