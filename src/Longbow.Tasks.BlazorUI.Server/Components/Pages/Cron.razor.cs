using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Longbow.Tasks.BlazorUI.Server.Components.Pages
{
    public sealed partial class Cron
    {
        private List<SelectedItem> CronTypeValues = new List<SelectedItem> {
            new (){ Value = "PerSecond", Text = "PerSecond" },
            new (){ Value = "Cycle" ,Text="Cycle"},
            new (){ Value = "FromTo" ,Text="FromTo" },
            new (){ Value = "Appoint" ,Text="Appoint" }
        };

        private string? SelectedValue;

        private List<SelectedItem> SecondItems = Enumerable.Range(0, 60)
            .Select(i => new SelectedItem { Value = i.ToString(), Text = i.ToString().PadLeft(2, '0') })
            .ToList();

        private string? SecondValue { get; set; }

        private List<SelectedItem> MinuteItems = Enumerable.Range(0, 60)
            .Select(i => new SelectedItem { Value = i.ToString(), Text = i.ToString().PadLeft(2, '0') })
            .ToList();

        private string? MinuteValue { get; set; }

        private List<SelectedItem> HourItems = Enumerable.Range(0, 24)
            .Select(i => new SelectedItem { Value = i.ToString(), Text = i.ToString().PadLeft(2, '0') })
            .ToList();

        private string? HourValue { get; set; }
    }
}
