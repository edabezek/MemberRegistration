using FluentValidation;
using MemberRegistration.Businnes.ValidationRules.FluentValidation;
using MemberRegistration.Entities.Concrete;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.Businnes.DependencyResolvers.Ninject
{
    public class ValidationModule : NinjectModule
    {
        public override void Load()
        {
            //Member ile ilgili validasyon Ioc
            Bind<IValidator<Member>>().To<MemberValidator>().InSingletonScope();
        }
    }
}
