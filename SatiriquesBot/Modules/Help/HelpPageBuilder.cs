﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Discord.Addons.Interactive;
using static Discord.Addons.Interactive.PaginatedMessage;
using Discord.Commands;

namespace SatiriquesBot.Modules.Help
{
    public static class HelpPageBuilder
    {
        public static Page Build(IEnumerable<CommandInfo> commands, ModuleInfo module)
        {
            return new Page()
            {
                Title = module.Name,
                Description = string.Join(Environment.NewLine, commands.Select(x => x.Aliases[0]))
            };
        }
    }
}
