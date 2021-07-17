using NewsApi.Models;
using NewsApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace NewsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly NewsService _newsService;

        public NewsController(NewsService newsService)
        {
            _newsService = newsService;
        }

        [HttpGet]
        public ActionResult<List<News>> Get() =>
            _newsService.Get();

        [HttpGet("{id:length(24)}", Name = "GetNews")]
        public ActionResult<News> Get(string id)
        {
            var news = _newsService.Get(id);

            if (news == null)
            {
                return NotFound();
            }

            return news;
        }

        [HttpPost]
        public ActionResult<News> Create(News news)
        {
            _newsService.Create(news);

            return CreatedAtRoute("GetNews", new { id = news.id.ToString() }, news);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, News newsIn)
        {
            var news = _newsService.Get(id);

            if (news == null)
            {
                return NotFound();
            }

            _newsService.Update(id, newsIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var news = _newsService.Get(id);

            if (news == null)
            {
                return NotFound();
            }

            _newsService.Remove(news.id);

            return NoContent();
        }
    }
}