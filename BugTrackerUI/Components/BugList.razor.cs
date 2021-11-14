using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;

namespace BugTrackerUI.Components
{
  public partial class BugList
  {

    [Inject]
    public IBugService BugService { get; set; }
    public List<Bug> Bugs { get; set; }

    protected override void OnInitialized()
    {
      base.OnInitialized();
      Bugs = BugService.GetBugs().OrderBy(x => x.Priority).ToList();


    }
  }
}
