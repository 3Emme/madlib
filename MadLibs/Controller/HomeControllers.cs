using MadLibs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers {
    public class HomeController : Controller {
        [Route ("/form")]
        public ActionResult Form () { return View (); }

        [Route ("/MadLib")]
        public ActionResult MadLib (string noun1, string noun2,string noun3, string adjective1,string adjective2, string adjective3,string adjective4, string verbPastTense1,string verbPastTense2, string verb, string adverb1, string adverb2) {
            MadLibVariable myMadLibVariable = new MadLibVariable ();
            myMadLibVariable.Noun1 = noun1;
            myMadLibVariable.Noun2 = noun2;
            myMadLibVariable.Noun3 = noun3;
            myMadLibVariable.Adjective1 = adjective1;
            myMadLibVariable.Adjective2 = adjective2;
            myMadLibVariable.Adjective3 = adjective3;
            myMadLibVariable.Adjective4 = adjective4;
            myMadLibVariable.VerbPastTense1 = verbPastTense1;
            myMadLibVariable.VerbPastTense2 = verbPastTense2;
            myMadLibVariable.Verb = verb;
            myMadLibVariable.Adverb1 = adverb1;
            myMadLibVariable.Adverb2 = adverb2;
            return View (myMadLibVariable);


        }
    }
}