// See https://aka.ms/new-console-template for more information
using ResolutionWorfklow;
using ResolutionWorfklow.Repository;
using System.Reflection;

Console.WriteLine("Hello, Wprkflow Respolution!");

List<IWorkflowStep> workflowSteps = new();

foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
{
    if (type.GetInterfaces().Contains(typeof(IWorkflowStep)))
    {
        workflowSteps.Add((IWorkflowStep)Activator.CreateInstance(type)!);
    }
}


while (true)
{
    Console.WriteLine("Pick an eLog PLATE, DLATE:");

    string eLogCode = Console.ReadLine()!;
    IDictionary<string, string> parameters = new Dictionary<string, string>();

    foreach (var workflowStep in WorkflowBlueprintRepository.GetWorkflowResolutionSteps(eLogCode))
    {
        var step = workflowSteps.Where(x => x.CanExecute(workflowStep)).FirstOrDefault();
        
        if(step!= null)
        {
            parameters = step.Execute(parameters).GetAwaiter().GetResult();
        }
    }

    Console.WriteLine("All Done");
}