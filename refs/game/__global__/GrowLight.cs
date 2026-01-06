public class GrowLight : ProceduralGridItem // TypeDefIndex: 3285
{
	// Fields
	[Header("References")]
	public ToggleableLight Light; // 0x200
	public UsableLightSource usableLightSource; // 0x208
	private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.GrowLightAssembly-CSharp.dll_Excuted; // 0x210
	private bool NetworkInitialize__LateScheduleOne.ObjectScripts.GrowLightAssembly-CSharp.dll_Excuted; // 0x211

	// Methods

	// RVA: 0xA31970 Offset: 0xA30370 VA: 0x180A31970 Slot: 67
	public override void InitializeProceduralGridItem(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID) { }

	// RVA: 0xA31C30 Offset: 0xA30630 VA: 0x180A31C30
	public void SetIsOn(bool isOn) { }

	// RVA: 0xA31770 Offset: 0xA30170 VA: 0x180A31770 Slot: 56
	protected override void Destroy() { }

	// RVA: 0xA31C70 Offset: 0xA30670 VA: 0x180A31C70
	public void .ctor() { }

	// RVA: 0xA31C10 Offset: 0xA30610 VA: 0x180A31C10 Slot: 63
	public override void NetworkInitialize___Early() { }

	// RVA: 0xA31BF0 Offset: 0xA305F0 VA: 0x180A31BF0 Slot: 64
	public override void NetworkInitialize__Late() { }

	// RVA: 0x67D360 Offset: 0x67BD60 VA: 0x18067D360 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xA31720 Offset: 0xA30120 VA: 0x180A31720 Slot: 47
	public override void Awake() { }
}
