using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarketsTree.Models
{
    public class MarketClassification : IEquatable<MarketClassification>
    {
        public string Root { get; set; }
        public string Classification { get; set; }
        public string Market { get; set; }
        public string Country { get; set; }
        public double? Exposure { get; set; }

        public MarketClassification()
        { }
        public MarketClassification(string root, string classification, string market, string country, double? exposure)
        {
            Root = root;
            Classification = classification;
            Market = market;
            Country = country;
            Exposure = exposure;
        }

        public bool Equals(MarketClassification other)
        {
            return other != null && Root == other.Root &&
                Classification == other.Classification && 
                Country == other.Country && 
                Market == other.Market;
        }
    }
}