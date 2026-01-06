public static class InputActionSetupExtensions // TypeDefIndex: 7299
{
	// Methods

	[Extension]
	// RVA: 0x2767E60 Offset: 0x2766860 VA: 0x182767E60
	public static InputActionMap AddActionMap(InputActionAsset asset, string name) { }

	[Extension]
	// RVA: 0x2767B60 Offset: 0x2766560 VA: 0x182767B60
	public static void AddActionMap(InputActionAsset asset, InputActionMap map) { }

	[Extension]
	// RVA: 0x276A610 Offset: 0x2769010 VA: 0x18276A610
	public static void RemoveActionMap(InputActionAsset asset, InputActionMap map) { }

	[Extension]
	// RVA: 0x276A7A0 Offset: 0x27691A0 VA: 0x18276A7A0
	public static void RemoveActionMap(InputActionAsset asset, string nameOrId) { }

	[Extension]
	// RVA: 0x2768060 Offset: 0x2766A60 VA: 0x182768060
	public static InputAction AddAction(InputActionMap map, string name, InputActionType type = 0, string binding, string interactions, string processors, string groups, string expectedControlLayout) { }

	[Extension]
	// RVA: 0x276A9E0 Offset: 0x27693E0 VA: 0x18276A9E0
	public static void RemoveAction(InputAction action) { }

	[Extension]
	// RVA: 0x276ADF0 Offset: 0x27697F0 VA: 0x18276ADF0
	public static void RemoveAction(InputActionAsset asset, string nameOrId) { }

	[Extension]
	// RVA: 0x2768620 Offset: 0x2767020 VA: 0x182768620
	public static InputActionSetupExtensions.BindingSyntax AddBinding(InputAction action, string path, string interactions, string processors, string groups) { }

	[Extension]
	// RVA: 0x2768BA0 Offset: 0x27675A0 VA: 0x182768BA0
	public static InputActionSetupExtensions.BindingSyntax AddBinding(InputAction action, InputControl control) { }

	[Extension]
	// RVA: 0x2768900 Offset: 0x2767300 VA: 0x182768900
	public static InputActionSetupExtensions.BindingSyntax AddBinding(InputAction action, InputBinding binding) { }

	[Extension]
	// RVA: 0x2768C50 Offset: 0x2767650 VA: 0x182768C50
	public static InputActionSetupExtensions.BindingSyntax AddBinding(InputActionMap actionMap, string path, string interactions, string groups, string action, string processors) { }

	[Extension]
	// RVA: 0x2768EB0 Offset: 0x27678B0 VA: 0x182768EB0
	public static InputActionSetupExtensions.BindingSyntax AddBinding(InputActionMap actionMap, string path, InputAction action, string interactions, string groups) { }

	[Extension]
	// RVA: 0x2768810 Offset: 0x2767210 VA: 0x182768810
	public static InputActionSetupExtensions.BindingSyntax AddBinding(InputActionMap actionMap, string path, Guid action, string interactions, string groups) { }

	[Extension]
	// RVA: 0x2768A30 Offset: 0x2767430 VA: 0x182768A30
	public static InputActionSetupExtensions.BindingSyntax AddBinding(InputActionMap actionMap, InputBinding binding) { }

	[Extension]
	// RVA: 0x2769060 Offset: 0x2767A60 VA: 0x182769060
	public static InputActionSetupExtensions.CompositeSyntax AddCompositeBinding(InputAction action, string composite, string interactions, string processors) { }

	// RVA: 0x2768460 Offset: 0x2766E60 VA: 0x182768460
	private static int AddBindingInternal(InputActionMap map, InputBinding binding, int bindingIndex = -1) { }

	[Extension]
	// RVA: 0x276A010 Offset: 0x2768A10 VA: 0x18276A010
	public static InputActionSetupExtensions.BindingSyntax ChangeBinding(InputAction action, int index) { }

	[Extension]
	// RVA: 0x2769D40 Offset: 0x2768740 VA: 0x182769D40
	public static InputActionSetupExtensions.BindingSyntax ChangeBinding(InputAction action, string name) { }

	[Extension]
	// RVA: 0x2769C00 Offset: 0x2768600 VA: 0x182769C00
	public static InputActionSetupExtensions.BindingSyntax ChangeBinding(InputActionMap actionMap, int index) { }

	[Extension]
	// RVA: 0x2769880 Offset: 0x2768280 VA: 0x182769880
	public static InputActionSetupExtensions.BindingSyntax ChangeBindingWithId(InputAction action, string id) { }

	[Extension]
	// RVA: 0x27699B0 Offset: 0x27683B0 VA: 0x1827699B0
	public static InputActionSetupExtensions.BindingSyntax ChangeBindingWithId(InputAction action, Guid id) { }

	[Extension]
	// RVA: 0x2769750 Offset: 0x2768150 VA: 0x182769750
	public static InputActionSetupExtensions.BindingSyntax ChangeBindingWithGroup(InputAction action, string group) { }

	[Extension]
	// RVA: 0x2769AD0 Offset: 0x27684D0 VA: 0x182769AD0
	public static InputActionSetupExtensions.BindingSyntax ChangeBindingWithPath(InputAction action, string path) { }

	[Extension]
	// RVA: 0x2769E10 Offset: 0x2768810 VA: 0x182769E10
	public static InputActionSetupExtensions.BindingSyntax ChangeBinding(InputAction action, InputBinding match) { }

	[Extension]
	// RVA: 0x276A0D0 Offset: 0x2768AD0 VA: 0x18276A0D0
	public static InputActionSetupExtensions.BindingSyntax ChangeCompositeBinding(InputAction action, string compositeName) { }

	[Extension]
	// RVA: 0x276B060 Offset: 0x2769A60 VA: 0x18276B060
	public static void Rename(InputAction action, string newName) { }

	[Extension]
	// RVA: 0x2769270 Offset: 0x2767C70 VA: 0x182769270
	public static void AddControlScheme(InputActionAsset asset, InputControlScheme controlScheme) { }

	[Extension]
	// RVA: 0x2769560 Offset: 0x2767F60 VA: 0x182769560
	public static InputActionSetupExtensions.ControlSchemeSyntax AddControlScheme(InputActionAsset asset, string name) { }

	[Extension]
	// RVA: 0x276AF10 Offset: 0x2769910 VA: 0x18276AF10
	public static void RemoveControlScheme(InputActionAsset asset, string name) { }

	[Extension]
	// RVA: 0x276B350 Offset: 0x2769D50 VA: 0x18276B350
	public static InputControlScheme WithBindingGroup(InputControlScheme scheme, string bindingGroup) { }

	[Extension]
	// RVA: 0x276B4B0 Offset: 0x2769EB0 VA: 0x18276B4B0
	public static InputControlScheme WithDevice(InputControlScheme scheme, string controlPath, bool required) { }

	[Extension]
	// RVA: 0x276B820 Offset: 0x276A220 VA: 0x18276B820
	public static InputControlScheme WithRequiredDevice(InputControlScheme scheme, string controlPath) { }

	[Extension]
	// RVA: 0x276B6D0 Offset: 0x276A0D0 VA: 0x18276B6D0
	public static InputControlScheme WithOptionalDevice(InputControlScheme scheme, string controlPath) { }

	[Extension]
	// RVA: 0x276A4C0 Offset: 0x2768EC0 VA: 0x18276A4C0
	public static InputControlScheme OrWithRequiredDevice(InputControlScheme scheme, string controlPath) { }

	[Extension]
	// RVA: 0x276A370 Offset: 0x2768D70 VA: 0x18276A370
	public static InputControlScheme OrWithOptionalDevice(InputControlScheme scheme, string controlPath) { }
}
