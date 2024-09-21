
using System.ComponentModel.DataAnnotations;

namespace FIREE.Db.Master.Entities;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
public class Organisation
{
    [Required]
    public string Name { get; set; }


    public string? Alias { get; set; }

    [Required]
    public string Server { get; set; }

    [Required]
    public string DbName { get; set; }
}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
