namespace AbstractFactory.Exercise
{
    internal class Demo
    {
        public static void Show()
        {
            var homePage = new HomePage();
            homePage.SetGoal(new WeightLossFactory());
        }
    }
}
