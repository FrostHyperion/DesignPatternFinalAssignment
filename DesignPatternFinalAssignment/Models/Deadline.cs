namespace DesignPatternFinalAssignment.Models;

// Abstract class to generate different types of deadlines
public abstract class Deadline {
    public int deadline;
    public abstract string GetDeadlineDescription();
}
