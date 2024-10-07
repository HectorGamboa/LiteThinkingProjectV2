namespace Domain.Entities
{
    public class FileEntity : BaseEntity
    {
        public string? FileName { get; set; }
        public string? TransactionName {  get; set; }

        public string ?Typename { get; set; }
        //Fecha de creacion
        public DateTime? CreatedAt { get; set; }
    }
}
