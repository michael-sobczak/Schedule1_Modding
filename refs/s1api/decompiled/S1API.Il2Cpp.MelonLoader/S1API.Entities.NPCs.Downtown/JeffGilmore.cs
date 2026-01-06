using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Downtown;

public class JeffGilmore : NPC
{
	public new static string NPCId => "jeff_gilmore";

	internal JeffGilmore()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "jeff_gilmore"))
	{
	}
}
