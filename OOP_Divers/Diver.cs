using System;


namespace Ex_Divers_OPP_17_12_21
{
    class Diver
    {
        //Props:
        protected int id_Diver;
        protected string first_Name, last_Name, email, password;
        protected DateTime birth_date;

        protected int diveCount;
        int num = 0;



        protected Rank[] ranksArr = new Rank[4];

        protected Rank rank;


        public Diver()
        {

        }

        public Diver(int id_Diver, string first_Name, string last_Name, DateTime birth_date, string email, string password)
        {

            SetIdDiver(id_Diver);
            SetFirstNameDiver(first_Name);
            SetLastNameDiver(last_Name);
            SetBirthDateDiver(birth_date);
            SetEmailDiver(email);
            SetPasswordDiver(password);

            ranksArr[0] = new Rank("No Rank!", "", "NaN", new DateTime(2005, 06, 01),0);
            this.ranksArr = ranksArr;



            SetDiveCount(diveCount);

        }

        public Diver(Diver obj)
        {
            SetIdDiver(obj.id_Diver);
            SetFirstNameDiver(obj.first_Name);
            SetLastNameDiver(obj.last_Name);
            SetBirthDateDiver(obj.birth_date);
            SetEmailDiver(obj.email);
            SetPasswordDiver(obj.password);
            AddRankToRanksArray(obj.rank);
            this.ranksArr = obj.ranksArr;
        }

        //Getters:
        public int GetIdDiver() { return id_Diver; }
        public string GetFirstNameDiver() { return first_Name; }
        public string GetLastNameDiver() { return last_Name; }
        public DateTime GetBirthDateDiver() { return birth_date; }

        public string GetEmailDiver() { return email; }

        public string GetPasswordDiver() { return password; }

        public int GetDiveCount() { return diveCount; }
        public void SetDiveCount(int count)
        {
            this.diveCount = count;
        }


        public Rank[] GetDiverRank() { return ranksArr; }

        

        public void AddRankToRanksArray(Rank rank)
        {
            for (int i = 0; i < ranksArr.Length; i++)
            {
                if (ranksArr[i] == null)
                {

                    ranksArr[i] = rank;
                    num = i;
                    break;
                }
            }
        }


        public void SetIdDiver(int id_Diver) { this.id_Diver = id_Diver; }
        public void SetFirstNameDiver(string first_Name) { this.first_Name = first_Name; }
        public void SetLastNameDiver(string last_Name) { this.last_Name = last_Name; }
        public void SetBirthDateDiver(DateTime birth_date) { this.birth_date = birth_date; }
        public void SetEmailDiver(string email) { this.email = email; }
        public void SetPasswordDiver(string password) { this.password = password; }



        public override string ToString()
        {
            return $"Name Diver: {first_Name} {last_Name}\nID: {id_Diver}\nBirth Date:{birth_date:d}\nEmail:{email}\n\n{ranksArr[num]}\n\n--------{diveCount}--------\n";

        }
    }
}
