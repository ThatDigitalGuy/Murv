namespace Murv.Classes;

class AccessCommanderPlugin {

    // Access Credentials Class

    // Access Commander Class
    private bool IsSysAdmin { get; set; } = false;
    private bool IsSuspended { get; set; } = false;
    private string? Note { get; set; } = "";
    private bool AttendanceMonitored { get; set; } = false;

};
