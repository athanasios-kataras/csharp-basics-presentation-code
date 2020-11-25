namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Structural.Facade
{
    public interface IWorkItemFacade
    {
         int CreateWorkItem(WorkItemType type, string topic, string description);
         bool DeleteWorkItem(int id);
    }
}