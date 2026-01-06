public abstract class PostProcessEffectRenderer // TypeDefIndex: 17034
{
	// Fields
	protected bool m_ResetHistory; // 0x10

	// Methods

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	public virtual void Init() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 5
	public virtual DepthTextureMode GetCameraFlags() { }

	// RVA: 0x50C890 Offset: 0x50B290 VA: 0x18050C890 Slot: 6
	public virtual void ResetHistory() { }

	// RVA: 0x5FF4F0 Offset: 0x5FDEF0 VA: 0x1805FF4F0 Slot: 7
	public virtual void Release() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Render(PostProcessRenderContext context);

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract void SetSettings(PostProcessEffectSettings settings);

	// RVA: 0x79D260 Offset: 0x79BC60 VA: 0x18079D260
	protected void .ctor() { }
}
