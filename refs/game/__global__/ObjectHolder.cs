internal sealed class ObjectHolder // TypeDefIndex: 4435
{
	// Fields
	private object m_object; // 0x10
	internal long m_id; // 0x18
	private int m_missingElementsRemaining; // 0x20
	private int m_missingDecendents; // 0x24
	internal SerializationInfo m_serInfo; // 0x28
	internal ISerializationSurrogate m_surrogate; // 0x30
	internal FixupHolderList m_missingElements; // 0x38
	internal LongList m_dependentObjects; // 0x40
	internal ObjectHolder m_next; // 0x48
	internal int m_flags; // 0x50
	private bool m_markForFixupWhenAvailable; // 0x54
	private ValueTypeFixupInfo m_valueFixup; // 0x58
	private TypeLoadExceptionHolder m_typeLoad; // 0x60
	private bool m_reachable; // 0x68

	// Properties
	internal bool IsIncompleteObjectReference { get; set; }
	internal bool RequiresDelayedFixup { get; }
	internal bool RequiresValueTypeFixup { get; }
	internal bool ValueTypeFixupPerformed { get; set; }
	internal bool HasISerializable { get; }
	internal bool HasSurrogate { get; }
	internal bool CanSurrogatedObjectValueChange { get; }
	internal bool CanObjectValueChange { get; }
	internal int DirectlyDependentObjects { get; }
	internal int TotalDependentObjects { get; }
	internal bool Reachable { get; set; }
	internal bool TypeLoadExceptionReachable { get; }
	internal TypeLoadExceptionHolder TypeLoadException { get; set; }
	internal object ObjectValue { get; }
	internal SerializationInfo SerializationInfo { get; set; }
	internal ISerializationSurrogate Surrogate { get; }
	internal LongList DependentObjects { get; set; }
	internal bool RequiresSerInfoFixup { get; set; }
	internal ValueTypeFixupInfo ValueFixup { get; }
	internal bool CompletelyFixed { get; }
	internal long ContainerID { get; }

	// Methods

	// RVA: 0x1B39840 Offset: 0x1B38240 VA: 0x181B39840
	internal void .ctor(long objID) { }

	// RVA: 0x1B39900 Offset: 0x1B38300 VA: 0x181B39900
	internal void .ctor(object obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x1B39B90 Offset: 0x1B38590 VA: 0x181B39B90
	internal void .ctor(string obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x1B39400 Offset: 0x1B37E00 VA: 0x181B39400
	private void IncrementDescendentFixups(int amount) { }

	// RVA: 0x1B393A0 Offset: 0x1B37DA0 VA: 0x181B393A0
	internal void DecrementFixupsRemaining(ObjectManager manager) { }

	// RVA: 0x1B39410 Offset: 0x1B37E10 VA: 0x181B39410
	internal void RemoveDependency(long id) { }

	// RVA: 0x1B392B0 Offset: 0x1B37CB0 VA: 0x181B392B0
	internal void AddFixup(FixupHolder fixup, ObjectManager manager) { }

	// RVA: 0x1B397E0 Offset: 0x1B381E0 VA: 0x181B397E0
	private void UpdateDescendentDependencyChain(int amount, ObjectManager manager) { }

	// RVA: 0x1B39220 Offset: 0x1B37C20 VA: 0x181B39220
	internal void AddDependency(long dependentObject) { }

	// RVA: 0x1B395F0 Offset: 0x1B37FF0 VA: 0x181B395F0
	internal void UpdateData(object obj, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainer, FieldInfo field, int[] arrayIndex, ObjectManager manager) { }

	// RVA: 0xD9C190 Offset: 0xD9AB90 VA: 0x180D9C190
	internal void MarkForCompletionWhenAvailable() { }

	// RVA: 0x1B39430 Offset: 0x1B37E30 VA: 0x181B39430
	internal void SetFlags() { }

	// RVA: 0x1B39DD0 Offset: 0x1B387D0 VA: 0x181B39DD0
	internal bool get_IsIncompleteObjectReference() { }

	// RVA: 0x1B39E50 Offset: 0x1B38850 VA: 0x181B39E50
	internal void set_IsIncompleteObjectReference(bool value) { }

	// RVA: 0x1B39DE0 Offset: 0x1B387E0 VA: 0x181B39DE0
	internal bool get_RequiresDelayedFixup() { }

	// RVA: 0x1B39E10 Offset: 0x1B38810 VA: 0x181B39E10
	internal bool get_RequiresValueTypeFixup() { }

	// RVA: 0x1B39E20 Offset: 0x1B38820 VA: 0x181B39E20
	internal bool get_ValueTypeFixupPerformed() { }

	// RVA: 0x1B39E90 Offset: 0x1B38890 VA: 0x181B39E90
	internal void set_ValueTypeFixupPerformed(bool value) { }

	// RVA: 0x1B39DB0 Offset: 0x1B387B0 VA: 0x181B39DB0
	internal bool get_HasISerializable() { }

	// RVA: 0x1B39DC0 Offset: 0x1B387C0 VA: 0x181B39DC0
	internal bool get_HasSurrogate() { }

	// RVA: 0x1B39CD0 Offset: 0x1B386D0 VA: 0x181B39CD0
	internal bool get_CanSurrogatedObjectValueChange() { }

	// RVA: 0x1B39CB0 Offset: 0x1B386B0 VA: 0x181B39CB0
	internal bool get_CanObjectValueChange() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	internal int get_DirectlyDependentObjects() { }

	// RVA: 0x1AC10E0 Offset: 0x1ABFAE0 VA: 0x181AC10E0
	internal int get_TotalDependentObjects() { }

	// RVA: 0xCE3DC0 Offset: 0xCE27C0 VA: 0x180CE3DC0
	internal bool get_Reachable() { }

	// RVA: 0xCE3E20 Offset: 0xCE2820 VA: 0x180CE3E20
	internal void set_Reachable(bool value) { }

	// RVA: 0xC0DCA0 Offset: 0xC0C6A0 VA: 0x180C0DCA0
	internal bool get_TypeLoadExceptionReachable() { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	internal TypeLoadExceptionHolder get_TypeLoadException() { }

	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	internal void set_TypeLoadException(TypeLoadExceptionHolder value) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal object get_ObjectValue() { }

	// RVA: 0x1B394C0 Offset: 0x1B37EC0 VA: 0x181B394C0
	internal void SetObjectValue(object obj, ObjectManager manager) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	internal SerializationInfo get_SerializationInfo() { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	internal void set_SerializationInfo(SerializationInfo value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	internal ISerializationSurrogate get_Surrogate() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	internal LongList get_DependentObjects() { }

	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	internal void set_DependentObjects(LongList value) { }

	// RVA: 0x1B39DF0 Offset: 0x1B387F0 VA: 0x181B39DF0
	internal bool get_RequiresSerInfoFixup() { }

	// RVA: 0x1B39E70 Offset: 0x1B38870 VA: 0x181B39E70
	internal void set_RequiresSerInfoFixup(bool value) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	internal ValueTypeFixupInfo get_ValueFixup() { }

	// RVA: 0x1B39D70 Offset: 0x1B38770 VA: 0x181B39D70
	internal bool get_CompletelyFixed() { }

	// RVA: 0x1B39D90 Offset: 0x1B38790 VA: 0x181B39D90
	internal long get_ContainerID() { }
}
