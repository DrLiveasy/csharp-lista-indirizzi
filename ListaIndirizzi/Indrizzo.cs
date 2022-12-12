using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ListaIndirizzi
{
    public class Indrizzo 
    {
        #region Proprietà 
        private string Name;
        private string Surname;
        private string Street;
        private string City;
        private string Province;
        private string Zip;
        #endregion

        #region Costruttori
        public Indrizzo(string Name, string Surname, string Street, string City, string Province, string Zip)
        { 
            this.Name = Name;
            this.Surname = Surname;
            this.Street = Street;
            this.City = City;
            this.Province = Province;
            this.Zip = Zip;
        }

        #endregion
       
        #region Getters
        public string GetName1()
        {
            return Name;
        }

        public string GetSurname1()
        {
            return Surname;
        }

        public string GetStreet1()
        {
            return Street;
        }

        public string GetCity1()
        {
            return City;
        }

        public string GetProvince1()
        {
            return Province;
        }

        public string GetZip1()
        {
            return Zip;
        }
        #endregion

        #region Setters
        public void SetStreet1(string value)
        {
            while (true)
            {
                if (value == "")
                {
                    Console.WriteLine("Questo cambo non può essere vuoto");
                }
                else
                {
                    this.Street = value;
                    break;
                }
            }
        }

        public void SetCity1(string value)
        {
            while (true)
            {
                if (value == "")
                {
                    Console.WriteLine("Questo cambo non può essere vuoto");
                }
                else
                {
                    this.City = value;
                    break;
                }
            }
        }

        public void SetProvince1(string value)
        {
            while (true)
            {
                if (value == "")
                {
                    Console.WriteLine("Questo cambo non può essere vuoto");
                }
                else
                {
                    this.Province = value;
                    break;
                }
            }
        }

        public void SetZip1(string value)
        {
            while (true)
            {
                if (value == "")
                {
                    Console.WriteLine("Questo cambo non può essere vuoto");
                }
                else
                {
                    this.Zip = value;
                    break;
                }
            }
        }
        #endregion

        #region Metodi
        public override string ToString()
        {
            return "Nome: " + this.Name + "\tCognome: " + this.Surname + "\nIndrizzo: " + this.Street + ", " + this.City + ", " + this.Province + ", " + this.Zip;
        }

        #endregion

    }
}
