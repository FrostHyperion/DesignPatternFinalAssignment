namespace DesignPatternFinalAssignment.Models;

public class ResponseDeadline : Deadline {
    public int deadline = 10;

    public override string GetDeadlineDescription() {
        return "ResponseDeadline";
    }
}
