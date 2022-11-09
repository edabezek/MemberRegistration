using MemberRegistration.Businnes.Abstract;
using MemberRegistration.Businnes.Concrete;
using MemberRegistration.Businnes.ServiceAdaptors;
using MemberRegistration.DataAccess.Abstract;
using MemberRegistration.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.Businnes.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMemberService>().To<MemberManager>().InSingletonScope();  
            Bind<IMemberDal>().To<EFMemberDal>().InSingletonScope();

            Bind<IKpsServiceAdapter>().To<KpsServiceAdapter>().InSingletonScope();
        }
    }
}
