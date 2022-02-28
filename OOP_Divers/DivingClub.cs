using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Divers_OPP_17_12_21
{
    class DivingClub
    {
        protected string clubName, contactPerson, address, phoneNumber, email, webAddress, licenseNumber;
        Country country;
        SiteCountry[] siteCountryArray;
        Instructor instructor; 


        public DivingClub(string clubName, Country country, string contactPerson, string address, string phoneNumber, string email, string licenseNumber, SiteCountry[] siteCountryArray,Instructor instructor = null, string webAddress="No Website")
        {
            SetClubName(clubName);
            this.country = country; 
            SetContactPerson(contactPerson);
            SetAddressClub(address);
            SetClubPhoneNumber(phoneNumber);
            SetClubEmail(email);
            SetClubLicenseNumber(licenseNumber);
                this.siteCountryArray = new SiteCountry[siteCountryArray.Length];
                for (int i = 0; i < siteCountryArray.Length; i++)
                {
                    this.siteCountryArray[i] = new SiteCountry(siteCountryArray[i]);
                }
            SetClubWebAddress(webAddress);
            this.instructor = instructor;   
            
        }
        public DivingClub()
        {

        }
  

        //Getters:
        public string GetClubName() { return clubName; }
        public string GetContactPerson() { return contactPerson; }
        public string GetAddressClub() { return address; }
        public string GetClubPhoneNumber() { return phoneNumber; }
        public string GetClubEmail() { return email; }
        public string GetClubWebAddress() { return webAddress; }
        public string GetClubLicenseNumber() { return licenseNumber; }

        public Country GetCountry() { return country; }

        public SiteCountry[] GetSiteCountryArray() { return siteCountryArray; }

        public Instructor GetInstructor() { return instructor; } 

        //Setters:
        public void SetClubName(string clubName) { this.clubName = clubName; }
        public void SetContactPerson(string contactPerson) { this.contactPerson = contactPerson; }
        public void SetAddressClub(string address) { this.address = address; }
        public void SetClubPhoneNumber(string phoneNumber) { this.phoneNumber = phoneNumber; }
        public void SetClubEmail(string email) { this.email = email; }
        public void SetClubWebAddress(string webAddress) { this.webAddress = webAddress; }
        public void SetClubLicenseNumber(string licenseNumber) { this.licenseNumber = licenseNumber; }

        public override string ToString()
        {
            return $"Club Name:{this.clubName}\nContact Person:{this.contactPerson}\nAddress Club:{this.address}\n" +
                $"Country:{country.GetCountryName()}\nPhone:{this.phoneNumber}\nEmail:{this.email}\nWeb:{this.webAddress}\nLicense Number:{this.licenseNumber}";
        }










    }
}
