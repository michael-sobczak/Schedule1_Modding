public class Gradient : IEquatable<Gradient> // TypeDefIndex: 11751
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public GradientColorKey[] colorKeys { get; set; }
	public GradientAlphaKey[] alphaKeys { get; }

	// Methods

	[FreeFunction(Name = "Gradient_Bindings::Init", IsThreadSafe = True)]
	// RVA: 0x2CA5B70 Offset: 0x2CA4570 VA: 0x182CA5B70
	private static IntPtr Init() { }

	[FreeFunction(Name = "Gradient_Bindings::Cleanup", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x2CA57A0 Offset: 0x2CA41A0 VA: 0x182CA57A0
	private void Cleanup() { }

	[FreeFunction("Gradient_Bindings::Internal_Equals", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x2CA5BA0 Offset: 0x2CA45A0 VA: 0x182CA5BA0
	private bool Internal_Equals(IntPtr other) { }

	[RequiredByNativeCode]
	// RVA: 0x2CA5C50 Offset: 0x2CA4650 VA: 0x182CA5C50
	public void .ctor() { }

	// RVA: 0x2CA5AE0 Offset: 0x2CA44E0 VA: 0x182CA5AE0 Slot: 1
	protected override void Finalize() { }

	[FreeFunction(Name = "Gradient_Bindings::Evaluate", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x2CA5A80 Offset: 0x2CA4480 VA: 0x182CA5A80
	public Color Evaluate(float time) { }

	[FreeFunction("Gradient_Bindings::GetColorKeys", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x2CA5CD0 Offset: 0x2CA46D0 VA: 0x182CA5CD0
	public GradientColorKey[] get_colorKeys() { }

	[FreeFunction("Gradient_Bindings::SetColorKeys", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x2CA5D10 Offset: 0x2CA4710 VA: 0x182CA5D10
	public void set_colorKeys(GradientColorKey[] value) { }

	[FreeFunction("Gradient_Bindings::GetAlphaKeys", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x2CA5C90 Offset: 0x2CA4690 VA: 0x182CA5C90
	public GradientAlphaKey[] get_alphaKeys() { }

	[FreeFunction(Name = "Gradient_Bindings::SetKeys", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x2CA5BF0 Offset: 0x2CA45F0 VA: 0x182CA5BF0
	public void SetKeys(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys) { }

	// RVA: 0x2CA57E0 Offset: 0x2CA41E0 VA: 0x182CA57E0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2CA5960 Offset: 0x2CA4360 VA: 0x182CA5960 Slot: 4
	public bool Equals(Gradient other) { }

	// RVA: 0x2CA5B60 Offset: 0x2CA4560 VA: 0x182CA5B60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CA5A20 Offset: 0x2CA4420 VA: 0x182CA5A20
	private void Evaluate_Injected(float time, out Color ret) { }
}
