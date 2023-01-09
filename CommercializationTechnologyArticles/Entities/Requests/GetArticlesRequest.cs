namespace CommercializationTechnologyArticles.Entities.Requests
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class GetArticlesRequest : IValidatableObject
    {
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public int NumberRecords { get; set; }
        public int Page { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new();

            if (CategoryId != 0
                && SubCategoryId != 0)
            {
                errors.Add(new ValidationResult("Solo se permite hacer un tipo de solicitud a la vez, ya sea por categoría o subcategoría", new[] { nameof(CategoryId), nameof(SubCategoryId) }));
            }

            return errors;
        }
    }
}
