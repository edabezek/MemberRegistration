using MemberRegistration.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistration.Businnes.ServiceAdaptors
{
    public interface IKpsServiceAdapter
    {
        //burada birini doğrulamaya çalışacağız.
        bool ValidateUser(Member member);

    }
}
