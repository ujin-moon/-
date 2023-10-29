using StatTrack.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.Mvc;
using System.Windows.Forms;

namespace StatTrack.Controllers
{
    public class HomeController : Controller
    {
        StatContext db = new StatContext();

        public ActionResult Index()
        {
            ViewData["TeamList"] = db.Teams.ToList();
            ViewData["PlayersList"] = db.Players.ToList();
            ViewData["TeamPlayerList"] = db.TeamPlayers.ToList();
            return View();
        }

        public ActionResult Teams(string page = "0", string sortOrder = "default")
        {
            if (page == null)
                ViewData["Page"] = 0;
            else
                ViewData["Page"] = Convert.ToInt32(page);

            ViewData["PlayersList"] = db.Players.ToList();
            ViewData["TeamPlayerList"] = db.TeamPlayers.ToList();

            if (sortOrder != "default")
            {
                var Teams = from s in db.Teams
                            select s;
                switch (sortOrder)
                {
                    case "A-Z":
                        Teams = Teams.OrderBy(s => s.Name);
                        ViewData["SortOrder"] = "A-Z";
                        ViewData["TeamList"] = Teams.ToList();
                        break;
                    case "Z-A":
                        Teams = Teams.OrderByDescending(s => s.Name);
                        ViewData["SortOrder"] = "Z-A";
                        ViewData["TeamList"] = Teams.ToList();
                        break;
                }
            }
            else
            {
                ViewData["TeamList"] = db.Teams.ToList();
                ViewData["SortOrder"] = "default";
            }

            return View();
        }

        public ActionResult Players(string searchString = null)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
                ViewData["PlayersList"] = db.Players.Where(s => s.Nickname.ToUpper().Contains(searchString.ToUpper())).ToList();
            }
            else
                ViewData["PlayersList"] = db.Players.ToList();

            return View();
        }

        public ActionResult Administration(string Login, string Password)
        {
            DialogResult isPasswordWrong = DialogResult.Cancel;
            foreach (var data in db.LogDatas)
            {
                if (data.Login == Login)
                {
                    if (data.Password == Password)
                    {
                        ViewData["db"] = db;

                        return View();
                    }
                    else if (data.Password != Password)
                    {
                        isPasswordWrong = MessageBox.Show("Wrong password!", "Error", MessageBoxButtons.OK);
                        break;
                    }
                }
            }

            if (isPasswordWrong != DialogResult.OK)
                MessageBox.Show("Wrong login!", "Error", MessageBoxButtons.OK);

            return View("Authefication");
        }

        public ActionResult Authefication()
        {
            return View(db.LogDatas.ToList());
        }

        public ActionResult AddTeam(string NameAdd)
        {
            if (NameAdd == null)
            {
                MessageBox.Show("Field name cannot be empty!", "Error", MessageBoxButtons.OK);
                ViewData["db"] = db;
                return View("Administration");
            }
            else
            {
                db.Teams.Add(new Team() { Name = NameAdd });
                db.SaveChanges();
                ViewData["db"] = db;
                return View("Administration");
            }
        }

        public ActionResult EditTeam(string ID, string NameEdit)
        {
            bool isValid = false;
            foreach (var t in db.Teams)
            {
                if (t.ID == Convert.ToInt32(ID))
                    isValid = true;
            }

            if (NameEdit == null)
                isValid = false;

            if (isValid == false)
            {
                MessageBox.Show("Not valid ID!", "Error", MessageBoxButtons.OK);
                ViewData["db"] = db;
                return View("Administration");
            }
            else
            {
                Team team = db.Teams.Find(Convert.ToInt32(ID));
                team.Name = NameEdit;

                db.Entry(team).State = EntityState.Modified;
                db.SaveChanges();
                ViewData["db"] = db;
                return View("Administration");
            }
        }

        public ActionResult AddPlayer(string Nickname, string NamePlayer, string Surname, string Age, string Country, string Role)
        {
            if (Nickname == null || NamePlayer == null || Surname == null || Age == null || Country == null)
            {
                MessageBox.Show("Fields cannot be empty!", "Error", MessageBoxButtons.OK);
                ViewData["db"] = db;
                return View("Administration");
            }
            else if (int.TryParse(Age, out int numericValue) == false)
            {
                MessageBox.Show("Field age must be a number!", "Error", MessageBoxButtons.OK);
                ViewData["db"] = db;
                return View("Administration");
            }
            else if (isHaveDigits(NamePlayer) == true || isHaveDigits(Surname) == true || isHaveDigits(Country) == true)
            {
                MessageBox.Show("Fields name, surname, country cannot contain digits!", "Error", MessageBoxButtons.OK);
                ViewData["db"] = db;
                return View("Administration");
            }
            else
            {
                db.Players.Add(new Player() { Nickname = Nickname, Name = NamePlayer, Surname = Surname, Age = Convert.ToInt32(Age), Country = Country, Role = Role });
                db.SaveChanges();
                ViewData["db"] = db;
                return View("Administration");
            }
        }

        public static bool isHaveDigits(string str)
        {
            foreach (char c in str)
            {
                if (Char.IsDigit(c))
                    return true;
            }
            return false;
        }

        public ActionResult DeletePlayer(string IDPlayerDelete)
        {
            bool isValid = false;

            foreach (var t in db.Players)
            {
                if (t.ID == Convert.ToInt32(IDPlayerDelete))
                {
                    isValid = true;
                }
            }

            if (isValid == false)
            {
                MessageBox.Show("Not valid ID!", "Error", MessageBoxButtons.OK);
                ViewData["db"] = db;
                return View("Administration");
            }
            else
            {
                Player pl = db.Players.Find(Convert.ToInt32(IDPlayerDelete));
                db.Entry(pl).State = EntityState.Deleted;
                db.SaveChanges();
                ViewData["db"] = db;
                return View("Administration");
            }
        }

        public ActionResult EditPlayer(string IDPlayer, string NicknameE, string NamePlayerE, string SurnameE, string AgeE, string CountryE, string RoleE)
        {
            try
            {
                bool isValid = true;

                if (NicknameE == null || NamePlayerE == null || SurnameE == null || AgeE == null || CountryE == null)
                    isValid = false;

                else if (int.TryParse(AgeE, out int numericValue) == false)
                    isValid = false;

                else if (isHaveDigits(NamePlayerE) == true || isHaveDigits(SurnameE) == true || isHaveDigits(CountryE) == true)
                    isValid = false;

                bool isContainid = false;
                foreach (var p in db.Players)
                    if (p.ID == Convert.ToInt32(IDPlayer)) { isContainid = true; break; }

                if (isValid == false)
                {
                    MessageBox.Show("Not valid information!", "Error", MessageBoxButtons.OK);
                    ViewData["db"] = db;
                    return View("Administration");
                }
                else if (isContainid == false)
                {
                    MessageBox.Show("Not valid ID!", "Error", MessageBoxButtons.OK);
                    ViewData["db"] = db;
                    return View("Administration");
                }
                else
                {
                    Player player = db.Players.Find(Convert.ToInt32(IDPlayer));
                    player.Nickname= NicknameE;
                    player.Name= NamePlayerE;
                    player.Surname=SurnameE; player.Country=CountryE;
                    player.Age = Convert.ToInt32(AgeE);
                    player.Role = RoleE;
                    db.Entry(player).State = EntityState.Modified;
                    db.SaveChanges();
                    ViewData["db"] = db;
                    return View("Administration");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK);
                ViewData["db"] = db;
                return View("Administration");
            }
        }
    }
}