internal class TEdge // TypeDefIndex: 18137
{
	// Fields
	public IntPoint Bot; // 0x10
	public IntPoint Curr; // 0x20
	public IntPoint Top; // 0x30
	public IntPoint Delta; // 0x40
	public double Dx; // 0x50
	public PolyType PolyTyp; // 0x58
	public EdgeSide Side; // 0x5C
	public int WindDelta; // 0x60
	public int WindCnt; // 0x64
	public int WindCnt2; // 0x68
	public int OutIdx; // 0x6C
	public TEdge Next; // 0x70
	public TEdge Prev; // 0x78
	public TEdge NextInLML; // 0x80
	public TEdge NextInAEL; // 0x88
	public TEdge PrevInAEL; // 0x90
	public TEdge NextInSEL; // 0x98
	public TEdge PrevInSEL; // 0xA0

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
