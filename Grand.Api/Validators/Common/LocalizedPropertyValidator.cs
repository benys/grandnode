using FluentValidation;
using Grand.Api.DTOs.Common;
using Grand.Framework.Validators;
using Grand.Services.Localization;

namespace Grand.Api.Validators.Common
{
    public class LocalizedPropertyValidator : BaseGrandValidator<LocalizedPropertyDto>
    {
        public LocalizedPropertyValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.Id).Empty().WithMessage(localizationService.GetResource("Api.Common.LocalizedProperty.Fields.Id.NotRequired"));
            RuleFor(x => x.LanguageId).Empty().WithMessage(localizationService.GetResource("Api.Common.LocalizedProperty.Fields.LanguageId.Required"));
            RuleFor(x => x.LocaleKey).Empty().WithMessage(localizationService.GetResource("Api.Common.LocalizedProperty.Fields.LocaleKey.Required"));
            RuleFor(x => x.LocaleValue).Empty().WithMessage(localizationService.GetResource("Api.Common.LocalizedProperty.Fields.LocaleValue.Required"));
        }
    }
}
