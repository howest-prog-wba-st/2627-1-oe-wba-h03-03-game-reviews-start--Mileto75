namespace Wba.Oefening.Games.Web.ViewModels
{
    public class DevelopersShowDeveloperViewModel
    {
        public string Developer { get; set; }
        public IEnumerable<BaseViewModel> Games { get; set; }
    }
}
