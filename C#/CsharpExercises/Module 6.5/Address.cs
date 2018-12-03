using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module_6._5
{
    class Address
    {
        //Properties
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }

        //Methods

        public void OkZip()
        {
            //string okZip = @"^[1-9]\d\d\d\d$";
            //kolla om okZip matchar med inputen

        }

        public string GetFullStreet()
        {
            return Street + " " + StreetNumber;
        }

        /*
         * //ETT KORTARE SÄTT ATT GÖRA METODEN
         
        if (zipcode == null || zipcode.Length != 6 || zipcode[0] =='0')
            {
            return false;

            string noSpace = zipcode.Remove(3, 1);

        return isNumber(noSpace);

        // ETT SÄTT ATT GÖRA METODEN

        bool ValidateZipCode(string zip)
        {
            if (zip==null)
                return false
        }

        if (zip.Length != 6)

    */

        public void SetZipCode(string zzz)
        {
            //Kollar om den infogade strängen innehåller bokstäver
            bool result = zzz.Any(x => !char.IsLetter(x));
            bool result2 = zzz.Any(x => !char.IsWhiteSpace(x));

            //Det godkända formatet på zipkoden
            //string validZipCode = string.Format("{0:### ##}", zzz);
            if (result && result2)
            {
                //string validZipCode = string.Format("{0:### ##}", zzz);

            }

            else Console.WriteLine("You must enter only numbers!");
            
        }

        //Getter
        //public string FullStreet
        //{
        //    get
        //    {
        //        return Street + " " + StreetNumber;
        //    }
        //}

        //Short getter
        public string FullStreet => Street + " " + StreetNumber;

    }
}
