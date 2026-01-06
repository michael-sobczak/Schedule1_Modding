using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Suburbia;

public class WeiLong : NPC
{
	public new static string NPCId => "wei_long";

	internal WeiLong()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "wei_long"))
	{
	}
}
