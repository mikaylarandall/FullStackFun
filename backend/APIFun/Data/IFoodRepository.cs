namespace APIFun.Data
{
    public interface IFoodRepository // rules for our template
    {
        IEnumerable<MarriottFood> Foods { get; }
    }
}
