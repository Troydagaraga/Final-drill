using System;
using System.Collection.Generic;
using System.Linq;

class student{
  public string StudentNumber { get;set; }
  public string Surname { get;set; }
  public string Firstname { get; set; }
  public string Occupation { get; set; }
  public string Gender { get; set; } 
  public int CountryCode { get; set; }
  public string AreaCode { get; set; }
  public string PhoneNumber { get; set; }

  public Student(string studentNumber, string surname,string firstName,string occupation,string gender,int countryCode,string areaCode,string phoneNumber)
  {
    StundentNumber = StudentNumber;
    Surname = surname;
    Firstname = firstName;
    Occupation = occupation;
    Gender = gender;
    CountryCode = countryCode;
    AreaCode = areaCode;
    PhoneNumber = phoneNumber;
  }

  public void Diplay()
  {
    Console.Write(
      $"{Surname}, {Firstname}, with stundent number" +
      $"{StudentNUmber}, is a {Occupation}. " +
      $"His/Her Phone number is {CountryCode}-" +
      ${AreaCode}-{PhoneNumber}");
      }
      }

class ASEANPhoneBook{
  private List<student> student = new List<Student>();
  public void addStudent(Student student)
  {
    student.Add(student);
  }
  public Student FindStudent(String StudentNumber)
  {
    return student.FirstOrDefault(
      s => s.StudentNumber == studentNumber);
  }

  public bool StudentNumberExist(string studentNumber)
  {
    return student.Any(
      s => s.StudentNumber == studentNumber);
  }
  public List<Student> SearchByCountry(HashSet<int> countryCodes)
  {
    return students
      .Where(s => countryCodes.Contains(s.CountryCode))
      .OrderBy(s => s.Surname)
      .ToList();
  }
  public List<Student> GetAllStudent()
  {
    return students
      .OrderBy(s => s.Surname)
      .ToList();
  }
}
 class country
      {
        public static readonly Dictionary<int,string> Countries = new Dictionary<int,string>()
        {
          {60, "Malaysia" },
          {62, "Indonesia" },
          {63, "Philippines" },
          {65, "Singapore" },
          {66, "Thailand" },
        };

        public static bool IsValidCountryCode(int code)
        {
          return Countries.ContainsKey(code);
        }
        public static string GetCountryName(int code)
        {
          return Coountries.ContainsKey(code)
            ? Countries[code]
            : "Unknown";
        }
      }
class Program
{
static ASEANPhonebook phonebook = new ASEANPhonebook();

  static void Main()
        {
          while (true)
          {
          Console.WriteLine("\n===== ASEAN PHONEBOOK =====");
          Console.WriteLine("[1] Store to ASEAN Phonebook");
          Console.WriteLIne("[2] Edit entry in ASEAN phonebook");
          Console.WriteLine("[3] Search ASEAN phonebook by country");
          Console.WriteLine("[4] Exit");

          Console.Write("Enter choice: ");

          string choice = Console.ReadLIne();

            switch (choice)
            {
              case "1":
                StoresStudent();
                break;

              case "2":
                EditStudent();
                break;

              case "3":
                SearchStudents();
                break;

              case "4":
                Console.WriteLine("Thank you for using ASEAN Phonebook!");
                return;

              default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
            }
          }
  }

  static void StoresStudent()
  {
    string again;
    do 
    {
      Console.writeLine("\n===== STORE STUDENT =====");

      string studentNumber;

      while(true)
      {
        Console.Write("Enter student number: ");
        studentNumber = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(studentNumber))
        {
          console.WriteLine("Student number cannot be empty.");
        }
        else if (phonebook.StudentNumberExist(studentNumber))
        {
          Console.WriteLine("Student number already exists.");
        }
        else
        {
          break;
        }
      }

      Console.Write("Enter surname: ");
      string surname = Console.ReadLine();

      Console.Write("Enter first name: ");
      string firstName = Console.ReadLine();

      Console.Write("Enter occupation: ");
      string occupation = Console.ReadLine();

      string gender;

      while (true)
      {
        console.Write("Enter gender (M/F): ");
        gender = Console.ReadLine().ToUpper();
         if (gender == "M" || gender == "F")
           break;
        Console.WriteLine("Invalid gender.");
      }
      int countryCode;

      while (true)
      {
        Console.Write("Enter country code: ");
        if (int.TryParse(Console.ReadLine(), out countryCode)
            && Country.IsValidCountryCode(countryCode))
        {
          break;
        }
        


  
        

  

      
      
