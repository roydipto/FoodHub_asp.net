using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FoodHub.Controllers
{
    public class Menu_ItemsController : ApiController
    {
        [HttpGet]
        [Route("api/menu")]
        public HttpResponseMessage Items()
        {
            try
            {
                var data = Menu_ItemService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/menu/{id}")]
        public HttpResponseMessage Post(int id)
        {
            try
            {
                var data = Menu_ItemService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/menu/add")]
        public HttpResponseMessage Add(Menu_ItemsDTO res)
        {
            try
            {
                var data = Menu_ItemService.Add(res);
                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { });
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPost]
        [Route("Api/menu/update")]
        public HttpResponseMessage Update(Menu_ItemsDTO obj)
        {
            try
            {
                var data = Menu_ItemService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/menu/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var res = Menu_ItemService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, res);

        }
    }
}
