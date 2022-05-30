using DesignPatternFinalAssignment.Models;

namespace DesignPatternFinalAssignment;

class Program {
    public static void Main() {
        Deadline deadline = new ResponseDeadline();

        Ticket bugReport = new BugReport(deadline, Ticket.Priority.Medium);

        Console.WriteLine(bugReport.GetDeadlineDescription());
        Console.WriteLine(bugReport.GetDeadline());
    }
}
