using Il2CppScheduleOne;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.UI;
using Il2CppScheduleOne.UI.Phone;
using MelonLoader;
using UnityEngine;

namespace S1API.PhoneApp;

[RegisterTypeInIl2Cpp]
internal class PhoneAppButtonHandler : MonoBehaviour
{
	internal PhoneApp phoneApp;

	private void Update()
	{
		if (phoneApp != null && phoneApp.IsOpen() && PlayerSingleton<Phone>.InstanceExists && PlayerSingleton<Phone>.Instance.IsOpen && IsHoveringButton() && GameInput.GetButtonDown((ButtonCode)0))
		{
			phoneApp.CloseApp();
		}
	}

	private bool IsHoveringButton()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		RaycastHit val = default(RaycastHit);
		if (Physics.Raycast(Singleton<GameplayMenu>.Instance.OverlayCamera.ScreenPointToRay(Input.mousePosition), ref val, 2f, 1 << LayerMask.NameToLayer("Overlay")) && ((Object)((Component)((RaycastHit)(ref val)).collider).gameObject).name == "Button")
		{
			return true;
		}
		return false;
	}
}
