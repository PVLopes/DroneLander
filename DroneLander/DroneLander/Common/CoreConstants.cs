using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneLander.Common
{
    public static class CoreConstants
    {
        public const double Gravity = 3.711;      // Mars gravity (m/s2)
        public const double LanderMass = 17198.0; // Lander mass (kg)
        public const int PollingIncrement = 500;

        public const double StartingAltitude = 5000.0;
        public const double StartingVelocity = 0.0;
        public const double StartingFuel = 1000.0;
        public const double StartingThrust = 0.0;
    }

    public static class MobileCenterConstants {
        public const string AndroidAppId = "4d147d4e-50a6-4f36-acfe-36fcb3bd502f";
        public const string iOSAppId = "";
    }

    public static class MobileServiceConstants {
        public const string AppUrl = "https://dronelandermobilentk.azurewebsites.net";
    }
}
