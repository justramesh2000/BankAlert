using System;
using System.ComponentModel.DataAnnotations;

namespace BankAlert.Models
{
    public class Alert
    {
       public string Subject {get;set;}
       public string Category {get;set;}
       public string Sent {get;set;}
    }
}