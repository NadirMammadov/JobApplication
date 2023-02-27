using JobApplicationLibrary.Models;

namespace JobApplicationLibrary
{
    public class ApplicationEvaluator
    {
        public ApplicationResult Evalute(JobApplication form)
        {
            if (form.Applicant.Age < 18) return ApplicationResult.AutoRejected; return ApplicationResult.AutoRejected;
            return ApplicationResult.AutoAccepted;
        }
    }
    public enum ApplicationResult
    {
        AutoRejected,
        TransferredToHR,
        TransferredToLead,
        TransferredToCTD,
        AutoAccepted
    }
}
