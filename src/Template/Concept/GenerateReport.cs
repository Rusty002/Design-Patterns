namespace Template.Concept
{
    public class GenerateReport
    {
        private AuditTrail auditTrail;
        public GenerateReport(AuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;
        }

        public void Execute()
        {
            auditTrail.Record();
            Console.WriteLine("Generate Report");
        }
    }
}
