using System.ComponentModel.DataAnnotations.Schema;

namespace Neltic.Shared.Domain.Entities;
public class SexType : Enumeration<SexType>
{
    [NotMapped]
    public static readonly SexType Male = new(1, "Male");
    [NotMapped]
    public static readonly SexType Female = new(2, "Female");
    [NotMapped]
    public static readonly SexType Other = new(3, "Other");
    public SexType(int id, string name)
        : base(id, name)
    {

    }
}
