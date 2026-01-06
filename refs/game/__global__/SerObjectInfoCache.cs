internal sealed class SerObjectInfoCache // TypeDefIndex: 4498
{
	// Fields
	internal string fullTypeName; // 0x10
	internal string assemblyString; // 0x18
	internal bool hasTypeForwardedFrom; // 0x20
	internal MemberInfo[] memberInfos; // 0x28
	internal string[] memberNames; // 0x30
	internal Type[] memberTypes; // 0x38

	// Methods

	// RVA: 0x9596A0 Offset: 0x9580A0 VA: 0x1809596A0
	internal void .ctor(string typeName, string assemblyName, bool hasTypeForwardedFrom) { }

	// RVA: 0x1B560C0 Offset: 0x1B54AC0 VA: 0x181B560C0
	internal void .ctor(Type type) { }
}
