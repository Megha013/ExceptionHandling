//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ExceptionHandling
//{
//    public class AgeException : Exception
//    {
//        public AgeException(string msg) : base(msg)
//        {

//        }
//    }
//    public class Users
//    {
//        private int age;
//        private string name;
//        public Users(int age, string name)
//        {
//            if (age >= 18)
//            {
//                this.age = age;
//            }
//            else
//            {
//                throw new AgeException(age + " age is not allowed");// explict call to exception using throw
//            }
//            //if(IsNullOrEmpty()) name is required
//        }
//        static void Main(string[] args)
//        {
//            try
//            {
//                Users users = new Users(15, "Nick");
//            }
//            catch (AgeException ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//        }
//    }    
//}
