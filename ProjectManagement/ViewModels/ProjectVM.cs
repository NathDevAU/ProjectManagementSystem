using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModels
{
    public class ProjectVM
    {
       

        [Display(Name = "Код на проекта")]
        public decimal Id { get; set; }

        [Display(Name = "Име на проекта")]
        public string Name { get; set; }

        [Display(Name = "Клиент")]
        public string Client { get; set; }

        [Display(Name = "Начало на проекта")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Край на проекта")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Статус на проекта")]
        public string Status { get; set; }

        [Display(Name = "Часова ставка")]
        public decimal? PayPerH { get; set; }
    }
}
