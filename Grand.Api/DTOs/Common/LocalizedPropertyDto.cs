using FluentValidation.Attributes;
using Grand.Api.Validators.Common;
using Grand.Framework.Localization;
using Grand.Framework.Mvc.Models;

namespace Grand.Api.DTOs.Common
{
    [Validator(typeof(LocalizedPropertyValidator))]

    public partial class LocalizedPropertyDto : BaseApiEntityModel, ILocalizedModelLocal
    {
        public string LanguageId { get; set; }

        /// <summary>
        /// Gets or sets the locale key
        /// </summary>
        public string LocaleKey { get; set; }

        /// <summary>
        /// Gets or sets the locale value
        /// </summary>
        public string LocaleValue { get; set; }
    }
}
