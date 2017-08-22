using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample1
{
    class Program
    {
        //enum days
        //{
        //    sunday,
        //    monday,
        //    tuesday,
        //    wednesday,
        //    thursday,
        //    friday,
        //    saturday
        //};
        
        static void Main(string[] args)
        {
            #region boxing 
            //int value = 1;
            //object obj = value;//boxing
            //Console.WriteLine(obj);
            //int a = (int)obj;//unboxing
            //Console.WriteLine(a);
            //Console.ReadLine();
            #endregion
            #region dynamic
            //dynamic dyvar1 = 3;
            //dynamic dyvar2 = "fsyhyh";
            //dynamic dyvar3 = false;
            //Console.WriteLine(dyvar1.GetType().ToString());
            //Console.WriteLine(dyvar2.GetType().ToString());
            //Console.WriteLine(dyvar3.GetType().ToString());
            //Console.ReadLine();
            #endregion
            #region nullable
            //int? i = null;
            //int j = i ?? 5;
            //Console.WriteLine(i);
            //Console.ReadLine();
            #endregion
            #region duplicate nos
            //int count = 0;
            //int a = 0;
            //int j;
            //Console.WriteLine("Enter the limit: ");
            //int limit = Convert.ToInt32(Console.ReadLine());
            //int[] numArray = new int[limit];
            //Console.WriteLine("Enter the numbers: ");
            //for (int i = 0; i < limit; i++)
            //{
            //    numArray[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < limit; i++)
            //{
            //    for (j = i + 1; j < limit; j++)
            //    {
            //        if (numArray[i] < numArray[j])
            //        {
            //            int temp = numArray[i];
            //            numArray[i] = numArray[j];
            //            numArray[j] = temp;
            //        }
            //    }
            //}
            //for (int i = 0; i < limit;)
            //{
            //    count++;
            //    for (j = i + 1; j < limit; j++)
            //    {
            //        if (numArray[i] == numArray[j])
            //        {
            //            count++;
            //            a = numArray[i];
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //    if (count > 1)
            //    {
            //        Console.WriteLine("The number " + numArray[i] + " occured " + count + " times");
            //    }
            //    count = 0;
            //    i = j;
            //}
            //Console.ReadLine();
            #endregion
            #region custom exception
            //        try
            //        {
            //            Temperature temperature = new Temperature();
            //            temperature.showTemp();
            //            Console.ReadLine();
            //        }
            //        catch(TempZeroException e)
            //        {
            //            Console.WriteLine(e.Error);
            //            Console.ReadLine();
            //        }
            //    }
            //}
            //public class TempZeroException: Exception
            //{
            //    public string Error { get; set; }
            //    public TempZeroException(string message) :base(message)
            //    {
            //        Error = "test 123";
            //    }
            //}
            //public class Temperature 
            //{
            //    int temp = 0;
            //    public void showTemp()
            //    {
            //        if (temp == 0)
            //        {
            //            throw (new TempZeroException("zero temperature found"));
            //        }
            //        else
            //        {
            //            Console.WriteLine(temp);
            //        }
            //    }
            //}
            #endregion
            #region  tryParse
            //int numerator, denominator;
            //Console.WriteLine("enter numerator");
            //string num =Console.ReadLine();
            //bool IsValid = Int32.TryParse(num, out numerator);
            //if (IsValid)
            //{
            //    Console.WriteLine("enter denominator");
            //    string deno = Console.ReadLine();
            //    bool IsValidDenominator = Int32.TryParse(deno, out denominator);
            //    if (IsValidDenominator)
            //    { 
            //        if (denominator!=0)
            //        {
            //            Console.WriteLine("Result is " + (numerator / denominator));
            //        }
            //        else
            //        {
            //            Console.WriteLine("Denominator should not be 0");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Number should be entered {0} and {1}",int.MinValue,int.MaxValue);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Number should be entered {0} and {1}", int.MinValue, int.MaxValue);
            //}
            //Console.ReadLine();
            #endregion
            //Console.WriteLine((int)days.friday);
            //Test test = new Test();
            //test.display();
            //test.show();
            #region pattern
            //Console.WriteLine("Enter no of rows: ");
            //int row = Convert.ToInt32(Console.ReadLine());
            //for(int i = 1; i <= row; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.WriteLine("");
            //}
            //Console.ReadLine();
            #endregion
            #region struct

            //Student student = new Student();
            //List<Student> studentList = new List<Student>();

            //Console.WriteLine("Enter the details: ");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Enter Id: ");
            //    student.id = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter name: ");
            //    student.name = Console.ReadLine();
            //    Console.WriteLine("Enter mark: ");
            //    student.mark1 = Convert.ToDecimal(Console.ReadLine());
            //    Console.WriteLine("Enter mark: ");
            //    student.mark2 = Convert.ToDecimal(Console.ReadLine());
            //    Console.WriteLine("Enter mark: ");
            //    student.mark3 = Convert.ToDecimal(Console.ReadLine());
            //    student.sum = student.mark1 + student.mark2 + student.mark3;
            //    studentList.Add(student);
            //}

            //Console.WriteLine("Enter the Id of the student to be displayed: ");
            //int id = Convert.ToInt32(Console.ReadLine());

            //foreach (Student s in studentList)
            //{
            //    if (id == s.id)
            //    {
            //        Console.WriteLine("ID: {0}", s.id);
            //        Console.WriteLine("Name: {0}", s.name);
            //        Console.WriteLine("Mark 1: {0}", s.mark1);
            //        Console.WriteLine("Mark 2: {0}", s.mark2);
            //        Console.WriteLine("Mark 3: {0}", s.mark3);
            //        Console.WriteLine("Total: {0}", s.sum);
            //    }
            //}
            //Console.ReadLine();
            #endregion
        }
    }
    #region partial class
    //public partial class Test
    //{
    //    public void display()
    //    {
    //        Console.WriteLine("test");
    //    }
    //}
    //public partial class Test
    //{
    //    public void show()
    //    {
    //        Console.WriteLine("show");
    //    }
    //}
    #endregion

    //public struct Student
    //{
    //    public int id;
    //    public string name;
    //    public decimal mark1,mark2,mark3;
    //    public decimal sum;
    //};

}
