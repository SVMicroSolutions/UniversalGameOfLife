using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace SVMicroSolution.GameOfLife.Models
{
    public class Cell
    {

        public CellState State { get; set; }
         

    }

    public enum CellState { Born, Alive, Dying, Dead} 
    
}
