internal class YogaConfig // TypeDefIndex: 6145
{
	// Fields
	internal static readonly YogaConfig Default; // 0x0
	private IntPtr _ygConfig; // 0x10
	private Logger _logger; // 0x18

	// Properties
	internal IntPtr Handle { get; }
	public bool UseWebDefaults { get; set; }
	public float PointScaleFactor { set; }

	// Methods

	// RVA: 0x2DBEB60 Offset: 0x2DBD560 VA: 0x182DBEB60
	private void .ctor(IntPtr ygConfig) { }

	// RVA: 0x2DBEB20 Offset: 0x2DBD520 VA: 0x182DBEB20
	public void .ctor() { }

	// RVA: 0x2DBE980 Offset: 0x2DBD380 VA: 0x182DBE980 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x180D270 Offset: 0x180BC70 VA: 0x18180D270
	internal IntPtr get_Handle() { }

	// RVA: 0x2DBEBE0 Offset: 0x2DBD5E0 VA: 0x182DBEBE0
	public bool get_UseWebDefaults() { }

	// RVA: 0x2DBEC70 Offset: 0x2DBD670 VA: 0x182DBEC70
	public void set_UseWebDefaults(bool value) { }

	// RVA: 0x2DBEC20 Offset: 0x2DBD620 VA: 0x182DBEC20
	public void set_PointScaleFactor(float value) { }

	// RVA: 0x2DBEA80 Offset: 0x2DBD480 VA: 0x182DBEA80
	private static void .cctor() { }
}
