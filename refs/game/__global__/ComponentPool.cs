public class ComponentPool : UnityObjectPool<Component>, ISerializationCallbackReceiver // TypeDefIndex: 10453
{
	// Fields
	[SerializeField]
	[HideInInspector]
	private string m_Identifier; // 0x50

	// Properties
	public override string Identifier { get; set; }
	public Type Type { get; }

	// Methods

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0 Slot: 18
	public override string get_Identifier() { }

	// RVA: 0x48B7E0 Offset: 0x48A1E0 VA: 0x18048B7E0 Slot: 19
	public override void set_Identifier(string value) { }

	// RVA: 0x48B6C0 Offset: 0x48A0C0 VA: 0x18048B6C0
	public Type get_Type() { }

	// RVA: 0x48B390 Offset: 0x489D90 VA: 0x18048B390
	public void Initialize(Type type, PoolSettings settings) { }

	// RVA: 0x48B130 Offset: 0x489B30 VA: 0x18048B130 Slot: 23
	protected override Component CreateObject() { }

	// RVA: 0x48B370 Offset: 0x489D70 VA: 0x18048B370 Slot: 24
	protected override GameObject GetItemGameObject(Component item) { }

	[UsedImplicitly]
	[Obsolete]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void OnSceneLoaded(Scene scn, LoadSceneMode mode) { }

	[UsedImplicitly]
	[Obsolete("Use other Pop method instead")]
	// RVA: -1 Offset: -1
	public T Pop<T>(Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE67880 Offset: 0xE66280 VA: 0x180E67880
	|-ComponentPool.Pop<object>
	*/

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 25
	public void OnBeforeSerialize() { }

	// RVA: 0x48B460 Offset: 0x489E60 VA: 0x18048B460 Slot: 26
	public void OnAfterDeserialize() { }

	// RVA: 0x48B680 Offset: 0x48A080 VA: 0x18048B680
	public void .ctor() { }
}
