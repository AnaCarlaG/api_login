using Login.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Controllers
{
    [ApiController]
    public class LoginController :Controller
    {
        LoginModel model = new LoginModel();
        [HttpGet]
        public ActionResult<LoginModel> logar(string senha, string user)
        {
            foreach(LoginModel model in model.list_login){
                if(model.senha == senha && model.user == user)
                {
                    var objLogin = model;
                    return Ok(objLogin);
                }
                return NotFound();
            }
            return BadRequest();
        }
    }
}
