using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.CQRS.Commands.BannerCommands
{
    public class CreateBannerCommand
    {
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string VideoDescription { get; set; } = default!;
        public string VideoUrl { get; set; } = default!;
    }
}
