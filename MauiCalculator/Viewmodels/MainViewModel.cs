using MauiCalculator.Models;
using Microsoft.Maui.Controls;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCalculator.Viewmodels
{
    public class MainViewModel : BaseViewModel
    {
        private ObservableCollection<string> _history;

        /// <summary>
        /// Property that will keep all the previous opperations
        /// </summary>
        public ObservableCollection<string> History
        {
            get { return _history; }
            set 
            { 
                _history = value;
                OnPropertyChanged(nameof(History));
            }
        }
        private ObservableCollection<ItemLine> _currentLine;

        /// <summary>
        /// Basically the line of the current operation
        /// </summary>
        public ObservableCollection<ItemLine> CurrentLine
        {
            get 
            { 
                return _currentLine; 
            }
            set 
            { 
                _currentLine = value; 
                OnPropertyChanged(nameof(CurrentLine));
            }
        }


        private Command _addNumber;
        /// <summary>
        /// Command to add a number to the current line
        /// </summary>
        public Command AddNumber
        {
            get 
            { 
                return _addNumber; 
            }
            private set
            { 
                _addNumber = value;
                //OnPropertyChanged(nameof(AddNumber));
            }
        }
        private Command _addOperator;

        public Command AddOperator
        {
            get 
            { 
                return _addOperator; 
            }
            private set
            {
                _addOperator = value;
                //OnPropertyChanged(nameof(AddOperator));
            }
        }



        public MainViewModel()
        {
            _currentLine = new ObservableCollection<ItemLine>();

            _addNumber = new Command((num) =>
            {
                if (num != null)
                    CurrentLine.Add(new ItemLine()
                    {  
                        Content = num.ToString(), 
                        Type = ItemType.Number
                    });
            });

            _addOperator = new Command((op) =>
            {
                if (op != null)
                    CurrentLine.Add(new ItemLine()
                    {  
                        Content = op.ToString(), 
                        Type = ItemType.Operator
                    });
            });
        }




    }
}
