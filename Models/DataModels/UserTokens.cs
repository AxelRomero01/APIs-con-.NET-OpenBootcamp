namespace UniversityApiBackend.Models.DataModels
{
    public class UserTokens
    {
        public int Id { get; set; }
        public string Token { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public TimeSpan validity { get; set; }
        public string RefresToken { get; set; } = string.Empty;
        public string EmailId { get; set; } = string.Empty;
        public Guid GuidId { get; set; }
        public DateTime ExpiredTime { get; set; }
    }
}
