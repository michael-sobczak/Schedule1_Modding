public sealed class VolumeProfile : ScriptableObject // TypeDefIndex: 13938
{
	// Fields
	public List<VolumeComponent> components; // 0x18
	public bool isDirty; // 0x20

	// Methods

	// RVA: 0x2A5DB80 Offset: 0x2A5C580 VA: 0x182A5DB80
	private void OnEnable() { }

	// RVA: 0x2A5DA90 Offset: 0x2A5C490 VA: 0x182A5DA90
	internal void OnDisable() { }

	// RVA: 0x77D420 Offset: 0x77BE20 VA: 0x18077D420
	public void Reset() { }

	// RVA: -1 Offset: -1
	public T Add<T>(bool overrides = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF76EE0 Offset: 0xF758E0 VA: 0x180F76EE0
	|-VolumeProfile.Add<object>
	*/

	// RVA: 0x2A5D4E0 Offset: 0x2A5BEE0 VA: 0x182A5D4E0
	public VolumeComponent Add(Type type, bool overrides = False) { }

	// RVA: -1 Offset: -1
	public void Remove<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF77020 Offset: 0xF75A20 VA: 0x180F77020
	|-VolumeProfile.Remove<object>
	*/

	// RVA: 0x2A5DCA0 Offset: 0x2A5C6A0 VA: 0x182A5DCA0
	public void Remove(Type type) { }

	// RVA: -1 Offset: -1
	public bool Has<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF76FB0 Offset: 0xF759B0 VA: 0x180F76FB0
	|-VolumeProfile.Has<object>
	*/

	// RVA: 0x2A5D910 Offset: 0x2A5C310 VA: 0x182A5D910
	public bool Has(Type type) { }

	// RVA: 0x2A5D7B0 Offset: 0x2A5C1B0 VA: 0x182A5D7B0
	public bool HasSubclassOf(Type type) { }

	// RVA: -1 Offset: -1
	public bool TryGet<T>(out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF77490 Offset: 0xF75E90 VA: 0x180F77490
	|-VolumeProfile.TryGet<object>
	*/

	// RVA: -1 Offset: -1
	public bool TryGet<T>(Type type, out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF77520 Offset: 0xF75F20 VA: 0x180F77520
	|-VolumeProfile.TryGet<object>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetSubclassOf<T>(Type type, out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF77280 Offset: 0xF75C80 VA: 0x180F77280
	|-VolumeProfile.TryGetSubclassOf<object>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetAllSubclassOf<T>(Type type, List<T> result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF77090 Offset: 0xF75A90 VA: 0x180F77090
	|-VolumeProfile.TryGetAllSubclassOf<object>
	*/

	// RVA: 0x2A5D6F0 Offset: 0x2A5C0F0 VA: 0x182A5D6F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2A5D620 Offset: 0x2A5C020 VA: 0x182A5D620
	internal int GetComponentListHashCode() { }

	// RVA: 0x2A5DDC0 Offset: 0x2A5C7C0 VA: 0x182A5DDC0
	internal void Sanitize() { }

	// RVA: 0x2A5DEA0 Offset: 0x2A5C8A0 VA: 0x182A5DEA0
	public void .ctor() { }
}
