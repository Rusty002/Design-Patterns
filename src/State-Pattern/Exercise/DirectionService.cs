namespace State_Pattern.Exercise
{
    public class DirectionService
    {
        private IDirectionService _directionService;

        public IDirectionService GetDirectionService()
        {
            return _directionService;
        }

        public void SetDirectionService(IDirectionService directionService)
        {
            _directionService = directionService;
        }

        public int GetDirection()
        {
            return _directionService.GetDirection();
        }

        public int GetETA()
        {
            return _directionService.GetETA();  
        }
    }
}
