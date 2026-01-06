public class ClipperBase // TypeDefIndex: 18144
{
	// Fields
	protected const double horizontal = -3.4E+38;
	protected const int Skip = -2;
	protected const int Unassigned = -1;
	protected const double tolerance = 1E-20;
	internal const long loRange = 1073741823;
	internal const long hiRange = 4611686018427387903;
	internal LocalMinima m_MinimaList; // 0x10
	internal LocalMinima m_CurrentLM; // 0x18
	internal List<List<TEdge>> m_edges; // 0x20
	internal bool m_UseFullRange; // 0x28
	internal bool m_HasOpenPaths; // 0x29
	[CompilerGenerated]
	private bool <PreserveCollinear>k__BackingField; // 0x2A

	// Properties
	public bool PreserveCollinear { get; set; }

	// Methods

	// RVA: 0x1E1FD50 Offset: 0x1E1E750 VA: 0x181E1FD50
	internal void .ctor() { }

	// RVA: 0x1E1FDF0 Offset: 0x1E1E7F0 VA: 0x181E1FDF0
	internal static bool near_zero(double val) { }

	[CompilerGenerated]
	// RVA: 0x844440 Offset: 0x842E40 VA: 0x180844440
	public bool get_PreserveCollinear() { }

	[CompilerGenerated]
	// RVA: 0x844450 Offset: 0x842E50 VA: 0x180844450
	public void set_PreserveCollinear(bool value) { }

	// RVA: 0xC2FB20 Offset: 0xC2E520 VA: 0x180C2FB20
	internal static bool IsHorizontal(TEdge e) { }

	// RVA: 0x1E1F1E0 Offset: 0x1E1DBE0 VA: 0x181E1F1E0
	internal bool PointIsVertex(IntPoint pt, OutPt pp) { }

	// RVA: 0x1E1F230 Offset: 0x1E1DC30 VA: 0x181E1F230
	internal bool PointOnLineSegment(IntPoint pt, IntPoint linePt1, IntPoint linePt2, bool UseFullRange) { }

	// RVA: 0x1E1F460 Offset: 0x1E1DE60 VA: 0x181E1F460
	internal bool PointOnPolygon(IntPoint pt, OutPt pp, bool UseFullRange) { }

	// RVA: 0x1E1EF80 Offset: 0x1E1D980 VA: 0x181E1EF80
	internal bool PointInPolygon(IntPoint pt, OutPt pp, bool UseFullRange) { }

	// RVA: 0x1E1FBE0 Offset: 0x1E1E5E0 VA: 0x181E1FBE0
	internal static bool SlopesEqual(TEdge e1, TEdge e2, bool UseFullRange) { }

	// RVA: 0x1E1F950 Offset: 0x1E1E350 VA: 0x181E1F950
	protected static bool SlopesEqual(IntPoint pt1, IntPoint pt2, IntPoint pt3, bool UseFullRange) { }

	// RVA: 0x1E1FA90 Offset: 0x1E1E490 VA: 0x181E1FA90
	protected static bool SlopesEqual(IntPoint pt1, IntPoint pt2, IntPoint pt3, IntPoint pt4, bool UseFullRange) { }

	// RVA: 0x1E1E3A0 Offset: 0x1E1CDA0 VA: 0x181E1E3A0 Slot: 4
	public virtual void Clear() { }

	// RVA: 0xC2F230 Offset: 0xC2DC30 VA: 0x180C2F230
	private void DisposeLocalMinimaList() { }

	// RVA: 0x1E1F5D0 Offset: 0x1E1DFD0 VA: 0x181E1F5D0
	private void RangeTest(IntPoint Pt, ref bool useFullRange) { }

	// RVA: 0xC2F890 Offset: 0xC2E290 VA: 0x180C2F890
	private void InitEdge(TEdge e, TEdge eNext, TEdge ePrev, IntPoint pt) { }

	// RVA: 0xC2F7E0 Offset: 0xC2E1E0 VA: 0x180C2F7E0
	private void InitEdge2(TEdge e, PolyType polyType) { }

	// RVA: 0x1E1D060 Offset: 0x1E1BA60 VA: 0x181E1D060
	public bool AddPath(List<IntPoint> pg, PolyType polyType, bool Closed) { }

	// RVA: 0x1E1DF00 Offset: 0x1E1C900 VA: 0x181E1DF00
	public bool AddPaths(List<List<IntPoint>> ppg, PolyType polyType, bool closed) { }

	// RVA: 0x1E1DFD0 Offset: 0x1E1C9D0 VA: 0x181E1DFD0
	public bool AddPolygon(List<IntPoint> pg, PolyType polyType) { }

	// RVA: 0x1E1DFF0 Offset: 0x1E1C9F0 VA: 0x181E1DFF0
	public bool AddPolygons(List<List<IntPoint>> ppg, PolyType polyType) { }

	// RVA: 0x1E1F540 Offset: 0x1E1DF40 VA: 0x181E1F540
	internal bool Pt2IsBetweenPt1AndPt3(IntPoint pt1, IntPoint pt2, IntPoint pt3) { }

	// RVA: 0xC30850 Offset: 0xC2F250 VA: 0x180C30850
	private TEdge RemoveEdge(TEdge e) { }

	// RVA: 0x1E1EB40 Offset: 0x1E1D540 VA: 0x181E1EB40
	private TEdge GetLastHorz(TEdge Edge) { }

	// RVA: 0x1E1F890 Offset: 0x1E1E290 VA: 0x181E1F890
	private bool SharedVertWithPrevAtTop(TEdge Edge) { }

	// RVA: 0x1E1F740 Offset: 0x1E1E140 VA: 0x181E1F740
	private bool SharedVertWithNextIsBot(TEdge Edge) { }

	// RVA: 0x1E1EEB0 Offset: 0x1E1D8B0 VA: 0x181E1EEB0
	private bool MoreBelow(TEdge Edge) { }

	// RVA: 0x1E1EC50 Offset: 0x1E1D650 VA: 0x181E1EC50
	private bool JustBeforeLocMin(TEdge Edge) { }

	// RVA: 0x1E1EDF0 Offset: 0x1E1D7F0 VA: 0x181E1EDF0
	private bool MoreAbove(TEdge Edge) { }

	// RVA: 0x1E1E0C0 Offset: 0x1E1CAC0 VA: 0x181E1E0C0
	private bool AllHorizontal(TEdge Edge) { }

	// RVA: 0xC30B20 Offset: 0xC2F520 VA: 0x180C30B20
	private void SetDx(TEdge e) { }

	// RVA: 0x1E1E7C0 Offset: 0x1E1D1C0 VA: 0x181E1E7C0
	private void DoMinimaLML(TEdge E1, TEdge E2, bool IsClosed) { }

	// RVA: 0x1E1E570 Offset: 0x1E1CF70 VA: 0x181E1E570
	private TEdge DescendToMin(ref TEdge E) { }

	// RVA: 0x1E1E110 Offset: 0x1E1CB10 VA: 0x181E1E110
	private void AscendToMax(ref TEdge E, bool Appending, bool IsClosed) { }

	// RVA: 0x1E1CD50 Offset: 0x1E1B750 VA: 0x181E1CD50
	private TEdge AddBoundsToLML(TEdge E, bool Closed) { }

	// RVA: 0x1E1EB90 Offset: 0x1E1D590 VA: 0x181E1EB90
	private void InsertLocalMinima(LocalMinima newLm) { }

	// RVA: 0x1E1F520 Offset: 0x1E1DF20 VA: 0x181E1F520
	protected void PopLocalMinima() { }

	// RVA: 0xC30AF0 Offset: 0xC2F4F0 VA: 0x180C30AF0
	private void ReverseHorizontal(TEdge e) { }

	// RVA: 0x1E1F6B0 Offset: 0x1E1E0B0 VA: 0x181E1F6B0 Slot: 5
	protected virtual void Reset() { }

	// RVA: 0x1E1E9F0 Offset: 0x1E1D3F0 VA: 0x181E1E9F0
	public IntRect GetBounds() { }
}
