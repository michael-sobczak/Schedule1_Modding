public class ToolboxBitmapAttribute : Attribute // TypeDefIndex: 17170
{
	// Fields
	private Image smallImage; // 0x10
	private Image bigImage; // 0x18
	public static readonly ToolboxBitmapAttribute Default; // 0x0

	// Methods

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	private void .ctor() { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor(string imageFile) { }

	// RVA: 0x2167DE0 Offset: 0x21667E0 VA: 0x182167DE0
	public void .ctor(Type t, string name) { }

	// RVA: 0x2167A00 Offset: 0x2166400 VA: 0x182167A00 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x2167AC0 Offset: 0x21664C0 VA: 0x182167AC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2167B20 Offset: 0x2166520 VA: 0x182167B20
	public static Image GetImageFromResource(Type t, string imageName, bool large) { }

	// RVA: 0x2167D70 Offset: 0x2166770 VA: 0x182167D70
	private static void .cctor() { }
}
