public abstract class UnityObjectPool<T> : DTVersionedMonoBehaviour, IPool // TypeDefIndex: 10462
{
	// Fields
	[NotNull]
	private readonly List<T> pooledObjects; // 0x0
	[SerializeField]
	[NotNull]
	[Inline]
	private PoolSettings m_Settings; // 0x0
	private double lastProcessingTime; // 0x0
	private double unprocessedDuration; // 0x0

	// Properties
	public virtual PoolSettings Settings { get; set; }
	[Obsolete("Use GetComponent<PoolManager>() instead")]
	[UsedImplicitly]
	public PoolManager Manager { get; }
	public int Count { get; }
	public abstract string Identifier { get; set; }
	private static double Now { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 16
	public virtual PoolSettings get_Settings() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	|-UnityObjectPool<object>.get_Settings
	*/

	[Obsolete("The setter will be made private. Rather than assigning a new Settings instance, modify the existing one")]
	[UsedImplicitly]
	// RVA: -1 Offset: -1 Slot: 17
	public virtual void set_Settings(PoolSettings value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D63C0 Offset: 0x12D4DC0 VA: 0x1812D63C0
	|-UnityObjectPool<object>.set_Settings
	*/

	// RVA: -1 Offset: -1
	public PoolManager get_Manager() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D6370 Offset: 0x12D4D70 VA: 0x1812D6370
	|-UnityObjectPool<object>.get_Manager
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D6350 Offset: 0x12D4D50 VA: 0x1812D6350
	|-UnityObjectPool<object>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public abstract string get_Identifier();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-UnityObjectPool<object>.get_Identifier
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void set_Identifier(string value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-UnityObjectPool<object>.set_Identifier
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public virtual void Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D5AC0 Offset: 0x12D44C0 VA: 0x1812D5AC0
	|-UnityObjectPool<object>.Push
	*/

	[NotNull]
	// RVA: -1 Offset: -1 Slot: 21
	public virtual T Pop(Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D5910 Offset: 0x12D4310 VA: 0x1812D5910
	|-UnityObjectPool<object>.Pop
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public virtual void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D5130 Offset: 0x12D3B30 VA: 0x1812D5130
	|-UnityObjectPool<object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D60B0 Offset: 0x12D4AB0 VA: 0x1812D60B0
	|-UnityObjectPool<object>.Update
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D5D80 Offset: 0x12D4780 VA: 0x1812D5D80
	|-UnityObjectPool<object>.Reset
	*/

	[NotNull]
	// RVA: -1 Offset: -1 Slot: 23
	protected abstract T CreateObject();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-UnityObjectPool<object>.CreateObject
	*/

	[NotNull]
	// RVA: -1 Offset: -1 Slot: 24
	protected abstract GameObject GetItemGameObject(T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-UnityObjectPool<object>.GetItemGameObject
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected override void OnValidate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D58C0 Offset: 0x12D42C0 VA: 0x1812D58C0
	|-UnityObjectPool<object>.OnValidate
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected override void ResetOnEnable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D5D10 Offset: 0x12D4710 VA: 0x1812D5D10
	|-UnityObjectPool<object>.ResetOnEnable
	*/

	// RVA: -1 Offset: -1
	protected void Initialize(PoolSettings settings) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D5610 Offset: 0x12D4010 VA: 0x1812D5610
	|-UnityObjectPool<object>.Initialize
	*/

	// RVA: -1 Offset: -1
	protected void ConfigureCreatedGameObject(GameObject item, string itemName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D52B0 Offset: 0x12D3CB0 VA: 0x1812D52B0
	|-UnityObjectPool<object>.ConfigureCreatedGameObject
	*/

	[UsedImplicitly]
	// RVA: -1 Offset: -1
	private void Start() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D6050 Offset: 0x12D4A50 VA: 0x1812D6050
	|-UnityObjectPool<object>.Start
	*/

	// RVA: -1 Offset: -1
	private void DestroyObject(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D54A0 Offset: 0x12D3EA0 VA: 0x1812D54A0
	|-UnityObjectPool<object>.DestroyObject
	*/

	[NotNull]
	// RVA: -1 Offset: -1
	private T RetrievedPoppedItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D5DF0 Offset: 0x12D47F0 VA: 0x1812D5DF0
	|-UnityObjectPool<object>.RetrievedPoppedItem
	*/

	// RVA: -1 Offset: -1
	private void ConfigurePushedGameObject(GameObject item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D53E0 Offset: 0x12D3DE0 VA: 0x1812D53E0
	|-UnityObjectPool<object>.ConfigurePushedGameObject
	*/

	// RVA: -1 Offset: -1
	private void ConfigurePoppedGameObject(GameObject item, Transform parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D5350 Offset: 0x12D3D50 VA: 0x1812D5350
	|-UnityObjectPool<object>.ConfigurePoppedGameObject
	*/

	// RVA: -1 Offset: -1
	private void LogMessage(string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D57D0 Offset: 0x12D41D0 VA: 0x1812D57D0
	|-UnityObjectPool<object>.LogMessage
	*/

	// RVA: -1 Offset: -1
	private void AdjustItemsCount(int minItemsCount, int maxItemsCount, int maxAdjustmentsCount, bool logOperations) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D4E90 Offset: 0x12D3890 VA: 0x1812D4E90
	|-UnityObjectPool<object>.AdjustItemsCount
	*/

	// RVA: -1 Offset: -1
	private void InstantShit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D56A0 Offset: 0x12D40A0 VA: 0x1812D56A0
	|-UnityObjectPool<object>.InstantShit
	*/

	// RVA: -1 Offset: -1
	private static double get_Now() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x50F380 Offset: 0x50DD80 VA: 0x18050F380
	|-UnityObjectPool<object>.get_Now
	*/

	[UsedImplicitly]
	// RVA: -1 Offset: -1
	private void ResetTimeRelatedFields() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D5D50 Offset: 0x12D4750 VA: 0x1812D5D50
	|-UnityObjectPool<object>.ResetTimeRelatedFields
	*/

	// RVA: -1 Offset: -1
	private int GetAdjustmentsCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D5530 Offset: 0x12D3F30 VA: 0x1812D5530
	|-UnityObjectPool<object>.GetAdjustmentsCount
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D6280 Offset: 0x12D4C80 VA: 0x1812D6280
	|-UnityObjectPool<object>..ctor
	*/
}
