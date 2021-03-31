using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBudget.Models
{
    public class Wallet
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int MinPlus { get; set; }
        public int Amount { get; set; }
        public int Type { get; set; }
    }
}
