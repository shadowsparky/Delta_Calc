using System;
using System.Windows;
using System.Windows.Input;

namespace DeltaBestCalc
{
    public partial class MainWindow : Window, IMainView
    {
        private IMainPresenter presenter; 
        public MainWindow()
        {
            InitializeComponent();
            presenter = new MainPresenter(this, new MainModel());
        }

        private void InputedValue_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                presenter.OnValueInputed(InputedValue.Text);
            }
        }

        void IMainView.SetResult(string result)
        {
            ResultedValue.Content = result;
        }
    }
}
