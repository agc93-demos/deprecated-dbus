using UPower.DBus;

namespace dbus
{
    public static class Extensions
    {
        internal static string GetSourceType(this DeviceProperties props) {
            switch (props.Type)
            {
                case 1:
                    return "Line Power";
                case 2:
                    return "Battery";
                case 3:
                    return "UPS";
                case 4:
                    return "Monitor";
                case 5:
                    return "Mouse";
                case 8:
                    return "Phone";
                default:
                    return "Unknown";
            }
        }

        internal static string GetDeviceState(this DeviceProperties props) {
            switch (props.State)
            {
                case 1:
                    return "Charging";
                case 2:
                    return "Discharging";
                case 3:
                    return "Empty";
                case 4:
                    return "Fully Charged";
                default:
                    return "Unknown";
            }
        }
    }
}