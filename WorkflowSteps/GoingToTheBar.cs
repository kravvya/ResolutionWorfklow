namespace ResolutionWorfklow.WorkflowSteps;

internal class GoingToTheBar: IWorkflowStep
{
    public bool CanExecute(string name)
    {
        return name == "GoingToTheBar";
    }

    public Task<IDictionary<string, string>> Execute(IDictionary<string, string> parameters)
    {
        Console.WriteLine("Going to the bar...");
        return Task.FromResult(parameters);
    }
}
