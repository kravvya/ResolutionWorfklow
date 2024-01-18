namespace ResolutionWorfklow.WorkflowSteps;


internal class AppointmentChangeRequest : IWorkflowStep
{
    public bool CanExecute(string name)
    {
        return name == "RequestNewAppt";
    }

    public Task<IDictionary<string, string>> Execute(IDictionary<string, string> parameters)
    {
        Console.WriteLine("Changing Appt...");
        return Task.FromResult(parameters);
    }
}