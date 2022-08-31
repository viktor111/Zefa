using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Zefa.Domain.Models;

public class ModelConstants
{
    public class Common
    {
        public const int MinNameLength = 2;
        public const int MaxNameLength = 20;
        public const int MinEmailLength = 3;
        public const int MaxEmailLength = 50;
        public const int MaxUrlLength = 2048;
        public const int Zero = 0;
        public const string AdministratorRoleName = "Administrator";
    }

    public class Item
    {
        public const int MinNameLength = 2;
        public const int MaxNameLength = 20;
        public const int MinDescriptionLength = 2;
        public const int MaxDescriptionLength = 1000;
        public const decimal MinPriceValue = 0m;
    }
    
    public class Table
    {
        public const int MinNameLength = 2;
        public const int MaxNameLength = 20;
        public const int MinPlacesCountLength = 1;
        public const int MaxPlacesCountLength = 10;
    }

    public class Restaurant
    {
        public const int MinNameLength = 2;
        public const int MaxNameLength = 200;
        public const int MinAddressLength = 2;
        public const int MaxAddressLength = 200;
    }

    public class PersonalInformation
    {
        public const int MinFirstNameLength = 2;
        public const int MaxFirstNameLength = 20;
        public const int MinLastNameLength = 2;
        public const int MaxLastNameLength = 20;
        public const int MinEmailLength = 5;
        public const int MaxEmailLength = 50;
        public static readonly Regex EmailRegex = new Regex("^\\S+@\\S+\\.\\S+$");
        public const int MinPhoneNumberLength = 5;
        public const int MaxPhoneNumberLength = 15;
        public static readonly Regex PhoneNumberRegex = new Regex("^\\+?[1-9][0-9]{7,14}$");
        public static readonly DateTime MinBirthDate = new DateTime(1900, 1, 1);
        public static readonly DateTime MaxBirthDate = new DateTime(DateTime.Now.Year, 1, 1);
    }
}