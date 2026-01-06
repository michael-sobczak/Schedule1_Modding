public struct Version // TypeDefIndex: 19344
{
	// Fields
	[SerializeField]
	private string _bundleIdentifier; // 0x0
	[SerializeField]
	private string _versionNumber; // 0x8
	[SerializeField]
	private int _buildNumber; // 0x10

	// Properties
	public bool IsValid { get; }
	public string BundleIdentifier { get; }
	public string VersionNumber { get; }
	[Obsolete]
	public int BuildNumber { get; }

	// Methods

	// RVA: 0x2F6A640 Offset: 0x2F69040 VA: 0x182F6A640
	public bool get_IsValid() { }

	// RVA: 0xF098E0 Offset: 0xF082E0 VA: 0x180F098E0
	public string get_BundleIdentifier() { }

	// RVA: 0x1CD2DF0 Offset: 0x1CD17F0 VA: 0x181CD2DF0
	public string get_VersionNumber() { }

	// RVA: 0x1E13C60 Offset: 0x1E12660 VA: 0x181E13C60
	public int get_BuildNumber() { }

	// RVA: 0x133AD70 Offset: 0x1339770 VA: 0x18133AD70
	public void .ctor(string identifier, string versionNumber, int buildNumber) { }

	// RVA: 0x2F6A410 Offset: 0x2F68E10 VA: 0x182F6A410 Slot: 3
	public override string ToString() { }

	// RVA: 0x2F69FE0 Offset: 0x2F689E0 VA: 0x182F69FE0
	public int CompareTo(in Version other) { }
}
