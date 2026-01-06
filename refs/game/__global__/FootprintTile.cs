public class FootprintTile : MonoBehaviour // TypeDefIndex: 656
{
	// Fields
	public TileAppearance tileAppearance; // 0x20
	public TileDetector tileDetector; // 0x28
	public int X; // 0x30
	public int Y; // 0x34
	public float RequiredOffset; // 0x38
	public List<CornerObstacle> Corners; // 0x40
	[CompilerGenerated]
	private Tile <MatchedStandardTile>k__BackingField; // 0x48

	// Properties
	public Tile MatchedStandardTile { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public Tile get_MatchedStandardTile() { }

	[CompilerGenerated]
	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30
	protected void set_MatchedStandardTile(Tile value) { }

	// RVA: 0xAB7510 Offset: 0xAB5F10 VA: 0x180AB7510 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30 Slot: 5
	public virtual void Initialize(Tile matchedTile) { }

	// RVA: 0xAB70A0 Offset: 0xAB5AA0 VA: 0x180AB70A0
	public bool AreCornerObstaclesBlocked(Tile proposedTile) { }

	// RVA: 0xAB7540 Offset: 0xAB5F40 VA: 0x180AB7540
	public void .ctor() { }
}
