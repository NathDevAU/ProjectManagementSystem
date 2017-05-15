namespace ProjectManagement.Utils
{
    class TaskStatus
    {
        
        //6	Изпълнена
        //4	В изпълнение
        //5	Отказана
        //3	Одобрена
        //2	Очаква одобрение
        //1	Планирана

        public const int TaskStatusPlannedId = 1;
        public const int TaskStatusWaitingApprovalId = 2;
        public const int TaskStatusApprovedId = 3;
        public const int TaskStatusInExecutionId = 4;
        public const int TaskStatusCanceledId = 5;
        public const int TaskStatusCompleatedId = 6;




    }
}
