using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace SqlQueryTest
{
    public partial class Form1 : Form
    {
        public enum EPsDBPadShape
        {
            epsdbPadShapeRound = 1,
            epsdbPadShapeOblong = 2,
            epsdbPadShapeSquare = 3,
            epsdbPadShapeRectangle = 4,
            epsdbPadShapeOctagon = 5,
            epsdbPadShapeElongatedOctagon = 6,
            epsdbPadShapeRadiusCornerRectangle = 7,
            epsdbPadShapeChamferedRectangle = 8,
            epsdbPadShapeRoundFinger = 9,
            epsdbPadShapeOctagonalFinger = 10,
            epsdbPadShape4WebRoundThermal = 11,
            epsdbPadShape4WebRoundThermal45 = 12,
            epsdbPadShape2WebRoundThermal = 13,
            epsdbPadShape2WebRoundThermal45 = 14,
            epsdbPadShape4WebSquareThermal = 15,
            epsdbPadShape4WebSquareThermal45 = 16,
            epsdbPadShapeRoundDonut = 17,
            epsdbPadShapeSquareDonut = 18,
            epsdbPadShapeCustom = 19,
            epsdbPadShape4WebRectangleThermal = 20,
            epsdbPadShape4WebRectangleThermal45 = 21,
            epsdbPadShape4WebOblongThermal = 22,
            epsdbPadShape4WebOblongThermal45 = 23,
            epsdbPadShapeLast = 24,
            epsdbPadShapeAll = 25
        }

        public class Student
        {
            public int rollNo { get; set; }
            public string name { get; set; }
            public int age { get; set; }
            public bool isMale { get; set; }
            public bool isFemale { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Debug.WriteLine("Hello World.");
                //string value = "epsdbPadShapeCustom";
                //EPsDBPadShape shp = (EPsDBPadShape)Enum.Parse(typeof(EPsDBPadShape), value);
                //
                //Debug.WriteLine("shape: " + shp + " - " + Enum.Parse(typeof(EPsDBPadShape), value) + ", type: " + Enum.Parse(typeof(EPsDBPadShape), value).GetType());

                //string val = null;
                //bool isBool = Convert.ToBoolean(val);
                //Debug.WriteLine("Val is: " + val + ", isBool: " + isBool);
                /*
                List<string> MainList = new List<string>();
                string name;
                for(int i = 1; i <= 5; i++)
                {
                    name = Convert.ToString("Bala - " + i);
                    MainList.Add(name);
                }
                Debug.WriteLine("1-MainList count: " + MainList.Count);
                List<string>subList = new List<string>();

                foreach(string str in MainList)
                {
                    name = str;
                    subList.Add(name);
                }
                foreach(string str in subList)
                {
                    MainList.Add(str);
                }
                Debug.WriteLine("2-MainList count: " + MainList.Count);
                foreach(string str in MainList)
                {
                    Debug.WriteLine("str - " + str);
                }
                */
                //  two objects are equal or not test

                Student student_1 = new Student();
                Student student_2 = new Student();
                Student student_3 = new Student();

                student_1.rollNo = 2401;
                student_2.rollNo = 2402;
                student_3.rollNo = 2403;

                student_1.name = "Vishnu";
                student_2.name = "Divya";
                student_3.name = "Vishnu";

                student_1.age = 19;
                student_2.age = 12;
                student_3.age = 19;

                student_1.isMale = true;
                student_2.isMale = false;
                student_3.isMale = true;

                student_1.isFemale = false;
                student_2.isFemale = true;
                student_3.isFemale = false;

                if (student_1.Equals(student_2))
                {
                    Console.WriteLine("student_1 and student_2 are equal.");
                }
                else
                {
                    Console.WriteLine("student_1 and student_2 are not equal.");
                }

                if(student_1.Equals(student_3))
                {
                    Console.WriteLine("student_1 and student_3 are equal.");
                }
                else
                {
                    Console.WriteLine("student_1 and student_3 are not equal.");
                }

                if(student_2.Equals(student_3))
                {
                    Console.WriteLine("student_2 and student_3 are equal.");
                }
                else
                {
                    Console.WriteLine("student_2 and student_3 are not equal.");
                }
                Console.WriteLine("Completed...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                
            }
        }
    }
}
