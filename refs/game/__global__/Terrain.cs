public sealed class Terrain : Behaviour // TypeDefIndex: 18993
{
	// Properties
	public TerrainData terrainData { get; }
	public bool allowAutoConnect { get; }
	public int groupingID { get; }
	public static Terrain activeTerrain { get; }
	[NativeProperty("ActiveTerrainsScriptingArray")]
	public static Terrain[] activeTerrains { get; }

	// Methods

	// RVA: 0x2D46F70 Offset: 0x2D45970 VA: 0x182D46F70
	public TerrainData get_terrainData() { }

	// RVA: 0x2D46EF0 Offset: 0x2D458F0 VA: 0x182D46EF0
	public bool get_allowAutoConnect() { }

	// RVA: 0x2D46F30 Offset: 0x2D45930 VA: 0x182D46F30
	public int get_groupingID() { }

	// RVA: 0x2D46E20 Offset: 0x2D45820 VA: 0x182D46E20
	public void SetNeighbors(Terrain left, Terrain top, Terrain right, Terrain bottom) { }

	// RVA: 0x2D46DD0 Offset: 0x2D457D0 VA: 0x182D46DD0
	public Vector3 GetPosition() { }

	// RVA: 0x2D46E90 Offset: 0x2D45890 VA: 0x182D46E90
	public static Terrain get_activeTerrain() { }

	// RVA: 0x2D46EC0 Offset: 0x2D458C0 VA: 0x182D46EC0
	public static Terrain[] get_activeTerrains() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	// RVA: 0x2D46D80 Offset: 0x2D45780 VA: 0x182D46D80
	private void GetPosition_Injected(out Vector3 ret) { }
}
