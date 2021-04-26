using Models.Interfaces;

namespace Models
{
    public class DevOps : Human, IDeveloper, IOperations
    {
        public bool AwsCertified { get; set; }
        public bool AzureCertified { get; set; }

        public DevOps(string firstName, string lastName, long phone, bool aws, bool azure) : base (firstName, lastName, phone)
        {
            AwsCertified = aws;
            AzureCertified = azure;
        }

        public string Codeing()
        {
            return "I am wrting PowerShell scripts";
        }

        public string CheckInfrastructure(string status)
        {
            return $"The cloud infrastructure is {status}";
        }

        public override string GetInfo()
        {
            string info = $"{FullName}";
            info += AwsCertified ? "\nI have Aws Certification" : string.Empty;
            info += AzureCertified ? "\nI have Azure Certification" : string.Empty;

            return info;
        }
    }
}
