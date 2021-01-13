using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class Persona
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string gender { get; set; }
    public string company { get; set; }
    public string email { get; set; }
    public string country { get; set; }
    public string dni { get; set; }

    public Boolean ComprobarDNI()
    {
        string DNIS = "TRWAGMYFPDXBNJZSQVHLCKE";
        int residu = 0;

        int result = Convert.ToInt32(Regex.Replace(dni, @"[^\d]", ""));
        residu = result % 23;

        return dni.Substring(dni.Length - 1, 1).Equals(DNIS.Substring(residu, 1)) ? true : false;
    }

    public Boolean ComprobarNom()
    {
        return Name.Equals("") ? true : false;
    }

    public bool ComprobarEmail()
    {
        try
        {
            MailAddress m = new MailAddress(email);

            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }
}