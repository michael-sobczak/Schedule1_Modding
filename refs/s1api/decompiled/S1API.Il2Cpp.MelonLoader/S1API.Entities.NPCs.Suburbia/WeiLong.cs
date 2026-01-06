using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Suburbia;

public class WeiLong : NPC
{
	public new static string NPCId => "wei_long";

	internal WeiLong()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "wei_long"))
	{
	}
}
