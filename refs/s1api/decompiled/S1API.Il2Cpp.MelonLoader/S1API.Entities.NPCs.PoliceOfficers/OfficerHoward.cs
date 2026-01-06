using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.PoliceOfficers;

public class OfficerHoward : NPC
{
	public new static string NPCId => "officerhoward";

	internal OfficerHoward()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "officerhoward"))
	{
	}
}
