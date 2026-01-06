public class ClipperRegistry // TypeDefIndex: 16377
{
	// Fields
	private static ClipperRegistry s_Instance; // 0x0
	private readonly IndexedSet<IClipper> m_Clippers; // 0x10

	// Properties
	public static ClipperRegistry instance { get; }

	// Methods

	// RVA: 0x2D8F730 Offset: 0x2D8E130 VA: 0x182D8F730
	protected void .ctor() { }

	// RVA: 0x2D8F7B0 Offset: 0x2D8E1B0 VA: 0x182D8F7B0
	public static ClipperRegistry get_instance() { }

	// RVA: 0x2D8F4C0 Offset: 0x2D8DEC0 VA: 0x182D8F4C0
	public void Cull() { }

	// RVA: 0x2D8F660 Offset: 0x2D8E060 VA: 0x182D8F660
	public static void Register(IClipper c) { }

	// RVA: 0x2D8F6D0 Offset: 0x2D8E0D0 VA: 0x182D8F6D0
	public static void Unregister(IClipper c) { }

	// RVA: 0x2D8F600 Offset: 0x2D8E000 VA: 0x182D8F600
	public static void Disable(IClipper c) { }
}
