using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MyXamarinFormsApp.Core.Interfaces;

namespace MyXamarinFormsApp.Core.ViewModels.Home
{
    public class HomeViewModel : BaseViewModel
    {
        private readonly ILogger<HomeViewModel> _logger;
        private readonly IGenerosityService _service;

        public HomeViewModel(ILogger<HomeViewModel> logger, IGenerosityService service)
        {
            _logger = logger;
            _service = service;
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            SubTotal = 100;
            Generosity = 10;
            Recalcuate();
        }

        private double _subTotal;
        public double SubTotal
        {
            get => _subTotal;
            set
            {
                _subTotal = value;
                RaisePropertyChanged(() => SubTotal);

                Recalcuate();
            }
        }

        private int _generosity;
        public int Generosity
        {
            get => _generosity;
            set
            {
                _generosity = value;
                RaisePropertyChanged(() => Generosity);

                Recalcuate();
            }
        }

        private double _tip;
        public double Tip
        {
            get => _tip;
            set
            {
                _tip = value;
                RaisePropertyChanged(() => Tip);
            }
        }

        private void Recalcuate()
        {
            Tip = _service.Calculate(SubTotal, Generosity);
            _logger.LogInformation("Calculated Tip: {Tip} from Sub Total: {SubTotal} and Generosity: {Generosity}",
                Tip, SubTotal, Generosity);
        }
    }
}
