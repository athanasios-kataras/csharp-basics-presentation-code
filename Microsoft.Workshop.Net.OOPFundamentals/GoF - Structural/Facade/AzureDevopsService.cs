namespace Microsoft.Workshop.Net.OOPFundamentals.GoF___Structural.Facade
{
    public class AzureDevopsService: IWorkItemFacade
    {
        private string organization;
        private string project;
        private string url;

        public AzureDevopsService() {
            // Get this form configuration
            this.organization = "fabrikam";
            this.project = "test";
            url = "https://dev.azure.com/"+organization+"/" + project;
        }

        public int CreateWorkItem(WorkItemType type, string topic, string description)
        {
            int workItemId = 0;
            // Do the required authorization
            // Create the work item with an HttpClient
            // Return the id
            return workItemId;
        }

        public bool DeleteWorkItem(int id)
        {
            bool success = false;
            // Do the required authorization
            // Call the DELETE action
            // Return true if succesfull
            return success;
        }
    }
}