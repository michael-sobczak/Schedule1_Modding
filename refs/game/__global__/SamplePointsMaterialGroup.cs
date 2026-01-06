public class SamplePointsMaterialGroup // TypeDefIndex: 10688
{
	// Fields
	public int MaterialID; // 0x10
	public List<SamplePointsPatch> Patches; // 0x18

	// Properties
	public int TriangleCount { get; }
	public int StartVertex { get; }
	public int EndVertex { get; }
	public int VertexCount { get; }

	// Methods

	// RVA: 0x50D8F0 Offset: 0x50C2F0 VA: 0x18050D8F0
	public int get_TriangleCount() { }

	// RVA: 0x50D8A0 Offset: 0x50C2A0 VA: 0x18050D8A0
	public int get_StartVertex() { }

	// RVA: 0x50D830 Offset: 0x50C230 VA: 0x18050D830
	public int get_EndVertex() { }

	// RVA: 0x50D990 Offset: 0x50C390 VA: 0x18050D990
	public int get_VertexCount() { }

	// RVA: 0x50D7A0 Offset: 0x50C1A0 VA: 0x18050D7A0
	public void .ctor(int materialID) { }

	// RVA: 0x50D760 Offset: 0x50C160 VA: 0x18050D760
	public void .ctor(int materialID, List<SamplePointsPatch> patches) { }

	// RVA: 0x50D450 Offset: 0x50BE50 VA: 0x18050D450
	public void GetLengths(CGVolume volume, out float worldLength, out float uLength) { }

	// RVA: 0x50D3A0 Offset: 0x50BDA0 VA: 0x18050D3A0
	public SamplePointsMaterialGroup Clone() { }
}
