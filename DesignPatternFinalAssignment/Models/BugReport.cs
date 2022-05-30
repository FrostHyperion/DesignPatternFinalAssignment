namespace DesignPatternFinalAssignment.Models;

public class BugReport : Ticket {
    public BugReport(Deadline deadline, Priority priority) : base(deadline, priority) {
        TicketType = "Bug Report";
    }

    public string ErrorCodes { get; set; }
    public string ErrorLogs { get; set; }

    public override int GetDeadline()
    {
        // This method will update deadline as per ErrorCodes and ErrorLogs
        DeadlineTime += 3;
        return DeadlineTime;
    }
}
