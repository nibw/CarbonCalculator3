using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSystem.Models;

namespace WebSystem.Interfaces
{
    public interface IHousehold
    {
        List<Household> GetItems(string SortProperty, SortOrder sortOrder, string SearchText = "");
        Household GetHousehold(int id);
        Household Create(Household household);
        Household Edit(Household household);
        Household Delete(Household household);

    }
}
