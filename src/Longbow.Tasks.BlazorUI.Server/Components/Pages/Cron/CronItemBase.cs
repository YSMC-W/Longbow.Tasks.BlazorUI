using BootstrapBlazor.Components;
using Longbow.Tasks.BlazorUI.Server.Enums;
using Microsoft.AspNetCore.Components;

namespace Longbow.Tasks.BlazorUI.Server.Components.Pages.Cron
{
    public class CronItemBase : ComponentBase
    {
        private readonly CronType _cronType;

        public CronItemBase(CronType cronType)
        {
            _cronType = cronType;
        }

        public List<SelectedItem> SelectedItems = [];

        public string? Value { get; set; }

        public string? CheckedString;

        protected override void OnInitialized()
        {
            SelectedItems = _cronType switch
            {
                CronType.Second or CronType.Minute => Enumerable.Range(0, 60)
                    .Select(i => new SelectedItem { Value = i.ToString(), Text = i.ToString().PadLeft(2, '0') })
                    .ToList(),
                CronType.Hour => Enumerable.Range(0, 24).Select(i => new SelectedItem { Value = i.ToString(), Text = i.ToString().PadLeft(2, '0') })
                    .ToList(),
                CronType.Day => Enumerable.Range(1, 32).Select(i => new SelectedItem { Value = i.ToString(), Text = i.ToString().PadLeft(2, '0') })
                    .ToList(),
                CronType.Month => Enumerable.Range(1, 13).Select(i => new SelectedItem { Value = i.ToString(), Text = i.ToString().PadLeft(2, '0') })
                    .ToList(),
                CronType.Week => Enumerable.Range(1, 8).Select(i => new SelectedItem { Value = i.ToString(), Text = i.ToString().PadLeft(2, '0') })
                    .ToList(),
                _ => []
            };
        }
    }
}
