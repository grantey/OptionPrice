namespace OptionPricingModels.PricingModels
{
    public interface IOptionsPricingModel
    {
        void Compute(OptionPosition option);
    }
}