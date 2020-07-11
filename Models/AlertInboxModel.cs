using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace BankAlert.Models
{
    public class AlertInboxModel
    {
       public List<Alert> MessageList {get;set;}
    }
}

