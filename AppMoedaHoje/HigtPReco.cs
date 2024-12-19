namespace AppMoedaHoje
{
    public class HigtPReco
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal High { get; set; } = 0;
        public decimal Low { get; set; } = 0;
        public decimal Ask { get; set; } = 0;
        public string CreateDate { get; set; }
    }
}
