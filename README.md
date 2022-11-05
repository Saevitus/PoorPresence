# PoorPresence - Formerly CS-Steamworks
## NOW USING .NET 6.0 - old branch has been saved and locked as master if anyone wants it.


Just a meme program using steamworks, includes basic functionalities, setting rich presence, unlocking achievements, fake invites, etc. I've now added discord rich presence to it as well.
For discord, you can set the details, state, large & small image along with a timestamp (currently hardcoded to show your local time).

Since it's no longer solely based around steamworks, I've decided to rename it.

add it to your cheat, or whatever, idc. easily replicatable, would be funny seeing custom discord rich presence for a cheat.

using [Lachee's Discord Rich Presence](https://github.com/Lachee/discord-rpc-csharp) to do all the management of that shit
`NuGet\Install-Package DiscordRichPresence`

Get [Steamworks.NET](https://steamworks.github.io/)
`NuGet\Install-Package Steamworks.NET -Version 20.1.0`
>this does not supply the steam_api/64 dlls, you will need to manually get them from steamworks

most of the code is commented, so it should be pretty easy to understand what's going on
