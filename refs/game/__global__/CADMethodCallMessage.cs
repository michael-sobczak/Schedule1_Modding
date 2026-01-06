internal class CADMethodCallMessage : CADMessageBase // TypeDefIndex: 4373
{
	// Fields
	private string _uri; // 0x38

	// Properties
	internal string Uri { get; }
	internal int PropertiesCount { get; }

	// Methods

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	internal string get_Uri() { }

	// RVA: 0x1B26F80 Offset: 0x1B25980 VA: 0x181B26F80
	internal static CADMethodCallMessage Create(IMessage callMsg) { }

	// RVA: 0x1B271E0 Offset: 0x1B25BE0 VA: 0x181B271E0
	internal void .ctor(IMethodCallMessage callMsg) { }

	// RVA: 0x1B27020 Offset: 0x1B25A20 VA: 0x181B27020
	internal ArrayList GetArguments() { }

	// RVA: 0x1B27010 Offset: 0x1B25A10 VA: 0x181B27010
	internal object[] GetArgs(ArrayList args) { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	internal int get_PropertiesCount() { }
}
