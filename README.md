[![NuGet Status](http://img.shields.io/nuget/v/LetsMove.Binding.svg?style=flat)](https://www.nuget.org/packages/LetsMove.Binding/)

# LetsMove.Binding

Xamarin binding for the [LetsMove library](https://github.com/potionfactory/LetsMove)

# LetsMove

Move a running Mac OS X application to the Applications folder. Does NOT support sandboxed applications.

## Usage

```c#
[Register("AppDelegate")]
public class AppDelegate : NSApplicationDelegate
{
    public AppDelegate()
    {
    }

    public override void DidFinishLaunching(NSNotification notification)
    {
       LetsMove.CFunctions.PFMoveToApplicationsFolderIfNecessary();
    }

    public override void WillTerminate(NSNotification notification)
    {
    }
}
```