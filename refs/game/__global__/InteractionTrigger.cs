public class InteractionTrigger : MonoBehaviour // TypeDefIndex: 14160
{
	// Fields
	[Tooltip("The valid ranges of the character's and/or its camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
	public InteractionTrigger.Range[] ranges; // 0x20

	// Methods

	[ContextMenu("User Manual")]
	// RVA: 0x1F233F0 Offset: 0x1F21DF0 VA: 0x181F233F0
	private void OpenUserManual() { }

	[ContextMenu("Scrpt Reference")]
	// RVA: 0x1F23330 Offset: 0x1F21D30 VA: 0x181F23330
	private void OpenScriptReference() { }

	[ContextMenu("TUTORIAL VIDEO")]
	// RVA: 0x1F23390 Offset: 0x1F21D90 VA: 0x181F23390
	private void OpenTutorial4() { }

	[ContextMenu("Support Group")]
	// RVA: 0x1F23450 Offset: 0x1F21E50 VA: 0x181F23450
	private void SupportGroup() { }

	[ContextMenu("Asset Store Thread")]
	// RVA: 0x1F23080 Offset: 0x1F21A80 VA: 0x181F23080
	private void ASThread() { }

	// RVA: 0x1F230E0 Offset: 0x1F21AE0 VA: 0x181F230E0
	public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit) { }

	// RVA: 0x1F234B0 Offset: 0x1F21EB0 VA: 0x181F234B0
	public void .ctor() { }
}
