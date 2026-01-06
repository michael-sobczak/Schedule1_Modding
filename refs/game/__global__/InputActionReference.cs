public class InputActionReference : ScriptableObject // TypeDefIndex: 7294
{
	// Fields
	[SerializeField]
	internal InputActionAsset m_Asset; // 0x18
	[SerializeField]
	internal string m_ActionId; // 0x20
	private InputAction m_Action; // 0x28

	// Properties
	public InputActionAsset asset { get; }
	public InputAction action { get; }

	// Methods

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public InputActionAsset get_asset() { }

	// RVA: 0x2767A80 Offset: 0x2766480 VA: 0x182767A80
	public InputAction get_action() { }

	// RVA: 0x27673B0 Offset: 0x2765DB0 VA: 0x1827673B0
	public void Set(InputAction action) { }

	// RVA: 0x27674D0 Offset: 0x2765ED0 VA: 0x1827674D0
	public void Set(InputActionAsset asset, string mapName, string actionName) { }

	// RVA: 0x27671B0 Offset: 0x2765BB0 VA: 0x1827671B0
	private void SetInternal(InputActionAsset asset, InputAction action) { }

	// RVA: 0x2767870 Offset: 0x2766270 VA: 0x182767870 Slot: 3
	public override string ToString() { }

	// RVA: 0x2766FA0 Offset: 0x27659A0 VA: 0x182766FA0
	internal static string GetDisplayName(InputAction action) { }

	// RVA: 0x2767780 Offset: 0x2766180 VA: 0x182767780
	internal string ToDisplayName() { }

	// RVA: 0x2767B50 Offset: 0x2766550 VA: 0x182767B50
	public static InputAction op_Implicit(InputActionReference reference) { }

	// RVA: 0x2766E60 Offset: 0x2765860 VA: 0x182766E60
	public static InputActionReference Create(InputAction action) { }

	// RVA: 0x2767060 Offset: 0x2765A60 VA: 0x182767060
	internal static void ResetCachedAction() { }

	// RVA: 0x2767860 Offset: 0x2766260 VA: 0x182767860
	public InputAction ToInputAction() { }

	// RVA: 0x6CAB30 Offset: 0x6C9530 VA: 0x1806CAB30
	public void .ctor() { }
}
