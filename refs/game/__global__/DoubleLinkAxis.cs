internal class DoubleLinkAxis : Axis // TypeDefIndex: 8236
{
	// Fields
	internal Axis next; // 0x40

	// Properties
	internal Axis Next { get; set; }

	// Methods

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	internal Axis get_Next() { }

	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	internal void set_Next(Axis value) { }

	// RVA: 0x2563910 Offset: 0x2562310 VA: 0x182563910
	internal void .ctor(Axis axis, DoubleLinkAxis inputaxis) { }

	// RVA: 0x25637E0 Offset: 0x25621E0 VA: 0x1825637E0
	internal static DoubleLinkAxis ConvertTree(Axis axis) { }
}
