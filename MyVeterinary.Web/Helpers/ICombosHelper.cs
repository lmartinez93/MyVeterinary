using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MyVeterinary.Web.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboPetTypes();
    }
}