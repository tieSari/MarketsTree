using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MarketsTree.Models
{
    public class MarketsDataModel
    {
        public List<MarketClassification> MarketsData => ReturnData();
        public List<Levels> GroupedLevels => GroupLevels(new List<Levels>(), 0, MarketsData.First(), MarketsData.Count - 1);

        private int _order = 0;
        private static List<MarketClassification> ReturnData()
        {
            return new List<MarketClassification>()
            {
                new MarketClassification("AllMarkets", "DevelopedMarket", "Americas", "Canada", 0.075602),
                new MarketClassification("AllMarkets", "DevelopedMarket", "Americas", "United States", 0.429668),
                new MarketClassification("AllMarkets", "DevelopedMarket", "Europe & Middle East", "Austria", 0.763432),
                new MarketClassification("AllMarkets", "DevelopedMarket", "Europe & Middle East", "Belgium", 0.369533),
                new MarketClassification("AllMarkets", "DevelopedMarket", "Europe & Middle East", "Denmark", 0.478086),
                new MarketClassification("AllMarkets", "DevelopedMarket", "Europe & Middle East", "Finland", 0.769578),
                new MarketClassification("AllMarkets", "DevelopedMarket", "Europe & Middle East", "France", 0.497321),
                new MarketClassification("AllMarkets", "DevelopedMarket", "Europe & Middle East", "Germany", 0.541352),
                new MarketClassification("AllMarkets", "DevelopedMarket", "Europe & Middle East", "Ireland", 0.951393),
                new MarketClassification("AllMarkets", "DevelopedMarket", "Europe & Middle East", "Israel", 0.596547),
                new MarketClassification("AllMarkets", "DevelopedMarket", "Europe & Middle East", "Italy", 0.242434),
                new MarketClassification("AllMarkets", "DevelopedMarket", "Europe & Middle East", "Netherlands", null),
                new MarketClassification("AllMarkets", "DevelopedMarket", "Europe & Middle East", "Norway", 0.392553),
                new MarketClassification("AllMarkets", "DevelopedMarket", "Europe & Middle East", "Portugal", 0.355136),
                new MarketClassification("AllMarkets", "DevelopedMarket", "Europe & Middle East", "Spain", 0.059199),
                new MarketClassification("AllMarkets", "DevelopedMarket", "Europe & Middle East", "Sweden", 0.128012),
                new MarketClassification("AllMarkets", "DevelopedMarket", "Europe & Middle East", "Switzerland",
                    0.397910),
                new MarketClassification("AllMarkets", "DevelopedMarket", "Europe & Middle East", "UK", 0.253234),
                new MarketClassification("AllMarkets", "DevelopedMarket", "Pacific", "Australia", 0.309915),
                new MarketClassification("AllMarkets", "DevelopedMarket", "Pacific", "Hongkong", 0.499744),
                new MarketClassification("AllMarkets", "DevelopedMarket", "Pacific", "Japan", 0.288132),
                new MarketClassification("AllMarkets", "DevelopedMarket", "Pacific", "New Zealand", 0.750317),
                new MarketClassification("AllMarkets", "DevelopedMarket", "Pacific", "Singapore", 0.816234),
                new MarketClassification("AllMarkets", "EmergingMarket", "Americas", "Brazil", 0.615955),
                new MarketClassification("AllMarkets", "EmergingMarket", "Americas", "Chile", 0.289277),
                new MarketClassification("AllMarkets", "EmergingMarket", "Americas", "Colombia", 0.775836),
                new MarketClassification("AllMarkets", "EmergingMarket", "Americas", "Mexico", 0.737671),
                new MarketClassification("AllMarkets", "EmergingMarket", "Americas", "Peru", 0.206788),
                new MarketClassification("AllMarkets", "EmergingMarket", "Europe,Middle East & Africa", "Czech Republic",
                    0.848446),
                new MarketClassification("AllMarkets", "EmergingMarket", "Europe,Middle East & Africa", "Egypt",
                    0.605934),
                new MarketClassification("AllMarkets", "EmergingMarket", "Europe,Middle East & Africa", "Greece",
                    0.124816),
                new MarketClassification("AllMarkets", "EmergingMarket", "Europe,Middle East & Africa", "Hungary", null),
                new MarketClassification("AllMarkets", "EmergingMarket", "Europe,Middle East & Africa", "Poland",
                    0.094122),
                new MarketClassification("AllMarkets", "EmergingMarket", "Europe,Middle East & Africa", "Qatar",
                    0.661242),
                new MarketClassification("AllMarkets", "EmergingMarket", "Europe,Middle East & Africa", "Russia",
                    0.276686),
                new MarketClassification("AllMarkets", "EmergingMarket", "Europe,Middle East & Africa", "South Africa",
                    0.151410),
                new MarketClassification("AllMarkets", "EmergingMarket", "Europe,Middle East & Africa", "Turkey",
                    0.107970),
                new MarketClassification("AllMarkets", "EmergingMarket", "Europe,Middle East & Africa", "UAE", 0.133770),
                new MarketClassification("AllMarkets", "EmergingMarket", "Asia", "China", 0.723930),
                new MarketClassification("AllMarkets", "EmergingMarket", "Asia", "India", 0.289413),
                new MarketClassification("AllMarkets", "EmergingMarket", "Asia", "Indonesia", 0.321349),
                new MarketClassification("AllMarkets", "EmergingMarket", "Asia", "Korea", 0.267374),
                new MarketClassification("AllMarkets", "EmergingMarket", "Asia", "Malaysia", 0.194563),
                new MarketClassification("AllMarkets", "EmergingMarket", "Asia", "Philippines", 0.817582),
                new MarketClassification("AllMarkets", "EmergingMarket", "Asia", "Taiwan", 0.994159),
                new MarketClassification("AllMarkets", "EmergingMarket", "Asia", "Thailand", 0.979013),
                new MarketClassification("AllMarkets", "FrontierMarket", "Americas", "Argentina", 0.053919),
                new MarketClassification("AllMarkets", "FrontierMarket", "Europe & CIS", "Croatia", null),
                new MarketClassification("AllMarkets", "FrontierMarket", "Europe & CIS", "Estonia", 0.073500),
                new MarketClassification("AllMarkets", "FrontierMarket", "Europe & CIS", "Lithuania", 0.605104),
                new MarketClassification("AllMarkets", "FrontierMarket", "Europe & CIS", "Kazakhstan", 0.182970),
                new MarketClassification("AllMarkets", "FrontierMarket", "Europe & CIS", "Romania", 0.423435),
                new MarketClassification("AllMarkets", "FrontierMarket", "Europe & CIS", "Serbia", 0.202100),
                new MarketClassification("AllMarkets", "FrontierMarket", "Europe & CIS", "Slovenia", 0.372518),
                new MarketClassification("AllMarkets", "FrontierMarket", "Africa", "Kenya", 0.596393),
                new MarketClassification("AllMarkets", "FrontierMarket", "Africa", "Mauritius", 0.935584),
                new MarketClassification("AllMarkets", "FrontierMarket", "Africa", "Morocco", 0.615352),
                new MarketClassification("AllMarkets", "FrontierMarket", "Africa", "Nigeria", 0.486448),
                new MarketClassification("AllMarkets", "FrontierMarket", "Africa", "Tunisia", 0.888916),
                new MarketClassification("AllMarkets", "FrontierMarket", "MiddleEast", "Bahrain", 0.443896),
                new MarketClassification("AllMarkets", "FrontierMarket", "MiddleEast", "Jordan", 0.590786),
                new MarketClassification("AllMarkets", "FrontierMarket", "MiddleEast", "Kuwait", 0.054588),
                new MarketClassification("AllMarkets", "FrontierMarket", "MiddleEast", "Lebanon", 0.013413),
                new MarketClassification("AllMarkets", "FrontierMarket", "MiddleEast", "Oman", 0.865510),
                new MarketClassification("AllMarkets", "FrontierMarket", "Asia", "Bangladesh", 0.551477),
                new MarketClassification("AllMarkets", "FrontierMarket", "Asia", "Pakistan", 0.613988),
                new MarketClassification("AllMarkets", "FrontierMarket", "Asia", "Srilanka", null),
                new MarketClassification("AllMarkets", "FrontierMarket", "Asia", "Vietnam", 0.995890)
            };
        }

        public List<Levels> GroupLevels(List<Levels> levels, int level, MarketClassification first, int last)
        {
            var prop = getPropertyInfo(level);

            double? sum = 0;
            var current = first;
            var index = MarketsData.IndexOf(first);
            while (index <= last)
            {
                while (prop.GetValue(current) == prop.GetValue(first) && index <= last)
                {
                    if (current.Exposure != null) sum += current.Exposure;
                    ++index;
                    if(index < MarketsData.Count)
                        current = MarketsData[index];
                }
     
                sum = sum.HasValue? Math.Round(sum.Value, 2): 0;
                var sumLevel = new Levels {Level = level, SumExp = sum, Name = prop.GetValue(first).ToString(),Order = ++_order};
                levels.Add(sumLevel);
                sum = 0;
                
                if (level < 3)
                {
                    levels = GroupLevels(levels, level+1, first, index-1);
                }
                first = current;
                if (last < index)
                {
                    return levels;
                }
            }

            return levels;
        }

        private PropertyInfo getPropertyInfo(int level)
        {
            string name;
            switch (level)
            {
                case 0:
                    name = "Root";
                    break;
                case 1:
                    name = "Classification";
                    break;
                case 2:
                    name = "Market";
                    break;
                case 3:
                    name = "Country";
                    break;
                case 4:
                    name = "Exposure";
                    break;
                default:
                    name = "";
                    break;
            }
            return typeof(MarketClassification).GetProperty(name);
        }
    }

    public class Levels
    {
        public int Level { get; set; }
        public double? SumExp { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
    }
}
