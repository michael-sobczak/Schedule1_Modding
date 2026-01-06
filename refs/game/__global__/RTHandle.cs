public class RTHandle // TypeDefIndex: 13817
{
	// Fields
	internal RTHandleSystem m_Owner; // 0x10
	internal RenderTexture m_RT; // 0x18
	internal Texture m_ExternalTexture; // 0x20
	internal RenderTargetIdentifier m_NameID; // 0x28
	internal bool m_EnableMSAA; // 0x50
	internal bool m_EnableRandomWrite; // 0x51
	internal bool m_EnableHWDynamicScale; // 0x52
	internal string m_Name; // 0x58
	internal bool m_UseCustomHandleScales; // 0x60
	internal RTHandleProperties m_CustomHandleProperties; // 0x64
	[CompilerGenerated]
	private Vector2 <scaleFactor>k__BackingField; // 0x94
	internal ScaleFunc scaleFunc; // 0xA0
	[CompilerGenerated]
	private bool <useScaling>k__BackingField; // 0xA8
	[CompilerGenerated]
	private Vector2Int <referenceSize>k__BackingField; // 0xAC

	// Properties
	public Vector2 scaleFactor { get; set; }
	public bool useScaling { get; set; }
	public Vector2Int referenceSize { get; set; }
	public RTHandleProperties rtHandleProperties { get; }
	public RenderTexture rt { get; }
	public RenderTargetIdentifier nameID { get; }
	public string name { get; }
	public bool isMSAAEnabled { get; }

	// Methods

	// RVA: 0x2A29230 Offset: 0x2A27C30 VA: 0x182A29230
	public void SetCustomHandleProperties(in RTHandleProperties properties) { }

	// RVA: 0x2A28E80 Offset: 0x2A27880 VA: 0x182A28E80
	public void ClearCustomHandleProperties() { }

	[CompilerGenerated]
	// RVA: 0x1063C40 Offset: 0x1062640 VA: 0x181063C40
	public Vector2 get_scaleFactor() { }

	[CompilerGenerated]
	// RVA: 0x1063DE0 Offset: 0x10627E0 VA: 0x181063DE0
	internal void set_scaleFactor(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x4D63F0 Offset: 0x4D4DF0 VA: 0x1804D63F0
	public bool get_useScaling() { }

	[CompilerGenerated]
	// RVA: 0x4D6660 Offset: 0x4D5060 VA: 0x1804D6660
	internal void set_useScaling(bool value) { }

	[CompilerGenerated]
	// RVA: 0xCE3DA0 Offset: 0xCE27A0 VA: 0x180CE3DA0
	public Vector2Int get_referenceSize() { }

	[CompilerGenerated]
	// RVA: 0xCE3E00 Offset: 0xCE2800 VA: 0x180CE3E00
	internal void set_referenceSize(Vector2Int value) { }

	// RVA: 0x2A294F0 Offset: 0x2A27EF0 VA: 0x182A294F0
	public RTHandleProperties get_rtHandleProperties() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public RenderTexture get_rt() { }

	// RVA: 0x2A294D0 Offset: 0x2A27ED0 VA: 0x182A294D0
	public RenderTargetIdentifier get_nameID() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public string get_name() { }

	// RVA: 0x49CAE0 Offset: 0x49B4E0 VA: 0x18049CAE0
	public bool get_isMSAAEnabled() { }

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	internal void .ctor(RTHandleSystem owner) { }

	// RVA: 0x2A29550 Offset: 0x2A27F50 VA: 0x182A29550
	public static RenderTargetIdentifier op_Implicit(RTHandle handle) { }

	// RVA: 0x2A295B0 Offset: 0x2A27FB0 VA: 0x182A295B0
	public static Texture op_Implicit(RTHandle handle) { }

	// RVA: 0x2A295A0 Offset: 0x2A27FA0 VA: 0x182A295A0
	public static RenderTexture op_Implicit(RTHandle handle) { }

	// RVA: 0x2A29250 Offset: 0x2A27C50 VA: 0x182A29250
	internal void SetRenderTexture(RenderTexture rt) { }

	// RVA: 0x2A29330 Offset: 0x2A27D30 VA: 0x182A29330
	internal void SetTexture(Texture tex) { }

	// RVA: 0x2A292D0 Offset: 0x2A27CD0 VA: 0x182A292D0
	internal void SetTexture(RenderTargetIdentifier tex) { }

	// RVA: 0x2A28F40 Offset: 0x2A27940 VA: 0x182A28F40
	public int GetInstanceID() { }

	// RVA: 0x2A29140 Offset: 0x2A27B40 VA: 0x182A29140
	public void Release() { }

	// RVA: 0x2A290B0 Offset: 0x2A27AB0 VA: 0x182A290B0
	public Vector2Int GetScaledSize(Vector2Int refSize) { }

	// RVA: 0x2A29000 Offset: 0x2A27A00 VA: 0x182A29000
	public Vector2Int GetScaledSize() { }

	// RVA: 0x2A29420 Offset: 0x2A27E20 VA: 0x182A29420
	public void SwitchToFastMemory(CommandBuffer cmd, float residencyFraction = 1, FastMemoryFlags flags = 1, bool copyContents = False) { }

	// RVA: 0x2A28E90 Offset: 0x2A27890 VA: 0x182A28E90
	public void CopyToFastMemory(CommandBuffer cmd, float residencyFraction = 1, FastMemoryFlags flags = 1) { }

	// RVA: 0x2A293B0 Offset: 0x2A27DB0 VA: 0x182A293B0
	public void SwitchOutFastMemory(CommandBuffer cmd, bool copyContents = True) { }
}
