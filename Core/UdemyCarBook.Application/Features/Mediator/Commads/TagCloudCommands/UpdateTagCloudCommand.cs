﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.Mediator.Commads.TagCloudCommands
{
    public class UpdateTagCloudCommand : IRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int BlogID { get; set; }
    }
}