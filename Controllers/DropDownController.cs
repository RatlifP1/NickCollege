using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using NickCollege.Areas.Identity.Data;
using NickCollege.Data;
using NickCollege.Models;

namespace NickCollege.Controllers
{

    


    public class DropDownController : Controller
    {
        //    AuthDbContext authdc;


        //    public DropDownController(AuthDbContext authdc)
        //    {
        //        this.authdc = authdc;

        //    }

        //    private readonly UserManager<ApplicationUser> userManager;
        //    [HttpGet]
        //    public IActionResult ListUsers()
        //    {
        //        var userName = authdc.userManager;

        //        var model = new ResultSetViewModel { ListVM = userManager};
        //        return View();
        //    }
    }
}

    //{

    //    public IConfigurationRoot GetConnection()

    //    {

    //        var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json").Build();

    //        return builder;

    //    }



    //    public IActionResult DropDownView()

    //    {
    //        Dropdownlist multi_Dropdownlist = new Dropdownlist

    //        {

    //            userName = GetUserNameList(),

    //            //emplist = GetEmployeeList()

    //        };



    //        return View(multi_Dropdownlist);

    //    }



    //    public List<ApplicationIdentity> GetUserNameList()

    //    {

    //        var connection = GetConnection().GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

    //        SqlConnection con = new SqlConnection(connection);

    //        SqlCommand cmd = new SqlCommand("Select Id,FirstName as Name From [dbo].[AspNetUsers]", con);

    //        con.Open();

    //        SqlDataReader idr = cmd.ExecuteReader();

    //        List<ApplicationIdentity> customers = new List<ApplicationIdentity>();

    //        if (idr.HasRows)

    //            //{

    //            //    while (idr.Read())

    //            //    {

    //            //        customers.Add(new ApplicationIdentity

    //            //        {

    //            //            custId = Convert.ToInt32(idr["customerId"]),

    //            //            custName = Convert.ToString(idr["Name"]),

    //            //        });



    //            //    }

    //            //}

    //            con.Close();

    //        return GetUserNameList();

    //    }

        /*******************************************************************************************************************************************************************************************/



//    }
//}

    

