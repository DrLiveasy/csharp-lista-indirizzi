// See https://aka.ms/new-console-template for more information


using ListaIndirizzi;

List<Indrizzo> listaIndrizzi = new List<Indrizzo>();


try
{
    StreamReader file = File.OpenText("F:\\generation\\Eserzcizi\\CSHARP ESERCIZI\\ListaIndirizzi\\ListaIndirizzi\\File\\addresses.csv");

    while (!file.EndOfStream)
    {
        string riga = file.ReadLine();


        string[] informazioniIndrizzo = riga.Split(", ");

        string Name = informazioniIndrizzo[0];
        string Surname = informazioniIndrizzo[1];
        string Street = informazioniIndrizzo[2];
        string City = informazioniIndrizzo[3];
        string Province = informazioniIndrizzo[4];
        int Zip = Convert.ToInt32(informazioniIndrizzo[5]);


        Indrizzo IndrizzoEstratto = new Indrizzo(Name, Surname, Street, City, Province, Zip);
        listaIndrizzi.Add(IndrizzoEstratto);
        // Console.WriteLine(riga);
    }

    file.Close();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


foreach (Indrizzo indrizzo in listaIndrizzi)
{
    Console.WriteLine(indrizzo);
}
