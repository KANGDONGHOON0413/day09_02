using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace day09_02
{
    struct Grade
    {
        private int keynum;
        private string name;
        public int kor, math, eng;
        public double avg;

        public int Keynum
        {
            get { return keynum; }
            set { keynum = value; }
        } 

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("학생수: ");
            int cnt = int.Parse(Console.ReadLine());
            Console.WriteLine("학생의 학번 이름 국어 수학 영어 점수를 차례대로 입력하시오");

            Grade[] Grades = new Grade[cnt];
            FileStream fs = new FileStream("test.txt", FileMode.Create);
            var swriter = new StreamWriter(fs);
            swriter.WriteLine("학생수: {0}", cnt);

            for(int a=0;a<cnt;a++)
            {
            string str = Console.ReadLine();
            string[] str_Element = str.Split(new char[] { ' ' });
                Grades[a].Keynum = int.Parse(str_Element[0]);
                Grades[a].Name = str_Element[1];
                Grades[a].kor = int.Parse(str_Element[2]);
                Grades[a].math = int.Parse(str_Element[3]);
                Grades[a].eng = int.Parse(str_Element[4]);
                Grades[a].avg = (Grades[a].kor + Grades[a].math + Grades[a].eng)/3.0;
            }

            swriter.WriteLine("");
            swriter.WriteLine("num      학번    이름    국어  수학  영어  평균");
            Console.WriteLine("num      학번    이름    국어  수학  영어  평균");

            for (int i = 0; i<cnt; i++)
            {
                swriter.WriteLine(" {0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", i, Grades[i].Keynum, Grades[i].Name, Grades[i].kor, Grades[i].math, Grades[i].eng, Grades[i].avg);
                Console.WriteLine(" {0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", i, Grades[i].Keynum, Grades[i].Name, Grades[i].kor, Grades[i].math, Grades[i].eng, Grades[i].avg);
            }
            swriter.Close();
        }
    }
}
