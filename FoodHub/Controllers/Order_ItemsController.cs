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
    public class Order_ItemsController : ApiController
    {
        [HttpGet]
        [Route("api/order")]
        public HttpResponseMessage OrderItems()
        {
            try
            {
                var data = Order_ItemsService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/order/{id}")]
        public HttpResponseMessage Post(int id)
        {
            try
            {
                var data = Order_ItemsService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/order/add")]
        public HttpResponseMessage Add(Order_ItemsDTO res)
        {
            try
            {
                var data = Order_ItemsService.Add(res);
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
        [Route("Api/order/update")]
        public HttpResponseMessage Update(Order_ItemsDTO obj)
        {
            try
            {
                var data = Order_ItemsService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/order/delete/{id}")]
        public HttpResponseMessage Delete(int UN)
        {
            var res = Order_ItemsService.Delete(UN);
            return Request.CreateResponse(HttpStatusCode.OK, res);

        }
    }
}
