public abstract class EventBase<T> : EventBase // TypeDefIndex: 6523
{
	// Fields
	private static readonly long s_TypeId; // 0x0
	private static readonly ObjectPool<T> s_Pool; // 0x0
	private int m_RefCount; // 0x0
	internal static readonly EventCategory EventCategory; // 0x0

	// Properties
	public override long eventTypeId { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal static void SetCreateFunction(Func<T> createMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AC2B0 Offset: 0x17AACB0 VA: 0x1817AC2B0
	|-EventBase<object>.SetCreateFunction
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AC750 Offset: 0x17AB150 VA: 0x1817AC750
	|-EventBase<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public static long TypeId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AC370 Offset: 0x17AAD70 VA: 0x1817AC370
	|-EventBase<object>.TypeId
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override void Init() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AC100 Offset: 0x17AAB00 VA: 0x1817AC100
	|-EventBase<object>.Init
	*/

	// RVA: -1 Offset: -1
	public static T GetPooled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ABE50 Offset: 0x17AA850 VA: 0x1817ABE50
	|-EventBase<object>.GetPooled
	*/

	// RVA: -1 Offset: -1
	internal static T GetPooled(EventBase e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ABF60 Offset: 0x17AA960 VA: 0x1817ABF60
	|-EventBase<object>.GetPooled
	*/

	// RVA: -1 Offset: -1
	private static void ReleasePooled(T evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AC190 Offset: 0x17AAB90 VA: 0x1817AC190
	|-EventBase<object>.ReleasePooled
	*/

	// RVA: -1 Offset: -1 Slot: 13
	internal override void Acquire() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ABC90 Offset: 0x17AA690 VA: 0x1817ABC90
	|-EventBase<object>.Acquire
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public sealed override void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17ABCA0 Offset: 0x17AA6A0 VA: 0x1817ABCA0
	|-EventBase<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override long get_eventTypeId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AC7E0 Offset: 0x17AB1E0 VA: 0x1817AC7E0
	|-EventBase<object>.get_eventTypeId
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17AC410 Offset: 0x17AAE10 VA: 0x1817AC410
	|-EventBase<object>..cctor
	*/
}
