using System.Collections.Generic;
using S1API.PhoneApp;

namespace S1API.Internal.Patches;

internal static class PhoneAppRegistry
{
	public static readonly List<global::S1API.PhoneApp.PhoneApp> RegisteredApps = new List<global::S1API.PhoneApp.PhoneApp>();

	public static void Register(global::S1API.PhoneApp.PhoneApp app)
	{
		RegisteredApps.Add(app);
	}
}
