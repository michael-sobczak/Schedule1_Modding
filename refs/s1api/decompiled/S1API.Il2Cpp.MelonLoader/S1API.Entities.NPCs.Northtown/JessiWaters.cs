using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Northtown;

public class JessiWaters : NPC
{
	public new static string NPCId => "jessi_waters";

	internal JessiWaters()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "jessi_waters"))
	{
	}
}
