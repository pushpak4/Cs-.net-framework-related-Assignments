using System;
namespace RectangleApplication
{
   class Rectangle
   {
  
      internal double length;
      internal double width;
      
      double GetArea()
      {
         return length * width;
      }
      public void Display()
      {
         Console.WriteLine("Length: {0}", length);
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
      }
   }//end class Rectangle
   
   class ExecuteRectangle
   {
      static void Main(string[] args)
      {
         Rectangle r = new Rectangle();
         r.length = 11.5;
         r.width = 12;
         r.Display();
         Console.ReadLine();
      }
   }
}