using System;
using MediaBrowser.Common.Plugins;
using System.IO;
using MediaBrowser.Model.Drawing;

namespace IMVDb
{
    public class Plugin : BasePlugin
    {
        private Guid _id = new Guid("0277E613-3EC0-4360-A3DE-F8AF0AABB5E9");
        public override Guid Id
        {
            get { return _id; }
        }

        public override string Name
        {
            get { return StaticName; }
        }

        public static string StaticName
        {
            get { return "IMVDb"; }
        }

        public override string Description
        {
            get
            {
                return "IMVDb metadata for musiv videos";
            }
        }
    }
}