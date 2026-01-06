using System.Linq;
using ScheduleOne.NPCs;

namespace S1API.Entities.NPCs.Uptown;

public class LilyTurner : NPC
{
	public new static string NPCId => "lily_turner";

	internal LilyTurner()
		: base(NPCManager.NPCRegistry.ToArray().First((NPC n) => n.ID == "lily_turner"))
	{
	}
}
