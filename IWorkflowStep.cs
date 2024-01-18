namespace ResolutionWorfklow;

internal interface IWorkflowStep
{
    public bool CanExecute(string name);
    public Task<IDictionary<string, string>> Execute(IDictionary<string, string> parameters);
}
