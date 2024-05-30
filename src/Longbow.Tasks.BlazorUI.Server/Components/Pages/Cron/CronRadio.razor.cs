using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Longbow.Tasks.BlazorUI.Server.Components.Pages.Cron
{
    public sealed partial class CronRadio
    {
        [Parameter, NotNull]
        public Func<string, Task>? Onclick { get; set; }

        [Parameter, NotNull]
        public string? CheckedString { get; set; }

        [Parameter, NotNull]
        public string? Name { get; set; }

        [Parameter, NotNull]
        public string? Text { get; set; }

        [Parameter, NotNull]
        public string? Value { get; set; }

        [Parameter]
        public RenderFragment<bool>? ChildContent { get; set; }

        [Parameter]
        public EventCallback<string> CheckedStringChanged { get; set; }

        private bool Checked => CheckedString == Value;

        private async Task OnRadioOnclick()
        {
            if (Onclick != null)
            {
                await Onclick(Value);
            }
        }

        private async Task OnChange()
        {
            if (CheckedStringChanged.HasDelegate)
            {
                await CheckedStringChanged.InvokeAsync(Value);
            }
        }
    }
}
