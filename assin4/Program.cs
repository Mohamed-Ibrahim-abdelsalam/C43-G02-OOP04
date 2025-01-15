using common;
namespace assin4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region calculator

            Calculator calc = new Calculator();

            
            Console.WriteLine(calc.Add(2, 3)); 
            Console.WriteLine(calc.Add(1, 2, 3)); 
            Console.WriteLine(calc.Add(1.5, 2.5));






            #endregion

            #region Rectangle

            Rectangle rect1 = new Rectangle();
            rect1.DisplayDimensions(); 


            Rectangle rect2 = new Rectangle(4, 6);
            rect2.DisplayDimensions(); 

   
            Rectangle rect3 = new Rectangle(5);
            rect3.DisplayDimensions();



            #endregion

            #region ComplexNumber

            ComplexNumber c1 = new ComplexNumber(3, 4);
            ComplexNumber c2 = new ComplexNumber(1, 2);

        
            ComplexNumber sum = c1 + c2;
            Console.WriteLine($"Sum: {sum}");

           
            ComplexNumber difference = c1 - c2;
            Console.WriteLine($"Difference: {difference}");










            #endregion

            #region Employee

            Employee emp = new Employee();
            emp.Work(); 

            Manager mgr = new Manager();
            mgr.Work();








            #endregion

            #region BaseClass

            BaseClass baseClass = new BaseClass();
            baseClass.DisplayMessage(); 
            
            BaseClass derived1 = new DerivedClass1();
            derived1.DisplayMessage(); 

          
            BaseClass derived2AsBase = new DerivedClass2();
            derived2AsBase.DisplayMessage(); 

            DerivedClass2 derived2 = new DerivedClass2();
            derived2.DisplayMessage();









            #endregion

            #region Duration

            Duration d1 = new Duration(1, 30, 45);
            d1.DisplayDuration();

            Duration d2 = new Duration();
            d2.DisplayDuration();


            #endregion

            #region Duration2

            Duration d1 = new Duration(1, 30, 45);
            Duration d2 = new Duration(1, 30, 45);
            Duration d3 = new Duration(2, 15, 10);

           
            Console.WriteLine(d1.ToString()); 

            
            Console.WriteLine(d1.Equals(d2)); 
            Console.WriteLine(d1.Equals(d3)); 

          
            Console.WriteLine(d1.GetHashCode() == d2.GetHashCode()); 
            Console.WriteLine(d1.GetHashCode() == d3.GetHashCode());








            #endregion

            #region Duration3

            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString()); 
            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString()); 

            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString()); 

            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString());








            #endregion

            

        }
    }
}
