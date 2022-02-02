using System;
using System.Collections.Generic;
using System.Text;

namespace MyXamarinFormsApp.Core.Interfaces
{
    public interface IGenerosityService
    {
        double Calculate(double subTotal, int generosity);
    }
}
