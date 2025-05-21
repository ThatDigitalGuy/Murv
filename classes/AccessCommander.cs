namespace Murv.Classes;

#region Account Credentials Class
class FingerPrint {
    internal string Finger {get; set; } = "";
    internal string? Template { get; set; }
    internal bool OpensDoor {get; set;}
    internal bool TriggersSilentAlarm {get; set;}
    internal bool ExecutesAutomation1 {get; set;}
    internal bool ExecutesAutomation2 {get; set;}
}

class AccessCredentials {
    internal string? ValidFrom {get;set;} 
    internal string? ValidTo {get;set;} 
    internal List<string>? Cards {get; set;}
    internal List<FingerPrint>? Fingerprints {get;set;}
    internal List<string>? LicensePlates {get; set;}
    internal string? Pin {get;set;} 
    internal string? QrCode {get;set;} 
    internal string? MobileKey {get;set;} 
    internal bool IsPairing {get;set;}
} 

#endregion

#region Account Class





class AccountSettings {
    internal bool PasswordMustBeChanged {get; set;}
    internal bool ShowWizard {get; set;}
    internal bool ShowGiveFeedback {get; set;}
    internal string Localization {get; set;} = "En";
    internal bool SimpleUI {get; set;}
}

class Account {
    internal string? Login { set; get; }
    internal string? Email { get; set; }
    internal AccountSettings settings { get; set; }
}

#endregion

#region UserCalling Class
    class GuidIdName {
        internal string Id { get; set; }
        internal string? Name { get; set; }
    }

    class PhoneNumber {
        internal string? Number {get; set;}
        internal GuidIdName TimeProfile { get; set; }
        internal bool CallNextNumberSimultaneously { get; set; }
        internal string? IpEyeAddress {get; set;}
    }
    class UserCalling {
        internal string? VirtualNumber { get; set; }
        internal List<PhoneNumber> PhoneNumbers { get; set; }
        internal GuidIdName Deputy { get; set; }
    }
#endregion

#region UserIntegration
    class UserIntegration {
        internal string? ExternalId {get;set;}
        internal string? VirtualCredential {get;set;}
        internal bool FromExternalSystem {get;set;}
        internal List<string>? SwitchCodes {get;set;}
    }
#endregion

class AccessCommanderPlugin {
    #region Response Body
    // Access Commander Class
    internal bool IsSysAdmin { get; set; } = false;
    internal bool IsSuspended { get; set; } = false;
    internal string? Note { get; set; } = "";
    internal bool AttendanceMonitored { get; set; } = false;
    internal AccessCredentials AccessCredentials {get; set;}
    internal Account Account {get; set;}
    internal UserCalling Calling { get; set; }
    internal UserIntegration Integration {get; set;}
    internal List<GuidIdName> Groups {get;set;}
    internal string? Name { get; set; }
    internal string? Id { get; set; }
    internal string? AvatarUrl { get; set; }
    internal string? Type { get; set; }
    internal Int32 Revision { get; set; }
    #endregion

    
};

