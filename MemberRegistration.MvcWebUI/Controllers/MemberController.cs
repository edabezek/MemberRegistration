using MemberRegistration.Businnes.Abstract;
using MemberRegistration.Entities.Concrete;
using MemberRegistration.MvcWebUI.Filters;
using MemberRegistration.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MemberRegistration.MvcWebUI.Controllers
{
    public class MemberController : Controller
    {
        private IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        // GET: /Member/Add
        public ActionResult Add()
        {
            return View(new MemberAddViewModel());
        }
        // POST: /Member/Add kayıtlar buradan gidecek arayuzden
        [HttpPost]
        [ExceptionHandler]
        public ActionResult Add(Member member)
        {
            _memberService.AddMember(member);   

            return View(new MemberAddViewModel());
        }
    }
}