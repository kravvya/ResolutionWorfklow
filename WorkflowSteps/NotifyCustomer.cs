namespace ResolutionWorfklow.WorkflowSteps;

internal class NotifyCustomer: IWorkflowStep
{
    public bool CanExecute(string name)
    {
        return name == "NotifyCustomer";
    }

    public Task<IDictionary<string, string>> Execute(IDictionary<string, string> parameters)
    {
        Console.WriteLine("Notifying customer...");
        return Task.FromResult(parameters);
    }
}