using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specFlowCalculator
{
    public class Restaurant
    {
        public float StarterCost = 4.00F;
        public float MainsCost = 7.00F;
        public float DrinksCost = 2.50F;
        public float ServiceTax =0.1F;
        public float DiscountedDrinksRate = 0.3F;
        public int noOfStarters { get; set; }
        public int noOfPeople { get; set; }
        public int noOfMains { get; set; }
        public int noOfDrinks { get; set; }
        public int noOfMainsAfterUpdate { get; set; }
        public int noOfDrinksAfterUpdate { get; set; }

        public int noOfStarterCancelled { get; set; }
        public int noOfMainsCancelled { get; set; }
        public int noOfDrinksCancelled { get; set; }

        public float createOrder()
        {
           float totalBill = (noOfStarters * StarterCost) + (noOfMains * MainsCost) + (noOfDrinks * DrinksCost);
             totalBill = totalBill + (ServiceTax * totalBill);
            return totalBill;
        }
        public float createOrderBeforeSeven()
        {
            
            float actualDrinksCostAfterDiscount=DrinksCost-(DiscountedDrinksRate*DrinksCost);
           float totalBill = (noOfStarters * StarterCost) + (noOfMains * MainsCost) + (noOfDrinks * actualDrinksCostAfterDiscount);
            totalBill = totalBill + (ServiceTax * totalBill);
            return totalBill;
        }

        public float calculateBillAfterOrderUpdate()
        {
            float totalBill = (noOfStarters * StarterCost) + (noOfMains * MainsCost) + (noOfDrinks * DrinksCost);
              float totalBillAfterUpdate= totalBill+((noOfMainsAfterUpdate * MainsCost) + (noOfDrinksAfterUpdate * DrinksCost));
            totalBillAfterUpdate=totalBillAfterUpdate+ (ServiceTax * totalBillAfterUpdate);
            return totalBillAfterUpdate;
        }

        public float calculateFinalBillAfterCancellation()
        {
            float totalBill = (noOfStarters * StarterCost) + (noOfMains * MainsCost) + (noOfDrinks * DrinksCost);
            float finalBill = totalBill-((noOfStarterCancelled * StarterCost) + (noOfMainsCancelled * MainsCost) + (noOfDrinksCancelled * DrinksCost));
            finalBill = finalBill+ (ServiceTax * finalBill);
                return finalBill;
        }

    }
}
