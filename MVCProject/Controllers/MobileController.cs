using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace YourProjectName.Controllers;

public class MobileController : Controller
{
    public IActionResult MobileName()
    {
        // List of mobiles
        List<string> mobileList = new List<string>
        {
            "Samsung Galaxy S23",
            "iPhone 14",
            "OnePlus 11",
            "Redmi Note 13",
            "Realme Narzo 60"
        };

        // Pass list to view
        return View(mobileList);
    }
}
