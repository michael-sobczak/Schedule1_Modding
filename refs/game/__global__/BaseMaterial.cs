public class BaseMaterial // TypeDefIndex: 18888
{
	// Fields
	public readonly Material Material; // 0x10

	// Methods

	// RVA: 0x2F6BBD0 Offset: 0x2F6A5D0 VA: 0x182F6BBD0
	public void .ctor(Material material) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	public virtual void Validate(bool clean) { }

	// RVA: 0x2F6AAD0 Offset: 0x2F694D0 VA: 0x182F6AAD0
	protected void SetKeyword(string keyword, bool isEnabled) { }

	// RVA: 0x2F6A750 Offset: 0x2F69150 VA: 0x182F6A750
	protected bool GetKeyword(string keyword) { }

	// RVA: 0x2F6B550 Offset: 0x2F69F50 VA: 0x182F6B550
	protected bool TrySetInt(string propertyName, int value, Action validate) { }

	// RVA: 0x2F6AFE0 Offset: 0x2F699E0 VA: 0x182F6AFE0
	protected int TryGetInt(string propertyName) { }

	// RVA: 0x2F6B4A0 Offset: 0x2F69EA0 VA: 0x182F6B4A0
	protected bool TrySetFloat(string propertyName, float value, Action validate) { }

	// RVA: 0x2F6AF80 Offset: 0x2F69980 VA: 0x182F6AF80
	protected float TryGetFloat(string propertyName) { }

	// RVA: 0x2F6B5F0 Offset: 0x2F69FF0 VA: 0x182F6B5F0
	protected bool TrySetTexture(string propertyName, Texture value, Action validate) { }

	// RVA: 0x2F6B6F0 Offset: 0x2F6A0F0 VA: 0x182F6B6F0
	protected bool TrySetTexture(Texture value, string[] propertyName) { }

	// RVA: 0x2F6B040 Offset: 0x2F69A40 VA: 0x182F6B040
	protected Texture TryGetTexture(string propertyName) { }

	// RVA: 0x2F6B0A0 Offset: 0x2F69AA0 VA: 0x182F6B0A0
	protected Texture TryGetTexture(string[] propertyName) { }

	// RVA: 0x2F6B1F0 Offset: 0x2F69BF0 VA: 0x182F6B1F0
	protected bool TrySetColor(string propertyName, Color value, Action validate) { }

	// RVA: 0x2F6B320 Offset: 0x2F69D20 VA: 0x182F6B320
	protected bool TrySetColor(Color value, string[] propertyName) { }

	// RVA: 0x2F6AE40 Offset: 0x2F69840 VA: 0x182F6AE40
	protected Color TryGetColor(string propertyName) { }

	// RVA: 0x2F6AEC0 Offset: 0x2F698C0 VA: 0x182F6AEC0
	protected Color TryGetColor(string[] propertyName) { }

	// RVA: 0x2F6B790 Offset: 0x2F6A190 VA: 0x182F6B790
	protected bool TrySetVector(string propertyName, Vector4 value, Action validate) { }

	// RVA: 0x2F6B150 Offset: 0x2F69B50 VA: 0x182F6B150
	protected Vector4 TryGetVector(string propertyName) { }

	// RVA: 0x2F6A800 Offset: 0x2F69200 VA: 0x182F6A800
	protected void SetDirty() { }

	// RVA: 0x2F6A770 Offset: 0x2F69170 VA: 0x182F6A770 Slot: 5
	protected virtual bool GetMotionVectorsEnabled() { }

	// RVA: 0x2F6B8C0 Offset: 0x2F6A2C0 VA: 0x182F6B8C0 Slot: 6
	protected virtual void ValidatePasses(bool receivesSSR, bool useSplitLighting) { }

	// RVA: 0x2F6A680 Offset: 0x2F69080 VA: 0x182F6A680
	private void ComputeStencilProperties(bool receivesLighting, bool forwardOnly, bool receivesSSR, bool useSplitLighting, out int stencilRef, out int stencilWriteMask, out int stencilRefDepth, out int stencilWriteMaskDepth, out int stencilRefGBuffer, out int stencilWriteMaskGBuffer, out int stencilRefMV, out int stencilWriteMaskMV) { }

	// RVA: 0x2F6AB50 Offset: 0x2F69550 VA: 0x182F6AB50
	private void SetupStencil(bool receivesLighting, bool receivesSSR, bool useSplitLighting) { }
}
