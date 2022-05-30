namespace DesignPatternFinalAssignment.Models;

public class BreachDeadline : Deadline {
    public int deadline = 20;

    public override string GetDeadlineDescription() {
        return "BreachDeadline";
    }
}
