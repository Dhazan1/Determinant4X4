using System;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets me help you solve your 4*4 matrices solutions");
            var Solution = new Determinant();
            Solution.GetMatrices();
            Solution.SolveMatrices();
        }
    }

public class Determinant {
      
         int [,] matrices= new int[4,4]; 
        
         public void GetMatrices(){
    
         Console.WriteLine("Enter your values for the first rows and press enter after each values");
            matrices[0,0] = int.Parse( Console.ReadLine());
            matrices[0,1] = int.Parse(Console.ReadLine());
            matrices[0,2] = int.Parse(Console.ReadLine());
            matrices[0,3] = int.Parse(Console.ReadLine());
         Console.WriteLine("values for first rows entered successfully");
         Console.WriteLine("Enter your values for the second rows and press enter after each values");
            matrices[1,0] = int.Parse(Console.ReadLine());
            matrices[1,1] = int.Parse(Console.ReadLine());
            matrices[1,2] = int.Parse(Console.ReadLine());
            matrices[1,3] = int.Parse(Console.ReadLine());
         Console.WriteLine("values for Second rows entered successfully");
         Console.WriteLine("Enter your values for the third rows and press enter after each values");
            matrices[2,0] = int.Parse(Console.ReadLine());
            matrices[2,1] = int.Parse(Console.ReadLine());
            matrices[2,2] = int.Parse(Console.ReadLine());
            matrices[2,3] = int.Parse(Console.ReadLine());
         Console.WriteLine("values for third rows entered successfully");
         Console.WriteLine("Enter your values for the fourth rows and press enter after each values");
            matrices[3,0] = int.Parse(Console.ReadLine());
            matrices[3,1] = int.Parse(Console.ReadLine());
            matrices[3,2] = int.Parse(Console.ReadLine());
            matrices[3,3] = int.Parse(Console.ReadLine());

        }

        public void SolveMatrices() {
          
            // First determinant 
            double determinant1 = +matrices[0, 0] * (
              matrices[1, 1] * ((matrices[3, 3] * matrices[2, 2]) - (matrices[2, 3] * matrices[3, 2]))
             - matrices[1, 2] * ((matrices[3, 3] * matrices[2, 1]) - (matrices[2, 3] * matrices[3, 1]))
             + matrices[1, 3] * ((matrices[3, 2] * matrices[2, 1]) - (matrices[2, 2] * matrices[3, 1]))
          );



            // second determinant 
            double determinant2 =  -matrices[0, 1] * (
              matrices[1, 0] * ((matrices[3, 3] * matrices[2, 2]) - (matrices[2, 3] * matrices[3, 2]))
             - matrices[1, 2] * ((matrices[3, 3] * matrices[2, 0]) - (matrices[2, 3] * matrices[3, 0]))
             + matrices[1, 3] * ((matrices[3, 2] * matrices[2, 0]) - (matrices[2, 2] * matrices[3, 0]))
          );

            // third determinant 
            double determinant3 =  +matrices[0, 2] * (
              matrices[1, 0] * ((matrices[3, 3] * matrices[2, 1]) - (matrices[2, 3] * matrices[3, 1]))
             - matrices[1, 1] * ((matrices[3, 3] * matrices[2, 0]) - (matrices[2, 3] * matrices[3, 0]))
             + matrices[1, 3] * ((matrices[3, 1] * matrices[2, 0]) - (matrices[2, 1] * matrices[3, 0]))
          );


            // fourth determinant 
            double determinant4 = matrices[0, 3] * (
              matrices[1, 0] * ((matrices[3, 2] * matrices[2, 1]) - (matrices[2, 2] * matrices[3, 1]))
             - matrices[1, 1] * ((matrices[3, 2] * matrices[2, 0]) - (matrices[2, 2] * matrices[3, 0]))
             + matrices[1, 2] * ((matrices[3, 1] * matrices[2, 0]) - (matrices[2, 1] * matrices[3, 0]))
          );


            double totalDeterminant = determinant1 - determinant2 + determinant3 - determinant4;

            Console.WriteLine("This is the determinant of your 4*4 matrix \n"+totalDeterminant);

            //fuction bracket
        }


        // class bracket
    }



// namespace bracket
 }