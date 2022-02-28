using System;

namespace Ex_Divers_OPP_17_12_21
{
    class Instructor : Diver    //This Class Inheritor from Diver Class
    {
        //Props:
        private DateTime start_Work_Date, end_Work_Date;

        //Constructor containing the props of the base Class , and a new props from this Class:
        public Instructor(int id_Diver, string first_Name, string last_Name, DateTime birth_date, string email, string password, DateTime start_Work_Date, DateTime end_Work_Date) :
            base(id_Diver, first_Name, last_Name, birth_date, email, password)
        {
            SetStartWorkDay(start_Work_Date);
            SetEndWorkDay(end_Work_Date);
        }

        //Setters:
        public void SetStartWorkDay(DateTime start_Work_Date) { this.start_Work_Date = start_Work_Date; }
        public void SetEndWorkDay(DateTime end_Work_Date) { this.end_Work_Date = end_Work_Date; }

        //Getters:
        public DateTime GetStartWorkDay() { return start_Work_Date; }
        public DateTime GetEndWorkDay() { return end_Work_Date; }

        public override string ToString()
        {
            string diverStr = base.ToString();
            return $"{diverStr}\nStart Work Date: {this.start_Work_Date}\nEnd Work Date: {this.end_Work_Date}";
        }

    }
}
