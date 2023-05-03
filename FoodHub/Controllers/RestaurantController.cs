using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FoodHub.Controllers
{
    public class RestaurantController : ApiController
    {
        [HttpGet]
        [Route("api/restaurants")]
        public HttpResponseMessage Restaurants()
        {
            try
            {
                var data = RestaurantService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/restaurants/{id}")]
        public HttpResponseMessage Post(string id)
        {
            try
            {
                var data = RestaurantService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/restaurants/add")]
        public HttpResponseMessage Add(RestaurantDTO res)
        {
            try
            {
                var data = RestaurantService.Add(res);
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
        [Route("Api/restaurants/update")]
        public HttpResponseMessage Update(RestaurantDTO obj)
        {
            try
            {
                var data = RestaurantService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/restaurants/delete/{id}")]
        public HttpResponseMessage Delete(int UN)
        {
            var res = Order_ItemsService.Delete(UN);
            return Request.CreateResponse(HttpStatusCode.OK, res);

        }

    }
}
