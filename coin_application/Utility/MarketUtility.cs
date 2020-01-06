using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using coin_application.Models;

namespace coin_application.Utility
{
    public class MarketUtility
    {
        private static MyDbContext db = new MyDbContext();
        private static List<Market> _listMarkets;

        public static List<Market> GetMarkets()
        {
            if (_listMarkets == null)
            {
                _listMarkets = db.Markets.ToList();
            }

            return _listMarkets;
        }

        public static List<SelectListItem> GetMarketsDropDownList()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            if (_listMarkets == null)
            {
                _listMarkets = db.Markets.ToList();
            }

            foreach (var market in _listMarkets)
            {
                list.Add(new SelectListItem { Text = market.MarketName, Value = market.MarketId });
            }

            return list;
        }

        public static void SetMarkets(List<Market> markets)
        {
            _listMarkets = markets;
        }

    }
}