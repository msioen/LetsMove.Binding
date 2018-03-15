using AppKit;
using Foundation;

namespace LetsMove.Binding.Test
{
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

		public override bool ApplicationShouldTerminateAfterLastWindowClosed(NSApplication sender)
		{
            return true;
		}
	}
}
