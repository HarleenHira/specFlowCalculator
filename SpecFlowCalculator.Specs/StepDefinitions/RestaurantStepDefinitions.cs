using specFlowCalculator;

namespace SpecFlowCalculator.Specs.StepDefinitions
{
    [Binding]
    public sealed class RestaurantStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly Restaurant _restaurant = new Restaurant();
        private float _totalCost;

        [Given(@"the service tax is (.*)% of total bill")]
        public void GivenTheServiceTaxIsOfTotalBill(float serviceTax)
        {
            _restaurant.ServiceTax = serviceTax;
        }

        [When(@"no of people arrived is (.*)")]
        public void WhenNoOfPeopleArrivedIs(int noOfPeople)
        {
            _restaurant.noOfPeople = noOfPeople;
        }
        [Then(@"the calculatedBill should be (.*)")]
        public void ThenTheCalculatedBillShouldBe(float totalCost)
        {
            _totalCost = _restaurant.createOrder();
            _totalCost.Should().Be(totalCost);
        }
        [Given(@"the number of starter is (.*)")]
        public void GivenTheNumberOfStarterIs(int noOfStarters)
        {
            _restaurant.noOfStarters = noOfStarters;
        }
        [Given(@"the number of mains is (.*)")]
        public void GivenTheNumberOfMainsIs(int noOfMains)
        {
            _restaurant.noOfMains = noOfMains;
        }
        [Given(@"the number of drinks is (.*)")]
        public void GivenTheNumberOfDrinksIs(int noOfDrinks)
        {
            _restaurant.noOfDrinks = noOfDrinks;

        }
        [Then(@"the calculatedBillbeforeSeven should be (.*)")]
        public void ThenTheCalculatedBillbeforeSevenShouldBe(float discountedBill)
        {
            _totalCost = _restaurant.createOrderBeforeSeven();
            _totalCost.Should().Be(discountedBill);
        }
        [Then(@"the number of mains after update is (.*)")]
        public void ThenTheNumberOfMainsAfterUpdateIs(int noOfMainsAfterUpdate)
        {
           _restaurant.noOfMainsAfterUpdate = noOfMainsAfterUpdate;
        }

        [Then(@"the number of drinks after update is (.*)")]
        public void ThenTheNumberOfDrinksAfterUpdateIs(int noOfDrinksAfterUpdate)
        {
            _restaurant.noOfDrinksAfterUpdate = noOfDrinksAfterUpdate;
        }
        [Then(@"the updatedBill should be (.*)")]
        public void ThenTheUpdatedBillShouldBe(float updatedBill)
        {
            _totalCost =_restaurant.calculateBillAfterOrderUpdate();
            _totalCost.Should().Be(updatedBill);
        }
        [Then(@"the number of starter cancelled is (.*)")]
        public void ThenTheNumberOfStarterAfterCancellationIs(int noOfStarterCancelled)
        {
          _restaurant.noOfStarterCancelled = noOfStarterCancelled;

        }

        [Then(@"the number of mains cancelled is (.*)")]
        public void ThenTheNumberOfMainsAfterCancellationIs(int noOfMainsCancelled)
        {
            _restaurant.noOfMainsCancelled = noOfMainsCancelled;
        }

        [Then(@"the number of drinks cancelled is (.*)")]
        public void ThenTheNumberOfDrinksAfterCancellationIs(int noOfDrinksCancelled)
        {
            _restaurant.noOfDrinksCancelled = noOfDrinksCancelled;
        }

        [Then(@"the finalBill should be (.*)")]
        public void ThenTheFinalBillShouldBe(float finalBill)
        {
            _totalCost = _restaurant.calculateFinalBillAfterCancellation();
            _totalCost.Should().Be(finalBill);
        }


    }
}


