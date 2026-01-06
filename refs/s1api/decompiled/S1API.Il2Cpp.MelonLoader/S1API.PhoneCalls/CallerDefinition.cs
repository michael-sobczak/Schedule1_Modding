using Il2CppScheduleOne.ScriptableObjects;
using UnityEngine;

namespace S1API.PhoneCalls;

public class CallerDefinition
{
	internal readonly CallerID S1CallerIDEntry;

	public string Name
	{
		get
		{
			return S1CallerIDEntry.Name;
		}
		set
		{
			S1CallerIDEntry.Name = value;
		}
	}

	public Sprite? ProfilePicture
	{
		get
		{
			return S1CallerIDEntry.ProfilePicture;
		}
		set
		{
			S1CallerIDEntry.ProfilePicture = value;
		}
	}

	internal CallerDefinition(CallerID s1CallerID)
	{
		S1CallerIDEntry = s1CallerID;
	}
}
