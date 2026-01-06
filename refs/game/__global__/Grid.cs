public class Grid : MonoBehaviour, IGUIDRegisterable // TypeDefIndex: 657
{
	// Fields
	public const float TileSize = 0.5;
	public List<Tile> Tiles; // 0x20
	public List<CoordinateTilePair> CoordinateTilePairs; // 0x28
	[SerializeField]
	private Property _parentProperty; // 0x30
	[FormerlySerializedAs("StaticGUID")]
	[SerializeField]
	private string _guid; // 0x38
	[CompilerGenerated]
	private Guid <GUID>k__BackingField; // 0x40
	public Action<string, TemperatureEmitterInfo[]> OnCosmeticTemperatureEmittersChanged; // 0x50
	public Action<TemperatureEmitterInfo[]> OnTemperatureEmittersChanged; // 0x58
	[CompilerGenerated]
	private TemperatureEmitterInfo[] <TemperatureEmitterInfos>k__BackingField; // 0x60
	protected Dictionary<Coordinate, Tile> _coordinateToTile; // 0x68
	protected List<TemperatureEmitter> _cosmeticTemperatureEmitters; // 0x70
	protected List<TemperatureEmitter> _temperatureEmitters; // 0x78
	[CompilerGenerated]
	private int <Width>k__BackingField; // 0x80
	[CompilerGenerated]
	private int <Height>k__BackingField; // 0x84
	private bool _cosmeticEmittersChangedThisFrame; // 0x88
	private bool _emittersChangedThisFrame; // 0x89

	// Properties
	public Guid GUID { get; set; }
	public Property ParentProperty { get; }
	public Transform Container { get; }
	public Vector3 Origin { get; }
	public TemperatureEmitterInfo[] TemperatureEmitterInfos { get; set; }
	public int Width { get; set; }
	public int Height { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xAB8F60 Offset: 0xAB7960 VA: 0x180AB8F60 Slot: 4
	public Guid get_GUID() { }

	[CompilerGenerated]
	// RVA: 0xAB8F70 Offset: 0xAB7970 VA: 0x180AB8F70
	protected void set_GUID(Guid value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public Property get_ParentProperty() { }

	// RVA: 0x80CE40 Offset: 0x80B840 VA: 0x18080CE40
	public Transform get_Container() { }

	// RVA: 0x7262C0 Offset: 0x724CC0 VA: 0x1807262C0
	public Vector3 get_Origin() { }

	[CompilerGenerated]
	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public TemperatureEmitterInfo[] get_TemperatureEmitterInfos() { }

	[CompilerGenerated]
	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	private void set_TemperatureEmitterInfos(TemperatureEmitterInfo[] value) { }

	[CompilerGenerated]
	// RVA: 0x4D6280 Offset: 0x4D4C80 VA: 0x1804D6280
	public int get_Width() { }

	[CompilerGenerated]
	// RVA: 0x4D6540 Offset: 0x4D4F40 VA: 0x1804D6540
	private void set_Width(int value) { }

	[CompilerGenerated]
	// RVA: 0x6A52B0 Offset: 0x6A3CB0 VA: 0x1806A52B0
	public int get_Height() { }

	[CompilerGenerated]
	// RVA: 0x9883D0 Offset: 0x986DD0 VA: 0x1809883D0
	private void set_Height(int value) { }

	// RVA: 0xAB7800 Offset: 0xAB6200 VA: 0x180AB7800 Slot: 7
	protected virtual void Awake() { }

	// RVA: 0xAB8020 Offset: 0xAB6A20 VA: 0x180AB8020
	private void LateUpdate() { }

	// RVA: 0xAB8420 Offset: 0xAB6E20 VA: 0x180AB8420
	private void ProcessCoordinateDataPairs() { }

	// RVA: 0xAB85A0 Offset: 0xAB6FA0 VA: 0x180AB85A0
	public void RegisterTile(Tile tile) { }

	// RVA: 0xAB7B70 Offset: 0xAB6570 VA: 0x180AB7B70
	public void DeregisterTile(Tile tile) { }

	[Button]
	// RVA: 0xAB8550 Offset: 0xAB6F50 VA: 0x180AB8550
	public void RegenerateGUID() { }

	// RVA: 0xAB89B0 Offset: 0xAB73B0 VA: 0x180AB89B0 Slot: 6
	public void SetGUID(Guid guid) { }

	// RVA: 0xAB7D20 Offset: 0xAB6720 VA: 0x180AB7D20
	public Coordinate GetMatchedCoordinate(FootprintTile tileToMatch) { }

	// RVA: 0xAB7EB0 Offset: 0xAB68B0 VA: 0x180AB7EB0
	public bool IsTileValidAtCoordinate(Coordinate gridCoord, FootprintTile tile, GridItem tileOwner) { }

	// RVA: 0xAB7E20 Offset: 0xAB6820 VA: 0x180AB7E20
	public Tile GetTile(Coordinate coord) { }

	[Button]
	// RVA: 0xAB8C90 Offset: 0xAB7690 VA: 0x180AB8C90
	public void SetVisible() { }

	[Button]
	// RVA: 0xAB8B80 Offset: 0xAB7580 VA: 0x180AB8B80
	public void SetInvisible() { }

	// RVA: 0xAB75C0 Offset: 0xAB5FC0 VA: 0x180AB75C0
	public void AddTemperatureEmitter(TemperatureEmitter emitter, bool onlyCosmetic) { }

	// RVA: 0xAB8770 Offset: 0xAB7170 VA: 0x180AB8770
	public void RemoveTemperatureEmitter(TemperatureEmitter emitter, bool onlyCosmetic) { }

	// RVA: 0xAB7B60 Offset: 0xAB6560 VA: 0x180AB7B60
	private void CosmeticTemperatureEmittersChanged() { }

	// RVA: 0xAB8DA0 Offset: 0xAB77A0 VA: 0x180AB8DA0
	private void TemperatureEmittersChanged() { }

	// RVA: 0xAB8A10 Offset: 0xAB7410 VA: 0x180AB8A10
	private void SetGridSize() { }

	// RVA: 0xAB8DB0 Offset: 0xAB77B0 VA: 0x180AB8DB0
	public void .ctor() { }
}
