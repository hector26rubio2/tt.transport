namespace Transport.Validators
{

    using FluentValidation;
    public abstract class BaseValidator<T> : AbstractValidator<T>
    {
        protected BaseValidator()
        {            
        }
    }
}
