﻿using System;
using System.Collections.Generic;

namespace MSM.Core.Models
{
    public class Basket
    {
        public Basket()
        {
            Id = new Guid();
            BasketItem = new List<BasketItem>();
        }
        
        public Guid Id { get; set; } 

        public List<BasketItem> BasketItem { get; set; }

    }

    
}