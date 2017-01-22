using System;
using Microsoft.AspNetCore.Mvc;
using WebApiFrame.Models;

namespace WebApiFrame.Controllers{


    [Route("api/[controller]")]
    public class UsersController:Microsoft.AspNetCore.Mvc.Controller
    {
        [HttpGetAttribute("{id}")]
        public IActionResult Get(int id){
            var user = new User();
            user.Id=id;
            user.Name="Name:"+id;
            user.Sex="male";
            return new ObjectResult(user);
        }
        [HttpPostAttribute]
        public IActionResult Post([FromBody] User user){
            if(user == null){
                return BadRequest();
            }
            //todo：新增操作
            user.Id = new Random().Next(1,10);
            return CreatedAtAction("Get",new {id = user.Id},user);
        }

        [HttpPutAttribute("{id}")]
        public IActionResult Put(int id,[FromBodyAttribute] User user){
            if(user==null){
                return BadRequest();
            }
            //todo:更新操作
            return new NoContentResult();
        }

        [HttpDeleteAttribute("{id}")]
        public void Delete(int id){
            //todo:删除操作

        }

    }
}
