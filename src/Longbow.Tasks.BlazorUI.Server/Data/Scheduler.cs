
namespace Longbow.Tasks.BlazorUI.Server.Data
{
    public class Scheduler
    {
        public string? Name { get; set; }

        public string? Status { get; set; }

        public DateTimeOffset? NextRuntime { get; set; }

        public DateTimeOffset? LastRuntime { get; set; }

        public TriggerResult LastRunResult { get; set; }

        public Exception? Exception { get; set; }

        public DateTimeOffset CreatedTime { get; set; }

        public IEnumerable<ITrigger> Triggers { get; set; } = [];

        public ITask? Task { get; set; }
    }
}
