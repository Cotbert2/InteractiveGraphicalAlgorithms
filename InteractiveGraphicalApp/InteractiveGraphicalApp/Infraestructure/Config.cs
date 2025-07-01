using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveGraphicalApp.Infraestructure
{
    public class Config
    {
        public static Config _instance;
        public static readonly object _lock = new object();

        public Color LineColor { get; set; } 
        public Color FillColor { get; set; } 
        public int AnimationDelay { get; set; }
        public int LineAnchors { get; set; }
        public bool SplashScreenShowed { get; set; }


        private Config()
        {
            LineColor = Color.Black;
            FillColor = Color.ForestGreen;
            AnimationDelay = 0;
            LineAnchors = 1;
            SplashScreenShowed = false;
        }

        public static Config Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Config();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
