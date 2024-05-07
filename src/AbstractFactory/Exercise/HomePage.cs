namespace AbstractFactory.Exercise
{
    internal class HomePage
    {
        public void SetGoal(IExercisePlan exercisePlan)
        {
            exercisePlan.CreateExercisePlan();
        }
    }
}
