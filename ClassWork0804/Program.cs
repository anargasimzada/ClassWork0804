using ClassWork0804.Moduls;

namespace ClassWork0804
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Group group=new Group();
            Student student=new Student("Anar", "Qasimzade",123);
            student.GetInfo();
           
            group.GroupName = "test";
            
        }

    }
}