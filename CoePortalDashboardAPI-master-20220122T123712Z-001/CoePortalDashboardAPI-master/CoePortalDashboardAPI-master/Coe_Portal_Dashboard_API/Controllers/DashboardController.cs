using Coe_Portal_Dashboard_API.Models;
using Coe_Portal_Dashboard_API.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Coe_Portal_Dashboard_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IService<Accelerator> iserv;
        public DashboardController(IService<Accelerator> _iserv)
        {
            iserv = _iserv;
        }



        [Route("GetAllAccelerators")]
        [HttpGet]
        public IActionResult GetAllAccelerators()
        {
            return Ok(iserv.GetAllAccelerators());
        }


        [Route("AcceleratorbyId")]
        [HttpGet]
        public ActionResult AcceleratorbyId(int id)
        {
               
                return Ok(iserv.AcceleratorById(id));

            

            
        }
        [Route("CreateAccelerators")]
        [HttpPost]
        public ActionResult CreateAccelerators(Accelerator accelerator)
        {

            return Ok(iserv.CreateAccelerators(accelerator));



        }
        [Route("DeleteAccelerators")]
        [HttpDelete]
        public ActionResult DeleteAccelerators(int acceleratorId)
        {


            return Ok(iserv.DeleteAccelerators(acceleratorId));





        }
        [Route("UpdateAccelerators")]
        [HttpPut]
        public ActionResult UpdateAccelerators(Accelerator acceleratorId, int id)
        {


            return Ok(iserv.UpdateAccelerators(acceleratorId, id));



        }

    }
}
