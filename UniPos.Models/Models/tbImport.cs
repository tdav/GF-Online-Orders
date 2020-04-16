using System;
using System.ComponentModel.DataAnnotations;

namespace UniPos.Models
{
    /// <summary>
    /// таблица Импорт из Гран фарм
    /// </summary>
    public class tbImport
    {
        public int Id { get; set; } //  Склд 	
        public string DrugStoreId { get; set; } //  Склд 	
        public int DrugId { get; set; } // Материал
        public string Partya { get; set; }  //  Партия 
        public string DrugName { get; set; }   //  Название для печатных форм и касс 
        public string SeriesNo { get; set; }   //  Серия   
        public DateTime ExpiryDate { get; set; } //  Срок  годн.
        public decimal Price { get; set; }   // Роз цена
    }
}