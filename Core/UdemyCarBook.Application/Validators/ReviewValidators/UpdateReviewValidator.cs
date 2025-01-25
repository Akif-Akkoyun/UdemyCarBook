using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Commads.ReviewCommands;

namespace UdemyCarBook.Application.Validators.ReviewValidators
{
    public class UpdateReviewValidator : AbstractValidator<UpdateReviewCommand>
    {
        public UpdateReviewValidator()
        {
            RuleFor(p => p.CustomerName)
                .NotEmpty().WithMessage("Lütfen müşteri adını boş geçmeyiniz.")
                .NotNull()
                .MinimumLength(5).WithMessage("Adınız en az 5 karakterli olmalıdır ");
            RuleFor(p => p.RaytingValue).NotEmpty()
                .WithMessage("Lütfen puanlama yapınız");
            RuleFor(p => p.Comment).NotEmpty()
                .WithMessage("Lütfen yorum yapınız")
                .MinimumLength(50).WithMessage("Yorumunuz en az 50 karakterli olmalıdır")
                .MaximumLength(500).WithMessage("Yorumunuz en fazla 500 karakterli olabilir");
            RuleFor(p => p.CustomerImage).NotEmpty()
                .WithMessage("Lütfen müşteri resmi ekleyiniz");
        }
    }
}
