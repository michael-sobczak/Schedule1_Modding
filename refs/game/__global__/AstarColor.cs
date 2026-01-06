public class AstarColor // TypeDefIndex: 13111
{
	// Fields
	public Color _SolidColor; // 0x10
	public Color _UnwalkableNode; // 0x20
	public Color _BoundsHandles; // 0x30
	public Color _ConnectionLowLerp; // 0x40
	public Color _ConnectionHighLerp; // 0x50
	public Color _MeshEdgeColor; // 0x60
	public Color[] _AreaColors; // 0x70
	public static Color SolidColor; // 0x0
	public static Color UnwalkableNode; // 0x10
	public static Color BoundsHandles; // 0x20
	public static Color ConnectionLowLerp; // 0x30
	public static Color ConnectionHighLerp; // 0x40
	public static Color MeshEdgeColor; // 0x50
	private static Color[] AreaColors; // 0x60

	// Methods

	// RVA: 0xB02FD0 Offset: 0xB019D0 VA: 0x180B02FD0
	public static int ColorHash() { }

	// RVA: 0xB03200 Offset: 0xB01C00 VA: 0x180B03200
	public static Color GetAreaColor(uint area) { }

	// RVA: 0xB03360 Offset: 0xB01D60 VA: 0x180B03360
	public static Color GetTagColor(uint tag) { }

	// RVA: 0xB034C0 Offset: 0xB01EC0 VA: 0x180B034C0
	public void PushToStatic(AstarPath astar) { }

	// RVA: 0xB03700 Offset: 0xB02100 VA: 0x180B03700
	public void .ctor() { }

	// RVA: 0xB03600 Offset: 0xB02000 VA: 0x180B03600
	private static void .cctor() { }
}
