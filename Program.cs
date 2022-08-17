using System;
namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new List<clsroom>()
            {
                new clsroom(){ stud_id=1,stud_Fname="Tania",stud_lname="Ghosh",Roll_no=65},
                new clsroom(){ stud_id=2,stud_Fname="Poulami",stud_lname="Dhar",Roll_no=15},
                new clsroom(){ stud_id=3,stud_Fname="suvo",stud_lname="dey",Roll_no=89},
                new clsroom(){ stud_id=4,stud_Fname="nishan",stud_lname="Mal",Roll_no=68},
                new clsroom(){ stud_id=5,stud_Fname="souvik",stud_lname="ghosh",Roll_no=14},
                new clsroom(){ stud_id=6,stud_Fname="Debjit",stud_lname="Purkaite",Roll_no=89},

            };
            var Rollno = from rno in student
                         where rno.stud_Fname == "Tania"
                         select rno;
            foreach (var item in Rollno)
                Console.WriteLine(item.stud_Fname +" " + item.Roll_no);


        }
    }
    public class clsroom
    {
        public int stud_id { get; set; }
        public string stud_Fname { get; set; }
        public string stud_lname { get; set; }
        public int Roll_no { get; set; }
    }

}





