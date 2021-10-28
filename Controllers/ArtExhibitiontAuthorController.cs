﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Art_exhibition.Controllers
{
    [ApiController]
    [Route("/author")]
    public class AuthorController : ControllerBase
    {
        [HttpGet("RegAuthors")]
        public string RegAuthors(string str)
        {
            return str;// "Метод регистрации на выставке"
        }

        [HttpGet("Transfer")]
        public string Transfer(string str)
        {
            return str;//"Метод передачи экспонатов"
        }

        [HttpPut("Create")]
        public string Create(string str)
        {
            return str;// Метод создания
        }

        [HttpGet("Read")]
        public string Read(string str)
        {
            return str;// Метод чтения
        }

        [HttpPatch("Update")]
        public string Update(string str)
        {
            return str;// Метод обновления
        }

        [HttpDelete("Delete")]
        public string Delete(string str)
        {
            return str;// Метод удаления
        }
    }
}