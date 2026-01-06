public class WeakReference : ISerializable // TypeDefIndex: 3896
{
	// Fields
	private bool isLongReference; // 0x10
	private GCHandle gcHandle; // 0x18

	// Properties
	public virtual bool IsAlive { get; }
	public virtual object Target { get; set; }
	public virtual bool TrackResurrection { get; }

	// Methods

	// RVA: 0x1CEAA10 Offset: 0x1CE9410 VA: 0x181CEAA10
	private void AllocateHandle(object target) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x1CEABC0 Offset: 0x1CE95C0 VA: 0x181CEABC0
	public void .ctor(object target) { }

	// RVA: 0x1CEAC00 Offset: 0x1CE9600 VA: 0x181CEAC00
	public void .ctor(object target, bool trackResurrection) { }

	// RVA: 0x1CEAC50 Offset: 0x1CE9650 VA: 0x181CEAC50
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1CEAD80 Offset: 0x1CE9780 VA: 0x181CEAD80 Slot: 5
	public virtual bool get_IsAlive() { }

	// RVA: 0x1CEADB0 Offset: 0x1CE97B0 VA: 0x181CEADB0 Slot: 6
	public virtual object get_Target() { }

	// RVA: 0x1CEADE0 Offset: 0x1CE97E0 VA: 0x181CEADE0 Slot: 7
	public virtual void set_Target(object value) { }

	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40 Slot: 8
	public virtual bool get_TrackResurrection() { }

	// RVA: 0x1CEAA40 Offset: 0x1CE9440 VA: 0x181CEAA40 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1CEAAA0 Offset: 0x1CE94A0 VA: 0x181CEAAA0 Slot: 9
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }
}
