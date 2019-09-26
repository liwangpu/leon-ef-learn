namespace EF_Console.Entities
{
    public class AccountTag
    {
        public string AccountId { get; set; }
        public Account Account { get; set; }
        public string TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
