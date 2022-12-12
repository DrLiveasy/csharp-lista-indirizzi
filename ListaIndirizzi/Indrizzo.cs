﻿using System;
using System.Collections.Generic;
using System.Globalization;
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
        private int Zip;
        #endregion

        #region Costruttori
        public Indrizzo(string Name, string Surname, string Street, string City, string Province, int Zip)
        {
            ControllaInputStringhe(this.Name, Name);
            ControllaInputStringhe(this.Surname, Surname);
            ControllaInputStringhe(this.Street, Street);
            ControllaInputStringhe(this.City, City);
            ControllaInputStringhe(this.Province, Province);
            ControllaInputInteri(this.Zip, Zip);
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

        private void ControllaInputStringhe(string porprieta, string value)
        {
            if (value == null)
            {
                porprieta = "questo cambo non è Nullo";
            }
            else
            {
                porprieta = value;
            }
        }
        private void ControllaInputInteri(int porprieta, int value)
        {
            if (value == null)
            {
                porprieta = 0;
            }
            else
            {
                porprieta = value;
            }
        }


        #endregion

    }
}
