public class Package : ScriptableObject // TypeDefIndex: 19342
{
	// Fields
	[HideInInspector]
	[SerializeField]
	private string _displayName; // 0x18
	[SerializeField]
	private string _description; // 0x20
	[SerializeField]
	[HideInInspector]
	private Version _version; // 0x28
	[SerializeField]
	private bool _downloadInBackground; // 0x40
	[HideInInspector]
	[SerializeField]
	private int _priority; // 0x44
	[SerializeField]
	private string _documentationUrl; // 0x48
	[SerializeField]
	private string _demoScene; // 0x50
	[SerializeField]
	private bool _pingAsset; // 0x58

	// Properties
	public string DisplayName { get; }
	public Version Version { get; }
	public bool DownloadInBackground { get; }
	public int Priority { get; }
	public string DocumentationUrl { get; }
	public string DemoScene { get; }
	public bool Ping { get; }
	public string Description { get; }

	// Methods

	// RVA: 0x1670E50 Offset: 0x166F850 VA: 0x181670E50
	public string get_DisplayName() { }

	// RVA: 0x2F69F40 Offset: 0x2F68940 VA: 0x182F69F40
	public Version get_Version() { }

	// RVA: 0x1E16300 Offset: 0x1E14D00 VA: 0x181E16300
	public bool get_DownloadInBackground() { }

	// RVA: 0x2F69F30 Offset: 0x2F68930 VA: 0x182F69F30
	public int get_Priority() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public string get_DocumentationUrl() { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public string get_DemoScene() { }

	// RVA: 0x4D61A0 Offset: 0x4D4BA0 VA: 0x1804D61A0
	public bool get_Ping() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_Description() { }

	// RVA: 0x2F69F10 Offset: 0x2F68910 VA: 0x182F69F10
	public void .ctor() { }
}
