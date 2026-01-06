using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.PoliceOfficers;

public class OfficerLopez : NPC
{
	public new static string NPCId => "officerlopez";

	internal OfficerLopez()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "officerlopez"))
	{
	}
}
