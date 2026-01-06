public class RaymarchingQuality // TypeDefIndex: 275
{
	// Fields
	public string name; // 0x10
	public int stepCount; // 0x18
	[SerializeField]
	private int _UniqueID; // 0x1C
	private static RaymarchingQuality ms_DefaultInstance; // 0x0
	private const int kRandomUniqueIdMinRange = 4;

	// Properties
	public int uniqueID { get; }
	public bool hasValidUniqueID { get; }
	public static RaymarchingQuality defaultInstance { get; }

	// Methods

	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	public int get_uniqueID() { }

	// RVA: 0x69FBB0 Offset: 0x69E5B0 VA: 0x18069FBB0
	public bool get_hasValidUniqueID() { }

	// RVA: 0x69FB60 Offset: 0x69E560 VA: 0x18069FB60
	public static RaymarchingQuality get_defaultInstance() { }

	// RVA: 0x69FAF0 Offset: 0x69E4F0 VA: 0x18069FAF0
	private void .ctor(int uniqueID) { }

	// RVA: 0x69F990 Offset: 0x69E390 VA: 0x18069F990
	public static RaymarchingQuality New() { }

	// RVA: 0x69F8D0 Offset: 0x69E2D0 VA: 0x18069F8D0
	public static RaymarchingQuality New(string name, int forcedUniqueID, int stepCount) { }

	// RVA: 0x69F870 Offset: 0x69E270 VA: 0x18069F870
	private static bool HasRaymarchingQualityWithSameUniqueID(RaymarchingQuality[] values, int id) { }

	// RVA: 0x69FA40 Offset: 0x69E440 VA: 0x18069FA40
	private static void .cctor() { }
}
