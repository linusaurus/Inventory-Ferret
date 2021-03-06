﻿using DataLayer.Entities;
using System;
using System.Collections.Generic;

namespace Weaselware.InventoryFerret.Wrapper
{
    public class PurchaseLineItemWrapper : ModelWrapper<PurchaseLineItem>
    {
        public PurchaseLineItemWrapper(PurchaseLineItem model) : base(model)
        {
        }

        public int LineID { get { return Model.LineID; } }

        public string Description
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public int PartID
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }

        public int Uom
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }

        public decimal? UnitCost
        {
            get { return GetValue<decimal>(); }
            set
            {
                SetValue(value);
                if (UnitCost.HasValue || Qnty > decimal.Zero)
                { Extended = Qnty * UnitCost.Value; }

            }
        }

        public decimal Qnty
        {
            get { return GetValue<decimal>(); }
            set
            {
                SetValue(value);
                if (UnitCost.HasValue || Qnty > decimal.Zero)
                { Extended = Qnty * UnitCost.Value; }
            }
        }

        public decimal Extended
        {
            get { return GetValue<decimal>(); }
            set { SetValue(value); }
        }

    }  
    
}
