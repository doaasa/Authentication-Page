using Authentication_Project.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Authentication_Project.Controllers
{
    public class UserLoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserEnroll e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SFDKHS6\\SQLEXPRESS;Integrated Security=true;Initial Catalog=UserDB");
            string SqlQuery = "select Email,Password from UserInfo where Email=@Email and Password=@Password";
            con.Open();
            SqlCommand cmd = new SqlCommand(SqlQuery, con);
            cmd.Parameters.AddWithValue("@Email", e.Email);
            cmd.Parameters.AddWithValue("@Password", e.Password);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                return RedirectToAction("Welcome", "UserLogin", new { email = e.Email });
            }
            else
            {
                ViewData["Message"] = "User Login Details Failed!!";
            }

            con.Close();
            return View();
        }


        [HttpGet]
        public ActionResult Welcome(string email)
        {
            UserEnroll user = new UserEnroll();
            DataSet ds = new DataSet();

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-SFDKHS6\\SQLEXPRESS;Integrated Security=true;Initial Catalog=UserDB"))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetEnrollmentDetails", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar, 30).Value = email;
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    List<UserEnroll> userlist = new List<UserEnroll>();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        UserEnroll uobj = new UserEnroll();
                        uobj.ID = Convert.ToInt32(ds.Tables[0].Rows[i]["ID"].ToString());
                        uobj.FirstName = ds.Tables[0].Rows[i]["FirstName"].ToString();
                        uobj.LastName = ds.Tables[0].Rows[i]["LastName"].ToString();
                        uobj.Password = ds.Tables[0].Rows[i]["Password"].ToString();
                        uobj.Email = ds.Tables[0].Rows[i]["Email"].ToString();
                        uobj.PhoneNumber = ds.Tables[0].Rows[i]["Phone"].ToString();
                        uobj.Gender = ds.Tables[0].Rows[i]["Gender"].ToString();

                        userlist.Add(uobj);
                    }
                    user.Enrollsinfo = userlist;
                }
                con.Close();
            }

            return View(user);
        }
        public IActionResult Logout()
        {
            return RedirectToAction("Index", "UserLogin");
        }
    }
}