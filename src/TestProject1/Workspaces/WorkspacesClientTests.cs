namespace TestProject1.Workspaces
{
    using System.Threading.Tasks;
    using Xunit;

    public sealed class WorkspacesClientTests
    {
        [Theory]
        [FileData(@"Workspaces/.testdata/Get_For_Workspace_That_Exists_Should_Return_The_Workspace.json")]
        public async Task Get_For_Workspace_That_Exists_Should_Return_The_Workspace(string responseJson)
        {
        }

        [Theory]
        [FileData(@"Workspaces\.testdata\List_Should_Return_The_Workspaces.json")]
        public async Task List_Should_Return_The_Workspaces(string responseJson)
        {
        }
    }
}