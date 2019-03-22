using Ninject.Web.Common.WebHost;

[assembly: WebActivator.PreApplicationStartMethod(typeof(timetospeak.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivator.ApplicationShutdownMethodAttribute(typeof(timetospeak.App_Start.NinjectWebCommon), "Stop")]

namespace timetospeak.App_Start
{
    using System;
    using System.Web;
    using Dal.Entities;
    using Dal.Interfaces;
    using Dal.Repositories;
    using global::Ninject;
    using global::Ninject.Web.Common;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

            kernel
                .Bind<IAboutRepository<AboutSchool>>()
                .To<AboutRepository>()
                .WithConstructorArgument("name", "TtsConnection");

            RegisterServices(kernel);
            return kernel;
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
        }        
    }
}
