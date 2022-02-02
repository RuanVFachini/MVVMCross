using System;
using System.Collections.Generic;
using System.Text;
using MyXamarinFormsApp.Core.Interfaces;

namespace MyXamarinFormsApp.Core.Services
{
    public class GenerosityService : IGenerosityService
    {
        public double Calculate(double subTotal, int generosity) => subTotal * generosity / 100;
    }
}
