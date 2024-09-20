
namespace FIREE.MasterDb
{
    public class Organisation
    {
        public required string Name { get; set; }
        
        public string Alias { get; set; }
        
        public required string Server { get; set; }

        public required string DbName { get; set; }
    }
}