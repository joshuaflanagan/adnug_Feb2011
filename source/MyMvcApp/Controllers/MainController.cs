using System.Web.Mvc;
using MyMvcApp.Models;

namespace MyMvcApp.Controllers
{
    public class MainController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EditPatient()
        {
            return View(new EditPatientModel {Patient = new Patient()});
        }

        public ActionResult MakeAppointment()
        {
            return View(new MakeAppointmentModel { Appointment = new Appointment() });
        }

        public ActionResult Help(string topic)
        {
            return View(new HelpViewModel{Topic = topic});
        }
    }

    public class HelpViewModel
    {
        public string Topic { get; set; }
    }

    public class EditPatientModel
    {
        public Patient Patient { get; set; }
    }

    public class MakeAppointmentModel
    {
        public Appointment Appointment { get; set; }
    }
}
