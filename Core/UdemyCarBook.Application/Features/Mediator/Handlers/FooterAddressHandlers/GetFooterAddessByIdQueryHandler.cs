﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Queries.FooterAdressQueries;
using UdemyCarBook.Application.Features.Mediator.Results.FooterAddressResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class GetFooterAddessByIdQueryHandler : IRequestHandler<GetFooterAddressByIdQuery, GetFooterAddressByIdQueryResult>
    {
        private readonly IRepository<FooterAdressEntity> _repository;

        public GetFooterAddessByIdQueryHandler(IRepository<FooterAdressEntity> repository)
        {
            _repository = repository;
        }

        public async Task<GetFooterAddressByIdQueryResult> Handle(GetFooterAddressByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetFooterAddressByIdQueryResult
            {
                Id = value.Id,
                Description = value.Description,
                Email = value.Email,
                Phone = value.Phone,
                Adress = value.Adress
            };
        }
    }
}
