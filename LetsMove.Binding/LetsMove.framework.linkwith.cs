using ObjCRuntime;

[assembly: LinkWith("LetsMove.framework", LinkTarget.x86_64, IsCxx = true, SmartLink = true, ForceLoad = true, Frameworks = "Security Cocoa", WeakFrameworks = "", LinkerFlags = "")]
