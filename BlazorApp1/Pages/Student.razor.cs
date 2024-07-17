using BlazorApp1.Model;
using Microsoft.AspNetCore.Components;
using Radzen;
using Radzen.Blazor;
namespace BlazorApp1.Pages
{
    public partial class Student
    {
        private int _age = 18;
        private string _name = "student";
        private string _newname = "click ";
        [Inject] public Component component { get; set; }
        [Inject] public NotificationService NotificationService { get; set; }
        [Inject] public DialogService DialogService { get; set; }
        public async Task Methon()
        {
            component.SayHello();
            _name = component.sMethod;
            NotificationService.Notify(NotificationSeverity.Success, "Error", "test", 3000);
        }

    }
}
