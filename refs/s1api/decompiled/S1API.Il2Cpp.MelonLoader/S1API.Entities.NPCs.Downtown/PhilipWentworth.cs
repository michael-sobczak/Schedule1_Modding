using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Downtown;

public class PhilipWentworth : NPC
{
	public new static string NPCId => "philip_wentworth";

	internal PhilipWentworth()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "philip_wentworth"))
	{
	}
}
