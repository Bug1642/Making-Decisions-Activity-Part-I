namespace UnoTrue
{
    public class StudentInput
    {
        public bool isBool(int number1)
        {
            bool isUno;
            if (number1 == 1)
                isUno =true;
            else
                isUno=false;
            return isUno;
        }
    }
    class Program{
        static void Main(string [] args){
            StudentInput StudentInput = new StudentInput();
            Console.WriteLine(StudentInput.isBool(0));
            Console.WriteLine(StudentInput.isBool(1));
        }
    }
}