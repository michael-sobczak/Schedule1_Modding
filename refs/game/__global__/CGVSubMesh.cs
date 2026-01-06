public class CGVSubMesh : CGData // TypeDefIndex: 10662
{
	// Fields
	public Material Material; // 0x20
	private SubArray<int> triangles; // 0x28

	// Properties
	public SubArray<int> TrianglesList { get; set; }
	[Obsolete("Use TrianglesList instead")]
	[UsedImplicitly]
	public int[] Triangles { get; set; }
	public override int Count { get; }

	// Methods

	// RVA: 0x4D8510 Offset: 0x4D6F10 VA: 0x1804D8510
	public SubArray<int> get_TrianglesList() { }

	// RVA: 0x5027D0 Offset: 0x5011D0 VA: 0x1805027D0
	public void set_TrianglesList(SubArray<int> value) { }

	// RVA: 0x502720 Offset: 0x501120 VA: 0x180502720
	public int[] get_Triangles() { }

	// RVA: 0x5028B0 Offset: 0x5012B0 VA: 0x1805028B0
	public void set_Triangles(int[] value) { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90 Slot: 6
	public override int get_Count() { }

	// RVA: 0x502290 Offset: 0x500C90 VA: 0x180502290
	public void .ctor(Material material) { }

	// RVA: 0x502690 Offset: 0x501090 VA: 0x180502690
	public void .ctor(int[] triangles, Material material) { }

	// RVA: 0x5023B0 Offset: 0x500DB0 VA: 0x1805023B0
	public void .ctor(SubArray<int> triangles, Material material) { }

	// RVA: 0x502570 Offset: 0x500F70 VA: 0x180502570
	public void .ctor(int triangleCount, Material material) { }

	// RVA: 0x502400 Offset: 0x500E00 VA: 0x180502400
	public void .ctor(CGVSubMesh source) { }

	// RVA: 0x502010 Offset: 0x500A10 VA: 0x180502010 Slot: 5
	protected override bool Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 7
	public override T Clone<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5CC80 Offset: 0xE5B680 VA: 0x180E5CC80
	|-CGVSubMesh.Clone<object>
	*/

	// RVA: 0x502100 Offset: 0x500B00 VA: 0x180502100
	public static CGVSubMesh Get(CGVSubMesh data, int triangleCount, Material material) { }

	// RVA: 0x502230 Offset: 0x500C30 VA: 0x180502230
	public void ShiftIndices(int offset, int startIndex = 0) { }

	// RVA: 0x501EB0 Offset: 0x5008B0 VA: 0x180501EB0
	public void Add(CGVSubMesh other, int shiftIndexOffset = 0) { }
}
