namespace ResolutionWorfklow.WorkflowSteps;

internal class BounceCarrier: IWorkflowStep
{
    public bool CanExecute(string name)
    {
        return name == "BounceCarrier";
    }

    public Task<IDictionary<string, string>> Execute(IDictionary<string, string> parameters)
    {
        Console.WriteLine("Bouncing carrier...");
        return Task.FromResult(parameters);
    }
}
