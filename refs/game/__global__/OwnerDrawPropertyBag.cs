public class OwnerDrawPropertyBag : MarshalByRefObject, ISerializable // TypeDefIndex: 5526
{
	// Fields
	private Color fore_color; // 0x18
	private Color back_color; // 0x30
	private Font font; // 0x48
	[CompilerGenerated]
	private static Dictionary<string, int> <>f__switch$map9; // 0x0

	// Properties
	public Color ForeColor { get; }
	public Color BackColor { get; }
	public Font Font { get; }

	// Methods

	// RVA: 0x239AF70 Offset: 0x2399970 VA: 0x18239AF70
	internal void .ctor() { }

	// RVA: 0x239AEE0 Offset: 0x23998E0 VA: 0x18239AEE0
	private void .ctor(Color fore_color, Color back_color, Font font) { }

	// RVA: 0x239B000 Offset: 0x2399A00 VA: 0x18239B000
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x239ADF0 Offset: 0x23997F0 VA: 0x18239ADF0 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x49D250 Offset: 0x49BC50 VA: 0x18049D250
	public Color get_ForeColor() { }

	// RVA: 0xCCD880 Offset: 0xCCC280 VA: 0x180CCD880
	public Color get_BackColor() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public Font get_Font() { }

	// RVA: 0x239AD10 Offset: 0x2399710 VA: 0x18239AD10
	public static OwnerDrawPropertyBag Copy(OwnerDrawPropertyBag value) { }
}
