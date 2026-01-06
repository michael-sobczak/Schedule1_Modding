public class StarBlender : FeatureBlender // TypeDefIndex: 419
{
	// Fields
	[Range(1, 3)]
	public int starLayer; // 0x20

	// Properties
	protected override string featureKey { get; }

	// Methods

	// RVA: 0x8D9400 Offset: 0x8D7E00 VA: 0x1808D9400 Slot: 5
	protected override string get_featureKey() { }

	// RVA: 0x8D8C40 Offset: 0x8D7640 VA: 0x1808D8C40 Slot: 6
	protected override void BlendBoth(ProfileBlendingState state, BlendingHelper helper) { }

	// RVA: 0x8D91A0 Offset: 0x8D7BA0 VA: 0x1808D91A0 Slot: 7
	protected override void BlendIn(ProfileBlendingState state, BlendingHelper helper) { }

	// RVA: 0x8D9290 Offset: 0x8D7C90 VA: 0x1808D9290 Slot: 8
	protected override void BlendOut(ProfileBlendingState state, BlendingHelper helper) { }

	// RVA: 0x8D9380 Offset: 0x8D7D80 VA: 0x1808D9380
	private string PropertyKeyForLayer(string key) { }

	// RVA: 0x44B2F0 Offset: 0x449CF0 VA: 0x18044B2F0
	public void .ctor() { }
}
