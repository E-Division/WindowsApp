using SQLite.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using E_Divison.Classes;
using System.Threading.Tasks;

namespace E_Divison
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : Application
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public static string dbPath = Path.Combine(Path.Combine(ApplicationData.Current.LocalFolder.Path, "db.sqlite"));
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;
            if (!CheckFileExists("customers.sqlite").Result)
            {
                using (SQLiteConnection db = new SQLiteConnection(new
            SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), dbPath))
                {
                    //Classes.DatabaseManager databaseManager = new Classes.DatabaseManager();
                    db.CreateTable<Classes.Page>();
                    db.CreateTable<Classes.Category>();
                    db.CreateTable<Classes.Brand>();
                    Classes.Page page = new Classes.Page();
                    page.InsertPages(db);
                    Brand brand = new Brand();
                    Category category = new Category();
                    brand.InsertBrands(db);
                    category.InsertCategories(db);

                }
            }

           
        }

        private async Task<bool> CheckFileExists(string fileName)
        {
            try
            {
                await Windows.Storage.ApplicationData.Current.LocalFolder.GetFileAsync(fileName);
                return true;
            }
            catch
            {
            }
            return false;
        }
        //private void CreateTables()
        //{
        //    //var tableQuery = "SELECT COUNT(*) FROM tbl_Page;";
        //    //bool tableExists = con.ExecuteScalar<int>(tableQuery) == 1;
        //    con.CreateTable<Page>();
        //    Page page = new Page();
        //    page.InsertPages(con);
        //    con.CreateTable<Category>();
        //    Category category = new Category();
        //    category.InsertCategories(con);
        //    con.CreateTable<Brand>();
        //    Brand brand = new Brand();
        //    brand.InsertBrands(con);
        //}
        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
#if DEBUG
            if (System.Diagnostics.Debugger.IsAttached)
            {
                this.DebugSettings.EnableFrameRateCounter = true;
            }
#endif
            Frame rootFrame = Window.Current.Content as Frame;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if (rootFrame == null)
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: Load state from previously suspended application
                }

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }

            if (e.PrelaunchActivated == false)
            {
                if (rootFrame.Content == null)
                {
                    // When the navigation stack isn't restored navigate to the first page,
                    // configuring the new page by passing required information as a navigation
                    // parameter
                    rootFrame.Navigate(typeof(MainPage), e.Arguments);
                }
                // Ensure the current window is active
                Window.Current.Activate();
            }
        }

        /// <summary>
        /// Invoked when Navigation to a certain page fails
        /// </summary>
        /// <param name="sender">The Frame which failed navigation</param>
        /// <param name="e">Details about the navigation failure</param>
        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }
    }
}
