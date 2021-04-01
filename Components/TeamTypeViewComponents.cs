using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Assignment10.Models;

namespace Assignment10.Components
{
    public class TeamTypeViewComponents : ViewComponent
    {
        private BowlingLeagueContext context;

        public TeamTypeViewComponents(BowlingLeagueContext ctx)
        {
            context = ctx;
        }

        //this little function grabs the team names
        public IViewComponentResult Invoke()
        {
            return View(context.Teams
                .Distinct()
                .OrderBy(x => x));
        }

    }
}
