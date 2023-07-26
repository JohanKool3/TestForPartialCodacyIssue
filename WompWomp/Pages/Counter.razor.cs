namespace WompWomp.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;

        private string name = "Barry's Counter";

        private List<string> shoppingItems = new List<string> { "Milk", "Bread", "Cheese" };

        private void IncrementCount()
        {
            currentCount++;
        }
    }
}
