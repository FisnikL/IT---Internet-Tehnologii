using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _151027_LAB3_IT.Models;

namespace _151027_LAB3_IT.Controllers
{
    public class FriendController : Controller
    {
        private static List<Friend> friends = new List<Friend>()
        {
            new Friend(0, "Fisnik Limani", "Kumanovo"),
            new Friend(1, "Musli Ademi", "Tetovo"),
            new Friend(2, "Kadir Ali", "Gostivar"),
            new Friend(3, "Ylli Sulejmani", "Struga")
        };
        static int big_id = 0;
        // GET: Friend1
        public ActionResult Index()
        {
            return RedirectToAction("ShowAllFriends", "Friend");
        }

        public ActionResult ShowAllFriends()
        {
            return View(friends);
        }

        public ActionResult AddFriend()
        {
            Friend model = new Friend();
            return View();
        }

        [HttpPost]
        public ActionResult AddFriend(Friend model)
        {
            if (!ModelState.IsValid)
                return View("AddFriend", model);

            friends.Add(model);
            return RedirectToAction("ShowAllFriends", "Friend");
        }

        public ActionResult EditFriend(int id)
        {
            big_id = id;
            var model = friends.ElementAt(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult EditFriend(Friend model)
        {
            if (!ModelState.IsValid)
                return View("EditFriend", model);

            friends.RemoveAt(big_id);
            friends.Insert(big_id, model);
            return RedirectToAction("ShowAllFriends", "Friend");
        }

        public ActionResult DeleteFriend(int id)
        {
            big_id = id;
            friends.RemoveAt(big_id);
            return RedirectToAction("ShowAllFriends", "Friend");
        }
    }
}