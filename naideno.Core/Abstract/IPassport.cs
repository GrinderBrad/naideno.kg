using System.Collections.Generic;
using naideno.Core.Entities;


namespace naideno.Core.Abstract
{
    interface IPassport
    {
        IEnumerable<Passport> Passports { get; }
    }
}
