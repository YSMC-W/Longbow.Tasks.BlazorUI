using Longbow.Tasks.BlazorUI.Server.Data;

namespace Longbow.Tasks.BlazorUI.Server.Components.Pages
{
    public partial class TaskList
    {
        private IEnumerable<Scheduler> Schedulers { get; set; } = new List<Scheduler>();
        protected override void OnInitialized()
        {
            base.OnInitialized();

            var items = TaskServicesManager.ToList().ToList();

            Schedulers = items
                .Select(s => new Scheduler
                {
                    Name = s.Name,
                    Status = s.Status switch { SchedulerStatus.Ready => "准备", SchedulerStatus.Running => "运行中", SchedulerStatus.Disabled => "禁用", _ => "-" },
                    NextRuntime = s.NextRuntime,
                    LastRuntime = s.LastRuntime,
                    LastRunResult = s.LastRunResult,
                    Exception = s.Exception,
                    CreatedTime = s.CreatedTime,
                    Triggers = s.Triggers,
                    Task = s.Task
                });

            System.Console.WriteLine("TaskList.OnInitialized");
        }
    }
}
