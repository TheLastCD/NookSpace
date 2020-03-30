using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NookSpace
{
    class Part
    {
        string PartID, PartNumber, Name, Description, Supplier;
        int AmountInStock;
        float PurchasePrice, MarkupPercentage,RRP, Tax, VAT = 20.00F;

        Part(string PID, string PNum, string PNam, string PDesc,string PSup, int Stock, float PPrice, float PMark,float RP, float T)
        {
            PartID = PID;
            PartNumber = PNum;
            Name = PNam;
            Description = PDesc;
            Supplier = PSup;
            AmountInStock = Stock;
            PurchasePrice = PPrice;
            MarkupPercentage = PMark;
            RRP = RP;
            if (T == -1)
                Tax = VAT;
            else
                Tax = T;
        }
        public void Increment_Stock(int NewStock)
        {
            AmountInStock = NewStock;
        }


    }
}
