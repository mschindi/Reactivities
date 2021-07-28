using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Activities;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API1.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly IMediator mediator;

        public ActivitiesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivites()
        {
            return await this.mediator.Send(new List.Query());
        }

        [HttpGet("{id}")] // activities/ id
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return Ok();
        }
        
    }
}