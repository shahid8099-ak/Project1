namespace DataBaseMVC.Models
{
    public class MobileRequest
    {
        public string Name { get; set; }
        public byte Ram { get; set; }
        public string Battery { get; set; }
    }
    public class MobileResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Ram { get; set; }
        public string Battery { get; set; }
    }
    public class MobileUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Ram { get; set; }
        public string Battery { get; set; }
    }
}

