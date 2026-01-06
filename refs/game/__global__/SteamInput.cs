public static class SteamInput // TypeDefIndex: 14336
{
	// Methods

	// RVA: 0xC694A0 Offset: 0xC67EA0 VA: 0x180C694A0
	public static bool Init(bool bExplicitlyCallRunFrame) { }

	// RVA: 0xC698F0 Offset: 0xC682F0 VA: 0x180C698F0
	public static bool Shutdown() { }

	// RVA: 0xC696E0 Offset: 0xC680E0 VA: 0x180C696E0
	public static bool SetInputActionManifestFilePath(string pchInputActionManifestAbsolutePath) { }

	// RVA: 0xC69620 Offset: 0xC68020 VA: 0x180C69620
	public static void RunFrame(bool bReservedValue = True) { }

	// RVA: 0xC68480 Offset: 0xC66E80 VA: 0x180C68480
	public static bool BWaitForData(bool bWaitForever, uint unTimeout) { }

	// RVA: 0xC68430 Offset: 0xC66E30 VA: 0x180C68430
	public static bool BNewDataAvailable() { }

	// RVA: 0xC68B30 Offset: 0xC67530 VA: 0x180C68B30
	public static int GetConnectedControllers(InputHandle_t[] handlesOut) { }

	// RVA: 0xC68600 Offset: 0xC67000 VA: 0x180C68600
	public static void EnableDeviceCallbacks() { }

	// RVA: 0xC685A0 Offset: 0xC66FA0 VA: 0x180C685A0
	public static void EnableActionEventCallbacks(SteamInputActionEventCallbackPointer pCallback) { }

	// RVA: 0xC686B0 Offset: 0xC670B0 VA: 0x180C686B0
	public static InputActionSetHandle_t GetActionSetHandle(string pszActionSetName) { }

	// RVA: 0xC683D0 Offset: 0xC66DD0 VA: 0x180C683D0
	public static void ActivateActionSet(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle) { }

	// RVA: 0xC68C40 Offset: 0xC67640 VA: 0x180C68C40
	public static InputActionSetHandle_t GetCurrentActionSet(InputHandle_t inputHandle) { }

	// RVA: 0xC68370 Offset: 0xC66D70 VA: 0x180C68370
	public static void ActivateActionSetLayer(InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle) { }

	// RVA: 0xC684E0 Offset: 0xC66EE0 VA: 0x180C684E0
	public static void DeactivateActionSetLayer(InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle) { }

	// RVA: 0xC68540 Offset: 0xC66F40 VA: 0x180C68540
	public static void DeactivateAllActionSetLayers(InputHandle_t inputHandle) { }

	// RVA: 0xC687D0 Offset: 0xC671D0 VA: 0x180C687D0
	public static int GetActiveActionSetLayers(InputHandle_t inputHandle, InputActionSetHandle_t[] handlesOut) { }

	// RVA: 0xC68D80 Offset: 0xC67780 VA: 0x180C68D80
	public static InputDigitalActionHandle_t GetDigitalActionHandle(string pszActionName) { }

	// RVA: 0xC68D20 Offset: 0xC67720 VA: 0x180C68D20
	public static InputDigitalActionData_t GetDigitalActionData(InputHandle_t inputHandle, InputDigitalActionHandle_t digitalActionHandle) { }

	// RVA: 0xC68EA0 Offset: 0xC678A0 VA: 0x180C68EA0
	public static int GetDigitalActionOrigins(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputDigitalActionHandle_t digitalActionHandle, EInputActionOrigin[] originsOut) { }

	// RVA: 0xC693E0 Offset: 0xC67DE0 VA: 0x180C693E0
	public static string GetStringForDigitalActionName(InputDigitalActionHandle_t eActionHandle) { }

	// RVA: 0xC68930 Offset: 0xC67330 VA: 0x180C68930
	public static InputAnalogActionHandle_t GetAnalogActionHandle(string pszActionName) { }

	// RVA: 0xC68890 Offset: 0xC67290 VA: 0x180C68890
	public static InputAnalogActionData_t GetAnalogActionData(InputHandle_t inputHandle, InputAnalogActionHandle_t analogActionHandle) { }

	// RVA: 0xC68A50 Offset: 0xC67450 VA: 0x180C68A50
	public static int GetAnalogActionOrigins(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputAnalogActionHandle_t analogActionHandle, EInputActionOrigin[] originsOut) { }

	// RVA: 0xC690A0 Offset: 0xC67AA0 VA: 0x180C690A0
	public static string GetGlyphPNGForActionOrigin(EInputActionOrigin eOrigin, ESteamInputGlyphSize eSize, uint unFlags) { }

	// RVA: 0xC69120 Offset: 0xC67B20 VA: 0x180C69120
	public static string GetGlyphSVGForActionOrigin(EInputActionOrigin eOrigin, uint unFlags) { }

	// RVA: 0xC68FE0 Offset: 0xC679E0 VA: 0x180C68FE0
	public static string GetGlyphForActionOrigin_Legacy(EInputActionOrigin eOrigin) { }

	// RVA: 0xC69320 Offset: 0xC67D20 VA: 0x180C69320
	public static string GetStringForActionOrigin(EInputActionOrigin eOrigin) { }

	// RVA: 0xC69380 Offset: 0xC67D80 VA: 0x180C69380
	public static string GetStringForAnalogActionName(InputAnalogActionHandle_t eActionHandle) { }

	// RVA: 0xC69940 Offset: 0xC68340 VA: 0x180C69940
	public static void StopAnalogActionMomentum(InputHandle_t inputHandle, InputAnalogActionHandle_t eAction) { }

	// RVA: 0xC691F0 Offset: 0xC67BF0 VA: 0x180C691F0
	public static InputMotionData_t GetMotionData(InputHandle_t inputHandle) { }

	// RVA: 0xC69B40 Offset: 0xC68540 VA: 0x180C69B40
	public static void TriggerVibration(InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed) { }

	// RVA: 0xC69AA0 Offset: 0xC684A0 VA: 0x180C69AA0
	public static void TriggerVibrationExtended(InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed, ushort usLeftTriggerSpeed, ushort usRightTriggerSpeed) { }

	// RVA: 0xC69A00 Offset: 0xC68400 VA: 0x180C69A00
	public static void TriggerSimpleHapticEvent(InputHandle_t inputHandle, EControllerHapticLocation eHapticLocation, byte nIntensity, char nGainDB, byte nOtherIntensity, char nOtherGainDB) { }

	// RVA: 0xC697F0 Offset: 0xC681F0 VA: 0x180C697F0
	public static void SetLEDColor(InputHandle_t inputHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags) { }

	// RVA: 0xC69500 Offset: 0xC67F00 VA: 0x180C69500
	public static void Legacy_TriggerHapticPulse(InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec) { }

	// RVA: 0xC69580 Offset: 0xC67F80 VA: 0x180C69580
	public static void Legacy_TriggerRepeatedHapticPulse(InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags) { }

	// RVA: 0xC69890 Offset: 0xC68290 VA: 0x180C69890
	public static bool ShowBindingPanel(InputHandle_t inputHandle) { }

	// RVA: 0xC69190 Offset: 0xC67B90 VA: 0x180C69190
	public static ESteamInputType GetInputTypeForHandle(InputHandle_t inputHandle) { }

	// RVA: 0xC68BE0 Offset: 0xC675E0 VA: 0x180C68BE0
	public static InputHandle_t GetControllerForGamepadIndex(int nIndex) { }

	// RVA: 0xC68F80 Offset: 0xC67980 VA: 0x180C68F80
	public static int GetGamepadIndexForController(InputHandle_t ulinputHandle) { }

	// RVA: 0xC69440 Offset: 0xC67E40 VA: 0x180C69440
	public static string GetStringForXboxOrigin(EXboxOrigin eOrigin) { }

	// RVA: 0xC69040 Offset: 0xC67A40 VA: 0x180C69040
	public static string GetGlyphForXboxOrigin(EXboxOrigin eOrigin) { }

	// RVA: 0xC68650 Offset: 0xC67050 VA: 0x180C68650
	public static EInputActionOrigin GetActionOriginFromXboxOrigin(InputHandle_t inputHandle, EXboxOrigin eOrigin) { }

	// RVA: 0xC699A0 Offset: 0xC683A0 VA: 0x180C699A0
	public static EInputActionOrigin TranslateActionOrigin(ESteamInputType eDestinationInputType, EInputActionOrigin eSourceOrigin) { }

	// RVA: 0xC68CA0 Offset: 0xC676A0 VA: 0x180C68CA0
	public static bool GetDeviceBindingRevision(InputHandle_t inputHandle, out int pMajor, out int pMinor) { }

	// RVA: 0xC69270 Offset: 0xC67C70 VA: 0x180C69270
	public static uint GetRemotePlaySessionID(InputHandle_t inputHandle) { }

	// RVA: 0xC692D0 Offset: 0xC67CD0 VA: 0x180C692D0
	public static ushort GetSessionInputConfigurationSettings() { }

	// RVA: 0xC69680 Offset: 0xC68080 VA: 0x180C69680
	public static void SetDualSenseTriggerEffect(InputHandle_t inputHandle, IntPtr pParam) { }
}
