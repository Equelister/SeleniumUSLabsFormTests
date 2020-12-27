using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumUSForm.Parameters
{
    class SeleniumParametersReturnStrings
    {
        public static string DefaultErrorString = "Blad danych";

        public static string FirstNameEmptyErrorString = "First name must be filled out";
        public static string LastNameEmptyErrorString = "Nazwisko musi byc wypelnione";
        public static string DateEmptyErrorString = "Data urodzenia nie moze byc pusta";

        public static string NotClassifiedString = "Brak kwalifikacji";
        public static string ClassifiedAsMlodzikString = "Mlodzik";
        public static string ClassifiedAsJuniorString = "Junior";
        public static string ClassifiedAsDoroslyString = "Dorosly";
        public static string ClassifiedAsSeniorString = "Senior";
    }
}
