using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;

namespace AzR.Web.Root
{
    public class AzRViewEngine : RazorViewEngine
    {
        private List<string> _areas = new List<string>();
        public AzRViewEngine()
        {
            var areas = Directory.GetDirectories(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Areas")).ToList();

            areas.ForEach(s =>
            {
                var di = new DirectoryInfo(s);
                _areas.Add(di.Name);
            });

            ViewLocationFormats = GetViewLocations(base.ViewLocationFormats);
            MasterLocationFormats = GetMasterLocations(base.MasterLocationFormats);
            PartialViewLocationFormats = PartialViewLocations(base.PartialViewLocationFormats);

        }
        public AzRViewEngine(List<string> areaFolders)
        {
            _areas = areaFolders;

            ViewLocationFormats = GetViewLocations(base.ViewLocationFormats);
            MasterLocationFormats = GetMasterLocations(base.MasterLocationFormats);
            PartialViewLocationFormats = PartialViewLocations(base.PartialViewLocationFormats);
        }

        public string[] GetViewLocations(string[] basePath)
        {
            var views = basePath.ToList();
            _areas.ForEach(plugin =>
                views.Add("~/Areas/" + plugin + "/Views/{1}/{0}.cshtml")
            );

            return views.ToArray();
        }

        public string[] GetMasterLocations(string[] basePath)
        {
            var views = basePath.ToList();
            _areas.ForEach(plugin =>
                views.Add("~/Areas/" + plugin + "/Views/Shared/{0}.cshtml")
            );
            return views.ToArray();
        }
        public string[] PartialViewLocations(string[] basePath)
        {
            var views = basePath.ToList();
            _areas.ForEach(plugin =>
                views.Add("~/Areas/" + plugin + "/Views/{1}/{0}.cshtml")
            );

            return views.ToArray();
        }

    }
}