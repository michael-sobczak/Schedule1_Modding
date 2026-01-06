public abstract class FeatureBlender : MonoBehaviour, IFeatureBlender // TypeDefIndex: 422
{
	// Properties
	protected abstract string featureKey { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract string get_featureKey();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void BlendBoth(ProfileBlendingState state, BlendingHelper helper);

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void BlendIn(ProfileBlendingState state, BlendingHelper helper);

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void BlendOut(ProfileBlendingState state, BlendingHelper helper);

	// RVA: 0x9DF9D0 Offset: 0x9DE3D0 VA: 0x1809DF9D0 Slot: 9
	protected virtual ProfileFeatureBlendingMode BlendingMode(ProfileBlendingState state, BlendingHelper helper) { }

	// RVA: 0x9DF900 Offset: 0x9DE300 VA: 0x1809DF900 Slot: 10
	public virtual void Blend(ProfileBlendingState state, BlendingHelper helper) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	protected void .ctor() { }
}
