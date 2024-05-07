namespace AbstractFactory.Exercise
{
    internal class BuildMuscleFactory : IExercisePlan
    {
        private IWorkoutPlan _workoutPlan;
        private IMealPlan _mealPlan;
        public void CreateExercisePlan()
        {
            _workoutPlan = new BuildMuscleWorkout();
            _mealPlan = new BuildMuscleMealPlan();

            Console.WriteLine(_workoutPlan);
            Console.WriteLine(_mealPlan);
        }
    }
}
