using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API_Demo.Data;
using API_Demo.Model;
using Microsoft.EntityFrameworkCore;

namespace API_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : Controller
    {
        [HttpGet]
        public IEnumerable<Question> Questions()
        {
            return HardwareStoreData.Questions.ToList();
        }

        [HttpPost("{productId}")]
        public IActionResult CreateQuestionForProduct(int productId, [FromBody] string question)
        {
            if (HardwareStoreData.Products.All(c => c.Id != productId)) return NotFound();
            var questionToAdd = new Question()
            {
                Value = question
            };
            HardwareStoreData.Products
                .Single(c => c.Id == productId)
                .Questions
                .Add(questionToAdd);
            HardwareStoreData.Questions.Add(questionToAdd);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateQuestion([FromBody] Question question, int id)
        {
            if (HardwareStoreData.Questions.All(c => c.Id != id)) return NotFound();
            
            var questionToUpdate = HardwareStoreData.Questions.Single(c => c.Id == id);
            questionToUpdate.Answer = question.Answer;
            questionToUpdate.Value = question.Value;
            
            return Ok();
        }
        
        [HttpDelete("{id}")]
        public IActionResult DeleteQuestion(int id)
        {
            if (HardwareStoreData.Questions.All(c => c.Id != id)) return NotFound();
            HardwareStoreData.Questions.RemoveAll(c => c.Id == id);
            return Ok();
        }
    }
}