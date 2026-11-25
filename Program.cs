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
        Console.WriteLine("Invalid country code. Use 60, 62, 63, 65, or 66.");
      }
      Console.Write("Enter area code: ");
      string areaCode = Console.ReadLine();

      Console.Write("Enter Number:");
      string phoneNumber = Console.ReadLine();

      Student student = new Student(
        studentNumber,
        surname,
        firstname,
        occupation,
        gender,
        countryCode,
        areaCode,
        PhoneNumber
        );

      phonebook.Addstudent(Student);

      Console.WriteLine("\nStudent successfully added!");
      Console.Write("Do you want to enter another entry [Y/N]? ");
      again = Console.ReadLine().ToUpper();
    } while(again == "y");
  }

static void EditStudent()
{
  Console.WriteLine("\n===== EDIT STUDENT =====");
  
  Console.Write("Enter student number: ");
  string studentNumber = Console.ReadLine();

  Student student = phonebook.FindStudent(studentNumber);

  if (student == null))
  {
    Console.WriteLine("Student number does not exist!");
    return;
  }

  while (true)
  {
    Console.WriteLine("\nHere is the existing information:");
    Console.WriteLine(
      $"{student.FirstName} {student.Surname} is a " +
      $"{student.Occupation}. His/Her number is " +
      $"{Student.CountryCode}-{stundent.AreaCode}-{student.PhoneNumber}");
    
    Console.WriteLine("\nWhich information do you wish to change?");

    Console.WriteLine("[1] Student number");
    Console.WriteLine("[2] Surname");
    Console.WriteLine("[3] Gender");
    Console.WriteLine("[4] Occupation");
    Console.WriteLine("[5] Counntry code");
    Console.WriteLine("[6] Area Code");
    Console.WriteLine("[7] Phone number");
    Console.WriteLine("[8] None - Go back to main menu");

    Console.Write("Enter Choice:");
    string choice = Console.ReadLine();

    switch (choice)
    {
      case "1":
        Console.Write("Enter new student number: ");
        string newNumber = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(newNumber))
        {
          Console.WriteLine("Student number cannot be empty.");
        }
        else if (phonebook.StudentNumberExists(newNumber))
        {
          Console.WriteLine("Student number already exists.");
        }
        else
        {
          student.StudentNumber = newNumber;
          Console.WriteLine("Student number updated!");
        }
        break;
        
      case "2":
        Console.Write("Enter new surname: ");
        student.Surname = Console.ReadLine();
        Console.WriteLine("Surname updated!");
        break;

      case "3":
        Console.Write("Enter new gender (M/F): ");
        string gender = Console.ReadLine().ToUpper();

        if (gender == "M" || gender == "F")
        {
          student.Gender = gender;
          Console.WriteLine("Gender updated!");
        }
        else
        {
          Console.WriteLine("Invalid gender.");
        }
        break;

      case "4":
        Console.Write("Enter new occupation: ");
        student.Occupation = Console.ReadLine();
        Console.WriteLine("Occupation updated!");
        break;

      case "5":
        Console.Write("Enter new country code: ");
        if (int.TryParse(Console.ReadLine(), out int code)
            && Country.IsValidCountryCode(code))
        {
          student.CountryCode = code;
          Console.WriteLine("Country code updated!");
        }
        else
        {
          Console.WriteLine("Invalid country code.");
        } 
        break;

      case "6":
        Console.WriteLine("Enter new area Code: ");
        student.AreaCode = Console.ReadLine();
        Console.WriteLine("Area Code Updated");
        break;

      case "7":
        Console.Write("Enter new PHone Number:");
        student.PhoneNumber = Console.ReadLine();
        Console.WriteLine("Phone number is Updated!");
        break;

        case"8":
        return;

      default:
        Consol.WriteLine("Invalid choice. Try Again.");
        break;
    }
  }
}

  static void SearchStudents()
  {
    Console.WriteLine("\n===== SEARCH BY COUNTRY =====");
    Console.WriteLine("[1] Philippines");
    Console.WriteLine("[2] Thailand");
    Console.WriteLine("[3] Singapore");
    Console.WriteLine("[4] Indonesia");
    Console.WriteLine("[5] Malaysia");
    Console.WriteLine("[6] ALL");
    Console.WriteLine("[0] No More");

    bool AllCountries = false;
    int choiceNumber = 0;

    while (true)
    {
      Console.Write("Enter choice {choiceNumber}: ");
      String intput = Console.ReadLine();

      if ( int.TryParse(input,out int choice))
      {
        Console.WriteLine("Invalid choice.");
        continue;
      }
      if (choice == 0)
        break;
      if (choice == 6)
      {
        allCountries  true;
        break;
      }

      switch (choice)
      {
        case 1:
          selectedCountries.Add(63);
          break;

        case 2:
          selectedCountries.Add(66):
          break;
        case 3:
          selectedCountries.Add(65);
          break;
        case 4:
          selectedCountries.Add(62);
          break;
        case 5:
          selectedCountries.Add(60):
          break;

        default:
          Console.WriteLine("Invalid Choice.");
          continue;
      }
      ChoiceNumber++;
    }
    List<Student> results;
    if (allCountries)
    {
      results = phonebook.GetAllStudent();
      Console.WriteLine("\nHere are all the students:");
    }
    else if (SelectedCountries);

    results = phonebook.SearchByCountry(selectedCountries);
    Console.WriteLine("\nHere are the students from:");
    foreach (int code in selectedCountries)
    {
      Console.WriteLine(Country>GetCountryName()):
    }
  }
  else
            
            
            
            

            
                     
                      
        
        
          
        
          

        

        
                    
    

    
    
  
      



  
        

  

      
      
