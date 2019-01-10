using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeltaBestCalc
{
    class MainPresenter : IMainPresenter
    {
        private IMainView view;
        private IMainModel model;

        public MainPresenter(MainWindow mainWindow, MainModel mainModel)
        {
            this.view = mainWindow;
            this.model = mainModel;
        }

        public void OnValueInputed(string value)
        {
            var result = model.ComputeValue(value);
            view.SetResult(result);
        }
    }
}
