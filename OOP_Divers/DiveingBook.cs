using System;

namespace Ex_Divers_OPP_17_12_21
{
    class DiveingBook
    {
        //siteCountry 
        //country ??
        //temperature
        //tide - Low or High
        //dive data - year month day Time: Start-hours minutes  End-hours minutes ; 
        //confirmed - Instructor name;
        //gear  - Equipment[];
        /* to string:
            Dive Details:
            Dived Throgh: EilatDive at the 'Dolphin Reef'
            Date 05/05/2020 at: 11:21 until 12:22
            The Tide was: high.
            Water Temperature: 23
            The Dive was Confirmed By: eli ID: 123456
         */

        /* Press Enter to Confirm OR any key to go back to main menu.
                     Dive recored was added!
                    Dive was also added to:golan
        */
        Diver nameDiver, partnerName;
        Instructor instructorName;
        DivingClub divingClub;
        SiteCountry site;
        Country countryName;
        Equipment[] equipmentArr;

        protected int waterTemperature;
        protected byte tideValue;
        protected string tide;
        protected DateTime diveingDate, startDiveTime, endDiveTime;
        public int counterDive, partnerCounterDive;
        

        public DiveingBook(Diver nameDiver, Diver partnerName, Instructor instructorName, DivingClub divingClub, SiteCountry site, Country countryName, int waterTemperature, byte tideValue, DateTime diveingDate, DateTime startDiveTime, DateTime endDiveTime, Equipment[] equipmentArr = null)
        {
            this.nameDiver = nameDiver;
            this.partnerName = partnerName;
            this.instructorName = instructorName;
            this.divingClub = divingClub;
            this.site = site;
            this.countryName = countryName;
            SetWaterTemperature(waterTemperature);
            SetTideValue(tideValue);
            SetDiveingDate(diveingDate);
            this.startDiveTime = startDiveTime;
            this.endDiveTime = endDiveTime;
            this.equipmentArr = equipmentArr;
            this.counterDive = this.nameDiver.GetDiveCount();
            this.partnerCounterDive = this.partnerName.GetDiveCount();
            SetDiverRankOnBook();
     

        }
        public DiveingBook()
        {
            //this.nameDiver = null;
            //th
            //this.instructorName = null;
            //this.divingClub = null;
            //this.countryName = null;
            //SetWaterTemperature(0);
            //SetTideValue(0);
            //this.diveingDate = new DateTime(1970, 01, 01);
            //this.sitesName = null;
            //this.endDiveTime = new DateTime(1970, 02, 01);
        }
        public DiveingBook(DiveingBook obj)
        {
            this.nameDiver = obj.nameDiver;
            this.partnerName = obj.partnerName;
            this.instructorName = obj.instructorName;
            this.divingClub = obj.divingClub;
            this.countryName = obj.countryName;
            SetWaterTemperature(obj.waterTemperature);
            SetTideValue(obj.tideValue);
            SetDiveingDate(obj.diveingDate);
            this.site = obj.site;
            this.endDiveTime = obj.endDiveTime;
            this.equipmentArr = obj.equipmentArr;

        }
        public string GetInstructorName() { return instructorName.GetFirstNameDiver(); }

        public int GetInstructorId() { return instructorName.GetIdDiver(); }

        public string GetCountryName() { return countryName.GetCountryName(); }

        public string GetDiveClubName() { return divingClub.GetClubName(); }

        public string GetSiteCountryName() { return site.GetSiteName(); }

        public string GetDiverName() { return nameDiver.GetFirstNameDiver(); }

        public string GetPartnerName() { return partnerName.GetFirstNameDiver(); }

        public int GetWaterTemperature() { return waterTemperature; }

        public Diver GetPartnerDiver() { return partnerName; }
        public Equipment[] GetEquipmentArray()
        {
            return equipmentArr;
        }
        public int GetDiveCount() { return counterDive; }

        public int GetPartnerDiveCount() { return partnerCounterDive; }


        public void SetDiveCount(int num) { this.counterDive = num; }

        public void SetPartnerDiveCount(int num) { this.partnerCounterDive = num; }


        public bool isSameClub(Rank[] arrRank, string clubName)
        {

            for (int i = 0; i <arrRank.Length; i++)
            {
                if (arrRank[i] != null)
                {
                    if (arrRank[i].GetRankClubName() == clubName)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void SetDiverRankOnBook()
        {
            string tempClubName = this.divingClub.GetClubName();
            int tempRankNumber = this.nameDiver.GetDiveCount();
            Rank[] ranks = nameDiver.GetDiverRank();
            bool flag1;
            string temp;

            if (counterDive == 1 )
            {
                // nameDiver.SetRankDiver(new Rank(" - * - ", "One Star - Open water diver", tempClubName, this.diveingDate));
                nameDiver.AddRankToRanksArray(new Rank(" - * - ", "One Star - Open water diver", tempClubName, this.diveingDate,1));
                
                //for (int i = 0; i < nameDiver.GetDiverRank().Length; i++)
                //{
                //    if (nameDiver.GetDiverRank() != null)
                //    {
                //        Console.WriteLine(nameDiver.GetDiverRank()[i]);
                //        
                //    }
                //}
                Console.WriteLine("nicnas");
            }

            if (counterDive == 2 && (!isSameClub(nameDiver.GetDiverRank(), this.divingClub.GetClubName())))
            {
                //this.nameDiver.SetDiveCount(counterDive);
                nameDiver.AddRankToRanksArray(new Rank(" - * * - ", "Two Stars - Advanced open water", tempClubName, this.diveingDate,2));

                //flag1 = false;
                //for (int i = 0; i < ranks.Length; i++)
                //{
                //    temp = ranks[i].GetRankClubName();
                //    Console.WriteLine(temp);
                //    if (tempClubName == temp)
                //    {
                //        flag1 = true;
                //        Console.WriteLine($"You Recived the Rank From {tempClubName} already...");
                //        break;
                //    }

                //}
                //if (!flag1)
                //{
                //    nameDiver.AddRankToRanksArray(new Rank(" - * * - ", "Two Stars - Advanced open water", tempClubName, this.diveingDate));

                //    // nameDiver.SetRankDiver(new Rank(" - * * - ", "Two Stars - Advanced open water", tempClubName, this.diveingDate));
                //}



            }

            if (this.nameDiver.GetDiveCount() == 3 && (!isSameClub(nameDiver.GetDiverRank(), this.divingClub.GetClubName())))
            {
                nameDiver.AddRankToRanksArray(new Rank(" - * * * - ", "Three Stars - Master Diver", tempClubName, this.diveingDate,3));

                //flag1 = false;
                //for (int i = 0; i < ranks.Length; i++)
                //{
                //    temp = ranks[i].GetRankClubName();
                //    if (tempClubName == temp)
                //    {
                //        flag1 = true;
                //        break;
                //    }

                //}
                //if (!flag1)
                //{
                //    // nameDiver.SetRankDiver(new Rank(" - * * * - ", "Three Stars - Master Diver", tempClubName, this.diveingDate));
                //    nameDiver.AddRankToRanksArray(new Rank(" - * * * - ", "Three Stars - Master Diver", tempClubName, this.diveingDate));
                //}

            }
         

        }

        //public void SetPartnerRankOnBook()
        //{

        //    //if (nameDiver.GetDiveCount() == 0)
        //    //{
        //    //    nameDiver.SetRankDiver(new Rank("No Rank!", ""));


        //    //}

        //    if (partnerName.GetDiveCount() == 1)
        //    {

        //        partnerName.SetRankDiver(new Rank(" - * - ", "One Star - Open water diver", this.divingClub.GetClubName(), this.diveingDate));

        //    }
        //    else if (partnerName.GetDiveCount() == 2)
        //    {

        //        partnerName.SetRankDiver(new Rank(" - * * - ", "Two Stars - Advanced open water", this.divingClub.GetClubName(), this.diveingDate));

        //    }
        //    else if (partnerName.GetDiveCount() == 3)
        //    {

        //        partnerName.SetRankDiver(new Rank(" - * * * - ", "Three Stars - Master Diver", this.divingClub.GetClubName(), this.diveingDate));

        //    }


        //}

       



        //public void SetDiverRank()
        //{
        //    Rank[] tempRankArr = nameDiver.GetDiverRank();

        //    if (diveCount == 0)
        //    {

        //        tempRankArr[0] = new Rank("No Rank!", "", "", new DateTime(1990, 01, 01));

        //    }
        //    else if (diveCount == 1)
        //    {
        //        tempRankArr[1] = new Rank(" - * - ", "One Star - Open water diver", this.site.GetSiteName(), this.diveingDate);
        //    }
        //    else if (diveCount == 2)
        //    {
        //        tempRankArr[2] = new Rank(" - * * - ", "Two Stars - Advanced open water", this.site.GetSiteName(), this.diveingDate);
        //    }
        //    else
        //    {
        //        tempRankArr[3] = new Rank(" - * * * - ", "Three Stars - Master Diver", this.site.GetSiteName(), this.diveingDate);
        //    }


        //}


        public void SetWaterTemperature(int waterTemperature)
        {

            while (!(CheckWaterTemperature(waterTemperature)))
            {
                Console.WriteLine("Wrong choice. Please choose Water Temperature: -20c^ - 60c^");
                waterTemperature = int.Parse(Console.ReadLine());
            }

            this.waterTemperature = waterTemperature;
        }
        private bool CheckWaterTemperature(int waterTemperature)
        {
            if (waterTemperature >= -20 && waterTemperature <= 60)
            {
                return true;
            }
            return false;
        }

        public string GetTide() { return tide; }

        public void SetTideValue(byte tideValue)
        {
           
            if (tideValue == 0)
                this.tide = "low";
            else if (tideValue == 1)
                this.tide = "high";
            else
            {
                Console.WriteLine("Wrong tide choice. Please choose 0=low OR 1=high");

            }
        }

        private bool CheckTideValue(byte tideValue)
        {
            if (tideValue == 0 || tideValue == 1)
                return true;
            return false;
        }

        public DateTime GetDiveingDate() { return diveingDate; }

        public void SetDiveingDate(DateTime diveingDate) { this.diveingDate = diveingDate; }

        public DateTime GetStartDiveTime() { return startDiveTime; }
        public DateTime GetEndDiveTime() { return endDiveTime; }

        public void SetEndDiveTime(DateTime endDiveTime)
        {
            while (endDiveTime < diveingDate)
            {
                Console.WriteLine("Invalid end diving time. Please Enter valid time");

                int endHour = int.Parse(Console.ReadLine());
                int endMin = int.Parse(Console.ReadLine());
                endDiveTime = new DateTime(diveingDate.Year, diveingDate.Month, diveingDate.Day, endHour, endMin, 0);
            }
            this.endDiveTime = endDiveTime;
        }

        public override string ToString()
        {
            return $@"Dive Details and Sign:
        Dived through: {this.divingClub.GetClubName()} at the '{this.site.GetSiteName()}'
        Date {this.diveingDate:d} at: {this.startDiveTime:t} until {this.endDiveTime:t}
        Water Type: {this.site.GetWaterType()}
        Depth: {this.site.GetDepth()}
        The Tide was: {this.tide}
        Water Temperature: {waterTemperature}°C       
        The Dive was Confirmed By: {GetInstructorName()} ID: {GetInstructorId()}";

        }
    }
}
