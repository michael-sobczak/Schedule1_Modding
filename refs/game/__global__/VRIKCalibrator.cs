public static class VRIKCalibrator // TypeDefIndex: 14222
{
	// Methods

	// RVA: 0x1F36FA0 Offset: 0x1F359A0 VA: 0x181F36FA0
	public static void RecalibrateScale(VRIK ik, VRIKCalibrator.CalibrationData data, VRIKCalibrator.Settings settings) { }

	// RVA: 0x1F36F40 Offset: 0x1F35940 VA: 0x181F36F40
	public static void RecalibrateScale(VRIK ik, VRIKCalibrator.CalibrationData data, float scaleMlp) { }

	// RVA: 0x1F33930 Offset: 0x1F32330 VA: 0x181F33930
	private static void CalibrateScale(VRIK ik, VRIKCalibrator.Settings settings) { }

	// RVA: 0x1F33950 Offset: 0x1F32350 VA: 0x181F33950
	private static void CalibrateScale(VRIK ik, float scaleMlp = 1) { }

	// RVA: 0x1F347C0 Offset: 0x1F331C0 VA: 0x181F347C0
	public static VRIKCalibrator.CalibrationData Calibrate(VRIK ik, VRIKCalibrator.Settings settings, Transform headTracker, Transform bodyTracker, Transform leftHandTracker, Transform rightHandTracker, Transform leftFootTracker, Transform rightFootTracker) { }

	// RVA: 0x1F32ED0 Offset: 0x1F318D0 VA: 0x181F32ED0
	private static void CalibrateLeg(VRIKCalibrator.Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft) { }

	// RVA: 0x1F33AE0 Offset: 0x1F324E0 VA: 0x181F33AE0
	public static void Calibrate(VRIK ik, VRIKCalibrator.CalibrationData data, Transform headTracker, Transform bodyTracker, Transform leftHandTracker, Transform rightHandTracker, Transform leftFootTracker, Transform rightFootTracker) { }

	// RVA: 0x1F32C60 Offset: 0x1F31660 VA: 0x181F32C60
	private static void CalibrateLeg(VRIKCalibrator.CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft) { }

	// RVA: 0x1F36640 Offset: 0x1F35040 VA: 0x181F36640
	public static VRIKCalibrator.CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1) { }

	// RVA: 0x1F32270 Offset: 0x1F30C70 VA: 0x181F32270
	public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset) { }

	// RVA: 0x1F31100 Offset: 0x1F2FB00 VA: 0x181F31100
	public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset) { }

	// RVA: 0x1F32000 Offset: 0x1F30A00 VA: 0x181F32000
	public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset) { }

	// RVA: 0x1F31580 Offset: 0x1F2FF80 VA: 0x181F31580
	private static void CalibrateHand(VRIK ik, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft) { }

	// RVA: 0x1F36D90 Offset: 0x1F35790 VA: 0x181F36D90
	public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm) { }

	// RVA: 0x1F368A0 Offset: 0x1F352A0 VA: 0x181F368A0
	public static Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm) { }
}
