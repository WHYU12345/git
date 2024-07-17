using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Model
{
    public class Component : ComponentBase
    {
        public string StudentName { get; set; }
        public string StudentDescription { get; set; }

        public string gzMethod { get; set; }

        public string sMethod { get; set; }

        public string eMethod { get; set; }

        public Component()
        {
            gzMethod = "我的构造方法被调用了";
        }
        public Component(string studentname, int studentage)
        {
            gzMethod = studentname + studentage + "岁了";
        }

        public void SayHello()
        {
            sMethod = "我要讲话了";
        }

        public void Eat()
        {
            eMethod = "我要吃了";
        }

    }
}
