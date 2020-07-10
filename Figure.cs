using System;

namespace MindBox_job
{
    public class Figure
    {
        private string name;

        public string Name   
        {
            get { return name; }  
            set { name = value; }  
        }
        public void Display()
        {
            Console.WriteLine(Name);
        }
    }

    class Triangle:Figure
    {
        float square = 0;
        float side_A = 0;
        float side_B = 0;
        float side_C = 0;
        public Triangle(float a, float b, float c)
        {
            side_A = a;
            side_B = b;
            side_C = c;
        }

        public float Square()
        {
            float h_p = (side_A + side_B + side_C) / 2;
            square = (float)Math.Sqrt(h_p * (h_p - side_A) * (h_p - side_B) * (h_p - side_C));
            return square;
        }

        public bool Right()
        {
            bool answer = false;
            if ((side_A * side_A + side_B * side_B == side_C * side_C) || (side_A * side_A + side_C * side_C == side_B * side_B) || (side_C * side_C + side_B * side_B == side_A * side_A))
            {
                 answer = true;
            }
            else {
                answer = false;
            }
            return answer;
        }
    }

    class Circle : Figure
    {
        float square;
        float radius = 0;

        public Circle(float r)
        {
            radius = r;
        }

        public float Square()
        {

            square = (float)Math.PI * radius * radius;

            return square;
        }
    }



}
