using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCalculator.Models
{
    /// <summary>
    /// Model Representing an element (number or operator) of a line.
    /// </summary>
    public class ItemLine
    {
        public string Content { get; set; }
        public ItemType Type { get; set; }
        public string Font 
        { 
            get 
            { 
                if (Type == ItemType.Operator)
                    return "SolidIcon";
                return "OpenSansRegular";
            } 
        }

    }
    public enum ItemType { Operator, Number }
}
