using System;

namespace JournalScreenControl.Navigation.Navigator
{
    public interface INavigator : IDisposable
    {
        string Navigate(string url);
    }
}
