public class MatchCondition : ObserverCondition // TypeDefIndex: 12663
{
	// Fields
	private static Dictionary<NetworkManager, MatchCondition.ConditionCollections> _collections; // 0x0

	// Properties
	[Obsolete("Use GetMatchConnections(NetworkManager).")]
	public static Dictionary<int, HashSet<NetworkConnection>> MatchConnections { get; }
	[Obsolete("Use GetConnectionMatches(NetworkManager).")]
	public static Dictionary<NetworkConnection, HashSet<int>> ConnectionMatch { get; }
	[Obsolete("Use GetMatchObjects(NetworkManager).")]
	public static Dictionary<int, HashSet<NetworkObject>> MatchObject { get; }
	[Obsolete("Use GetObjectMatches(NetworkManager).")]
	public static Dictionary<NetworkObject, HashSet<int>> ObjectMatch { get; }

	// Methods

	// RVA: 0xD2D290 Offset: 0xD2BC90 VA: 0x180D2D290
	public static Dictionary<int, HashSet<NetworkConnection>> get_MatchConnections() { }

	// RVA: 0xD2D200 Offset: 0xD2BC00 VA: 0x180D2D200
	public static Dictionary<NetworkConnection, HashSet<int>> get_ConnectionMatch() { }

	// RVA: 0xD2D320 Offset: 0xD2BD20 VA: 0x180D2D320
	public static Dictionary<int, HashSet<NetworkObject>> get_MatchObject() { }

	// RVA: 0xD2D3B0 Offset: 0xD2BDB0 VA: 0x180D2D3B0
	public static Dictionary<NetworkObject, HashSet<int>> get_ObjectMatch() { }

	// RVA: 0xD2C3E0 Offset: 0xD2ADE0 VA: 0x180D2C3E0
	internal static void StoreCollections(NetworkManager manager) { }

	// RVA: 0xD2A250 Offset: 0xD28C50 VA: 0x180D2A250
	private static MatchCondition.ConditionCollections GetCollections(NetworkManager manager) { }

	// RVA: 0xD2A540 Offset: 0xD28F40 VA: 0x180D2A540
	public static Dictionary<int, HashSet<NetworkConnection>> GetMatchConnections(NetworkManager manager) { }

	// RVA: 0xD2A4E0 Offset: 0xD28EE0 VA: 0x180D2A4E0
	public static Dictionary<NetworkConnection, HashSet<int>> GetConnectionMatches(NetworkManager manager) { }

	// RVA: 0xD2A5A0 Offset: 0xD28FA0 VA: 0x180D2A5A0
	public static Dictionary<int, HashSet<NetworkObject>> GetMatchObjects(NetworkManager manager) { }

	// RVA: 0xD2A600 Offset: 0xD29000 VA: 0x180D2A600
	public static Dictionary<NetworkObject, HashSet<int>> GetObjectMatches(NetworkManager manager) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void ConditionConstructor() { }

	// RVA: 0xD29970 Offset: 0xD28370 VA: 0x180D29970
	private static bool AddToMatch(int match, NetworkConnection conn, NetworkManager manager, bool replaceMatch, bool rebuild) { }

	// RVA: 0xD298E0 Offset: 0xD282E0 VA: 0x180D298E0
	public static void AddToMatch(int match, NetworkConnection conn, NetworkManager manager, bool replaceMatch = False) { }

	// RVA: 0xD28DB0 Offset: 0xD277B0 VA: 0x180D28DB0
	private static void AddToConnectionMatches(NetworkConnection conn, int match, NetworkManager manager) { }

	// RVA: 0xD29D00 Offset: 0xD28700 VA: 0x180D29D00
	public static void AddToMatch(int match, NetworkConnection[] conns, NetworkManager manager, bool replaceMatch = False) { }

	// RVA: 0xD29260 Offset: 0xD27C60 VA: 0x180D29260
	public static void AddToMatch(int match, List<NetworkConnection> conns, NetworkManager manager, bool replaceMatch = False) { }

	// RVA: 0xD28F10 Offset: 0xD27910 VA: 0x180D28F10
	private static bool AddToMatch(int match, NetworkObject nob, NetworkManager manager, bool replaceMatch, bool rebuild) { }

	// RVA: 0xD29850 Offset: 0xD28250 VA: 0x180D29850
	public static void AddToMatch(int match, NetworkObject nob, NetworkManager manager, bool replaceMatch = False) { }

	// RVA: 0xD297B0 Offset: 0xD281B0 VA: 0x180D297B0
	public static void AddToMatch(int match, NetworkObject[] nobs, NetworkManager manager, bool replaceMatch = False) { }

	// RVA: 0xD29490 Offset: 0xD27E90 VA: 0x180D29490
	public static void AddToMatch(int match, List<NetworkObject> nobs, NetworkManager manager, bool replaceMatch = False) { }

	// RVA: 0xD2CC40 Offset: 0xD2B640 VA: 0x180D2CC40
	private static void TryRemoveKey(Dictionary<int, HashSet<NetworkObject>> dict, int key, HashSet<NetworkObject> value) { }

	// RVA: 0xD2CB20 Offset: 0xD2B520 VA: 0x180D2CB20
	private static void TryRemoveKey(Dictionary<int, HashSet<NetworkObject>> dict, int key) { }

	// RVA: 0xD2CED0 Offset: 0xD2B8D0 VA: 0x180D2CED0
	private static void TryRemoveKey(Dictionary<NetworkObject, HashSet<int>> dict, NetworkObject key, HashSet<int> value) { }

	// RVA: 0xD2D050 Offset: 0xD2BA50 VA: 0x180D2D050
	private static void TryRemoveKey(Dictionary<NetworkObject, HashSet<int>> dict, NetworkObject key) { }

	// RVA: 0xD2CF90 Offset: 0xD2B990 VA: 0x180D2CF90
	private static void TryRemoveKey(Dictionary<int, HashSet<NetworkConnection>> dict, int key, HashSet<NetworkConnection> value) { }

	// RVA: 0xD2CD00 Offset: 0xD2B700 VA: 0x180D2CD00
	private static void TryRemoveKey(Dictionary<int, HashSet<NetworkConnection>> dict, int key) { }

	// RVA: 0xD2CE10 Offset: 0xD2B810 VA: 0x180D2CE10
	private static void TryRemoveKey(Dictionary<NetworkConnection, HashSet<int>> dict, NetworkConnection key, HashSet<int> value) { }

	// RVA: 0xD2CA00 Offset: 0xD2B400 VA: 0x180D2CA00
	private static void TryRemoveKey(Dictionary<NetworkConnection, HashSet<int>> dict, NetworkConnection key) { }

	// RVA: 0xD2BFD0 Offset: 0xD2A9D0 VA: 0x180D2BFD0
	internal static bool RemoveFromMatchesWithoutRebuild(NetworkConnection conn, NetworkManager manager) { }

	// RVA: 0xD2B4E0 Offset: 0xD29EE0 VA: 0x180D2B4E0
	public static void RemoveFromMatch(NetworkConnection conn, NetworkManager manager) { }

	// RVA: 0xD2AD20 Offset: 0xD29720 VA: 0x180D2AD20
	private static bool RemoveFromMatch(int match, NetworkConnection conn, NetworkManager manager, bool rebuild) { }

	// RVA: 0xD2AC10 Offset: 0xD29610 VA: 0x180D2AC10
	public static bool RemoveFromMatch(int match, NetworkConnection conn, NetworkManager manager) { }

	// RVA: 0xD2AC90 Offset: 0xD29690 VA: 0x180D2AC90
	public static void RemoveFromMatch(int match, NetworkConnection[] conns, NetworkManager manager) { }

	// RVA: 0xD2B2D0 Offset: 0xD29CD0 VA: 0x180D2B2D0
	public static void RemoveFromMatch(int match, List<NetworkConnection> conns, NetworkManager manager) { }

	// RVA: 0xD2A6E0 Offset: 0xD290E0 VA: 0x180D2A6E0
	internal static bool RemoveFromMatchWithoutRebuild(NetworkObject nob, NetworkManager manager) { }

	// RVA: 0xD2AAF0 Offset: 0xD294F0 VA: 0x180D2AAF0
	public static bool RemoveFromMatch(NetworkObject nob, NetworkManager manager) { }

	// RVA: 0xD2BC60 Offset: 0xD2A660 VA: 0x180D2BC60
	public static void RemoveFromMatch(NetworkObject[] nobs, NetworkManager manager) { }

	// RVA: 0xD2B0C0 Offset: 0xD29AC0 VA: 0x180D2B0C0
	public static void RemoveFromMatch(List<NetworkObject> nobs, NetworkManager manager) { }

	// RVA: 0xD2B8E0 Offset: 0xD2A2E0 VA: 0x180D2B8E0
	public static void RemoveFromMatch(int match, NetworkObject nob, NetworkManager manager) { }

	// RVA: 0xD2BCE0 Offset: 0xD2A6E0 VA: 0x180D2BCE0
	public static void RemoveFromMatch(int match, NetworkObject[] nobs, NetworkManager manager) { }

	// RVA: 0xD2B5E0 Offset: 0xD29FE0 VA: 0x180D2B5E0
	public static void RemoveFromMatch(int match, List<NetworkObject> nobs, NetworkManager manager) { }

	// RVA: 0xD29DE0 Offset: 0xD287E0 VA: 0x180D29DE0 Slot: 6
	public override bool ConditionMet(NetworkConnection connection, bool currentlyAdded, out bool notProcessed) { }

	// RVA: 0xD2A660 Offset: 0xD29060 VA: 0x180D2A660
	private static ServerObjects GetServerObjects(NetworkManager manager) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 8
	public override ObserverConditionType GetConditionType() { }

	// RVA: 0xD29DA0 Offset: 0xD287A0 VA: 0x180D29DA0 Slot: 9
	public override ObserverCondition Clone() { }

	// RVA: 0xD27D30 Offset: 0xD26730 VA: 0x180D27D30
	public void .ctor() { }

	// RVA: 0xD2D170 Offset: 0xD2BB70 VA: 0x180D2D170
	private static void .cctor() { }
}
