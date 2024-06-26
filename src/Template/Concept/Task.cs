﻿namespace Template.Concept
{
    public abstract class Task
    {
        private AuditTrail _auditTrail;

        public Task()
        {
            _auditTrail = new AuditTrail();
        }

        public Task(AuditTrail auditTrail)
        {
            _auditTrail = auditTrail;
        }

        public void Execute()
        {
            _auditTrail.Record();
            DoExecute();
        }
        protected abstract void DoExecute();
    }
}
