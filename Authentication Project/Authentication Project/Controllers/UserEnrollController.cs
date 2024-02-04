using Authentication_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace Authentication_Project.Controllers
{
    public class UserEnrollController : Controller
    {
        public string value = "";

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UserEnroll e)
        {
          
                UserEnroll er = new UserEnroll();
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-SFDKHS6\\SQLEXPRESS;Integrated Security=true;Initial Catalog=UserDB"))
                {
                    using (SqlCommand cmd = new SqlCommand("SP_EnrollDetail", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@FirstName", e.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", e.LastName);
                        cmd.Parameters.AddWithValue("@Password", e.Password);
                        cmd.Parameters.AddWithValue("@Gender", e.Gender);
                        cmd.Parameters.AddWithValue("@Email", e.Email);
                        cmd.Parameters.AddWithValue("@Phone", e.PhoneNumber);
                        cmd.Parameters.AddWithValue("@status", "INSERT");
                        con.Open();
                      ViewData["result"] = cmd.ExecuteNonQuery();
                       // cmd.ExecuteNonQuery();
                    con.Close();
                    }
                }
           
            return View();
        }
    }
}
