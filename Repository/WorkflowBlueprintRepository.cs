namespace ResolutionWorfklow.Repository;

internal class WorkflowBlueprintRepository
{
    public static IList<string> GetWorkflowResolutionSteps(string eLogCode)
    {

        switch (eLogCode)
        {
            case "PLATE":
                return new List<string>
                {                      
                    "BounceCarrier",
                    "NotifyCustomer",
                     "GoingToTheBar",
                };
            case "DLATE":
                return new List<string>
                {
                    "NotifyCustomer",
                    "RequestNewAppt",
                    "GoingToTheBar",
                   
                };
          
            default:
                return new List<string>
                {
                    "GoingToTheBar"
                };
        }

    }
}
