using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternHW.Domain.Entities;
using RepositoryPatternHW.ServiceLayer.Abstracts;
using RepositoryPatternHW.ServiceLayer.DTOs;

namespace RepositoryPatternHW.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimationMovieController : ControllerBase
    {
        private readonly IMapper mapper;

        private readonly IAnimationService animationService;

        public AnimationMovieController(IAnimationService animationService, IMapper mapper)
        {
            this.animationService = animationService;
            this.mapper = mapper;

        }
        [HttpPost]
        public IActionResult Post(AnimationDto animationmovies)
        {
            var mappedAnimationDto = mapper.Map<AnimationMovie>(animationmovies);
            animationService.Add(mappedAnimationDto);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var film=animationService.Get(id);
            return Ok(film);
        }
        [HttpGet]
        public IActionResult GetAllMovies()
        {
            var film = animationService.GetAll();
            return Ok(film);
        }
        [HttpDelete]

        public IActionResult DeleteMovies([FromBody]AnimationMovie movie)
        {

            animationService.Delete(movie);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateMovies([FromBody]AnimationMovie movie)
        {
            animationService.Update(movie);
            return Ok();
        }
    }
}
