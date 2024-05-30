using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components.Routing;

namespace Longbow.Tasks.BlazorUI.Server.Components.Shared
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MainLayout
    {
        private bool UseTabSet { get; set; } = true;

        private string Theme { get; set; } = "";

        private bool IsOpen { get; set; }

        private bool IsFixedHeader { get; set; } = true;

        private bool IsFixedFooter { get; set; } = true;

        private bool IsFullSide { get; set; } = true;

        private bool ShowFooter { get; set; } = true;

        private List<MenuItem>? Menus { get; set; }

        /// <summary>
        /// OnInitialized 方法
        /// </summary>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            TaskServicesManager.GetOrAdd("任务1", async (token, s) =>
            {
                System.Console.WriteLine("任务1");
                await Task.Delay(1000);
            }, TriggerBuilder.Build("*/5 11 * * * *"));

            TaskServicesManager.GetOrAdd("任务2", async (token, s) =>
            {
                System.Console.WriteLine("任务2");
                await Task.Delay(1000);
            }, TriggerBuilder.Build("*/5 6 * * * *"));

            TaskServicesManager.GetOrAdd("任务3", async (token, s) =>
            {
                System.Console.WriteLine("任务3");
                await Task.Delay(1000);
            }, TriggerBuilder.Build("*/5 36 * * * *"));

            TaskServicesManager.GetOrAdd("任务4", async (token, s) =>
            {
                System.Console.WriteLine("任务4");
                await Task.Delay(1000);
            }, TriggerBuilder.Build("*/5 55 * * * *"));

            TaskServicesManager.GetOrAdd("任务5", async (token, s) =>
            {
                System.Console.WriteLine("任务5");
                await Task.Delay(1000);
            }, TriggerBuilder.Build("*/5 12 * * * *"));

            TaskServicesManager.GetOrAdd("任务6", async (token, s) =>
            {
                System.Console.WriteLine("任务6");
                await Task.Delay(1000);
            }, TriggerBuilder.Build("*/5 10 * * * *"));

            Menus = GetIconSideMenuItems();
        }

        private static List<MenuItem> GetIconSideMenuItems()
        {
            var menus = new List<MenuItem>
            {
                //new() { Text = "返回组件库", Icon = "fa-solid fa-fw fa-home", Url = "https://www.blazor.zone/components" },
                new() { Text = "Index", Icon = "fa-solid fa-fw fa-flag", Url = "/" , Match = NavLinkMatch.All},
                //new() { Text = "Counter", Icon = "fa-solid fa-fw fa-check-square", Url = "/counter" },
                //new() { Text = "Weather", Icon = "fa-solid fa-fw fa-database", Url = "/weather" },
                //new() { Text = "Table", Icon = "fa-solid fa-fw fa-table", Url = "/table" },
                //new() { Text = "花名册", Icon = "fa-solid fa-fw fa-users", Url = "/users" },
                new() { Text = "任务列表", Icon = "fa-solid fa-fw fa-users", Url = "/tasks" },
                new() { Text = "Cron", Icon = "fa-solid fa-fw fa-users", Url = "/cron" }
            };

            return menus;
        }
    }
}
