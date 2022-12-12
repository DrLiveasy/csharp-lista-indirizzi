using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private int Zip;
        #endregion

        #region Costruttori
        public Indrizzo(string name, string surname, string street, string city, string province, int zip)
        {
            this.Name = name;
            this.Surname = surname;
            this.Street = street;
            this.City = city;
            this.Province = province;
            this.Zip = zip;
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

        public int GetZip1()
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

        public void SetZip1(int value)
        {
            while (true)
            {
                if (value <= 0)
                {
                    Console.WriteLine("IL zip non può essere minore o uguale a 0");
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
            return "Nome: " + this.Name + "\tCognome: " + this.Surname + "\nIndrizzo: " + this.Street + ", " +this.City + ", " + this.Province + ", " + this.Zip;
        }
        #endregion
    }
}
