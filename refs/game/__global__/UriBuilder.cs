public class UriBuilder // TypeDefIndex: 9494
{
	// Fields
	private bool _changed; // 0x10
	private string _fragment; // 0x18
	private string _host; // 0x20
	private string _password; // 0x28
	private string _path; // 0x30
	private int _port; // 0x38
	private string _query; // 0x40
	private string _scheme; // 0x48
	private string _schemeDelimiter; // 0x50
	private Uri _uri; // 0x58
	private string _username; // 0x60

	// Properties
	public string Host { set; }
	public string Path { get; set; }
	public string Query { get; set; }
	public string Scheme { set; }
	public Uri Uri { get; }

	// Methods

	// RVA: 0x260BEF0 Offset: 0x260A8F0 VA: 0x18260BEF0
	public void .ctor() { }

	// RVA: 0x260C060 Offset: 0x260AA60 VA: 0x18260C060
	public void .ctor(Uri uri) { }

	// RVA: 0x260B660 Offset: 0x260A060 VA: 0x18260B660
	private void Init(Uri uri) { }

	// RVA: 0x260C2F0 Offset: 0x260ACF0 VA: 0x18260C2F0
	public void set_Host(string value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_Path() { }

	// RVA: 0x260C3D0 Offset: 0x260ADD0 VA: 0x18260C3D0
	public void set_Path(string value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public string get_Query() { }

	// RVA: 0x260C480 Offset: 0x260AE80 VA: 0x18260C480
	public void set_Query(string value) { }

	// RVA: 0x260C530 Offset: 0x260AF30 VA: 0x18260C530
	public void set_Scheme(string value) { }

	// RVA: 0x260C240 Offset: 0x260AC40 VA: 0x18260C240
	public Uri get_Uri() { }

	// RVA: 0x260B5B0 Offset: 0x2609FB0 VA: 0x18260B5B0 Slot: 0
	public override bool Equals(object rparam) { }

	// RVA: 0x260B620 Offset: 0x260A020 VA: 0x18260B620 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x260B840 Offset: 0x260A240 VA: 0x18260B840
	private void SetFieldsFromUri(Uri uri) { }

	// RVA: 0x260BA00 Offset: 0x260A400 VA: 0x18260BA00 Slot: 3
	public override string ToString() { }
}
