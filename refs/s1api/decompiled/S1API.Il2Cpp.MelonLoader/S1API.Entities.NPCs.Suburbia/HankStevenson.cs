using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Suburbia;

public class HankStevenson : NPC
{
	public new static string NPCId => "hank_stevenson";

	internal HankStevenson()
		: base(((IEnumerable<NPC>)NPCManager.NPCRegistry.ToArray()).First((NPC n) => n.ID == "hank_stevenson"))
	{
	}
}
