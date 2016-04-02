using System;

namespace _014_EventRaiser
{
    public interface IView
    {
        event EventHandler Load;
    }
}
