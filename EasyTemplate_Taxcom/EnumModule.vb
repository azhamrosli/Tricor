Module EnumModule
    Enum License_Type
        Normal
        Silver
        Gold
    End Enum
    Enum Status
        Deactive
        Active
    End Enum
    Enum LogError_Type
        Normal
        Code_Error
        Module_Error
        Page_Error
        Data_Error
        Database_Error
    End Enum
    Enum User_Type
        Normal = 0
        Administrator = 1
        Super_User = 2
    End Enum
    Enum UserStatus_Type
        Deactive = 0
        Active = 1
        Pending_Active = 2
    End Enum
    Enum VersionLicenseType
        Normal = 0
        Tricor = 1
    End Enum
End Module
