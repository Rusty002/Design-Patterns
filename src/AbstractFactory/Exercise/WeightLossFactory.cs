namespace AbstractFactory.Exercise
{
    internal class WeightLossFactory : IExercisePlan
    {
        private IWorkoutPlan _workoutPlan;
        private IMealPlan _mealPlan;
        public void CreateExercisePlan()
        {
            _workoutPlan = new WeightLossWorkoutPlan();
            _mealPlan = new WeightLossMealPlan();

            Console.WriteLine(_workoutPlan);
            Console.WriteLine(_mealPlan);
        }
    }
}
