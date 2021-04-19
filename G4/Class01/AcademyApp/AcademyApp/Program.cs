using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace AcademyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region Create Users
                List<Subject> subjects = new List<Subject>();
                subjects.Add(new Subject("HTML/CSS"));
                subjects.Add(new Subject("JavaScript Basic"));
                subjects.Add(new Subject("JavaScript Advanced"));
                subjects.Add(new Subject("C# Basic"));
                subjects.Add(new Subject("C# Advanced"));

                List<Person> users = new List<Person>();
                users.Add(new Admin("John", "Peterson", "user01", "pass01"));
                users.Add(new Admin("Ben", "Johnson", "user02", "pass02"));
                users.Add(new Trainer("Peter", "Steel", "user03", "pass03"));
                users.Add(new Trainer("Dean", "McNeil", "user04", "pass04"));
                users.Add(new Student("John", "Peterson", "user05", "pass05", new Dictionary<Subject, int> { { subjects[0], 7 }, { subjects[2], 10 } }));
                users.Add(new Student("David", "Peters", "user06", "pass06", new Dictionary<Subject, int> { { subjects[1], 9 }, { subjects[4], 8 } }));
                users.Add(new Student("Christina", "Meyers", "user07", "pass07", new Dictionary<Subject, int> { { subjects[2], 6 }, { subjects[3], 9 } }));
                users.Add(new Student("Kate", "Stevenson", "user08", "pass08", new Dictionary<Subject, int> { { subjects[0], 10 }, { subjects[3], 8 } }));
                users.Add(new Student("Kristina", "Spasevska", "user09", "pass09", new Dictionary<Subject, int> { { subjects[0], 8 }, { subjects[3], 10 } }));


                #endregion

                #region Welcome
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("-----------------------Web Academy------------------------");
                Console.WriteLine("This is an application for admins, trainers and students of the Web Academy.");
                Console.WriteLine("Follow the instructions after each step to use this app!");
                Console.WriteLine("-----------------------------------------------------------");
                Console.ResetColor();
                #endregion
                while (true)
                {

                    #region Login
                    Person user;
                    while (true)
                    {
                        Console.WriteLine("Enter username:");
                        string inputUserName = Console.ReadLine();
                        user = users
                            .Where(x => x.UserName == inputUserName)
                            .FirstOrDefault();

                        if (user == null)
                        {
                            Console.WriteLine("There isn't such username!");
                            continue;
                        }
                        Console.WriteLine("Enter password:");
                        string inputPassword = Console.ReadLine();
                        if (user.ValidatePassword(inputPassword))
                        {
                            Console.WriteLine($"Successful login! Welcome {user.GetFullName()}!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Wrong password, please try again!");
                            continue;
                        }

                    }
                    #endregion

                    #region Admin
                    if (user.PersonRole == Role.Admin)
                    {
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Your role in the academy is an admin!");
                        Console.WriteLine("Choose one of the options in the menu:");
                        Console.WriteLine("Press 1 to add users or press 2 to remove users...");

                        int inputChoice = int.Parse(Console.ReadLine());
                        //add  option
                        if (inputChoice == 1)
                        {
                            Console.WriteLine("Add first name:");
                            string addFirstName = Console.ReadLine();
                            Console.WriteLine("Add last name:");
                            string addLastName = Console.ReadLine();
                            Console.WriteLine("Add username:");
                            string addUserName = Console.ReadLine();
                            Console.WriteLine("Add password:");
                            string addPassword = Console.ReadLine();
                            Console.WriteLine("Press 1 to add and admin, press 2 to add trainer and 3 to add student... ");
                            int inputChoice02 = int.Parse(Console.ReadLine());


                            switch (inputChoice02)
                            {
                                case 1:
                                    users.Add(new Admin(addFirstName, addLastName, addUserName, addPassword));
                                    Console.WriteLine("A new admin has been created!");
                                    Console.WriteLine("Log out user...");
                                    Console.WriteLine("---------------------------------------------------");
                                    continue;
                                case 2:
                                    users.Add(new Trainer(addFirstName, addLastName, addUserName, addPassword));
                                    Console.WriteLine("A new trainer has been created!");
                                    Console.WriteLine("Log out user...");
                                    Console.WriteLine("---------------------------------------------------");
                                    continue;
                                case 3:
                                    users.Add(new Student(addFirstName, addLastName, addUserName, addPassword, new Dictionary<Subject, int>()));
                                    Console.WriteLine("A new student has been created!");

                                    string answer;
                                    do
                                    {
                                        Console.WriteLine("Add subject from following:");
                                        foreach (var item in subjects)
                                        {
                                            Console.WriteLine(item.Name);
                                        }
                                        string subInp = Console.ReadLine();
                                        Console.WriteLine("Add grade");
                                        int grInp = int.Parse(Console.ReadLine());
                                        Person lastAdded = users.FirstOrDefault(x => x.FirstName == addFirstName);
                                        Student lastSt = (Student)lastAdded;
                                        lastSt.PreviousSubjects.Add(new Subject(subInp), grInp);
                                        Console.WriteLine($"Subject {subInp} added!");
                                        Console.WriteLine("Would you like to add subjects for student?");
                                        answer = Console.ReadLine().ToUpper();

                                        continue;
                                    }
                                    while (answer == "Y");
                                    Console.WriteLine("Log out user...");
                                    Console.WriteLine("---------------------------------------------------");
                                    continue;
                                default:
                                    Console.WriteLine("No option for your choice!");
                                    break;
                            }

                        }

                        //remove option
                        else if (inputChoice == 2)
                        {
                            Console.WriteLine("You have chosen to remove a user.");
                            Console.WriteLine("Add username:");
                            string addUserName = Console.ReadLine();
                            if (user.UserName == addUserName)
                            {
                                Console.WriteLine("You can't remove yourself!");
                                Console.WriteLine("Log out user...");
                                Console.WriteLine("---------------------------------------------------");
                                continue;
                            }
                            else
                            {
                                if (users.Remove(users.FirstOrDefault(x => x.UserName == addUserName)))
                                {
                                    Console.WriteLine($"User with username {addUserName} removed!");
                                    Console.WriteLine("Log out user...");
                                    Console.WriteLine("---------------------------------------------------");
                                    continue;
                                }
                                else
                                {
                                    Console.WriteLine("No such username found!");
                                    Console.WriteLine("Log out user...");
                                    Console.WriteLine("---------------------------------------------------");
                                    continue;
                                }
                            }
                        }
                        else if ((inputChoice != 1) || (inputChoice != 2))
                        {
                            Console.WriteLine("No options for your choice!!!");
                            Console.WriteLine("Log out user...");
                            Console.WriteLine("---------------------------------------------------");
                            continue;
                        }


                    }
                    #endregion

                    #region Trainer
                    if (user.PersonRole == Role.Trainer)
                    {
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Your role in the academy is a trainer!");
                        Console.WriteLine("Choose one of the options in the menu:");
                        Console.WriteLine("Press 1 to see students or press 2 to list all subjects...");
                        int inputChoice = int.Parse(Console.ReadLine());
                        //list of students
                        List<Person> listStudents = users
                                .Where(x => x.PersonRole == Role.Student)
                                .ToList();
                        //cast class elements into Student!!!!!!!!!!!!!!!!
                        List<Student> listOfStudents = listStudents.Cast<Student>().ToList();

                        if (inputChoice == 1)
                        {
                            Console.WriteLine("---------------------------------------------------");
                            Console.WriteLine("You can choose a student's name to see their grades:");

                            foreach (var students in listOfStudents)
                            {
                                Console.WriteLine(students.GetFullName());
                            }
                            string inputName = Console.ReadLine();
                            Console.WriteLine("---------------------------------------------------");
                            foreach (var student in listOfStudents)
                            {
                                if (student.FirstName == inputName)
                                {
                                    Console.WriteLine(student.GetInfo());
                                }
                            }
                            Console.WriteLine("Log out user...");
                            Console.WriteLine("---------------------------------------------------");
                            continue;
                        }
                        else if (inputChoice == 2)
                        {
                            int htmlCount = 0;
                            int jsbCount = 0;
                            int jsaCount = 0;
                            int csbCount = 0;
                            int csaCount = 0;
                            foreach (Student st in listOfStudents)
                            {
                                foreach (var sub in st.PreviousSubjects)
                                {
                                    if (sub.Key.Name == "HTML/CSS")
                                    {
                                        htmlCount++;
                                        continue;
                                    }
                                    else if (sub.Key.Name == "JavaScript Basic")
                                    {
                                        jsbCount++;
                                        continue;
                                    }
                                    else if (sub.Key.Name == "JavaScript Advanced")
                                    {
                                        jsaCount++;
                                        continue;
                                    }
                                    else if (sub.Key.Name == "C# Basic")
                                    {
                                        csbCount++;
                                        continue;
                                    }
                                    else if (sub.Key.Name == "C# Advanced")
                                    {
                                        csaCount++;
                                        continue;
                                    }
                                }
                            }

                            Console.WriteLine($"HTML/CSS was listened by {htmlCount} students.");
                            Console.WriteLine($"JavaScript was listened by {jsbCount} students.");
                            Console.WriteLine($"JavaScript - Advanced was listened by {jsaCount} students.");
                            Console.WriteLine($"C# Basic was listened by {csbCount} students.");
                            Console.WriteLine($"C# Advanced was listened by {csaCount} students.");
                            Console.WriteLine("---------------------------------------");
                            Console.WriteLine("Log out user...");
                            Console.WriteLine("---------------------------------------------------");
                            continue;
                        }
                        else if ((inputChoice != 1) || (inputChoice != 2))
                        {
                            Console.WriteLine("No options for your choice!");
                            Console.WriteLine("Log out user...");
                            Console.WriteLine("---------------------------------------------------");
                            continue;
                        }
                    }
                    #endregion


                    #region Student
                    if (user.PersonRole == Role.Student)
                    {
                        Console.WriteLine("---------------------------------------------------");
                        Student student = (Student)user;
                        Console.WriteLine("Your role in the academy is a student!");
                        Console.WriteLine("Choose one of the options in the menu:");
                        Console.WriteLine("Press 1 to enroll a subject or press 2 to list all grades...");
                        int inputChoice = int.Parse(Console.ReadLine());

                        if (inputChoice == 1)
                        {
                            Console.WriteLine("---------------------------------------------------");
                            Console.WriteLine("This is a list of subjects you can choose:");
                            foreach (Subject sub in subjects)
                            {
                                if (!student.PreviousSubjects.ContainsKey(sub))
                                {
                                    Console.WriteLine(sub.Name);
                                }
                            }
                            string chosenSubject = Console.ReadLine();
                            Console.WriteLine("---------------------------------------------------");
                            student.Enroll(subjects.FirstOrDefault(x => x.Name == chosenSubject));
                            Console.WriteLine($"Your current subject is: {student.CurrentSubject.Name}");
                            Console.WriteLine("Log out user...");
                            Console.WriteLine("---------------------------------------------------");
                            continue;
                        }
                        if (inputChoice == 2)
                        {
                            Console.WriteLine(student.GetInfo());
                            Console.WriteLine("Log out user...");
                            Console.WriteLine("---------------------------------------------------");
                            continue;
                        }
                    }
                    #endregion

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
