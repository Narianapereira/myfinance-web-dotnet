using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace myfinance_web_netcore.Models
{
    public class TransactionModel
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "O campo Historico é obrigatório.")]
        public string Historico { get; set; }

        [Required(ErrorMessage = "O campo Tipo é obrigatório.")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "O campo Valor é obrigatório.")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "O campo AccountPlanId é obrigatório.")]
        public int AccountPlanId { get; set; }

        [Required(ErrorMessage = "O campo Data é obrigatório.")]
        public DateTime Data { get; set; }

        public IEnumerable<SelectListItem>? AccountPlan { get; set; }
    }
}
