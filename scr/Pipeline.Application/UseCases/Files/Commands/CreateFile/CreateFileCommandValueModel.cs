namespace Application.UseCases.Files.Commands.CreateFile
{
    public class CreateFileCommandValueModel
    {
        public Guid Id { get; set; }
        public required string FileName { get; set; }
        public required string TransactionName { get; set; }
        public required string Typename { get; set; } = "Success";
    }
}
