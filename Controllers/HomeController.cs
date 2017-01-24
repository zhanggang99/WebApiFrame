using System;
using Microsoft.AspNetCore.Mvc;
using WebApiFrame.Models;
using Microsoft.Extensions.Logging;

namespace WebApiFrame.Controllers{

    public class HomeController:Microsoft.AspNetCore.Mvc.Controller
    {
        private ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger){
            _logger=logger;
        }

        public IActionResult Index()
        {
            return new ObjectResult("hello");
        }
        
        [HttpGetAttribute("{id}")]
        public IActionResult Get(int id){
            //演示日志输出
            _logger.LogInformation("this is a infomation log ");
            _logger.LogWarning("this is a waring log ");
            _logger.LogError("this is a error log ");
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
