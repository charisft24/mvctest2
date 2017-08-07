using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalR.Controllers
{
    public class HomeController : Controller
    {        
        //
        // GET: /Home/        
        public ActionResult Index()
        {
            ViewBag.Why = HttpUtility.UrlDecode("%EC%B0%BD%3F%ED%98%A2");
            return View();
        }


        public ActionResult Print()
        {
            return View(CreateLinked());
        }   
     
        private LinkedList<string> CreateLinked()
        {            
            LinkedList<string> myLink = new LinkedList<string>();
            LinkedListNode<string> preUnit = new LinkedListNode<string>(string.Empty);


            for (int i = 0; i < 10; i++ )
            {
                LinkedListNode<string> unit = new LinkedListNode<string>("node" + i);
                
                if (i == 0)
                {
                    myLink.AddFirst(unit);                    
                }
                else
                {
                    myLink.AddAfter(preUnit, unit);
                }

                preUnit = unit;

            }

            LinkedListNode<string> unit2 = new LinkedListNode<string>("끼어들기");
            LinkedListNode<string> unit3 = myLink.Find("node1");


            myLink.AddBefore(unit3, unit2);


            return myLink;
        }
    }
}
