public class ToolboxItemAttribute : Attribute // TypeDefIndex: 9709
{
	// Fields
	private string _toolboxItemTypeName; // 0x10
	public static readonly ToolboxItemAttribute Default; // 0x0
	public static readonly ToolboxItemAttribute None; // 0x8

	// Properties
	public string ToolboxItemTypeName { get; }

	// Methods

	// RVA: 0x2678120 Offset: 0x2676B20 VA: 0x182678120 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x2678370 Offset: 0x2676D70 VA: 0x182678370
	public void .ctor(bool defaultType) { }

	// RVA: 0x26782E0 Offset: 0x2676CE0 VA: 0x1826782E0
	public void .ctor(string toolboxItemTypeName) { }

	// RVA: 0x26783E0 Offset: 0x2676DE0 VA: 0x1826783E0
	public string get_ToolboxItemTypeName() { }

	// RVA: 0x2677FD0 Offset: 0x26769D0 VA: 0x182677FD0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x26780E0 Offset: 0x2676AE0 VA: 0x1826780E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2678190 Offset: 0x2676B90 VA: 0x182678190
	private static void .cctor() { }
}
