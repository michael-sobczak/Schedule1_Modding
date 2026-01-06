using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Uptown;

public class PearlMoore : NPC
{
	public new static string NPCId => "pearl_moore";

	internal PearlMoore()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "pearl_moore"))
	{
	}
}
