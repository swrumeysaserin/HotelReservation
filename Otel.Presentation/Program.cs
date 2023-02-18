using Otel.Business.Abstract;
using Otel.Business.Concrete;
using Otel.DataAccess.Abstract;
using Otel.DataAccess.Concrete.EntityFramework;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel.Presentation
{
    internal static class Program
    {
        public static Container staticContainer = new Container();
        public static Action _act;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = new Container();
            //using SimpleInjector.Lifestyles;
            

            staticContainer = container;
            container.Register<ILoginService, LoginManager>(Lifestyle.Singleton);
            container.Register<IUserDal, EfUserDal>(Lifestyle.Singleton);

            container.Register<IOtelService, OtelManager>(Lifestyle.Singleton);
            container.Register<IOtelDal, EfOtelDal>(Lifestyle.Singleton);

            container.Register<ICustomerService, CustomerManager>(Lifestyle.Singleton);
            container.Register<ICustomerDal, EfCustomerDal>(Lifestyle.Singleton);

            container.Register<IReservationService, ReservationManager>(Lifestyle.Singleton);
            container.Register<IReservationDal, EfReservationDal>(Lifestyle.Singleton);

            container.Register<frmLogin>(Lifestyle.Singleton);
            container.Register<frmMain>(Lifestyle.Singleton);
            container.Register<frmAddOtel>(Lifestyle.Singleton);
            container.Register<frmCustomerAdd>(Lifestyle.Singleton);///
            container.Register<frmCustomerList>(Lifestyle.Singleton);///
            container.Register<frmReservationAdd>(Lifestyle.Singleton);////----------------
            

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.GetInstance<frmLogin>());
        }
    }
}
