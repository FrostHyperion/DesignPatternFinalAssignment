namespace DesignPatternFinalAssignment.Models;

public class ServiceRequest : Ticket {
    public ServiceRequest(Deadline deadline, Priority priority) : base(deadline, priority) {
        TicketType = "Service Request";
    }

    public RequestType RequestTypeName { get; set; }

    public override int GetDeadline()
    {
        // This method with update the deadline for different type of Request type
        DeadlineTime += 10;
        return DeadlineTime;
    }

    public enum RequestType {
        // Types of Request as an enum
    }
}
