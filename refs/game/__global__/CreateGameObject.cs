public class CreateGameObject : ResourceExportingModule // TypeDefIndex: 10714
{
	// Fields
	[HideInInspector]
	[InputSlotInfo(new[] { typeof(CGGameObject) }, Array = True, Name = "GameObject")]
	public CGModuleInputSlot InGameObjectArray; // 0xC0
	[HideInInspector]
	[InputSlotInfo(new[] { typeof(CGSpots) }, Name = "Spots")]
	public CGModuleInputSlot InSpots; // 0xC8
	[SerializeField]
	[CGResourceCollectionManager("GameObject", ShowCount = True)]
	private CGGameObjectResourceCollection m_Resources; // 0xD0
	[Tab("General")]
	[SerializeField]
	private bool m_MakeStatic; // 0xD8
	[SerializeField]
	[Layer("", "")]
	private int m_Layer; // 0xDC
	[Tooltip("Whether Layer should be applied only on the root of a created game object, or it should be applied on its whole hierarchy")]
	[SerializeField]
	private bool applyLayerOnChildren; // 0xE0
	private readonly Dictionary<Transform, string> usedPoolsDictionary; // 0xE8

	// Properties
	public int Layer { get; set; }
	public bool ApplyLayerOnChildren { get; set; }
	public bool MakeStatic { get; set; }
	public CGGameObjectResourceCollection GameObjects { get; }
	public int GameObjectCount { get; }

	// Methods

	// RVA: 0x510B10 Offset: 0x50F510 VA: 0x180510B10
	public int get_Layer() { }

	// RVA: 0x51FD00 Offset: 0x51E700 VA: 0x18051FD00
	public void set_Layer(int value) { }

	// RVA: 0x510890 Offset: 0x50F290 VA: 0x180510890
	public bool get_ApplyLayerOnChildren() { }

	// RVA: 0x510C40 Offset: 0x50F640 VA: 0x180510C40
	public void set_ApplyLayerOnChildren(bool value) { }

	// RVA: 0x4B5E70 Offset: 0x4B4870 VA: 0x1804B5E70
	public bool get_MakeStatic() { }

	// RVA: 0x5189F0 Offset: 0x5173F0 VA: 0x1805189F0
	public void set_MakeStatic(bool value) { }

	// RVA: 0x4B6180 Offset: 0x4B4B80 VA: 0x1804B6180
	public CGGameObjectResourceCollection get_GameObjects() { }

	// RVA: 0x51FCD0 Offset: 0x51E6D0 VA: 0x18051FCD0
	public int get_GameObjectCount() { }

	// RVA: 0x51FAB0 Offset: 0x51E4B0 VA: 0x18051FAB0 Slot: 13
	public override void Reset() { }

	// RVA: 0x51EDE0 Offset: 0x51D7E0 VA: 0x18051EDE0 Slot: 12
	protected override void OnDestroy() { }

	// RVA: 0x51EB00 Offset: 0x51D500 VA: 0x18051EB00 Slot: 15
	public override bool DeleteAllOutputManagedResources() { }

	[UsedImplicitly]
	[Obsolete("Use DeleteAllOutputManagedResources instead")]
	// RVA: 0x4DD630 Offset: 0x4DC030 VA: 0x1804DD630
	public void Clear() { }

	// RVA: 0x51EE20 Offset: 0x51D820 VA: 0x18051EE20 Slot: 14
	public override void Refresh() { }

	// RVA: 0x51FB30 Offset: 0x51E530 VA: 0x18051FB30 Slot: 18
	protected override GameObject SaveResourceToScene(Component managedResource, Transform newParent) { }

	// RVA: 0x51FA50 Offset: 0x51E450 VA: 0x18051FA50 Slot: 5
	protected override void ResetOnEnable() { }

	// RVA: 0x51FBA0 Offset: 0x51E5A0 VA: 0x18051FBA0
	public void .ctor() { }
}
