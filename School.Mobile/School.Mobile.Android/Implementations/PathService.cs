using School.Mobile.Interfaces;
using System;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(School.Mobile.Droid.Implementations.PathService))]
namespace School.Mobile.Droid.Implementations
{
    public class PathService : IPathService
    {
        public string GetDatabasePath()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, "SchoolData.db3");
        }
    }
}