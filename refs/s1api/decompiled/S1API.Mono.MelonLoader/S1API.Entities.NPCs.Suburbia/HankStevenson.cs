using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Suburbia;

public class HankStevenson : NPC
{
	public new static string NPCId => "hank_stevenson";

	internal HankStevenson()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "hank_stevenson"))
	{
	}
}
