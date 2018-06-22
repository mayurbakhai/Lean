﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantConnect.Securities.Graph
{
    interface IShortestPathSearch
    {
        CurrencyEdge AddEdge(string currencyPair, SecurityType type);

        CurrencyEdge AddEdge(string baseCode, string quoteCode, SecurityType type);

        CurrencyPath FindShortestPath(string startCode, string endCode);
    }
}
