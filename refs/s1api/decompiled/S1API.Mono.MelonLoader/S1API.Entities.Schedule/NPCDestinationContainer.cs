using UnityEngine;

namespace S1API.Entities.Schedule;

internal static class NPCDestinationContainer
{
	private const string NPC_CONTAINERS_PATH = "@Managers/@NPCs/NPC Containers";

	public static GameObject GetOrCreateContainer(string npcName)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(npcName))
		{
			return null;
		}
		GameObject val = GameObject.Find("@Managers/@NPCs/NPC Containers");
		if ((Object)(object)val == (Object)null)
		{
			GameObject val2 = GameObject.Find("@Managers");
			if ((Object)(object)val2 == (Object)null)
			{
				val2 = new GameObject("@Managers");
			}
			Transform val3 = val2.transform.Find("@NPCs");
			if ((Object)(object)val3 == (Object)null)
			{
				val3 = new GameObject("@NPCs").transform;
				val3.SetParent(val2.transform);
			}
			val = new GameObject("NPC Containers");
			val.transform.SetParent(val3);
		}
		Transform val4 = val.transform.Find(npcName);
		if ((Object)(object)val4 == (Object)null)
		{
			GameObject val5 = new GameObject(npcName);
			val5.transform.SetParent(val.transform);
			return val5;
		}
		return ((Component)val4).gameObject;
	}

	public static Transform CreateDestinationMarker(string npcName, string markerName, Vector3 position, Vector3? forward = null)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		GameObject orCreateContainer = GetOrCreateContainer(npcName);
		if ((Object)(object)orCreateContainer == (Object)null)
		{
			return null;
		}
		GameObject val = new GameObject(markerName);
		val.transform.SetParent(orCreateContainer.transform);
		val.transform.position = position;
		if (forward.HasValue)
		{
			Vector3 value = forward.Value;
			if (((Vector3)(ref value)).sqrMagnitude > 0.001f)
			{
				Transform transform = val.transform;
				value = forward.Value;
				transform.forward = ((Vector3)(ref value)).normalized;
				goto IL_0098;
			}
		}
		val.transform.forward = Vector3.forward;
		goto IL_0098;
		IL_0098:
		return val.transform;
	}
}
