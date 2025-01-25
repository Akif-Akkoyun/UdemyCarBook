using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Queries.AppUserQueries;
using UdemyCarBook.Application.Features.Mediator.Results.AppUserResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.AppUserHandlers
{
    public class GetCheckAppUserQueryHandler : IRequestHandler<GetCheckAppUserQuery, GetCheckAppUserQueryResult>
    {
        private readonly IRepository<AppUserEntity> _appUserRepository;
        private readonly IRepository<AppRoleEntity> _appRoleRepository;

        public GetCheckAppUserQueryHandler(IRepository<AppUserEntity> appUserRepository, IRepository<AppRoleEntity> appRoleRepository)
        {
            _appUserRepository = appUserRepository;
            _appRoleRepository = appRoleRepository;
        }

        public async Task<GetCheckAppUserQueryResult> Handle(GetCheckAppUserQuery request, CancellationToken cancellationToken)
        {
            var values = new GetCheckAppUserQueryResult();
            var user = await _appUserRepository.GetByFilterAsync(x => x.UserName == request.UserName && x.Password == request.Password);
            if (user != null)
            {
                values.Id = user.Id;
                values.UserName = user.UserName;
                var role = await _appRoleRepository.GetByFilterAsync(x => x.Id == user.AppRoleId);
                values.Role = role.AppRoleName;
                values.IsExist = true;
            }
            else
            {
                values.IsExist = false;
            }
            return values;
        }
    }
}
