using System.Security.Cryptography.X509Certificates;

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
        public const int MinDescriptionLength = 20;
        public const int MaxDescriptionLength = 200;
        public const decimal MinPriceValue = 0m;
    }
}