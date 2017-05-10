using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExploreCalifornia.Models;

namespace ExploreCalifornia.ViewComponents
{
    public class MonthlySpecialsViewComponent : ViewComponent
    {
        private SpecialsDataContext _specialsDataContext;
        public MonthlySpecialsViewComponent(SpecialsDataContext specialsDataContext)
        {
            _specialsDataContext = specialsDataContext;
        }

        public IViewComponentResult Invoke()
        {
            return View(_specialsDataContext.GetMonthlySpecials());
        }
    }
}
