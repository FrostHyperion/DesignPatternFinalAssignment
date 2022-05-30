namespace DesignPatternFinalAssignment.Models;

// Abstract ticket class to generate different ticket type
public abstract class Ticket {
    public Deadline Deadline;
    public int DeadlineTime { get; set; }
    public Priority PriorityName { get; set; }
    public string TicketType { get; set; }

    // Constructor set the Deadline and priority type in order to set the base deadline
    public Ticket(Deadline deadline, Priority priority) {
        if(priority == Priority.Low) {
            DeadlineTime = 10;
        } else if(priority == Priority.Medium) {
            DeadlineTime = 5;
        } else if(priority == Priority.High) {
            DeadlineTime = 2;
        }
        Deadline = deadline;
    }

    // abstract method to be overriden by the class inhereting Ticket abstract class to get the Deadline
    public abstract int GetDeadline();

    // Get description of the of deadline
    public string GetDeadlineDescription() {
        return TicketType + ", " + Deadline.GetDeadlineDescription();
    }

    // This method will set the deadline type in ticket
    public void SetDeadline(Deadline deadline) {
        Deadline = deadline;
    }

    // Different priorities of the ticket
    public enum Priority
    {
        Low = 1,
        Medium = 2,
        High = 3
    }
}
