using DotNetBrowser.Browser;
using DotNetBrowser.Engine;
using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace TestWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IBrowser browser;
        private IEngine engine;

        private List<TestItems> testControl;

        bool _isNavigating = false;

        public List<TestItems> TestControl
        {
            get
            {
                return testControl;
            }
            set
            {
                if(value != testControl)
                    testControl = value;
            }
        }

        public MainWindow()
        {
            DataContext = this;

            TestControl = new List<TestItems>
            {
                new TestItems{ DisplayValues = "Boiana" },
                new TestItems{ DisplayValues = "Kalina" },
                new TestItems{ DisplayValues = "Branimir" },
                new TestItems{ DisplayValues = "Jitar" },
                new TestItems{ DisplayValues = "Selena" },
                new TestItems{ DisplayValues = "Romana" }
            };
            /*
            Task.Run(() =>
            {
                engine = EngineFactory.Create(new EngineOptions.Builder
                {
                    RenderingMode = RenderingMode.HardwareAccelerated,
                    LicenseKey = "1BNKDJZJSD1INVE6YAQ3XO1EY2EPOEOAB51HVN2Q2970GO8RX5XK2VPVGWCYI9VJNMWP7A"
                }
                .Build());
                browser = engine.CreateBrowser();
            })
                .ContinueWith(t =>
                {
                    browserView.InitializeFrom(browser);
                    browser.Navigation.LoadUrl("https://dnenov.github.io/at-docs/revit-phpp-plugins/window-family/");
                }, TaskScheduler.FromCurrentSynchronizationContext());
                */

            InitializeComponent();
        }



        void WebView_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            _isNavigating = true;
            RequeryCommands();
        }

        void WebView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            _isNavigating = false;
            RequeryCommands();
        }


        void RequeryCommands()
        { 
            CommandManager.InvalidateRequerySuggested();
        }

        // ESC Button pressed triggers Window close        
        private void OnCloseExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            browser.Dispose();
            engine.Dispose();
        }
    }

    public class TestItems
    {
        private string displayValues;

        public string DisplayValues
        {
            get
            {
                return displayValues;
            }
            set
            {
                if (value != displayValues)
                    displayValues = value;
            }
        }
    }
}
