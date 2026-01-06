public sealed class WeakReference<T> : ISerializable // TypeDefIndex: 3897
{
	// Fields
	private GCHandle handle; // 0x0
	private bool trackResurrection; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13C69D0 Offset: 0x13C53D0 VA: 0x1813C69D0
	|-WeakReference<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T target, bool trackResurrection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13C6A10 Offset: 0x13C5410 VA: 0x1813C6A10
	|-WeakReference<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13C68A0 Offset: 0x13C52A0 VA: 0x1813C68A0
	|-WeakReference<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13C6690 Offset: 0x13C5090 VA: 0x1813C6690
	|-WeakReference<object>.GetObjectData
	*/

	// RVA: -1 Offset: -1
	public void SetTarget(T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13C6770 Offset: 0x13C5170 VA: 0x1813C6770
	|-WeakReference<object>.SetTarget
	*/

	// RVA: -1 Offset: -1
	public bool TryGetTarget(out T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13C6780 Offset: 0x13C5180 VA: 0x1813C6780
	|-WeakReference<object>.TryGetTarget
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13C6610 Offset: 0x13C5010 VA: 0x1813C6610
	|-WeakReference<object>.Finalize
	*/
}
