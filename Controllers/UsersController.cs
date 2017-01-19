using System;
using Microsoft.AspNetCore.Mvc;
using WebApiFrame.Models;

namespace WebApiFrame.Controllers{

    public class UsersController:Microsoft.AspNetCore.Mvc.Controller{
        [RouteAttribute("{id}")]
        public IActionResult Get(int id){
            var user = new User();
            user.Id=id;
            user.Name="Name:"+id;
            user.Sex="male";
            return new ObjectResult(user);
        }
        //http://www.cnblogs.com/niklai/p/5658876.html
    }
}
