using System.Runtime.InteropServices;

namespace LetsMove
{
	public static class CFunctions
	{
		// extern void PFMoveToApplicationsFolderIfNecessary ();
		[DllImport ("__Internal")]
		public static extern void PFMoveToApplicationsFolderIfNecessary ();

		// extern BOOL PFMoveIsInProgress ();
		[DllImport ("__Internal")]
		public static extern bool PFMoveIsInProgress ();
	}
}
