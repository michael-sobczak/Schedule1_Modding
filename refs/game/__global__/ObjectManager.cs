public class ObjectManager // TypeDefIndex: 4434
{
	// Fields
	private DeserializationEventHandler m_onDeserializationHandler; // 0x10
	private SerializationEventHandler m_onDeserializedHandler; // 0x18
	internal ObjectHolder[] m_objects; // 0x20
	internal object m_topObject; // 0x28
	internal ObjectHolderList m_specialFixupObjects; // 0x30
	internal long m_fixupCount; // 0x38
	internal ISurrogateSelector m_selector; // 0x40
	internal StreamingContext m_context; // 0x48

	// Properties
	internal object TopObject { get; set; }
	internal ObjectHolderList SpecialFixupObjects { get; }

	// Methods

	// RVA: 0x1B3E910 Offset: 0x1B3D310 VA: 0x181B3E910
	internal void .ctor(ISurrogateSelector selector, StreamingContext context, bool checkSecurity, bool isCrossAppDomain) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	private bool CanCallGetType(object obj) { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	internal void set_TopObject(object value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	internal object get_TopObject() { }

	// RVA: 0x1B3E9A0 Offset: 0x1B3D3A0 VA: 0x181B3E9A0
	internal ObjectHolderList get_SpecialFixupObjects() { }

	// RVA: 0x1B3C8D0 Offset: 0x1B3B2D0 VA: 0x181B3C8D0
	internal ObjectHolder FindObjectHolder(long objectID) { }

	// RVA: 0x1B3C920 Offset: 0x1B3B320 VA: 0x181B3C920
	internal ObjectHolder FindOrCreateObjectHolder(long objectID) { }

	// RVA: 0x1B3A670 Offset: 0x1B39070 VA: 0x181B3A670
	private void AddObjectHolder(ObjectHolder holder) { }

	// RVA: 0x1B3CE20 Offset: 0x1B3B820 VA: 0x181B3CE20
	private bool GetCompletionInfo(FixupHolder fixup, out ObjectHolder holder, out object member, bool bThrowIfMissing) { }

	// RVA: 0x1B3CA70 Offset: 0x1B3B470 VA: 0x181B3CA70
	private void FixupSpecialObject(ObjectHolder holder) { }

	// RVA: 0x1B3E6D0 Offset: 0x1B3D0D0 VA: 0x181B3E6D0
	private bool ResolveObjectReference(ObjectHolder holder) { }

	// RVA: 0x1B3C270 Offset: 0x1B3AC70 VA: 0x181B3C270
	private bool DoValueTypeFixup(FieldInfo memberToFix, ObjectHolder holder, object value) { }

	// RVA: 0x1B3AC60 Offset: 0x1B39660 VA: 0x181B3AC60
	internal void CompleteObject(ObjectHolder holder, bool bObjectFullyComplete) { }

	// RVA: 0x1B3C120 Offset: 0x1B3AB20 VA: 0x181B3C120
	private void DoNewlyRegisteredObjectFixups(ObjectHolder holder) { }

	// RVA: 0x1B3D330 Offset: 0x1B3BD30 VA: 0x181B3D330 Slot: 4
	public virtual object GetObject(long objectID) { }

	// RVA: 0x1B3E5D0 Offset: 0x1B3CFD0 VA: 0x181B3E5D0
	internal void RegisterString(string obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member) { }

	// RVA: 0x1B3DDC0 Offset: 0x1B3C7C0 VA: 0x181B3DDC0
	public void RegisterObject(object obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member, int[] arrayIndex) { }

	// RVA: 0x1B3A8F0 Offset: 0x1B392F0 VA: 0x181B3A8F0
	internal void CompleteISerializableObject(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B3D200 Offset: 0x1B3BC00 VA: 0x181B3D200
	internal static RuntimeConstructorInfo GetConstructor(RuntimeType t) { }

	// RVA: 0x1B3BCE0 Offset: 0x1B3A6E0 VA: 0x181B3BCE0 Slot: 5
	public virtual void DoFixups() { }

	// RVA: 0x1B3DBB0 Offset: 0x1B3C5B0 VA: 0x181B3DBB0
	private void RegisterFixup(FixupHolder fixup, long objectToBeFixed, long objectRequired) { }

	// RVA: 0x1B3D900 Offset: 0x1B3C300 VA: 0x181B3D900 Slot: 6
	public virtual void RecordFixup(long objectToBeFixed, MemberInfo member, long objectRequired) { }

	// RVA: 0x1B3D780 Offset: 0x1B3C180 VA: 0x181B3D780 Slot: 7
	public virtual void RecordDelayedFixup(long objectToBeFixed, string memberName, long objectRequired) { }

	// RVA: 0x1B3D600 Offset: 0x1B3C000 VA: 0x181B3D600 Slot: 8
	public virtual void RecordArrayElementFixup(long arrayToBeFixed, int[] indices, long objectRequired) { }

	// RVA: 0x1B3D420 Offset: 0x1B3BE20 VA: 0x181B3D420 Slot: 9
	public virtual void RaiseDeserializationEvent() { }

	// RVA: 0x1B3A7B0 Offset: 0x1B391B0 VA: 0x181B3A7B0 Slot: 10
	internal virtual void AddOnDeserialization(DeserializationEventHandler handler) { }

	// RVA: 0x1B3A850 Offset: 0x1B39250 VA: 0x181B3A850 Slot: 11
	internal virtual void AddOnDeserialized(object obj) { }

	// RVA: 0x1B3D480 Offset: 0x1B3BE80 VA: 0x181B3D480 Slot: 12
	internal virtual void RaiseOnDeserializedEvent(object obj) { }

	// RVA: 0x1B3D540 Offset: 0x1B3BF40 VA: 0x181B3D540
	public void RaiseOnDeserializingEvent(object obj) { }
}
