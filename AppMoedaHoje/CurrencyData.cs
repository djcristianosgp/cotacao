using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AppMoedaHoje
{
    public class CurrencyData
    {
        
        public string Code { get; set; }
        public string Codein { get; set; }
        public string Name { get; set; }
        public string High { get; set; }
        public string Low { get; set; }
        public string VarBid { get; set; }
        public string PctChange { get; set; }
        public string Bid { get; set; }
        public string Ask { get; set; }
        public string Timestamp { get; set; }
        public string Create_Date { get; set; }
        public decimal HighValue => decimal.Parse(High, System.Globalization.CultureInfo.InvariantCulture);
        public decimal LowValue => decimal.Parse(Low, System.Globalization.CultureInfo.InvariantCulture);
    }
}
