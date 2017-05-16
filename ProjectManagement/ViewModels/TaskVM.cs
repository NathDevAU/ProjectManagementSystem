using System;

namespace ProjectManagement.ViewModels
{
    public class TaskVM
    {
        private string result;
        private DateTime end;

        public string TaskName { get; set; }

        public string TimeRemaining
        {
            get
            {
                if ((end - DateTime.Now).Days > 0)
                {
                    result = (end - DateTime.Now).Days == 1 ?
                        string.Concat((end - DateTime.Now).Days, " ден") :
                        string.Concat((end - DateTime.Now).Days, " дни");
                    return result;
                }
                return "-";
            }
            set { }
        }

        public string Delay
        {
            get
            {
                if ((end - DateTime.Now).Days < 0)
                {
                    result = (end - DateTime.Now).Days == 1 ?
                         string.Concat(Math.Abs((end - DateTime.Now).Days), " ден") :
                         string.Concat(Math.Abs((end - DateTime.Now).Days), " дни");
                    return result;
                }
                return "-";

            }
            set { }

        }

        public DateTime EndDate
        {
            get
            {
                return this.end;
            }
            set { this.end = value; }
        }

        public decimal TaskId { get; set; }

    }
}
