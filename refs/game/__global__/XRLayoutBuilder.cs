internal class XRLayoutBuilder // TypeDefIndex: 7467
{
	// Fields
	private string parentLayout; // 0x10
	private string interfaceName; // 0x18
	private XRDeviceDescriptor descriptor; // 0x20
	private static readonly string[] poseSubControlNames; // 0x0
	private static readonly FeatureType[] poseSubControlTypes; // 0x8

	// Methods

	// RVA: 0x283C7A0 Offset: 0x283B1A0 VA: 0x18283C7A0
	private static uint GetSizeOfFeature(XRFeatureDescriptor featureDescriptor) { }

	// RVA: 0x283CDE0 Offset: 0x283B7E0 VA: 0x18283CDE0
	private static string SanitizeString(string original, bool allowPaths = False) { }

	// RVA: 0x283CA00 Offset: 0x283B400 VA: 0x18283CA00
	internal static string OnFindLayoutForDevice(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeCommandDelegate) { }

	// RVA: 0x283C5A0 Offset: 0x283AFA0 VA: 0x18283C5A0
	private static string ConvertPotentialAliasToName(InputControlLayout layout, string nameOrAlias) { }

	// RVA: 0x283C9D0 Offset: 0x283B3D0 VA: 0x18283C9D0
	private bool IsSubControl(string name) { }

	// RVA: 0x283C760 Offset: 0x283B160 VA: 0x18283C760
	private string GetParentControlName(string name) { }

	// RVA: 0x283C860 Offset: 0x283B260 VA: 0x18283C860
	private bool IsPoseControl(List<XRFeatureDescriptor> features, int startIndex) { }

	// RVA: 0x283B7F0 Offset: 0x283A1F0 VA: 0x18283B7F0
	private InputControlLayout Build() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x283CF50 Offset: 0x283B950 VA: 0x18283CF50
	private static void .cctor() { }
}
