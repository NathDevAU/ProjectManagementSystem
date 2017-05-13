namespace ProjectManagement.ViewModels
{
    public class ExpertVM
    {
        private string expertType;

        public decimal Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string ExpertType
        {
            get
            {
                if (this.expertType == "E" || this.expertType == "Външен")
                {
                    return "Външен";
                }

                return "Вътрешен";
            }

            set
            {
                this.expertType = value;
            }
        }
    }
}
