﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Shop.Models;
using Shop.Models.EF;

namespace Shop.Common
{
    public class SettingHelper
    {
        private static ApplicationDbContext db = new ApplicationDbContext();

        public static string GetValue(string key)
        {
            var item = db.SystemSettings.SingleOrDefault(x => x.SettingKey == key);
            if (item != null)
            {
                return item.SettingValue;
            }
            return "";
        }
    }
}