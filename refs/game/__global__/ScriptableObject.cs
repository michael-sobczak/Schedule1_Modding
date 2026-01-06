public class ScriptableObject : Object // TypeDefIndex: 11839
{
	// Methods

	// RVA: 0x2CC6CD0 Offset: 0x2CC56D0 VA: 0x182CC6CD0
	public void .ctor() { }

	// RVA: 0x2CC6BC0 Offset: 0x2CC55C0 VA: 0x182CC6BC0
	public static ScriptableObject CreateInstance(string className) { }

	// RVA: 0x2CC6C00 Offset: 0x2CC5600 VA: 0x182CC6C00
	public static ScriptableObject CreateInstance(Type type) { }

	// RVA: -1 Offset: -1
	public static T CreateInstance<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF49F60 Offset: 0xF48960 VA: 0x180F49F60
	|-ScriptableObject.CreateInstance<object>
	*/

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x2CC6C90 Offset: 0x2CC5690 VA: 0x182CC6C90
	private static void CreateScriptableObject(ScriptableObject self) { }

	[FreeFunction("Scripting::CreateScriptableObject")]
	// RVA: 0x2CC6BC0 Offset: 0x2CC55C0 VA: 0x182CC6BC0
	private static ScriptableObject CreateScriptableObjectInstanceFromName(string className) { }

	[NativeMethod(Name = "Scripting::CreateScriptableObjectWithType", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x2CC6C40 Offset: 0x2CC5640 VA: 0x182CC6C40
	internal static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset) { }
}
