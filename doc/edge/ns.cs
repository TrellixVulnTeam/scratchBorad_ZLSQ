namespace My.Namespace
{
    public class MyClassA
    {
        public void MyMethod()
        {
            // Use value from MyOtherClass
            int myValue = My.Other.Namespace.MyOtherClass.MyInt;
        }
    }
}

namespace My.Other.Namespace
{
    public class MyOtherClass
    {
        private static int myInt;
        public static int MyInt
        {
            get {return myInt;}
            set {myInt = value;}
        }
        public static int MyOtherInt {get;set;}
    }
}